---
title: "Provisioning IIS 7 Sites for Shared Hosting | Microsoft Docs"
author: walterov
description: "The following articles contain recommendations for provisioning sites in shared hosting environments. Configuring Logging and Diagnostics Enabling a Delegate..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 10/30/2007
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/manage/creating-websites/provisioning-iis-7-sites-for-shared-hosting
msc.type: authoredcontent
---
Provisioning IIS 7 Sites for Shared Hosting
====================
by [Walter Oliver](https://github.com/walterov)

The following articles contain recommendations for provisioning sites in shared hosting environments.

<a id="ConfigLog"></a>

## Configuring Logging and Diagnostics

### Overview

IIS 7 provides the same Web site activity or traffic logging as IIS 6.0, but includes the new Failed Request Tracing feature. Request-based tracing provides a way to determine what is happening with a request, allowing you to see each step of the request as IIS processes it.

Problems, such as poor performance or authenticated failures, or even the Server Error 500 from ASP or ASP.NET, can be difficult to troubleshoot. Failed Request Tracing buffers the trace events for a request and writes them to disk when a failure occurs. The server administrator defines a failure by using the tracing rules. The tracing rules can be as broad as all content and status codes, or as specific as a single status and sub-status code such as 404.2.

For shared hosting, it is recommend that you delegate Failed Request Tracing to site owners, enabling site owners to determine problems with their sites, which helps to prevent support calls. You can store the tracing logs in the logs\FailedRequestLogFiles folder as discussed in the topic [Configuring Share and NTFS Permissions](../../web-hosting/configuring-servers-in-the-windows-web-platform/configuring-share-and-ntfs-permissions.md) in the [Setting Up a Remote File Server for Content Storage](../../web-hosting/configuring-servers-in-the-windows-web-platform/index.md) section.

### Configuring Procedures

#### Failed Request Tracing

To configure the Failed Request Tracing log file location by using the command line, use the following:

- Open a command prompt and run the following:

[!code-unknown[Main](provisioning-iis-7-sites-for-shared-hosting/samples/sample-127143-1.unknown)]

It is also recommend that you configure all logging fields for W3SVC logging. You may need the W3SVC logging information when a problem occurs.

For more information about failed request tracing, see the Failed Request Tracing walkthrough at [https://www.iis.net/articles/view.aspx/IIS7/Managing-IIS7/Diagnostics-in-IIS7/Using-Failed-Request-Tracing/How-to-Enable-Failed-Request-Tracing-for-UNC-Hosti](../../troubleshoot/using-failed-request-tracing/how-to-enable-failed-request-tracing-for-unc-hosting.md).

#### Log File Location

To configure the W3SVC log file location by using the command line, use the following **:** 

- Open a command prompt and run the following:

[!code-unknown[Main](provisioning-iis-7-sites-for-shared-hosting/samples/sample-127143-2.unknown)]

For more information about diagnostics, see [Troubleshooting a Web Server Error.](../../troubleshoot/index.md)

<a id="Enabling"></a>

## Enabling a Delegated Administration User

IIS Manager allows those who host or administer Web sites to delegate administrative control to developers or content owners, thus reducing cost of ownership and the administrative burden for the server administrator.

### Procedure

To enable a delegated user for a Web site using IIS  Manager, use the following steps **:** 

1. Navigate to **Administrative Tools** and click **Internet Information Services (IIS) Manager**.
2. Expand the server name node.
3. Expand the Sites node.
4. Double-click the name of the site you want to enable the user on.
5. Double-click the **IIS Manager Permissions** icon.
6. In the **Actions** pane, click **Allow User...**.
7. In the **Allow User** dialog box, choose whether to use a Windows user or an IIS Manager user. In this case, select a Windows user, type the name, and then click **OK**.

For more information about delegation, go to the *Configuring Remote Administration and Feature Delegation* overview at [https://www.iis.net/articles/view.aspx/IIS7/Managing-IIS7/Delegation-in-IIS7/Delegating-permissions-in-IIS-Manager/Configuring-Remote-Administration-and-Feature-Dele?Page=4](../remote-administration/configuring-remote-administration-and-feature-delegation-in-iis-7.md)

<a id="Isolating"></a>

## Isolating Sites with Application Pools

Each application, residing in its own application pool and configured with a unique process identity, offers the highest level of isolation. Each application has its own process and if the application stops responding, it is unable to affect other sites on the server. For these reasons, we recommend this configuration for a shared hosting environment.

### IIS 7 Improvements

IIS 7 introduces a configuration isolation service that prevents application pools from having to access the applicationHost.config file. When started, IIS 7 reads the applicationHost.config file and writes a temporary file for each application pool that contains the configuration for that pool. The worker process only has access to that file, and not other pool configuration files. This feature provides both enhanced security and performance improvements.

For information on Application Pools, see [Introduction to IIS 7 Architecture](../../get-started/introduction-to-iis/introduction-to-iis-architecture.md) in the "IIS 7 Application Pools" section.

<a id="ConfigASP"></a>

## Configuring ASP.NET Temporary Compilation Directories

### Directory Code

By default, the temporary compilation directory is:

[!code-unknown[Main](provisioning-iis-7-sites-for-shared-hosting/samples/sample-127143-3.unknown)]

This directory contains all the temporary files that are generated by ASP.NET. This directory is shared between all application pools. Although not a requirement when Medium Trust is used, it is a good security practice to create a compilation directory for each application pool.

### Creating and Setting the Directory

To create and set a unique temporary compilation directory, use the following:

1. Open a command prompt and run the following command to create a folder and set permissions:

[!code-unknown[Main](provisioning-iis-7-sites-for-shared-hosting/samples/sample-127143-4.unknown)]
2. Run the following command to set the temporary compilation directory to a site:  

    [!code-console[Main](provisioning-iis-7-sites-for-shared-hosting/samples/sample5.cmd)]