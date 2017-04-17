---
title: "Troubleshooting Common Problems with Web Deploy | Microsoft Docs"
author: Tuesdaysgreen
description: "This walkthrough shows how to diagnose and fix common problems with Web Deploy, including common errors seen while publishing from Visual Studio 2010. Loggin..."
ms.author: iiscontent
manager: soshir
ms.date: 04/20/2012
ms.topic: article
ms.assetid: 
ms.technology: iis-publish
ms.prod: iis
msc.legacyurl: /learn/publish/troubleshooting-web-deploy/troubleshooting-common-problems-with-web-deploy
msc.type: authoredcontent
---
Troubleshooting Common Problems with Web Deploy
====================
by [Elliott Hamai](https://github.com/Tuesdaysgreen)

This walkthrough shows how to diagnose and fix common problems with Web Deploy, including common errors seen while publishing from Visual Studio 2010.

<a id="_Toc295395148"></a>

## Logging

When you run into issues with Web Deploy, there are several logging options depending on where the problem occurred. By default, Web Deploy logs to the Event Log under Applications &gt; Microsoft Web Deploy. This is great place to start looking for errors on the destination server.

In the unlikely case that you cannot diagnose the problem using the Event Log, here are some other options:

1. To diagnose installation problems, Web Deploy MSI logs are placed under %programfiles%\IIS\Microsoft Web Deploy v3.
2. If Web Management Service or Remote Agent Service fail to start at all, look at the event Event Log &gt; System for Service Control Manager errors.
3. You can further configure [tracing for Web Management Service](https://technet.microsoft.com/en-us/library/ee461173(WS.10).aspx)

## Error Codes

For certain common error cases, Web Deploy will show a message and an error code which may be useful in getting more information to troubleshoot an issue. For a full list of error codes, see [https://go.microsoft.com/fwlink/?LinkId=221672](https://go.microsoft.com/fwlink/?LinkId=221672) .

Note that the error message may be different depending on how Web Deploy is invoked. For example, Microsoft WebMatrix chooses to show custom error messages instead of error codes whereas the command line will always show error codes if they are logged.

## Installation

<a id="_Toc295395132"></a>

### 1. Could not install Web Deploy on a valid OS

| Symptoms | The OS is correct, the version and bitness of Web Deploy are correct, but the installation does not succeed. |
| --- | --- |
| Root Cause | Unknown |
| Fix/Workaround | Look in the install log, located in %programfiles%\IIS\Microsoft Web Deploy V2. |

### 2. Web Deploy does not function after upgrade

| **Symptoms** | Web Deploy does not work after a version upgrade. |
| --- | --- |
| **Root Cause** | Web Deploy does not restart services after an upgrade. |
| **Fix/Workaround** | If you are upgrading an existing installation of Web Deploy, make sure to restart the handler and agent services by running the following commands at an administrative command prompt: · net stop msdepsvc &amp; net start msdepsvc · net stop wmsvc &amp; net start wmsvc |

<a id="_Toc239408302"></a>

### 3. Could not install Web Deploy 32-bit version on 64-bit hardware

| **Symptoms** | [![](troubleshooting-common-problems-with-web-deploy/_static/image2.png)](troubleshooting-common-problems-with-web-deploy/_static/image1.png) |
| --- | --- |
| **Root Cause** | Trying to install 32-bit on 64-bit OS is a check inside the Web Deploy MSI that will fail because it doesn't support WoW64 mode. |
| **Fix/Workaround** | Install the same version that matches the architecture of your OS. |

<a id="_Toc239408303"></a>

#### 4. Could not install Web Deploy 64-bit version on 32-bit hardware

| **Symptoms** | [![](troubleshooting-common-problems-with-web-deploy/_static/image4.png)](troubleshooting-common-problems-with-web-deploy/_static/image3.png) |
| --- | --- |
| **Root Cause** | Trying to install 64-bit on 32-bit OS is a check inside Web Deploy's MSI that will fail. |
| **Fix/Workaround** | Install the same version that matches the architecture of your OS. |

<a id="_Toc239408307"></a>

#### 5. Could not register the URL namespace due to pre-existing namespace

| **Symptoms** | Unable to install Web Deploy |
| --- | --- |
| **Root Cause** | The URL namespace that Web Deploy tries to create during installation is already registered |
| **Fix/Workaround** | · Remove the conflicting registration · Change Web Deploy URL during installation msiexec /i wdeploy.msi /passive ADDLOCAL=ALL LISTENURL=http://+:8080/MSDEPLOY2/ Further details on URL customization are found here: [https://technet.microsoft.com/en-us/library/dd569093(WS.10).aspx](https://technet.microsoft.com/en-us/library/dd569093(WS.10).aspx) |

<a id="_Toc295395136"></a>

## Remote Agent Service

<a id="_Toc175651746"></a>

#### 1. Could not initialize Microsoft.Web.Deployment.Dll during start-up

| **Symptoms** | Remote Agent Service fails to start |
| --- | --- |
| **Root Cause** | msdepsvc.exe or other files are missing from %programfiles%\IIS\Microsoft Web Deploy v2. |
| **Fix/Workaround** | Re-install the product |

<a id="_Toc239408310"></a>

#### 2. Remote Agent Service is not started

| **Symptoms** | Microsoft.Web.Deployment.DeploymentAgentUnavailableException: Remote agent (URL http://DestinationServer /msdeployagentservice) could not be contacted. Make sure the remote agent service is installed and started on the target computer. ---&gt; System.Net.WebException: The remote server returned an error: (404) Not Found. |
| --- | --- |
| **Root Cause** | Remote Agent Service is not started |
| **Fix/Workaround** | Start the service - ex: net start msdepsvc |

<a id="_Toc239408311"></a>

#### 3. Trying to connect to server where HTTP is not listening or allowed

| **Symptoms** | Microsoft.Web.Deployment.DeploymentAgentUnavailableException: Remote agent (URL http://DestinationServer/msdeployagentservice) could not be contacted. Make sure the remote agent service is installed and started on the target computer. ---&gt; System.Net.WebException: Unable to connect to the remote server ---&gt; System.Net.Sockets.SocketException: No connection could be made because the target machine actively refused it DestinationServer:80 |
| --- | --- |
| **Root Cause** | HTTP not listening |
| **Fix/Workaround** | Make sure HTTP traffic is allowed to the Remote Agent Service |

<a id="_Toc239408312"></a>

#### 4. Trying to connect to server with Method Not Allowed error

| **Symptoms** | Microsoft.Web.Deployment.DeploymentException: Could not complete the request to remote agent URL 'http://DestinationServer/'. ---&gt; System.Net.WebException: The remote server returned an error: (405) Method Not Allowed. |
| --- | --- |
| **Root Cause** | Request was picked up by IIS itself instead of MS Deploy, because the path to msdepsvc.exe is missing. |
| **Fix/Workaround** | Change the URL to include to /MSDeployAgentService |

<a id="_Toc239408313"></a>

#### 5. Trying to access Remote Agent Service as a non-administrator

| **Symptoms** | Microsoft.Web.Deployment.DeploymentException: Could not complete the request to remote agent URL 'http://DestinationServer/msdeployAgentService'. ---&gt; System.Net.WebException: The remote server returned an error: (401) Unauthorized. |
| --- | --- |
| **Root Cause** | Remote Agent Service requires that the caller is a member of the Administrators group or from a domain account that has been added to the Administrators group. A local administrator which is not the built-in account will not work with the Remote Agent Service because of a bug in Web Deploy 2.0. |
| **Fix/Workaround** | Provide administrative credentials |

<a id="_Toc239408314"></a>

#### 6. Remote Agent Service hangs during operation

| **Symptoms** | Service may stop responding for a long time, up to several hours |
| --- | --- |
| **Root Cause** | Unknown |
| **Fix/Workaround** | Stop the operation and attempt to repeat it |

<a id="_Toc239408315"></a>

#### 7. Client and server are not compatible (version mismatch)

| **Symptoms** | Timestamp=24638007621418 MsDepSvc.exe Error: 0 : An error occurred. The exception details are as follows: Microsoft.Web.Deployment.DeploymentClientServerException: The client and server are not compatible. The lowest version supported by the client is '7.1.538.0'. The highest version supported by the server is '7.1.537.0'. |
| --- | --- |
| **Root Cause** | Some versions do not work together, so Web Deploy blocks them from working together. This is typically done to block pre-release versions from operating with released versions. |
| **Fix/Workaround** | Match the versions |

<a id="_Toc239408316"></a>

#### 8. Remote Agent Service could not start listening on URL

| **Symptoms** | The Remote Agent Service could not start listening on the URL '{0}'. Make sure that the URL is not in use. |
| --- | --- |
| **Root Cause** | Usually indicates a URL conflict. |
| **Fix/Workaround** | Try reinstalling if you want the default URL or setting a custom URL as specified in the documentation. Further details on URL customization are found here: [https://technet.microsoft.com/en-us/library/dd569093(WS.10).aspx](https://technet.microsoft.com/en-us/library/dd569093(WS.10).aspx) |

<a id="_Toc295395145"></a>

## Web Management Service

<a id="_Toc239408321"></a>

#### 1. Web Management Service not started

| **Symptoms** | Web Management Service is not started. |
| --- | --- |
| **Root Cause** | Unknown. The service should be started by default. |
| **Fix/Workaround** | Start the Web Management Service service: Net Start WMSVC |

<a id="_Toc239408323"></a>

#### 2. Not Authorized: User not authorized by deployment handler rules

| **Symptoms** | Could not complete an operation with the specified provider &lt;provider name&gt; when connecting using the Web Management Service. This can occur if the server administrator has not authorized the user for this operation. |
| --- | --- |
| **Root Cause** | A non-administrator user tried to perform a restricted action with a provider. This usually indicates that a matching delegation rule was not found. Either the username, provider, operation or provider path is wrong. |
| **Fix/Workaround** | The workaround is to fix the delegation rule or create one. Further details on delegation rules can be found here: [https://www.iis.net/learn/publish/using-web-deploy/configure-the-web-deployment-handler](../using-web-deploy/configure-the-web-deployment-handler.md) |

### Case Study: Diagnosing Publishing Errors in Visual Studio 2010

This case study shows how to diagnose common errors encountered in Visual Studio 2010. The steps below walk through the series of errors you are likely to encounter when trying to publish from Visual Studio to a server that has not been correctly configured.

To collect the screenshots and errors below, we used a new ASP.NET MVC3 project. The destination server was a clean install of Windows Server 2008 R2 SP1 with IIS. No additional configuration was done.

The first error you are likely to encounter will look something like this in Visual Studio's output window. To make it easier to read, the full text of the message is reproduced below the screenshot.

[![](troubleshooting-common-problems-with-web-deploy/_static/image6.png)](troubleshooting-common-problems-with-web-deploy/_static/image5.png)

Web deployment task failed.(Could not connect to the destination computer ("deployserver"). On the destination computer, make sure that Web Deploy is installed and that the required process ("The Web Management Service") is started.)

This error indicates that you cannot connect to the server. Make sure the service URL is correct, firewall and network settings on this computer and on the server computer are configured properly, and the appropriate services have been started on the server.

Error details:

Could not connect to the destination computer ("deployserver"). On the destination computer, make sure that Web Deploy is installed and that the required process ("The Web Management Service") is started.

Unable to connect to the remote server

A connection attempt failed because the connected party did not properly respond after a period of time, or established connection failed because connected host has failed to respond 192.168.0.211:8172

**Is the web management service installed?** On the destination server, open IIS Manager and select the machine name node. In the Features view, scroll down to the Management section and look for these Icons:

[![](troubleshooting-common-problems-with-web-deploy/_static/image8.png)](troubleshooting-common-problems-with-web-deploy/_static/image7.png)

If they are not there, you need to install the Web Management Service.

· Through the "Add Role Services" dialog in Server Manager.

· Through the Web Platform Installer from the Products tab. Select "Server" in the left column and choose "IIS: Management Service".

Note that after you install the Management Service, you will need to start it, as it is not started automatically.

Once the Web Management Service is installed, Visual studio may show this error:

[![](troubleshooting-common-problems-with-web-deploy/_static/image10.png)](troubleshooting-common-problems-with-web-deploy/_static/image9.png)

Web deployment task failed.(Could not connect to the destination computer ("deployserver") using the specified process ("The Web Management Service") because the server did not respond. Make sure that the process ("The Web Management Service") is started on the destination computer.)

Could not connect to the destination computer ("deployserver") using the specified process ("The Web Management Service") because the server did not respond. Make sure that the process ("The Web Management Service") is started on the destination computer.

The remote server returned an error: (403) Forbidden.

**Is the Web Management Service configured to allow remote connections?** Start IIS Manager and double-click the Management Service icon, and verify that "Enable Remote Connections" is checked. You must stop the service to make changes, so be sure to restart it.

[![](troubleshooting-common-problems-with-web-deploy/_static/image12.png)](troubleshooting-common-problems-with-web-deploy/_static/image11.png)

**Is Windows Firewall blocking the request?** The Web Management Service creates an Inbound rule named "Web Management Service (HTTP Traffic-In)", and enables it. Verify this rule is enabled by going to Start-&gt;Administrative tools-&gt; "Windows Firewall with Advanced Security". Click "Inbound Rules" and find the Web Management rule in the list. It should be enabled for all profiles.

If you are using a 3rd party firewall, make sure inbound TCP connections on port 8172 are allowed.

If Visual Studio is able to contact the Management Service, the error message changes:

[![](troubleshooting-common-problems-with-web-deploy/_static/image14.png)](troubleshooting-common-problems-with-web-deploy/_static/image13.png)

Web deployment task failed.(Could not connect to the destination computer ("deployserver"). On the destination computer, make sure that Web Deploy is installed and that the required process ("The Web Management Service") is started.)

The requested resource does not exist, or the requested URL is incorrect.

Error details:

Could not connect to the destination computer ("deployserver"). On the destination computer, make sure that Web Deploy is installed and that the required process ("The Web Management Service") is started.

The remote server returned an error: (404) Not Found.

If you look in the Web Management Service log under %SystemDrive%\Inetpub\logs\WMSvc on the destination server, you will see an entry that looks like 

[!code-console[Main](troubleshooting-common-problems-with-web-deploy/samples/sample1.cmd)]
 

**Is Web Deploy installed?** You can verify web deploy is installed by going to the "Programs and Features" control panel and looking for "Microsoft Web Deploy 2.0" in the list of installed programs. If it is not there, you can install it via the Web Platform Installer by going to the "Products" tab. It is listed as "Web Deployment Tool 2.1".

**Is the Web Deployment IIS7 Deployment Handler installed?** If Web Deploy is installed and you still get this error, make sure the "IIS 7 Deployment Handler" feature in Web Deploy is installed. In "Add Remove Programs", find "Microsoft Web Deploy 2.0", right click and choose "Change". In the Wizard that comes up, click next on the first page, and then choose "Change" on the second page. Add "IIS 7 Deployment Handler" and everything under it.

[![](troubleshooting-common-problems-with-web-deploy/_static/image16.png)](troubleshooting-common-problems-with-web-deploy/_static/image15.png)

Click **Next** to complete the Wizard.

Once Web Deploy and the Web Management Service are correctly configured, you will need to set up Web Management Service delegation rules to allow users to update content. For permissions issues, there are several different errors you may see in Visual Studio. For example:

[![](troubleshooting-common-problems-with-web-deploy/_static/image18.png)](troubleshooting-common-problems-with-web-deploy/_static/image17.png)

Web deployment task failed.(Connected to the destination computer ("deployserver") using the Web Management Service, but could not authorize. Make sure that you are using the correct user name and password, that the site you are connecting to exists, and that the credentials represent a user who has permissions to access the site.)

Make sure the site name, user name, and password are correct. If the issue is not resolved, please contact your local or server administrator.

Error details:

Connected to the destination computer ("deployserver") using the Web Management Service, but could not authorize. Make sure that you are using the correct user name and password, that the site you are connecting to exists, and that the credentials represent a user who has permissions to access the site.

The remote server returned an error: (401) Unauthorized.

In the Web Management Service log, you will see

[!code-console[Main](troubleshooting-common-problems-with-web-deploy/samples/sample2.cmd)]

[!code-console[Main](troubleshooting-common-problems-with-web-deploy/samples/sample3.cmd)]

The highlighted HTTP status in the Visual Studio output is an Access Denied error. The highlighted Win32 status in the error log maps to "Logon failure: unknown user name or bad password". This is a simple logon failure. If the user is authenticated, but does not have the rights needed to publish, the log entry will look like

[!code-console[Main](troubleshooting-common-problems-with-web-deploy/samples/sample4.cmd)]

You will need to setup delegation for this user per the instructions at [https://www.iis.net/learn/publish/using-web-deploy/configure-the-web-deployment-handler](../using-web-deploy/configure-the-web-deployment-handler.md)

If the account is able to log in, but has not been granted the rights needed to publish the content, you will see

[[![](troubleshooting-common-problems-with-web-deploy/_static/image21.png)](troubleshooting-common-problems-with-web-deploy/_static/image20.png)](troubleshooting-common-problems-with-web-deploy/_static/image19.png)

Web deployment task failed. (Unable to perform the operation ("Create Directory") for the specified directory ("bin"). This can occur if the server administrator has not authorized this operation for the user credentials you are using.

The WMSvc log will show HTTP 200 responses for these requests. The most likely cause is file system permissions. Web Deploy will also write events to the "Microsoft Web Deploy" service log. To view it, open the event viewer and go to "Applications and Services Logs" -&gt;"Microsoft Web Deploy".

[[![](troubleshooting-common-problems-with-web-deploy/_static/image24.png)](troubleshooting-common-problems-with-web-deploy/_static/image23.png)](troubleshooting-common-problems-with-web-deploy/_static/image22.png)

For this particular error, the event log contains extra detail (truncated for brevity):

[!code-console[Main](troubleshooting-common-problems-with-web-deploy/samples/sample5.cmd)]

This message tells you where permissions need to be granted for this particular error. Another permissions error you may see in Visual Studio is

[[![](troubleshooting-common-problems-with-web-deploy/_static/image27.png)](troubleshooting-common-problems-with-web-deploy/_static/image26.png)](troubleshooting-common-problems-with-web-deploy/_static/image25.png)

Web deployment task failed.((5/12/2011 11:31:41 AM) An error occurred when the request was processed on the remote computer.)

(5/12/2011 11:31:41 AM) An error occurred when the request was processed on the remote computer.  
The server experienced an issue processing the request. Contact the server administrator for more information.

This particular error does not give you much to go on, but the picture becomes much clearer if you look at the Web Deploy error log in Event Viewer.

[!code-console[Main](troubleshooting-common-problems-with-web-deploy/samples/sample6.cmd)]

From this, we can see that User1 does not have rights to set security information. In this case, the user does not have Modify permissions on the content. Granting "Change Permissions" to the content resolves the problem.

If you cannot browse a .NET 4.0 application after it has been successfully published, it could be that .NET 4.0 has not been registered correctly with IIS. Other symptoms are that .NET 4.0 is installed, but there are no .NET 4.0 application pools or handler mappings in IIS. This happens when .NET 4.0 is installed before IIS was installed. To fix this problem, start an elevated command prompt and run this command:

[!code-console[Main](troubleshooting-common-problems-with-web-deploy/samples/sample7.cmd)]