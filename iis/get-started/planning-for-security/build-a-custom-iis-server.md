---
title: "Build a Custom IIS 7.0 Server"
author: leanserver
description: "IIS 6.0 and previous versions implemented most of the widely used server functionality inside the server itself. In contrast, IIS 7.0 and above web server en..."
ms.date: 11/22/2007
ms.assetid: fe44b363-6fef-4a09-b3b2-dbb0bc5c4b64
msc.legacyurl: /learn/get-started/planning-for-security/build-a-custom-iis-server
msc.type: authoredcontent
---
# Build a Custom IIS 7.0 Server

by [Mike Volodarsky](https://github.com/leanserver)

## Introduction

IIS 6.0 and previous versions implemented most of the widely used server functionality inside the server itself. In contrast, IIS 7.0 and above web server engine provides a modular architecture on top of which virtually all of the server features are provided as pluggable components. This enables tremendous improvements across the board, including:

- Ability to control exactly what set of features is loaded / used on the server, removing unneeded features to reduce the attack surface area / memory footprint of the server
- Ability to replace each feature with third party or custom implementations
- Ability to specialize the server based on its role in the server topology
- Advanced control over the feature set of the server, both on a fine grain and application-delegatable level

These server components, known as modules, are loaded during the initialization of the application pool worker process and provide request processing services on the server. Each IIS 7.0 and above application is a combination of services provided by modules enabled for the application, and associated content used by these services. The server provides two major roles played by modules:

- Providing request services, such as authentication or output caching (similar to ISAPI filters in IIS 6.0)
- Providing request handling, such as static file handling, CGI, or ASP.NET page processing (similar to ISAPI extensions in IIS 6.0)

By enabling different modules, the server can be configured to provide the services required by the applications on the server.

Tasks illustrated in this article include:

- Reviewing the server configuration, the default and the set of modules loaded on the server by default
- Removing all modules to strip the server down to its minimal configuration, and examine the effect on footprint
- Building a custom server by incrementally adding modules to support a specific scenario

<a id="Review"></a>

## Review of the Default Module Configuration

The main server configuration is contained in the applicationHost.config file, located in the IIS configuration directory `%windir%\system32\inetsrv\config\`. We look at the following configuration contained in the `<system.webServer>` section group:

`<globalModules>` section. This server-level section contains the list of modules loaded by the server worker process, and the associated native DLLs that implement their functionality.

`<modules>` section. This application-level section contains the list of modules enabled for a particular application. This section serves to select the subset of loaded modules that should be active in an application, and also to load additional application level modules.

`<handlers>` section. This URL-level section contains the handler mappings that the server uses to map incoming requests to a particular module that will process it. This is similar to the IIS 6.0 scriptmaps or ASP.NET, and serves a unified mapping of requests to both native and managed content type handlers.

The full description of all IIS modules is available in the [IIS 7.0 and Above Modules Overview.](../introduction-to-iis/iis-modules-overview.md)

### Create a Configuration Backup

First, we backup the server configuration so that we can restore it if necessary. Run the following command from a command prompt running as Administrator:

[!code-console[Main](build-a-custom-iis-server/samples/sample1.cmd)]

We can then restore the server configuration to the initial state by running:

[!code-console[Main](build-a-custom-iis-server/samples/sample2.cmd)]

### Examine the Default List of Modules

Navigate to the &lt;system.webServer&gt;/&lt;globalModules&gt; section. This section, which can only be configured on the server level, contains the modules loaded by each server worker process. Each entry configures a module with a specific name and the DLL that implements the functionality of that module:

[!code-xml[Main](build-a-custom-iis-server/samples/sample3.xml)]

Look through the names of the various modules in the default server configuration – we see familiar services provided as part of the server in IIS 6.0:

**Windows Authentication module, NTLM request authentication**

[!code-xml[Main](build-a-custom-iis-server/samples/sample4.xml)]

**Static File Handler module, serving static files**

[!code-xml[Main](build-a-custom-iis-server/samples/sample5.xml)]

**Dynamic Compression module, compression of responses**

[!code-xml[Main](build-a-custom-iis-server/samples/sample6.xml)]

Navigate to the &lt;system.webServer&gt;/&lt;modules&gt; section. This section, which can be configured at the server or application level, specifies which of the modules loaded in the &lt;globalModules&gt; section are enabled for a particular application. For the most part, we see that this section lists the names of the modules we saw in the section, enabling them by default for all applications.

> [!NOTE]
> There are a few extra items at the end of the list – these are managed modules developed using the ASP.NET extensibility model. Learn more about building managed modes in the [Develop a Module Using .NET](../../develop/runtime-extensibility/developing-a-module-using-net.md) walkthrough.

Navigate to the &lt;system.webServer&gt;/&lt;handlers&gt; section. This section, which can be configured at the server, application, or URL-level, specifies how requests are handled. Modules typically participate in each and every request, whereas handlers only get requests for a particular URL.

A good example of a module is the compression module. The compression module looks at each response and compresses it if required. The ASP.NET page handler is a good example. It receives only requests that are mapped to it, for example requests that have the extension .aspx. The `<handlers>` list defines the mappings between a request based on the URL and verb, and a handling module that will be used to process this request. There is also some extra information that is used to configure each mapping, which is not the focus in this topic.

[!code-xml[Main](build-a-custom-iis-server/samples/sample7.xml)]

<a id="Examination"></a>

## Examination of the Server Footprint

1. Open Internet Explorer, and make a request to the server by specifying the following URL and pressing Enter:  

    [!code-console[Main](build-a-custom-iis-server/samples/sample8.cmd)]

   This starts the server application pool, and serves the iisstart.htm document.
2. Start Task Manager, and go to the Processes tab. Because the IIS worker process runs under a different user account, you must check "Show processes for all users". Note the size of the w3wp.exe server worker process.  
    [![Screenshot that shows Windows Task Manager. The processes tab is selected.](build-a-custom-iis-server/_static/image2.jpg)](build-a-custom-iis-server/_static/image1.jpg)  
    *Figure 1: Task Manager showing the IIS Worker Process*
3. Now execute the following command-line:  

    [!code-console[Main](build-a-custom-iis-server/samples/sample9.cmd)]
  
   We see that more than 90 DLLs are loaded by the worker process. Most of them are located in the …\intersrv\ directory – many of these are module DLLs that we saw in the first task when looking at the &lt;globalModules&gt; section, and a few others that support the .NET framework and the server runtime itself.

<a id="Stripping"></a>

## Stripping Down the Server

In the previous task, we examined the default list of components loaded by the server, which contained over 35 modules that provided various services ranging from authentication to static file serving. Each of the components loaded in the server has an impact on the server footprint, its attack surface area, runtime performance, and of course, the enabled feature set.

Before we build our own custom server with only the functionality required in the next task, we build a fast, small, and secure web server by removing all the modules and running the empty server.

If we changed the applicationHost.config file during the previous task, we can restore it to the original state by running `%windir%\system32\inetsrv\appcmd restore backup initial` from command line.

Now to strip down the server.

1. Use a text editor to open `%windir%\system32\inetsrv\config\applicationHost.config`.
2. Navigate to the `<system.webServer>/<globalModules>` section.
3. Remove all of the entries in the collection, so that only an empty section definition remains:  

    [!code-xml[Main](build-a-custom-iis-server/samples/sample10.xml)]
4. Paste the items into a scratch notepad window for use later. Repeat the same with the &lt;system.webServer&gt;/&lt;modules&gt; section. Remove all of the entries under this section and paste them into a scratch notepad for later use. This ensures we are not enabling any modules we no longer load. Paste these cut items into a scratch notepad window for use later.
5. Repeat the same with the `<system.webServer>/<handlers>` section. Remove all of the entries under this section, to make sure we are not specifying any handler mappings with modules we disabled. Paste the items into a scratch notepad for later use. Save the applicationHost.config file to effect the changes.

### Examine the Stripped Down Server Footprint

At this point, we are ready to load our stripped down server – we will repeat the previous steps to examine the new footprint of the server.

1. Open Internet Explorer, and make a request to the server by specifying the following URL and pressing Enter:  

    [!code-console[Main](build-a-custom-iis-server/samples/sample11.cmd)]

    This should start the server application pool, and return an error to the browser because no handler is registered to serve the resource you requested.
2. Run Task Manager, and go to the Processes tab. Note the size of the w3wp.exe server worker process.
3. Execute the following command-line:  

    [!code-console[Main](build-a-custom-iis-server/samples/sample12.cmd)]

    Observe that the footprint of the server has been reduced to about 8Mb. In the server timeframe, the footprint of the empty server will be further reduced.

    Only 50 DLLs are loaded, as compared to 90 or more – this indicates that the server did not load any of the module DLLs, which directly and indirectly accounted for the DLL count difference. Not only are the services disabled on the server, but also no code for these features is even loaded in the process. After optimization, the DLL count of the empty server will be significantly lower.

In the next task, we will build the custom server with only the features we want.

<a id="Building"></a>

## Building a Custom Server

In the previous task, we stripped down the server to the minimal configuration, with only the core server engine running and no additional modules loaded. Now, we build the custom server to be used as web file server on a corporate network. To do this, we enable the server to provide only the following services:

- Serve static files
- Serve directory listings
- Protect the content with basic authentication and URL-based authorization rules

### Enable the Server to Serve Static Files

To perform this task, it is assumed that we have followed the previous task and stripped down the server by removing all of the modules it was running. In this state, the server always returns empty 401 error responses to all requests, as no modules are loaded to provide any kind of request processing at all.

1. Use a text editor to open `%windir%\system32\inetsrv\config\applicationHost.config`.
2. Navigate to the &lt;system.webServer&gt;/&lt;globalModules&gt; section. Add the 2 lines in bold below inside the collection – copy it from the scratch pad used earlier to save the default collection items. This loads the static file handler module, which is responsible for serving requests for static files, and the anonymous authentication module, which produces a default authentication token for the request:  

    [!code-xml[Main](build-a-custom-iis-server/samples/sample13.xml)]
3. Navigate to the &lt;system.webServer&gt;/&lt;modules&gt; section. Enable the static file handler and anonymous authentication modes by adding the line in bold below:  

    [!code-xml[Main](build-a-custom-iis-server/samples/sample14.xml)]
4. Navigate to the &lt;system.webServer&gt;/&lt;handlers&gt; section. Map the static file handler to all file requests by adding the line in bold below:  

    [!code-xml[Main](build-a-custom-iis-server/samples/sample15.xml)]
5. Save the applicationHost.config file.
6. Open Internet Explorer, and make a request to the following URL:  

    [!code-console[Main](build-a-custom-iis-server/samples/sample16.cmd)]

    This serves the requested document. We have successfully enabled the static file serving capability on the server.
7. Next, request the directory listing by making a request to the following URL:  

    [!code-console[Main](build-a-custom-iis-server/samples/sample17.cmd)]

    We get an empty response because no handler is currently loaded, enabled, and mapped to process directory listings--an empty response is sent (200 OK). In the next task, we will add the handler.

### Enable the Server to Provide Directory Listings

To perform this task, it is assumed that we have performed the previous tasks, stripped the server down to nothing, and added the file serving capability.

1. Use a text editor to open `%windir%\system32\inetsrv\config\applicationHost.config`.
2. As before, add the configuration below to enable the directory browsing module, and map it to serve directory requests (the cumulative configuration will look exactly as specified below after this step, building on top of the previous step):  

    [!code-xml[Main](build-a-custom-iis-server/samples/sample18.xml)]

    At this point, we have enabled the directory listing feature on the server. However, the feature exposes additional configuration for security reasons that controls whether or not directory listing is allowed. This configuration is specified in the &lt;system.webServer&gt;/&lt;directoryBrowse&gt; section.
3. Change the entry to &lt;directoryBrowse enabled="true" /&gt;
4. Save the applicationHost.config file.
5. Open Internet Explorer, and repeat the request to the directory by requesting the following URL: 

[!code-console[Main](build-a-custom-iis-server/samples/sample19.cmd)]

This serves the listing of the requested directory. We have successfully enabled the directory listing capability on the server.

Next, we add the authentication and authorization services to protect the content on the server from unauthorized access.

### Protecting Resources with URL Authorization

To perform this task, it is assumed that we have followed the previous tasks, stripped the server down to nothing, and added the file serving and directory listing capability.

1. Use a text editor to open `%windir%\system32\inetsrv\config\applicationHost.config`.
2. This time, we add two modules:  

    - The basic authentication module, which supports the basic authentication scheme over http1.1 against the server Windows credentials
    - The URL authorization module, which supports user and role rule based access control
3. To add these modules, add the module load entries to the &lt;system.webServer&gt;/&lt;globalModules&gt; section, and then enable the modules in the &lt;system.webServer&gt;/&lt;modules&gt; section, as we did earlier for the static file handler and directory browser.  

    > [!NOTE]
    > This time we do not need to add anything to the &lt;system.webServer&gt;/&lt;handlers&gt; section, because these modules do not provide request handling – they only provide request services to all requests. Your final configuration after adding the below items in bold will look like this:

    [!code-xml[Main](build-a-custom-iis-server/samples/sample20.xml)]

    In order to use the added features, we need to configure them.
4. Enable the Basic Authentication service. Navigate to the &lt;basicAuthentication&gt; element, and set the enabled attribute to true:  

    [!code-xml[Main](build-a-custom-iis-server/samples/sample21.xml)]
5. Disable anonymous authentication. Navigate to the &lt;anonymousAuthentication&gt; element, and set the enabled attribute to false:  

    [!code-xml[Main](build-a-custom-iis-server/samples/sample22.xml)]

    This disables anonymous authentication, and requires the basic authentication module to successfully authenticate the user before access will be granted.
6. Save the applicationHost.config file.
7. Open Internet Explorer, and repeat the request to the directory by requesting the following URL:  

    [!code-console[Main](build-a-custom-iis-server/samples/sample23.cmd)]

    This requests a directory listing. Because the browser has not authenticated us, the URL authorization module rejects the request. The basic authentication module intercepts the rejection, and triggers a basic authentication challenge back to the browser, causing the browser to display the basic authentication login dialog.
8. Log in with invalid credentials. The request is rejected, with a request prompting for credentials again.
9. Log in with the Administrator account that you used to log into the machine. The directory listing displays, indicating that you have successfully added authentication and authorization capabilities to the server.

<a id="Summary"></a>

## Summary

This article covered the componentized nature of the server, examined the IIS features that are provided, and explained how to build a custom web server with only the services a user may require.

Before using the server again, undo the changes to the server configuration performed as part of this walkthrough. If you created a backup earlier, restore it by running `%windir%\system32\inetsrv\appcmd restore backup initial` from command line.

## Related Links

See the following links for further information:

- To learn more about the IIS Core Architecture, see [IIS 7.0 and Above Core Web Server section](../../manage/working-with-server-core/iis-70-on-server-core.md) on IIS.NET.
- To learn more about IIS modules, see IIS [7.0 and Above Modules Overview.](../introduction-to-iis/iis-modules-overview.md)
- To learn more about building modules to extend or replace IIS functionality, see [Develop a Module Using .NET](../../develop/runtime-extensibility/developing-a-module-using-net.md) and [Develop a Native (C/C++) Module](../../develop/runtime-extensibility/develop-a-native-cc-module-for-iis.md).
