---
title: "Use the Web Deployment Tool"
author: rick-anderson
description: "The Microsoft® Web Deployment Tool simplifies the migration, management, and deployment of Internet Information Services (IIS) Web servers, Web applications,..."
ms.date: 11/15/2009
ms.assetid: e0ca89f0-33b5-4266-ae35-cb2f9a0f83df
msc.legacyurl: /learn/publish/using-web-deploy/use-the-web-deployment-tool
msc.type: authoredcontent
---
# Use the Web Deployment Tool

by Tali Smith

## Introduction

The Microsoft® Web Deployment Tool simplifies the migration, management, and deployment of Internet Information Services (IIS) Web servers, Web applications, and Web sites. Administrators can use command-line scripting with the Web Deployment Tool to synchronize IIS 6.0 and IIS 7 and above servers or to migrate an IIS 6.0 server to IIS 7 or above. The Web Deployment Tool also makes it possible for administrators and delegated users to use IIS Manager to deploy Microsoft® ASP.NET and PHP applications to an IIS 7 and above servers.

With the Web Deployment Tool, you can:

- **Migrate Web applications between IIS 6.0 and IIS 7 and above** - Simplify the planning of your IIS 6.0 to IIS 7 and above migrations by determining incompatibilities and previewing the proposed changes before starting the process. Learning about any potential issues in advance gives you the chance to take corrective measures and simplifies migration.
- **Synchronize your server farm** - The Web Deployment Tool makes it possible for you to efficiently synchronize sites, applications, or servers across your IIS server farm by detecting differences between the source and destination content and transferring only those changes which need synchronization. The tool simplifies the synchronization process by automatically determining the configuration, content, and certificates to be synchronized for a specific site. In addition to the default behavior, you still have the option to specify additional providers for the synchronization, including databases, Component Object Model (COM) objects, Global Assembly Cache (GAC) assemblies, and registry settings.
- **Package, archive, and deploy Web applications** - You can use the Web Deployment Tool to package configuration and content of your installed Web applications, including databases, and use the packages for storage or redeployment. These packages can be deployed using IIS Manager without requiring administrative privileges. The tool integrates with Microsoft® Visual Studio® 2010 to help developers streamline the deployment of Web applications to the Web server. The tool also integrates with the Microsoft® Web Platform Installer (Web PI) so you can simply and easily install community Web applications. You can submit your own application to the Web Application Gallery.

## Download and Install the Web Deployment Tool

The Web Deployment Tool is a managed code framework that includes the public application programming interfaces (APIs) and underlying engine. (This is the top-level node and cannot be removed.)

- **IIS Manager UI Module** – UI module makes it possible for users to perform a subset of deployment tasks, mainly packaging or deploying a Web site or app. This module requires the installation of IIS 7 or above, or IIS Remote Manager.
- **Remote Agent Service** – An administrator-only service based on HTTP/HTTPS that allows server administrators to connect and perform remote operations.
- **IIS Deployment Handler** – A handler that integrates with Web Management Service (WMSvc) and allows non-administrators or administrators to perform remote operations. This handler requires the installation of IIS with WMSvc.

### Choose Installation Options

Before you install the Web Deployment Tool, decide whether you want to use the remote service to perform live operations between two servers or if you prefer to use the offline mode.

- The remote service is not started by default and is set to Manual startup. It is only required to have it running during an operation, and it can be stopped when not in use.
- Offline mode is simply installation of the tool without the service. It requires you to create a local copy of a site or server and then manually copy this "snapshot" or archive to the destination.

Note that you only need the remote service installed on either the source or the destination. For example, to "push" all content from a server to a client, you can install the remote service on all client computers so that the content can be pushed from the source. Alternatively, you could have each client "pull" from the server and only install the remote service on the source.

#### To install the tool using the default remote service URL

