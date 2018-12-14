---
title: Test and Debug Applications
TOCTitle: Test and Debug Applications
ms:assetid: 1810c277-c032-4eac-8f41-74a4623294bb
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Ee958030(v=VS.95)
ms:contentKeyID: 46359317
ms.date: 05/31/2012
mtps_version: v=VS.95
---

# Test and Debug Applications

You can test and debug a Smooth Streaming application based on Silverlight by hosting both the application and the media content in the same domain or you can add a client access specification to enable cross-domain data access with the ASP.NET Development Server. In the first scenario, IIS serves the Web application, and IIS Media Services streams the audio and video content. The second scenario is explained below in Client Access Policy.

## Setup Test Environment

Create a new Silverlight application from the template supported by the **New/Project** option in Visual Studio 2008 or Visual Studio Web Developer Edition. Add a reference to the Microsoft.Web.Media.SmoothStreaming.dll that is found in the installation folder with the Smooth Streaming Client (The [Silverlight Applications](silverlight-applications.md) topic provides a basic example).

To test a Smooth Streaming player application on a common domain, add the multiple-bitrate media files and the manifest files to the default Web site on IIS. After you have built the project, copy the Silverlight .xap file and the TestPage.html file that hosts the application to the default Web site with the media files. This way the Silverlight application will run on the same domain and the same port as the Smooth Streaming media. You can test the application from any Silverlight-enabled browser.

If you build and run this application from the Visual Studio development environment, the ASP.NET Development Server will host and run the Silverlight application, but a cross-domain exception will occur because the multiple-bitrate media files and manifest are hosted on a separate domain by IIS. You can work around this issue by creating a client-access specification, but be sure to investigate the security risks if you use cross-domain access in production. For more information, see [HTTP Communication and Security with Silverlight](http://go.microsoft.com/fwlink/?linkid=181829) and the following information.

## Domain Requirements

For security reasons, Silverlight restricts data access to sources that run on the same domain, protocol, and port as the Silverlight application. A Silverlight application cannot access Smooth Streaming media data from a separate domain unless client access policy overrides the default setting and explicitly allows cross-domain access. This restriction is implemented at the level of the Silverlight runtime. A ClientAccessPolicy.xml file in the root folder of the IIS Web site that hosts Smooth Streaming data can allow cross-domain access. Without the ClientAccessPolicy.xml file, a Silverlight application that attempts to access Smooth Streaming data on a separate domain will throw a [SecurityException](http://go.microsoft.com/fwlink/?linkid=181847).

### Client Access Policy

Applications can implement cross-domain access to Smooth Streaming media data. For example, you can debug a Silverlight application, running on the ASP.NET Development Server, that gets Smooth Streaming media data from another domain or port. To debug this way, the following specification must be in a file named ClientAccessPolicy.xml in the root folder of the IIS Web site that hosts Smooth Streaming data.

    <?xml version="1.0" encoding="utf-8"?>
    <access-policy>
        <cross-domain-access>
            <policy>
                <allow-from http-request-headers="*">
                    <domain uri="*"/>
                </allow-from>
                <grant-to>
                    <resource path="/" include-subpaths="true"/>
                </grant-to>
            </policy>
        </cross-domain-access>
    </access-policy>

## Attach to Process and Debug

The **Attach to Process** option on the **Debug** menu in Visual Studio 2008 supports debugging Silverlight applications. (Visual Studio Web Developer edition does not support the **Attach to Process** option.) When a Silverlight application is running on the localhost, you can attach the debugger to the application process or processes and step through code, set breakpoints, and examine the content of variables while the code is running.

To debug a Silverlight application that is running Smooth Streaming content, start the application by opening your Silverlight-enabled Internet browser and entering the URL of the application TestPage.html. From the **Debug** menu in Visual Studio select **Attach to Process**. When the **Attach to Process** dialog box opens, locate the running application processes from the **Title** and **Type** columns in the list of running processes. Usually the name of the application will show in the **Title** column, and another Silverlight process will show in the **Type** column. Select these processes and click **Attach**.

If the breakpoints you have set in the application code are disabled when you close the **Attach to Process** dialog box, repeat the procedures until you find and attach the necessary processes.

You will be able to step through code sequences, run to breakpoints, and examine the content of variables to analyze the running application.

For more information, see [How to: Attach to a Running Process](http://go.microsoft.com/fwlink/?linkid=181849).

## See Also

#### Concepts

[Silverlight Applications](silverlight-applications.md)

