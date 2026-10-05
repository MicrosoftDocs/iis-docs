[Reflection.Assembly]::LoadWithPartialName('Microsoft.IIS.PowerShell.Framework')
[Reflection.Assembly]::LoadWithPartialName('Microsoft.Web.Administration')
function Get-ConfigElement {
    param (
        [Microsoft.Web.Administration.ConfigurationElement]$ElementCollection,
        [String]$ElementTagName,
        [string[]]$KeyValues
    )
    [Microsoft.Web.Administration.ConfigurationElement]$element = $null
    foreach ($element in $ElementCollection) {
        if ([String]::Equals($element.ElementTagName, $ElementTagName, [System.StringComparison]::OrdinalIgnoreCase)) {
            $find = $true
            for ($i = 0; $i -lt $KeyValues.Count; $i += 2) {
                [System.Object]$o = $element.GetAttributeValue($KeyValues[$i])
                if ($null -ne $o ) {
                    $ftpname = $o.ToString()
                }
                if ([String]::Equals($ftpname, $KeyValues[$i + 1], [System.StringComparison]::OrdinalIgnoreCase) -eq $false) {
                    $find = $false
                    break
                }
            }
            if ($find) {
                return $element
            }
        }
    }
}

$serverManager = New-Object Microsoft.Web.Administration.ServerManager
[Microsoft.Web.Administration.Configuration]$config = $serverManager.GetApplicationHostConfiguration()
$sitesSection = $config.GetSection("system.applicationHost/sites")
[Microsoft.Web.Administration.ConfigurationElementCollection]$listaSites = $sitesSection.GetCollection()
$element = Get-ConfigElement -ElementCollection $listaSites -ElementTagName "site"  -KeyValues @("name", "ftp.example.com")

[Microsoft.Web.Administration.ConfigurationElement]$ftpServerElement = $element.GetChildElement("ftpServer")
[Microsoft.Web.Administration.ConfigurationElementCollection]$sessionsElement = $ftpServerElement.GetChildElement("sessions").GetCollection()
if ($sessionsElement.count -gt 0) {
    $attributesList = ($sessionsElement | Select-Object -First 1 | ForEach-Object -MemberName Attributes).name   
    foreach ($sessionElement in $sessionsElement) {
        $sessionObject = [PSCustomObject]@{}
        for ($j = 0; $j -lt $attributesList.Count; $j++) {
            Add-Member -Name $attributesList[$j] -MemberType NoteProperty -Value $sessionElement.GetAttribute($attributesList[$j]).value.ToString() -InputObject $sessionObject
        }
        $sessionObject 
    } 
}        