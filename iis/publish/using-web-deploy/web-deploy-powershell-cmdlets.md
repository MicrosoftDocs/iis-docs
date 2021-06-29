---
title: "Web Deploy PowerShell Cmdlets"
author: rick-anderson
description: "Web Deploy V3.0 ships with PowerShell cmdlets for carrying out most of the tasks supported by the Web Deploy API [Microsoft.Web.Deployment]. You can read mor..."
ms.date: 04/19/2012
ms.assetid: 6dae383f-e79d-44f8-a63b-4695c28eec03
msc.legacyurl: /learn/publish/using-web-deploy/web-deploy-powershell-cmdlets
msc.type: authoredcontent
---
# Web Deploy PowerShell Cmdlets

by [Owais Shaikh](https://twitter.com/shmparvez)

Web Deploy V3.0 ships with PowerShell cmdlets for carrying out most of the tasks supported by the Web Deploy API [Microsoft.Web.Deployment]. You can read more about this API [here](https://msdn.microsoft.com/library/microsoft.web.deployment(v=VS.90).aspx). These cmdlets are in the snapin named WDeploySnapin3.0 which is installed and registered as a snapin on a typical or higher install of web deploy. To use these cmdlets either add the snapin every time the PowerShell console is started or add the snapin to the PowerShell profile which will make all consoles automatically load the snapin.

To add when PowerShell console is loaded, run the following command in the console window:

Add-PSSnapin WDeploySnapin3.0

To add it to the PowerShell profile:

1. If you already have a PowerShell profile, go to step 4.
2. Create a WindowsPowerShell folder under &lt;My Documents&gt;.
3. Create a file called Microsoft.PowerShell\_profile.ps1
4. Add this line to the PowerShell profile file: 'Add-PSSnapin WDeploySnapin3.0'

A few points to note:

1. PowerShell console runs in 64 bit on 64 bit systems and runs in .Net 2.0 except until Windows8. If you face issues because of one or both of these refer to the troubleshooting section for solutions.
2. All cmdlets that create a Web Deploy package create parameters for the most common tasks and the cmdlets that consume it accept parameter values.
3. There is only one removal cmdlet for deleting a site or an app beneath it.
4. Web Deploy has parameters but they are orthogonal to PowerShell cmdlet parameters. When parameters are referred to in this document, it implies cmdlet parameters. Web Deploy parameters have been specifically called out as Web Deploy parameters.

<a id="_Toc322604005"></a>

## I. Publish Settings File

All of the cmdlets given below have the ability to execute against a remote artifact such as a remote server or a remote database. These require more than just the credentials. For e.g. you need the remote server name, the remote database connection string, whether you want to allow publishing to a server with a test certificate etc. For ease of use, transfer of credential information from server admin to consumer etc. a new file type has originated which groups these settings together. This file is called the publish settings file ending in .publishsettings. This is used by Visual Studio for publishing as well as by WebMatrix.

To be able to create such a file for consumption by other cmdlets and to edit it **New-WDPublishSettings** cmdlet can be used. If no filename is specified it will create a new file in your documents directory with the name &lt;new guid&gt;.publishsettings. This path will be displayed when the file is created. If a filename is specified and the file does not exist it will be created as described above in the folder specified by the path, however the path to the file must be valid. If the file exists only the values for the attributes that you specified while running the command will be modified, except for the attributes in the file which are unknown and will get removed

Example: This example gets a credential object and then passes it to the new publish settings file cmdlet along with other parameters

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample1.ps1)]

<a id="_Toc322604006"></a>

## II. Backup

All backup cmdlets have a positional parameter (it's the second one except for backup-wdserver where it is the first positional parameter) called output. This takes a path to the folder where you want the backup created. Backup is always a Web Deploy zip package. You can read more about Web Deploy Packages at [Package Provider](https://msdn.microsoft.com/library/dd569019(v=WS.10).aspx) and [custom packages](../../develop/windows-web-application-gallery/package-an-application-for-the-windows-web-application-gallery.md). If no path is specified the backups are created in a folder named 'Web Deploy Backups' under the user's documents folder. The backups are named as machinename\_nameofproviderused\_[Siteorapporfoldername(Optional)]\_timestamp.zip.

All these cmdlets will work locally by default unless remote server information is provided by passing in a publish settings file for SourcePublishSettings parameter.

<a id="_Toc322604007"></a>

### A. IIS

All IIS cmdlets will work against installed IIS version 7 or higher

<a id="_Toc322604008"></a>

#### 1. Server

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample2.ps1)]

