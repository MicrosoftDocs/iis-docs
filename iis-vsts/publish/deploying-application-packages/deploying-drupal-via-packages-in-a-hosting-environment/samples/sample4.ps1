# Web Deploy: Powershell script to setup IIS sites for Hosting.
# Copyright (C) Microsoft Corp. 2010
#
# Requirements: IIS 7, Windows Server 2008 (or higher)
#
# You should use this script if you want to set up a Windows 2008 (or higher) 
# server for delegated Web Deploy deployments. 
#   1. Create an IIS Site
#   2. Creates an IIS Manager user and assigns it 
#      permissions to the IIS Site Created 
#
# ================= PARAMS =======================
#
# All of these parameters are required.
#
# $website               IIS Web site. 
# $iisManagerUsername    User name of IIS Manager user
# $iisManagerPassword    Password of above user.  
# $hostheaderName        Web site Host Header/FQDN     
#
# All of these parameters are optional.
#
# $wmsvcUsername, 
# $directory          App physical directory        c:\websites by default.
# $serverPort         Web site Port                 80 by default.
#
# sample usage AddHostingSite.ps1 
#      -website MyWebSite01 
#      -iisManagerUsername TestUser01 
#      -iisManagerPassword TestPass01 
#      -hostheaderName www.mysite.com 
#      -directory c:\Websites -serverPort 80  
param($website, $iisManagerUsername, $iisManagerPassword, $hostheaderName, $wmsvcUsername, $directory,  $serverPort)  
clear-host  
sv APPCMD -value $env:systemroot\system32\inetsrv\AppCmd.exe  
# Check if params are missing
if($website -eq $null){
    write-host 'Please specify a website. Script aborting.'
    break
}
if($iisManagerUsername -eq $null){
     write-host 'Please supply an IIS Manager username to create account. Script aborting.'
    break
}
if($iisManagerPassword -eq $null){
    write-host 'Please supply an IIS Manager password to create account. Script aborting.'
    break
}
if($wmsvcUsername -eq $null){
   $wmsvcUsername = "LOCAL SERVICE"
} 
if($directory -eq $null){
    $directory = "c:\Websites"
}
if($hostheaderName -eq $null){
    write-host 'Please specify a domain name for the websites host header. Script aborting.'
    break
}
if($serverPort -eq $null){
    $serverPort = '80'
}  
# ================= GLOBAL VARIABLES ====================  
# IIS management assemblies
$ENV_APPPOOL_NAME = $website + "_AP"  
$global:mwaAssembly = $null
$global:mwmAssembly = $null  
# the instance Microsoft.Web.Administration.ServerManager we use to interact 
# with IIS's administration.config
$global:serverManager = $null  
# collection of Web Deploy delegation rules
$global:delegationRulesCollection = $null  
# ================ METHODS =======================  
function LoadAssemblies{
    trap [Exception]{
        write-host 'Failed to load Microsoft.Web.*.dll. Are you sure IIS 7 is installed?'
        break
    }
    $global:mwaAssembly = [System.Reflection.Assembly]::LoadFrom( [System.Environment]::ExpandEnvironmentVariables("%WINDIR%") + 
                                                               "\system32\inetsrv\Microsoft.Web.Administration.dll" )
    $global:serverManager = (New-Object Microsoft.Web.Administration.ServerManager)
    $global:mwmAssembly = [System.Reflection.Assembly]::LoadFrom( [System.Environment]::ExpandEnvironmentVariables("%WINDIR%") + 
                                                               "\system32\inetsrv\Microsoft.Web.Management.dll" )
}  
 function NotServerOS{
    $sku = $((gwmi win32_operatingsystem).OperatingSystemSKU)
    $server_skus = @(7,8,9,10,12,13,14,15,17,18,19,20,21,22,23,24,25)
    
    return ($server_skus -notcontains $sku)
}  
 function CheckDelegationRulesExist{
    trap [Exception]{
        write-host 'Did not find delegation rules in administration.config'
        return $false
    }
    $global:delegationRulesCollection = $serverManager.GetAdministrationConfiguration().GetSection("system.webServer/management/delegation").GetCollection()
    
    if($global:delegationRulesCollection.Count -eq 0){
        return $false
    }
    else{
        return $true
    }
}  
function CreateAndAuthorizeIISManagerUser {
    param ($username, $pwd)
    trap [Exception]{
        write-host "Could not create and / or authorize IIS Manager user on Default Web Site: $username"
    }
    [Microsoft.Web.Management.Server.ManagementAuthentication]::CreateUser($username, $pwd)
    [Microsoft.Web.Management.Server.ManagementAuthorization]::Grant($username, $website, $FALSE)
    write-host "Created IIS Manager user: $username and granted it permissions on website: $website"
}   
 function GetPhysicalPathOfWebsite{
    $path = ""
    if($website -eq $null){
        $path = $serverManager.Sites[0].Applications[0].virtualDirectories[0].physicalPath
    }
    else{
        $i = 0
        $found = $false
        for ($i=0; $i -lt $serverManager.Sites.Count; $i++){
            if($serverManager.Sites[$i].Name -eq $website){
                $found = $true
                break;            
            }        
        }
      if($found){
            $path = $serverManager.Sites[$i].Applications[0].virtualDirectories[0].physicalPath
      }
    }
    # if website doesn't exist, create it
    if($path -eq ""){
            $fp = $directory+ "\" +$website
        $global:serverManager = (New-Object Microsoft.Web.Administration.ServerManager)
        $global:serverManager.Sites.Add($website, $fp, 8080)
        $global:serverManager.CommitChanges() 
      new-item $fp -type directory
        $path = $fp
      # Create the AppPool for this site
      Invoke-Expression "$APPCMD add apppool /name:$ENV_APPPOOL_NAME"
      Invoke-Expression "$APPCMD set apppool /apppool.name:$ENV_APPPOOL_NAME /processModel.identityType:NetworkService"
      Invoke-Expression "$APPCMD add app /site.name:$WebSite /path:/ /physicalPath:`"$path`" /applicationPool:$ENV_APPPOOL_NAME"
      
      #appcmd add site /name: $website /physicalPath: $path   /bindings:http/*:$serverPort: $hostheaderName
      
      echo $error  
      write-host "Created new website name: $website, directory: $path , port:$serverport"
    }
    
    return $path
}  
#================= Main Script =================  
if(NotServerOS){
    write-host 'Please run this script on a server OS only. Script aborting.'
    break
}  
LoadAssemblies  
$physicalPathOfWebSite = GetPhysicalPathOfWebsite
$physicalPathOfApplicationHost = [System.Environment]::ExpandEnvironmentVariables("%WINDIR%") + "\system32\inetsrv\config\applicationHost.config"  
CreateAndAuthorizeIISManagerUser $iisManagerUsername $iisManagerPassword