---
title: "Configuring the FastCGI Extension for IIS 6.0 | Microsoft Docs"
author: rick-anderson
description: "From its first version, Internet Information Services (IIS) has supported Common Gateway Interface (CGI), which is a standards-based protocol that allows inf..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 12/05/2007
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/application-frameworks/install-and-configure-php-on-iis/configuring-the-fastcgi-extension-for-iis-60
msc.type: authoredcontent
---
Configuring the FastCGI Extension for IIS 6.0
====================
by Ruslan Yakushev

## Introduction

From its first version, Internet Information Services (IIS) has supported Common Gateway Interface (CGI), which is a [standards-based](http://www.w3.org/CGI/) protocol that allows information servers, such as IIS, to interface with external applications. FastCGI was introduced to address the scalability shortcomings of CGI.

This article describes the shortcomings of earlier versions of CGI and defines the need for the FastCGI extension for IIS 6.0. This article also describes the configuration settings for the FastCGI extension.

## CGI, ISAPI, and FastCGI in IIS 6.0 and IIS 5.1

### CGI

CGI is a protocol that allows information servers to interface with external applications. Because HTTP is stateless, any requests that are made over HTTP create a new instance of the external application in a new operating system process.

Within the new process, the *stdin* handle is remapped so that it receives request data from the client, the *stdout* handle is remapped so that it writes response data to the client, and the command line and operating system environment variables are set to provide other server and request information to the CGI process.

The disadvantage with CGI on IIS is the relatively expensive process creation on Windows operating systems. Every HTTP request creates a new process, performs the work inside the CGI application, and shuts down the process. On operating systems with light-weight process creation, performance is bound by the work that is completed inside the CGI application. On operating systems where process creation is expensive, such as Windows, performance of the CGI application is bound by spinning up the new process. This is the reason why CGI has performed well on a Unix-based platform, but has not been recommended for IIS.

### ISAPI

Despite the disadvantage of CGI on Windows, IIS is capable of keeping up with, and often surpassing, the performance of other Web servers. The reason for this is Internet Server Application Programming Interface (ISAPI). Unlike CGI, ISAPI is completely internal to the Web server process. When a new request is made for an ISAPI application, a new process is not created. Instead, the Web server calls an entry point in a DLL that is loaded into the Web server process. If the ISAPI application is written with an understanding of how the operating system threading model works, the performance is extremely fast.

For many years, PHP has run on IIS through both ISAPI and CGI implementations. However, both implementations have disadvantages when running on IIS. As with all CGI applications, the CGI implementation of PHP has a disadvantage due to the performance characteristics of process creation on the Windows OS. The ISAPI implementation has a disadvantage due to threading issues.

When PHP runs as an ISAPI, it runs inside the Web server process in a highly multi-threaded environment. While the PHP implementation is thread-safe, many popular extensions to PHP are not thread-safe. If you use a non-thread-safe extension to PHP with ISAPI, the server can become unstable. Hence, many applications cannot run in the ISAPI PHP implementation, while other applications can run well in this environment.

### FastCGI

FastCGI offers a solution that delivers both performance and stability. FastCGI allows the host CGI process to remain alive after one request finishes so that the process can be reused for another request. Since the process can be reused many times, the cost of process creation on the Windows OS is no longer an issue.

The technical difference between normal CGI and FastCGI is that FastCGI has a layer in the process that maps the FastCGI protocol into the *stdin*, *stdout* and other resources that CGI uses. Many third-party libraries can be linked into existing CGI source code with minor modifications to make them work with FastCGI.

FastCGI on IIS runs on top of ISAPI and can be broken down into the following parts: applications, the application manager, and the FastCGI protocol support code.

Because Web servers handle multiple, concurrent requests, a pool of processes must be available and ready to handle incoming requests. In the FastCGI handler, this pool of processes is called an application (to avoid confusion with IIS applications, this article uses the term "process pool"). There are a number of properties of a process pool that you can manage. For example, you can specify the number of processes in the pool, or the number of requests that a process is allowed to accept before it is shut down and recycled.

The FastCGI handler supports multiple process pools so that you can run more than one kind of FastCGI on a single server. For example, you can configure your server to support both PHP and Ruby on Rails. If you have multiple sites on your server and do not want requests for those sites to share the same processes, you can have the site processes run as different users. The part of the server that handles multiple process pools is called the application manager.

## Configuring FastCGI

### Script Maps

To route requests to the FastCGI handler, you must associate the FastCGI handler with IIS. In IIS 6.0 and IIS 5.1, you can do this by using an IIS configuration setting called a "script map." Script maps are used to associate file extensions with the ISAPI handler that executes when that file type is requested. The script map also has an optional setting that verifies that the physical file associated with the request exists before allowing the request to be processed. For security reasons, this is the default setting.

However, you might want to allow a request to be processed that is not associated with a physical file. The ISAPI extension that contains the FastCGI handler is called fcgiext.dll. To configure the FastCGI handler to accept PHP requests, you must create a new script map that associates the ".php" extension with fcgiext.dll. For Ruby on Rails, you must map the ".rb" extension to fcgiext.dll and so on. In IIS 6.0 it is also possible to use a wildcard character in the script map. In this situation, all requests are routed to a single ISAPI extension. If you create a wildcard script map for fcgiext.dll, all requests go to FastCGI, regardless of the file extension that is requested.

To create a script map for the FastCGI handler on IIS 6.0 and IIS 5.1:

1. Open IIS Manager.
2. Double-click the machine icon for the local computer.
3. Right-click **Web Sites** and then click **Properties**.
4. Click the **Home Directory** tab.
5. Click the **Configuration…** button.
6. Click the **Add…** button.
7. Browse to %WINDIR%\system32\inetsrv\ and select fcgiext.dll as the executable file.  
    > [!NOTE]
    >  If you are using a 64-bit platform in WOW mode, you must use the fcgiext.dll file that is located in the %WINDIR%\SysWOW64\inetsrv path.
8. In the **Extension** text box, enter **.php** (or another extension that is specific to your FastCGI application).
9. Under **Verbs**, in the **Limit to** text box, enter **GET,HEAD,POST**.
10. Select the **Script engine** and **Verify that file exists** check boxes.  
    [![](configuring-the-fastcgi-extension-for-iis-60/_static/image3.png)](configuring-the-fastcgi-extension-for-iis-60/_static/image1.png)
11. Click **OK**.

### FCGIEXT.ini

The configuration for FastCGI is a collection of one or more applications. A FastCGI application consists of a pool of processes that each handle HTTP requests. Each process in the pool handles one request at a time. After each request, the process is returned to the pool to await another request. Each application is required to have its own section in the configuration file to specify its behavior.

The main section of the fcgiext.ini file is the **[types]** section. This section associates file extensions from the URL with FastCGI applications.

The general syntax is as follows:


[!code-unknown[Main](configuring-the-fastcgi-extension-for-iis-60/samples/sample-127384-1.unknown)]


The above example consists of seven mappings that are mapped as follows:

- The file extension "abc" is associated with the FastCGI application named "Application 1".
- The file extension "def" is associated with the FastCGI application named "Application 2", but only for requests that are made to the application /app1 under the site with the numeric identifier of "1701187997". Note that application-specific mappings override site, extension-specific mappings.
- Requests to the application /app1 under the Web site with the identifier of "1701187997" and with a file extension other than "def" are associated with the FastCGI application named "Application 3".
- The file extension "def" is associated with the FastCGI application named "Application 4", but only for requests that are made to the applications other than /app1 under the Web site with the numeric identifier of "1701187997". Note that site-specific mappings override non-site-specific mappings.
- Requests to the applications other than /app1 under the Web site with the identifier of "1701187997" and with file extensions other than "def" are associated with the FastCGI application named "Application 5".
- The file extension "def" is associated with the FastCGI application named "Application 6" for requests that are not for sites with the numeric identifier of "1701187997".
- Requests with a file extension that does not have a specific mapping are associated with the FastCGI application named "Application 7".

> [!NOTE]
> Application names are ASCII and should generally contain only alphanumeric characters. Space characters are allowed. Application names are not case sensitive.

> [!NOTE]
> Multiple mappings can be associated with the same FastCGI application.

### FastCGI Application Settings

The FastCGI extension has a set of configuration settings that controls the behavior of FastCGI processes that are associated with the FastCGI process pool. This section lists all the settings that are supported by FastCGI and their format:

- *ExePath* - The physical path to the process executable to use in the pool.
- *Arguments* - Arguments to pass to each process in the pool at start time. This setting is optional.
- *EnvironmentVars –*Environment variables that are set for the process executable associated with this pool. This setting uses the following format:

> EnvironmentVars=Name:Value,Name:Value,…,Name:Value


Example:

[!code-unknown[Main](configuring-the-fastcgi-extension-for-iis-60/samples/sample-127384-2.unknown)]

If the environment variable value contains a space character, then enclose the value in quotes. If the environment variable value contains a comma character, then this character is escaped with "/". Similarly, if the environment variable value contains "/", then this character should be escaped as well.

Example:

[!code-unknown[Main](configuring-the-fastcgi-extension-for-iis-60/samples/sample-127384-3.unknown)]

- *Protocol –*This setting specifies the protocol to use to communicate with the FastCGI process. The allowed values are 'NamedPipe' and 'Tcp'. If not specified, the default value is 'NamedPipe'.
- *QueueLength* – This setting specifies the maximum number of requests to this application's process pool that are queued before the FastCGI handler starts returning errors to clients, indicating that the application is too busy. If not specified, the default value is 1000.
- *MaxInstances* – This is the highest number of process instances allowed in the process pool. Note that the FastCGI handler will not create this number of processes unless they are needed. If your application never receives more than two concurrent requests, your application only creates two processes. The default is 0, which means that the number of process instances will be adjusted automatically based on available memory and current CPU usage .
- *InstanceMaxRequests* – This is the number of requests that are sent to a process in the pool before it is shut down and recycled. The default value is 1000.
- *IdleTimeout* – This is the number of seconds that a process can remain idle without working on a request before it shuts down. The default is 300 seconds.
- *ActivityTimeout* – This is the number of seconds that the FastCGI handler waits for I/O activity from a process before it is terminated. The default is 30 seconds.
- *RequestTimeout* – This is the maximum amount of time that a FastCGI process is allowed to handle a request before it is terminated. The default value is 90 seconds.
- *ResponseBufferLimit –*Data from FastCGI processes is buffered before being returned to the client as responses. This property specifies the amount of response data, in bytes, that is buffered for requests to this application. This buffer is flushed to the client once it is full, or when the response is complete, whichever occurs first. If not specified, the default value is 4194304 (4MB).
- *FlushNamedPipe* – There are some cases where a FastCGI application might not read all of the data from the named pipe that communicates with the Web server. If this happens, the Web server waits for a read that is not coming, causing a deadlock on that member of the process pool. This most often happens in the case where the FastCGI process abnormally exits. For instance, the process may have an internal notion of the maximum number of requests that it can handle that is less than the *InstanceMaxRequests* setting. Setting *FlushNamedPipe* to 1 will cause FastCGI to flush data that might lead to this condition. The default value is 0.
- *UnhealthyOnQueueFull* – If the value is 1, the worker process that is hosting is flagged to IIS as unhealthy any time that the application's request queue is filled. IIS checks health whenever it does a ping to the worker process. If that worker process has been flagged as unhealthy, it (along with everything it is hosting) will be recycled. If not specified, the default value is 0.
- *MonitorChangesTo* - This property specifies the path to a file, changes to which will trigger a recycle of FastCGI executables that are running for this FastCGI process pool. If the value of this property is blank, file change monitoring is disabled. The path to a file can be absolute or relative to the folder in which the FastCGI process (as specified by ExePath) is present. If not specified, the default value is blank.
- *StderrMode* - This setting specifies how content that is received on **stderr** is handled. The allowed values are: 

    - '**ReturnStderrIn500**' - The FastCGI extension will set the response status code to 500 and send whatever was received on the stderr stream as a response. This is the same behavior as in the FastCGI Extension v1.0.
    - '**ReturnGeneric500**' - The FastCGI extension will set the response status code to 500, but will return a generic 500 response.
    - '**IgnoreAndReturn200**' - Data on **stderr** is completely ignored and the FastCGI extension will send what was received on **stdout** as a response, with the status code 200.
    - **'TerminateProcess**' - The FastCGI extension will terminate the FastCGI process as soon as it returns anything on **stderr**. A generic response with the status code 500 will be sent to the HTTP client.
  
 If this setting is not specified, the default value is 'ReturnStderrIn500'.
- *MaxInstances* - This setting dictates the maximum number of FastCGI processes that can be launched for each application pool. This value is also equal to the maximum number of requests that can be processed simultaneously, since one process handles only one request at a time. This setting existed in the FastCGI Extension v1.0; however, with FastCGI Extension v1.5, the value can be set to 0, which will turn on automatic adjustment of the maximum number of instances. When the value is set to 0, the FastCGI extension will constantly analyze current CPU load and memory availability and, based on that, will increase or decrease the number of FastCGI process instances that are running at the same time.
- *SignalBeforeTerminateSeconds* - This setting specifies the number of seconds to elapse after setting the shutdown event and before calling TerminateProcess, thereby forcibly terminating the process. The default value is 0, which means that the event is not set and the FastCGI processes can be terminated abruptly at any time. If this value is greater than 0, the FastCGI process will create an event that is inherited by the child process. The value of this event's handle is set as the environment variable \_FCGI\_SHUTDOWN\_EVENT\_. The name of the named pipe, which is used to communicate with the process, is stored in the environment variable \_FCGI\_X\_PIPE\_.
- *ActivityTimeout* - This is the number of seconds that the FastCGI handler waits for I/O activity from a process before it is terminated. This setting existed in the FastCGI Extension v1.0, but in v1.5 its default value has been increased from 30 seconds to 70 seconds.

<a id="utf8servervars"></a>
### Using UTF-8 Encoding for Server Variables

By default, the FastCGI extension uses ASCII encoding when setting server variables that are used by PHP. When the requested URL contains non-ASCII characters, server variables that derive their values from the requested URL string may be set incorrectly. PHP applications that rely on those server variables may not work as a result.

To prevent this, the FastCGI extension can be configured to use UTF-8 encoding when setting server variables. To configure FastCGI to use UTF-8 encoding for a particular set of server variables, use the **REG\_MULTI\_SZ** registry key **FastCGIUtf8ServerVariables** and set its value to a list of server variable names. For example:

[!code-console[Main](configuring-the-fastcgi-extension-for-iis-60/samples/sample4.cmd)]

The above example configures the FastCGI extension to use UTF-8 encoding when setting the REQUEST\_URI and PATH\_INFO server variables.

After setting the registry key, restart IIS by using the **iisreset** command.

**Warning:** Using UTF-8 encoding for server variables may affect how PHP core and PHP applications work. Make sure to verify that applications work as expected after the registry key has been changed.

## Using the FastCGI Configuration Script

To simplify and automate the configuration steps that are described in the previous sections, a configuration script (fcgiconfig.js) is provided with the installation of the FastCGI extension. The script is located in %WINDIR%\system32\inetsrv. This script adds and removes script maps and modifies application pool settings in the fcgiext.ini file.

### Adding a New FastCGI Mapping

To add a new FastCGI mapping, run the script fcgiconfig.js with the **–add** switch. When using this switch, you must provide the following parameters:


- **-section:&lt;Section name&gt;.** This parameter specifies the name of the section that will be added to the fcgiext.ini file in the **[Types]** block.
- **-extension:&lt;file extension&gt;**. This parameter specifies which file extensions are associated with this section.
- **-path:&lt;file path to CGI executable&gt;**. This parameter specifies the absolute file path to the CGI executable that processes requests for files with the extension that is specified in the **–extension** parameter.
- **-site:&lt;site id&gt;**. This optional parameter specifies to which site the section should be added. If not specified, the section is added to all sites on your Web server.
- **-application:"/w3svc/&lt;siteid&gt;/root/&lt;appname&gt;"**
- **-norecycle**. By default, the configuration script recycles all application pools on IIS 6.0 for configuration changes to take effect. This optional parameter prevents this recycling.


Examples:

[!code-unknown[Main](configuring-the-fastcgi-extension-for-iis-60/samples/sample-127384-5.unknown)]

The above example adds a script map for the .php extension and updates the fcgiext.ini file.

As an option, you can specify to which site the script map is applied:

[!code-unknown[Main](configuring-the-fastcgi-extension-for-iis-60/samples/sample-127384-6.unknown)]

This example adds a script map to the "Default Web Site" only.

Also, you can specify to which application the script map is applied:

[!code-unknown[Main](configuring-the-fastcgi-extension-for-iis-60/samples/sample-127384-7.unknown)]

### Removing an Existing FastCGI Mapping

To remove an existing FastCGI mapping, run the script fcgiconfig.js with the **–remove** switch. When using this switch, you must provide the following parameters:

- **-section:&lt;Section name&gt;**. This parameter specifies the name of the section that will be removed from the fcgiext.ini file in the **[Types]** block.
- **-norecycle**. By default, the configuration script recycles all application pools on IIS 6.0 for configuration changes to take effect. This optional parameter prevents this recycling.

This example removes the FastCGI mapping for PHP applications:

[!code-unknown[Main](configuring-the-fastcgi-extension-for-iis-60/samples/sample-127384-8.unknown)]

### Configuring an Existing FastCGI Mapping

You can use the configuration script to set all the FastCGI configuration properties that are described earlier in this article. To set the configuration properties, use the **–set** switch. When using this switch, you must provide the following parameters:

- **-section:&lt;Section name&gt;**. This parameter specifies the name of the section to which the configuration change will be applied.
- **-&lt;Parameter Name&gt;:&lt;Parameter Value&gt;.** This parameter specifies the name of the parameter to change and its new value. The complete list of possible parameters is found in the section "Application Pool Settings".
- **-norecycle**. By default, the configuration script recycles all application pools on IIS 6.0 for configuration changes to take effect. This optional parameter prevents this recycling.

This example sets the FastCGI process pool configuration property InstanceMaxRequests for the "PHP" section:

[!code-unknown[Main](configuring-the-fastcgi-extension-for-iis-60/samples/sample-127384-9.unknown)]
  
  
[Discuss in IIS Forums](https://forums.iis.net/1102.aspx)