1. Download the [Web Deployment Tool](https://www.iis.net/downloads/microsoft/web-deploy).
2. Run the Windows®Installer file to install the tool.
3. Select a Custom installation.
4. Click on the remote service node to install the remote service.
5. Complete the installation.
6. Manually start the service by running the following command:  

    [!code-console[Main](use-the-web-deployment-tool/samples/sample1.cmd)]
7. Ensure that port 80 is open in the firewall.

#### To install the tool with a custom remote service URL

1. Download the [Web Deployment Tool](https://www.iis.net/downloads/microsoft/web-deploy).
2. Open an administrative command prompt on Windows Server® 2008, or a command prompt on Windows Server® 2003.
3. Go to the directory where the setup file is located.
4. Run the following command (customize the port and URL specifications):  

    [!code-console[Main](use-the-web-deployment-tool/samples/sample2.cmd)]
5. Manually start the service by running the following command:  

    [!code-console[Main](use-the-web-deployment-tool/samples/sample3.cmd)]
6. Ensure that the port you have chosen is open in the firewall.

The tool will be installed to %programfiles%\IIS\Microsoft Web Deploy. This cannot be changed.

#### Starting the remote service after installation

The remote service listens on `http://+/msdeployagentservice/` by default or at the URL that you specified if you performed a custom installation.

You should now start the remote service. You can do this by going to **Start** &gt; **Run**, and then typing **services.msc**. The service is listed as the Microsoft Web Deployment Agent Service.

The service startup is Manual by default; you can set the startup to Automatic in Services.msc. You can also use the command-line tool Sc.exe, to set the startup to Automatic.

A [Knowledge Base article](https://support.microsoft.com/kb/251192) provides more information about Sc.exe.

## Use the Web Deployment Tool for Web Farms

The Web Deployment Tool can be used to deploy new applications to a Web farm or to keep changes synchronized between the Web farm servers. The Web Deployment Tool does not currently support a central UI or configuration store for a list of servers in a farm (for example, syncing multiple machines at once), but you can simply store this list of servers and perform synchronization operations against each server. These synchronization operations can easily be scheduled using Microsoft® System Center or another scheduling mechanism. Resources that can be synchronized include Web sites or applications, content folders and files, databases, registry keys, and assemblies in the GAC, among others. You can also build custom "providers" that understand other types of resources that are not supported. For more information, see [Using the Web Deployment Tool for Web Farms](using-web-deploy-for-web-farms.md).

## Package and Deploy Applications with the Web Deployment Tool

For information about packaging and deploying applications with the Web Deployment Tool, see the following articles.

- [Export a Package through IIS Manager](export-a-package-through-iis-manager.md).
- [Import a Package through IIS Manager](import-a-package-through-iis-manager.md).
- [Configure the Web Deployment Handler](configure-the-web-deployment-handler.md).

## Migrate from IIS 6.0 to IIS 7 or Above

You can use the Web deployment Tool to migrate:

- From 1 or 1,000 Web sites from IIS 6.0 to IIS 7 or above, including all configuration settings, content, and certificates.
- A single application.
- An entire server (including all Web sites and application pools) from IIS 6.0 to IIS 7 or above.
- A custom manifest comprised of sites, application pools, assemblies, COM objects, registry keys, and content from IIS 6.0 to IIS 7 or above.

For instructions, see [Migrate from IIS 6.0 to IIS 7 and Above](migrate-a-web-site-from-iis-60-to-iis-7-or-above.md).

## Synchronize Web Servers

You can use the Web Deployment Tool to synchronize a Web site from a source to a destination on IIS 6.0, or IIS 7 or above. You can do this by "pushing" data to a remote destination or by "pulling" data from a remote source. You can also use a package (compressed file) to avoid installing the remote service. For more information, see the following articles:

- [Synchronize IIS 7 and Above](synchronize-iis.md).
- [Synchronize IIS 6.0](synchronize-iis-60-web-sites.md).

## Features of the Web Deployment Tool

The following information is an extensive list of the features of the Web Deployment Tool:

- Seamless integration with IIS Manager and Visual Studio 2010 interface for creating packages and deploying them onto a machine, both locally and remotely.
- Seamless integration with the Web Platform Installer to install community Web applications simply and easily.
- Web application packaging: 

    - Can package a Web application or an entire site, including the associated databases.
    - Can package access control lists (ACLs), COM, GAC, and registry settings.
    - Supports both live servers and zipped packages as a source or destination.
- Web application deployment: 

    - Administrative privileges are not required in order to deploy Web applications.
    - Can add powerful parameters to change text in files when they are deployed (such as prompting to replace a connection string when deploying from quality assurance to staging environments).
    - Integration with the IIS Web Management Service (WMSvc) for remote deployment by non-administrators.
    - Server administrators have granular control over the operations that can be performed and can delegate tasks to non-administrators.
- Web server migration and synchronization: 

    - Can synchronize or migrate the entire Web server, a Web site, or application.
    - Synchronizes only the data that has changed.
    - Can detect missing dependencies during synchronization.
    - Automatically gathers content, IIS configuration, Secure Sockets Layer (SSL) certificates, and ASP.NET configuration when you synchronize a Web site.
- In addition to using IIS Manager and Visual Studio 10, tasks can be performed using the command-line, Windows PowerShell™ cmdlets, or public APIs.

> [!NOTE]
> *This article is based on material from: " Installing the Web Deployment Tool" by Faith Allington, published on September 1, 2009.*

## Links for Further Information

- [Overview of the Web Deployment Tool](introduction-to-web-deploy.md).
- [Videocast: Simplified Application Deployment on the Microsoft Web Platform](../deploying-application-packages/videocast-simplified-application-deployment-on-the-microsoft-web-platform.md).
- [Web Deployment Tool](https://forums.iis.net/1144.aspx).
- [Microsoft Web Deployment Team Blog](https://blogs.iis.net/msdeploy/).
