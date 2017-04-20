---
title: "ASP.NET 2.0/3.5 Shared Hosting Configuration | Microsoft Docs"
author: walterov
description: "IIS offers enhancements for dynamic content, especially ASP.NET. In IIS 7 and above, the ASP.NET runtime extensibility model is integrated into the core serv..."
ms.author: iiscontent
manager: soshir
ms.date: 10/30/2007
ms.topic: article
ms.assetid: cf9bd511-eb48-49e1-83bb-2848794cc7a4
ms.technology: iis-hosting
ms.prod: iis
msc.legacyurl: /learn/web-hosting/web-server-for-shared-hosting/aspnet-20-35-shared-hosting-configuration
msc.type: authoredcontent
---
ASP.NET 2.0/3.5 Shared Hosting Configuration
====================
by [Walter Oliver](https://github.com/walterov)

## Introduction

IIS offers enhancements for dynamic content, especially ASP.NET. In IIS 7 and above, the ASP.NET runtime extensibility model is integrated into the core server. This allows developers to fully extend IIS with the rich functionality of ASP.NET 2.0 or higher and the .NET Framework, instead of using lower-level C++ APIs. Existing ASP.NET applications will benefit from the closer integration by being able to use existing features such as forms authentication, roles, and output caching for all types of content, not just .aspx pages.

To learn more about some of the key features and benefits of ASP.NET integration with IIS, see the [Core Web Server Overview](../../get-started/introduction-to-iis/iis-web-server-overview.md). For information about and how to install the .NET Framework 3.5, see [https://www.microsoft.com/net/](https://www.microsoft.com/net/) or the [ASP.NET community site](https://www.asp.net/ "ASP.NET community site").

The following settings were used on the Web server as part of the shared hosting architecture mentioned in the "Planning The Shared Hosting Architecture" article in Hosting Guidance. To learn more about why these settings are recommended and for additional details about how to configure them, download the *[ASP.NET 4 Hosting Deployment Guide](https://go.microsoft.com/fwlink/?LinkId=191365 "ASP.NET 4 Hosting Deployment Guide")*.

<a id="_Toc180824182"></a>

## Configuring Trust Levels

Trust levels let you define security rules for ASP.NET. They define what types of operations an application can perform, such as reading from disk or accessing the registry. The recommended trust level is Medium, which allows many common operations but restricts many of the dangerous applications. If you need to permit more operations than Medium trust allows, you should create a custom trust level.

**To configure a custom trust level and configure additional permissions**

1. Navigate to the `%windir%\Microsoft.NET\Framework \{version}\ CONFIG` directory.
2. Copy the Medium trust policy file, web\_mediumtrust.config, to create a new policy file in the same directory `%windir%\Microsoft.NET\Framework\{version}\ CONFIG\`.
3. Rename the file to indicate that it is a custom trust level, for example, web\_CustomTrust.config.
4. Open the new file, web\_CustomTrust.config, and locate the **WebPermission** section.  

    ...

    [!code-xml[Main](aspnet-20-35-shared-hosting-configuration/samples/sample1.xml)]

    [!code-console[Main](aspnet-20-35-shared-hosting-configuration/samples/sample2.cmd)]

    ...
5. Edit **WebPermission** so that the **ConnectAccess** element is removed and **Unrestricted** is set to **true**.  

    ...

    [!code-xml[Main](aspnet-20-35-shared-hosting-configuration/samples/sample3.xml)]

    [!code-console[Main](aspnet-20-35-shared-hosting-configuration/samples/sample4.cmd)]

    ...
6. Comment out **PrintingPermission** and **EnvironmentPermission**, unless it is known that they are needed for the shared hosting  environment.
7. Add the new `<trustLevel>` element to the `<securityPolicy>` section of the Web.config file, as shown below:  

    [!code-xml[Main](aspnet-20-35-shared-hosting-configuration/samples/sample5.xml)]

    [!code-xml[Main](aspnet-20-35-shared-hosting-configuration/samples/sample6.xml)]
8. Lock the trust level so that it cannot be changed by applications on the server, by setting the location **allowOverride** element to **false**.  

    [!code-xml[Main](aspnet-20-35-shared-hosting-configuration/samples/sample7.xml)]

<a id="_Toc180824183"></a>

## Configuring Content to be Served from a Remote File Server

When configuring ASP.NET to work with content that is stored on a remote file server, a few additional steps are required.

When IIS receives content from a remote file server, it impersonates the authenticated user. This is either the user specifically set as the virtual directory user, or if one is not specified, the anonymous user. IIS guidance states that the application pool user should be used as the anonymous user, so in this case the impersonated identity is the application pool identity. Using one identity for all access (anonymous, application pool, and virtual directory) greatly simplifies a deployment.

To run some ASP.NET applications from a remote file server, the impersonated user must have access to the Windows temp and the temporary compilation directories.

**To serve ASP.NET content from a file server share**

1. Grant permission for all application pool identities to the `%windir%\Temp` directory by editing the ACLs for the folder.
2. Add a Code Access Security (CAS) policy to allow ASP.NET appropriate access to the file server share. To do this, open a command prompt and run the following command:  

    [!code-console[Main](aspnet-20-35-shared-hosting-configuration/samples/sample8.cmd)]

<a id="_Toc180824185"></a>

## Configuring Garbage Collector Settings

The .NET framework uses automatic garbage collection to manage memory for all applications. When the garbage collector (GC) decides that sufficient garbage has accumulated and that it is efficient to do so, it performs a collection to free some memory. This process is fully automatic, but there are settings that can make the process more efficient.

For more information about the GC, see "*Chapter 5 - Improving Managed Code Performance*" and look at the section *[Garbage Collection Explained](https://msdn.microsoft.com/en-us/library/ms998547.aspx#scalenetchapt05_topic9 "Garbage Collection Explained")*.

### Enabling the Workstation Garbage Collector

By default, the Server GC is used by the .NET Framework to optimize speed and CPU load. For shared hosting, where memory is more often the constraint for a number of active sites, the Workstation GC should be used. The Workstation GC optimizes for memory.

To learn more about this setting, see the KB article, ["](https://support.microsoft.com/kb/911716)*[You may receive an error message, or the computer stops responding, when you host Web applications that use ASP.NET on a computer that is running Windows Server 2003"](https://support.microsoft.com/kb/911716)*.

### Disabling the Concurrent Garbage Collector

There are 3 versions of the GC: Server, Workstation with concurrent enabled, and Workstation with concurrent disabled. The concurrent Workstation GC is intended for client scenarios. Just as the Server GC prioritizes throughput and scalability at a memory cost, the concurrent Workstation GC prioritizes responsiveness at a memory cost. To optimize for memory, disable concurrent garbage collection when you use the Workstation GC.

### Enabling the gcTrimCommitOnLowMemory Setting

Because the GC holds on to memory for future allocations, its committed space can be more than what is strictly needed. This space can be reduced to accommodate situations when there is a heavy load on system memory. When this setting is enabled, the GC evaluates the system memory load and enters a trimming mode when the load reaches 90%. It maintains the trimming mode until the load drops under 85%. When conditions permit, the GC can decide that the setting will not help the application and ignore it.

**To configure the GC settings**

1. Navigate to the `%windir%\Microsoft.NET\Framework\{version}` directory.
2. Open the aspnet.config file, and locate the `<gcServer>` element. If the element does not exist, create an entry using Step 3.  

    ...

    [!code-xml[Main](aspnet-20-35-shared-hosting-configuration/samples/sample9.xml)]
3. Add the following three elements within the `<runtime>` section:  

    ...

    [!code-xml[Main](aspnet-20-35-shared-hosting-configuration/samples/sample10.xml)]

    [!code-xml[Main](aspnet-20-35-shared-hosting-configuration/samples/sample11.xml)]
4. Save the file and close it.