Description: This without any arguments backs up the current server where this command is run. It uses the well-known webserver provider for this operation. Hence the package created contains all the artifacts that would be contained in a webserver package. You can read more about this provider [here](https://technet.microsoft.com/library/dd569021(v=WS.10).aspx).

Cmdlet Parameters: ConfigOnly parameter allows you to exclude all content while SkipFileList and SkipFolderList parameters allow you to selectively exclude one or more files or folders from the package.

Examples:

This will back up everything of the web server except for the content:

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample3.ps1)]

Create a list of the files that should be skipped. This is standard regular expressions.

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample4.ps1)]

You can also change this to skip all files under site2 by changing the list to $list=@('\\site2\\')

<a id="_Toc322604009"></a>

#### 2. Site

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample5.ps1)]

Description: This will back up an IIS site along with its settings and content using apphostconfig provider. You can read more about this provider [here](https://docs.microsoft.com/previous-versions/windows/it-pro/windows-server-2008-R2-and-2008/dd569080(v=ws.10)?redirectedfrom=MSDN).

Cmdlet Parameters: The name of the site specified by the site parameter or by the publish settings file is backed up. Site parameter value overrides publish settings specification for site name.

ConfigOnly can be used to create a backup with no content. If the site uses a non-default app pool then to make this package work on other servers that might not have the same application pool, use the switch parameter includeAppPool. This will bundle the application pool into the package.

Auto generated Web Deploy parameters: Two types of parameters are created:

1. A parameter to enable the user to change the name of the site where the site backup will be applied.
2. Another parameter to enable the user to change the physical path of the site and every web application under that site.

So if I have a site with three apps beneath I will get 4 physical path parameters apart and one site name parameter.

Examples:

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample6.ps1)]

<a id="_Toc322604010"></a>

#### 3. Web Application

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample7.ps1)]

Description: This will back up a web application using iisApp provider. Read more about this provider [here](https://technet.microsoft.com/library/dd569054(WS.10).aspx). Here is a good [article](http://learn.iis.net/page.aspx/150/understanding-sites-applications-and-virtual-directories-on-iis/) that explains what a web application is and what is the difference between a site, an app and a virtual directory in IIS.

Cmdlet Parameters: The name of the app specified by the application parameter or by the publish settings file is backed up. If none of them is specified it throws an error. Application parameter value overrides publish settings specification for site name. SkipFileList and SkipFolderList parameters allow you to selectively exclude one or more files or folders from the package.

Auto generated Web Deploy parameters: A Parameter for changing the name of the app or site during restore or install is created.

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample8.ps1)]

<a id="_Toc322604011"></a>

### B. Database

<a id="_Toc322604012"></a>

#### 1. MSSql

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample9.ps1)]

Description: This will back up a Microsoft SQL Server Database using the dbfullsql provider. This provider uses SMO to script out the database and exposes more than 100 provider settings to control the way the database is scripted. This is covered in detail [here](https://technet.microsoft.com/library/dd569036(v=ws.10).aspx).

Cmdlet Parameters: The connection string specified by the Database parameter or SQLServerDBConnectionString in the publish settings file is backed up. Database parameter value overrides publish settings specification for SQLServerDBConnectionString. The provider settings exposed by this dbfullsql provider can be passed using SourceSettings parameter. One very commonly used setting is scriptdropsfirst which scripts if object exists drop object scripts. Another provider setting from the SMO scripting options is to set scriptdata to false to just extract schema.

Auto generated Web Deploy parameters: A parameter is created for changing the database connection string during restore or install

Examples:

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample10.ps1)]

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample11.ps1)]

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample12.ps1)]

