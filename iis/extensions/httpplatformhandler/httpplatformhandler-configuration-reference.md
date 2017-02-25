---
title: "HttpPlatformHandler Configuration Reference | Microsoft Docs"
author: rick-anderson
description: "This article provides an overview of the HttpPlatformHandler and explains the configuration of the module."
ms.author: aspnetcontent
manager: wpickett
ms.date: 01/26/2015
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/extensions/httpplatformhandler/httpplatformhandler-configuration-reference
msc.type: authoredcontent
---
HttpPlatformHandler Configuration Reference
====================
by IIS Team

> This article provides an overview of the HttpPlatformHandler and explains the configuration of the module.


[Functionality Overview](#_Functionality_Overview)

[HttpPlatformHandler Configuration](#_HttpPlatformHandler_Configuration)

[HttpPlatformHandler Configuration Examples](#_HttpPlatformHandler_Configuration_E)

[Sample Code](#_Sample_Code)

<a id="_Functionality_Overview"></a>
## Functionality Overview

The HttpPlatformHandler is an IIS Module, for IIS 8+, which does the following two things:

1. Process management of http listeners - this could be any process that can listen on a port for http requests. For example - Tomcat, Jetty, Node.exe, Ruby etc;
2. Proxy requests to the process that it manages.

<a id="_HttpPlatformHandler_Configuration"></a>
## HttpPlatformHandler Configuration

 The HttpPlatformHandler is configured via a site or applications web.config file and has its own configuration section within system.webServer - httpPlatform. 

### Configuration Attributes

| **Attribute** | **Description** |
| --- | --- |
| `processPath` | Required attribute. Path to the executable or script that will launch a process listening for HTTP requests. As of v1.2 relative paths are supported, if the path begins with '.' the path is considered to be relative to the site root. There is no default value |
| `arguments` | Optional string value. Arguments to the executable or script specified in the processPath setting. There is no default value. |
| `startupTimeLimit` | Optional integer attribute. Duration in seconds for which HttpPlatformHandler will wait for the executable/script to start a process listening on the port. If this time limit is exceeded, HttpPlatformHandler will kill the process and try to launch it again **startupRetryCount** times. The default value is `10`. |
| `startupRetryCount` | Optional integer attribute. Number of times HttpPlatformHandler will try to launch the process specified in **processPath**. See **startupTimeLimit** for more details. The default value is `10`. |
| `rapidFailsPerMinute` | Optional integer attribute. Specifies the number of times the process specified in **processPath** is allowed to crash per minute. If this limit is exceeded, **HttpPlatformHandler** will stop launching the process for the remainder of the minute. The **managedPipelineMode** attribute can be one of the following possible values. The default is `10`. |
| `requestTimeout` | Optional timespan attribute. Specifies the duration for which **HttpPlatformHandler** will wait for a response from the process listening on `%HTTP_PLATFORM_PORT%`. The default value is **"00:02:00"**. |
| `stdoutLogEnabled` | Optional boolean attribute. If true, **stdout** and **stderr** for the process specified in the **processPath** setting will be redirected to the file specified in **stdoutLogFile.** The default value is `false`. |
| `stdoutLogFile` | Optional string attribute. Specifies the relative OR absolute file path for which **stdout** and **stderr** from the process specified in **processPath** will be logged. Relative paths are relative to the root of the site. As of v1.2 any path starting with '.' will be relative to the site root and all other paths will be treated as absolute paths. The default value is `httpplatform-stdout.` |
| `processesPerApplication` | Optional integer attribute. Specifies the number of instances of the process specified in the **processPath** setting that can be spun up per application. Maximum is 100. The default value is `1`. |
| `forwardWindowsAuthToken` | True or False. New for v1.2. If this setting is set to true, the token will be forwarded to the child process listening on %HTTP\_PLATFORM\_PORT% as a header 'X-IIS-WindowsAuthToken' per request. It is the responsibility of that process to call CloseHandle on this token per request. The default value is `false`. |

#### Child Elements

| **Element** | **Description** |
| --- | --- |
| **environmentVariables** | Configures **environmentVariables** collection for the process specified in the **processPath** setting. |
| **recycleOnFileChange** | configures **file** collection which recycles the worker process when changes are made to file in the specified list. Element syntax e.g. &lt;file path=&quot;.\touch.txt&quot;/&gt; or &lt;file path=&quot;c:\file.txt&quot;/&gt; |

<a id="_HttpPlatformHandler_Configuration_E"></a>
## HttpPlatformHandler Configuration Examples

 Below are configuration examples for running a number of applications with different processes. 

### Tomcat

[!code-xml[Main](httpplatformhandler-configuration-reference/samples/sample1.xml)]

### Jetty

[!code-xml[Main](httpplatformhandler-configuration-reference/samples/sample2.xml)]

<a id="_Sample_Code"></a>
## Sample Code

### C#

[!code-csharp[Main](httpplatformhandler-configuration-reference/samples/sample3.cs)]

### JavaScript

[!code-csharp[Main](httpplatformhandler-configuration-reference/samples/sample4.cs)]

### Command Line (AppCmd)

[!code-console[Main](httpplatformhandler-configuration-reference/samples/sample5.cmd)]

### PowerShell

[!code-console[Main](httpplatformhandler-configuration-reference/samples/sample6.cmd)]