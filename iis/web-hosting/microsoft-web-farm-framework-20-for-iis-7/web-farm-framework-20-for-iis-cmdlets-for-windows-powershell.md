---
title: "Web Farm Framework 2.0 for IIS 7 cmdlets for Windows PowerShell"
author: rick-anderson
description: "You can use the Web Farm Framework cmdlets for Windows PowerShell to configure and manage your server farm. You must have Windows PowerShell installed on the..."
ms.date: 07/21/2010
ms.assetid: 84a13b54-d243-47bd-b204-b82bbbbb0c43
msc.legacyurl: /learn/web-hosting/microsoft-web-farm-framework-20-for-iis-7/web-farm-framework-20-for-iis-cmdlets-for-windows-powershell
msc.type: authoredcontent
---
# Web Farm Framework 2.0 for IIS 7 cmdlets for Windows PowerShell

by Randall DuBois

You can use the Web Farm Framework cmdlets for Windows PowerShell to configure and manage your server farm. You must have Windows PowerShell installed on the web farm controller.

## To use the Web Farm Framework cmdlets for Windows PowerShell

1. On the controller server, open a command prompt.
2. To start the PowerShell console, enter the following command:

   [!code-console[Main](web-farm-framework-20-for-iis-cmdlets-for-windows-powershell/samples/sample1.cmd)]
3. At the PowerShell prompt, enter the following command:

   [!code-powershell[Main](web-farm-framework-20-for-iis-cmdlets-for-windows-powershell/samples/sample2.ps1)]

   The Web Farm Framework snapin for Windows PowerShell is loaded.
4. At the PowerShell prompt, type the following command to display a list of the available WFF cmdlets:

   [!code-powershell[Main](web-farm-framework-20-for-iis-cmdlets-for-windows-powershell/samples/sample3.ps1)]

The list is displayed as in the following image:

![Screenshot shows Windows Power Shell with the following command entered, Get Command Web Farm Snap in.](web-farm-framework-20-for-iis-cmdlets-for-windows-powershell/_static/image1.png)

## Viewing cmdlet Syntax and Help

To get help for each cmdlet, enter **get-Help &lt;cmdletName&gt; -full**. For example, to get help for the **Get-ActiveOperation** cmdlet, enter the following command.

[!code-powershell[Main](web-farm-framework-20-for-iis-cmdlets-for-windows-powershell/samples/sample4.ps1)]

![Screenshot shows Windows Power Shell with the following command entered, Get Help Get Active Operation full.](web-farm-framework-20-for-iis-cmdlets-for-windows-powershell/_static/image3.png)

## Managing Servers Using the cmdlets

You can perform management tasks for the server farm or a specific server in the farm using the cmdlets. The following table lists the cmdlets for these tasks.

| cmdlet Name | Description |
| --- | --- |
| Get-ActiveOperation | Returns the operations currently running on the server or server farm. |
| Get-AvailableOperation | Returns the operations available on the server or server farm. |
| Get-Server | Returns a list of servers in the farm, or, if you specify a signal server, it returns the specified server. |
| Get-ServerProcess | Returns a list of the processes currently running on the server or server farm. |
| Get-ServerRequest | Returns a list of the requests currently being processed on the server or server farm. |
| Get-TraceMessage | Returns a list of the trace messages from the server or server farm. |
| Get-WeNbFarm | Returns the name of the server farm or farms available. |
| Install-ServerProduct | Installs the specified product on the server or server farm. |
| New-CredentialStoreTarget | Adds a new target to the Windows credential store. |
| New-MiniDump | Returns dump information from the server. |
| New-Server | Adds a server to an existing server farm. |
| New-WebFarm | Creates a new server farm. |
| Remove-CredentialStoreTarget | Removes a target from the Windows credential store. |
| Remove-Server | Removes a server from the server farm. |
| Remove-WebFarm | Removes a server farm. |
| Run-Operation | Executes the specified operation on the server or server farm. |
| Start-Server | Starts the specified server. |
| Stop-Server | Stops the specified server. |

## Creating a Server Farm Using the cmdlets

To create a server farm, at the PowerShell prompt, enter the following cmdlet:

[!code-powershell[Main](web-farm-framework-20-for-iis-cmdlets-for-windows-powershell/samples/sample5.ps1)]

Provide the name of the new web farm and your credentials as prompted.

![Screenshot that shows the Windows Power Shell Credential Request dialog box. New Web Farm is entered on the command line in Power Shell.](web-farm-framework-20-for-iis-cmdlets-for-windows-powershell/_static/image5.png)

To verify the server farm was created, use the **Get-WebFarm** cmdlet, as follows:

[!code-powershell[Main](web-farm-framework-20-for-iis-cmdlets-for-windows-powershell/samples/sample6.ps1)]

![Screenshot that shows Windows Power Shell. Get Web Farm is entered on the command line.](web-farm-framework-20-for-iis-cmdlets-for-windows-powershell/_static/image7.png)

## Adding a Server to a Server Farm Using the cmdlets

To add a server to an existing server farm, at the PowerShell prompt, enter the following command:

[!code-powershell[Main](web-farm-framework-20-for-iis-cmdlets-for-windows-powershell/samples/sample7.ps1)]

Provide the name of the web farm and server address as prompted.

To verify that the server was added, use the **Get-Server** Nmdlet as follows:

[!code-powershell[Main](web-farm-framework-20-for-iis-cmdlets-for-windows-powershell/samples/sample8.ps1)]

The servers in the farm are displayed.

![Screenshot that shows Windows Power Shell. Get Server is entered on the command line.](web-farm-framework-20-for-iis-cmdlets-for-windows-powershell/_static/image9.png)

## Adding Credentials to Windows Credential Store

Using Window's credential store, users can store passwords and access credential stored password information via the command-line. This is very useful if you want keep your password from showing up in any log files that may capture command line input. The credential store saves a target along with your user name and password. The *target* is a string that is used to identify the credential information.

To add a new target to an existing server farm, at the PowerShell prompt, enter the following command:

[!code-powershell[Main](web-farm-framework-20-for-iis-cmdlets-for-windows-powershell/samples/sample9.ps1)]

Provide the target and your credentials as prompted.

![Screenshot that shows the Windows Power Shell Credential Request dialog box. New Credential Store Target is entered on the command line in Power Shell.](web-farm-framework-20-for-iis-cmdlets-for-windows-powershell/_static/image11.png)

## Removing Credentials from Windows Credential Store

To remove an existing target (and therefore the associated credentials), at the PowerShell prompt, enter the following command:

Remove-CredentialStoreTarget

Provide the target to be removed as prompted.

![Screenshot that shows Windows Power Shell. Remove Credential Store Target is entered on the command line.](web-farm-framework-20-for-iis-cmdlets-for-windows-powershell/_static/image13.png)