<a id="_Toc322604013"></a>

#### 2. MySql

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample13.ps1)]

Description: This will back up a MySql Server Database using the dbmysql provider. This provider uses mysqldump to script out the database. This is covered in detail [here](https://technet.microsoft.com/library/dd569017(v=ws.10).aspx).

Cmdlet Parameters: The connection string specified by the Database parameter or mySQLDBConnectionString in the publish settings file is backed up. Database parameter value overrides publish settings specification for mySQLDBConnectionString. The provider settings can be passed using SourceSettings parameter. The commonly used settings are includeData and includeSchema. By default these are set to true.

Auto generated Web Deploy parameters: A parameter is created for changing the database connection string during restore or install

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample14.ps1)]

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample15.ps1)]

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample16.ps1)]

<a id="_Toc322604014"></a>

## III. Restore

All restore cmdlets take the Web Deploy package to restore as the first positional parameter.

WebDeploy supports the concept of [parameterization](https://msdn.microsoft.com/library/ff398068.aspx) of the packages, which lets you change few aspects during restore (without modifying package). For example during restore, you can choose to specify value of database connection string which is different from what is inside the package using WebDeploy parameters (you need to have connection string parameter present in the package.)

Depending upon how package was built, Web Deploy package might have one or more [parameters](https://msdn.microsoft.com/library/ff398068.aspx "parameters"). These restore cmdlets inspect the package and add dynamic PowerShell parameters to the collection. So if a package has a Web Deploy parameter named "Parameter1" then you will find a PowerShell parameter with the name "Parameter1". However dynamic parameters have their own issues in PowerShell and this will only work if packages don't have a space in their name or in the path to the file.

Alternatively, all these restore cmdlets also have a "Parameters" parameter which allows you to manually specify new parameter values during restore. This "Parameters" parameter takes PowerShell Dictionary object for the name value pairs of Web Deploy parameters.

To find out the Web Deploy parameters defined in any Web Deploy package you can simply open the zip file in Windows Explorer and examine the parameters.xml file present in the root of the package. Any Web Deploy parameter that does not have a default value or a value needs a value to be specified. Add all of these parameters in an xml file and pass it in as the value for ParameterValuesFile parameter. You can generate this file as given in [here](https://blogs.iis.net/moshaikh/archive/2009/09/25/msdeploy-xpath-and-xsl-part-iii-auto-generate-setparamfile-from-package-and-batch-file-to-migrate-apps-to-sites.aspx) or manually. The format is

[!code-xml[Main](web-deploy-powershell-cmdlets/samples/sample17.xml)]

Get-WDParameters cmdlet can read this file and convert it into WebDeploy parameters object (dictionary), which is accepted by all restore cmdlets.

If any package is restored without specifying a value for the parameters within, the default behavior would be overwrite the resources from which the package was originally created. For e.g. if I create a package from site1 using backup-wdsite site1, then when I restore this package using the restore cmdlet without providing any values to the parameters in this package, site1 will be overwritten with whatever the package contains, content as well as config. Same is true for all restore cmdlets.

All these cmdlets restore locally except when destination publish settings file is specified, in which case the same exact operation would occur against a remote server via Web Management Service (WMSvc) or the Web Deployment Agent service.

<a id="_Toc322604015"></a>

### A. IIS

<a id="_Toc322604016"></a>

#### 1. Server

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample18.ps1)]

Description: Restores a web server package. Common usage is to back up a server before making a change and in case of failure the server can be reverted by applying the Web Deploy backup package created before making the changes.

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample19.ps1)]

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample20.ps1)]

<a id="_Toc322604017"></a>

#### 2. Site

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample21.ps1)]

Description: Restores an IIS Site package. If the package has two parameters named "Site Physical Path" and "Site Name" they will be exposed as SitePhysicalPath and SiteName dynamic powershell parameter. This command will create a new site site1 with physical path `c:\site1`. If no value is specified for these parameters, restore will apply to the same site and content, overwriting any changes you might have in the site.

Parameters: You might want to use skipfolderlist and skipfilelist to exclude some folders and/or files from being copied in site contents.

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample22.ps1)]

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample23.ps1)]

<a id="_Toc322604018"></a>

#### 3. App

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample24.ps1)]

Description: This will restore a web application. Backup-WDApp creates package with one parameter to change the name of the app at install time. This can be used to restore the app to a different app during restore. The site must exist when deploying to an app under a site. App will be created by this package but site will not be created.

Examples:

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample25.ps1)]

<a id="_Toc322604019"></a>

### B. Database

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample26.ps1)]

Description: If the database does not exist, this will create a new database called customers (as long as the current user has permissions for this operation) and execute the script on it. If this is run without any values for dynamic Web Deploy parameters the original database from which this package was created will be overwritten. Note that if scriptDropsFirst setting was not used when creating the package, then applying to a database with conflicting existing content will fail. This cmdlet may be used to restore either an MSSql or MySQL backup. You can only restore a MS SQL database with a backup created using Backup-WDSQLDatabase and My SQL database with a backup created using Backup-WDMySqlDatabase.

Examples:

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample27.ps1)]

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample28.ps1)]

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample29.ps1)]

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample30.ps1)]

<a id="_Toc322604020"></a>

### C. Generic Package

[!code-console[Main](web-deploy-powershell-cmdlets/samples/sample31.cmd)]

Description: This cmdlet can be used to apply any Web Deploy package. There are several ways to create or obtain a Web Deploy package, such as by downloading an open source Application Gallery package, creating a package in Visual Studio, using the msdeploy.exe command-line tool ([more info](https://technet.microsoft.com/library/dd568996(WS.10).aspx)), or using the Backup-WD\* cmdlets noted earlier in the document. For e.g. for installing wordpress on an IIS Server Default web site as an app named wordpress download the wordpress package from [the app gallery](https://www.microsoft.com/web/gallery/wordpress.aspx) into a folder called packages. All the default values for the wordpress package parameters will work as is but just need to specify the values for two required parameters: admin and non admin mysql password.

Parameters:

[!code-console[Main](web-deploy-powershell-cmdlets/samples/sample32.cmd)]

<a id="_Toc322604021"></a>

## IV. Remove

[!code-console[Main](web-deploy-powershell-cmdlets/samples/sample33.cmd)]

This command will delete the site named nonworkingsite's definition in applicationHost.config as well as the site's directory contents

<a id="_Toc322604022"></a>

## V. Get &amp; Set App pool Framework

These cmdlets let you read and change the apppool .net framework version.

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample34.ps1)]

<a id="_Toc322604023"></a>

## VI. Set WDACL

This cmdlet can be used to set acls on the content of a site. For e.g. Lets say I have a site, site1 and I am trying to give user u1 read access.

First I check the current permissions.

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample35.ps1)]

<a id="_Toc322604024"></a>

## VII. Invoke

You can invoke commands or scripts on a remote system using destinationpublishsettings and the see the results of the remote execution in real time. You have to be an admin on the remote system to be able to execute runcommand provider remotely. You can read more about this provider [here](https://technet.microsoft.com/library/ee619740(v=WS.10).aspx). The default maximum time MWD Api waits for the given script or command to finish is 5 seconds. If you want to increase this time of execution, you can specify higher values for waitInterval and waitAttempts as shown in the example below.

<a id="_Toc322604025"></a>

### A. Script

`Invoke-WDScript C:\my.cmd –Verbose`

This will execute the script and you will be able to see the output of the command if you run it with verbose.

<a id="_Toc322604026"></a>

### B. Command

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample36.ps1)]

This will execute the command and no output will be displayed since verbose was not specified. However this will wait for 3 seconds between every time lapse and will do 25 iterations of wait. In all, the process execution will continue at the most for 75 seconds.

<a id="_Toc322604027"></a>

## VIII. Sync

These cmdlets take a source and a destination and synchronize between them. The source is never modified. The reason I am using the word source instead of client is because client and server are very confusing terms in synchronization. You can potentially sync the local server with a remote server. In this case the remote server is the source and local server is the destination. Alternatively you can be executing the PowerShell cmdlet on machine 1 and syncing machines 2 and 3. In order to use a remote source and / or destination you need to provide a publish settings file which can be created using the first cmdlet mentioned in this doc. All the sync cmdlets also support sourceSettings and destinationSettings parameters to be able to selectively set provider settings for either the source or destination or both.

<a id="_Toc322604028"></a>

### A. IIS

<a id="_Toc322604029"></a>

#### 1. Server

I want to sync two IIS 7.5 servers, Owais-1 and Owais-2. I will first create a publishsettings file for each and then sync the servers. Since I did not specify my credentials this will succeed if I am an admin on those two systems.

[!code-powershell[Main](web-deploy-powershell-cmdlets/samples/sample37.ps1)]

<a id="_Toc322604030"></a>

#### 2. Site

In the following command, the site2 will get created if it did not exist and I have also changed the physical path (the contents will thus get copied to the new folder `c:\site2`) and the binding of the site.

[!code-console[Main](web-deploy-powershell-cmdlets/samples/sample38.cmd)]

<a id="_Toc322604031"></a>

#### 3. App

I have an application running under default web site. I want to move this under Site1. The following command will do it.

[!code-console[Main](web-deploy-powershell-cmdlets/samples/sample39.cmd)]

Now that I have tested my new drupal app works I will delete the original drupal app under default web site.

[!code-console[Main](web-deploy-powershell-cmdlets/samples/sample40.cmd)]

<a id="_Toc322604032"></a>

### B. Database

The previous cmdlets have shown how you can backup and restore a database using a Web Deploy package, however you can also sync a database to or from a .sql script or sync directly to another database instance using the Sync-WDSQLDatabase and Sync-WDMySQLDatabase cmdlets.

<a id="_Toc322604033"></a>

#### 1. MSSql

[!code-console[Main](web-deploy-powershell-cmdlets/samples/sample41.cmd)]

This will create a new database called sometestdb (if it does not exist already) and synchronize schema and data.

[!code-console[Main](web-deploy-powershell-cmdlets/samples/sample42.cmd)]

This will script out the umbracodb database into umbraco.sql at the path given above.

<a id="_Toc322604034"></a>

#### 2. MySql

[!code-console[Main](web-deploy-powershell-cmdlets/samples/sample43.cmd)]

This will create a new database called wordpress265\_new (if it does not exist already) and synchronize schema and data.

[!code-console[Main](web-deploy-powershell-cmdlets/samples/sample44.cmd)]

This will script out the wordpress265 database into wordpress.sql at the path given above.

<a id="_Toc322604035"></a>

### C. Everything else

For general purpose sync not covered by other cmdlets given above, you can use Sync-WDManifest cmdlet. This is a general manifest provider sync supported by the MWD API. You can read more about it [here](https://technet.microsoft.com/library/dd569104(v=WS.10).aspx). Manifest is a collection of providers, provider paths and provider settings in an xml file. The structure is that the root node of the xml file is considered the name of a provider for the purpose of the current sync. Hence it cannot be the name of any of the well-known providers as given in the list [here](https://msdn.microsoft.com/library/microsoft.web.deployment.deploymentwellknownprovider(v=VS.90).aspx). Then it can have child nodes with the element name matching the provider you want to include in the sync. A path attribute represents the path of that provider and it is mandatory. Then add attribute value pairs for each provider setting that you want to leverage for the current sync operation.

This cmdlet needs two manifests: One for the source and one for the destination. The manifest is always executed in the order specified. If the provider supports a commit operation such as apphostconfig provider which works with IIS Sites, the commit is not called unless the sync is complete. Hence if you have a provider that expects a site to exist after a provider that creates it, then this will fail since the site has not been committed yet. In the following example I will synchronize an app and include a database that the app uses along with it in the manifest.

Source Manifest:

[!code-xml[Main](web-deploy-powershell-cmdlets/samples/sample45.xml)]

Destination Manifest:

[!code-xml[Main](web-deploy-powershell-cmdlets/samples/sample46.xml)]
