---
title: "Develop on IIS 7 | Microsoft Docs"
author: rick-anderson
description: "The following articles provide information about developing on Internet Information Services 7 (IIS 7) and above. Use Development Tools Microsoft® Visual Stu..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 11/15/2009
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/application-frameworks/running-php-applications-on-iis/develop-on-iis-7-and-above
msc.type: authoredcontent
---
Develop on IIS 7
====================
by Tali Smith

The following articles provide information about developing on Internet Information Services 7 (IIS 7) and above.

## Use Development Tools

Microsoft® Visual Studio® provides several options for working with IIS when developing Web sites and Web applications. In Microsoft® Visual Studio® 2008, the Web site and Web application features support IIS in Windows® 7, Windows Vista®, and Windows Server® 2008 operating system environments. In addition, the Web Deployment Project 2008 also provides support for IIS.

The following topics address development tools;

- [Visual Studio 2008 with IIS 7 and Above](../../develop/using-visual-studio-with-iis/using-visual-studio-2008-with-iis.md).
- [Microsoft® Visual Studio® 2005 with IIS 7 and Above](../../develop/using-visual-studio-with-iis/using-visual-studio-2005-with-iis.md).
- [Using Visual Studio 2008 with IIS 7.0 and Above](../../develop/using-visual-studio-with-iis/using-visual-studio-2008-with-iis.md).
- [Using Visual Studio 2005 with IIS 7.0 and Above](../../develop/using-visual-studio-with-iis/using-visual-studio-2005-with-iis.md).

## Extend IIS 7 and Above

IIS is built with a completely modular architecture on top of rich extensibility APIs. This enables developers to easily add, remove, and even replace built-in IIS components with hand-crafted ones that are specifically suited for any given Web site. It has never been so easy to plug code deep into the IIS core pipeline and extend IIS in ways that were impossible before.

For example, a few lines of code allow developers to write modules or handlers that provide new authentication and authorization schemes, do run-time or security analysis of incoming requests, and inspect responses. But to provide a real value-add, these modules must be manageable via programming interfaces, command-line tools, and a user interface.

### Runtime Extensibility

- [An End-to-End Extensibility Example for IIS 7.0 and Above Developers](../../develop/runtime-extensibility/an-end-to-end-extensibility-example-for-iis-developers.md).
- [Developing IIS 7.0 and Above Modules and Handlers with the .NET Framework](../../develop/runtime-extensibility/developing-iis-modules-and-handlers-with-the-net-framework.md).
- [Sample: Web Analytics Tracking Module](../../develop/runtime-extensibility/sample-web-analytics-tracking-module.md).
- [Extending Web Server Functionality in .NET.](../../develop/runtime-extensibility/extending-web-server-functionality-in-net.md)
- [Develop a Native C\C++ Module for IIS 7.0 and Above](../../develop/runtime-extensibility/develop-a-native-cc-module-for-iis.md).
- [Developing a Module Using .NET](../../develop/runtime-extensibility/developing-a-module-using-net.md).
- [How to Add Tracing to IIS 7.0 and Above Managed Modules](../../develop/runtime-extensibility/how-to-add-tracing-to-iis-managed-modules.md).
- [Sample: Image Watermark Module](../../develop/runtime-extensibility/sample-image-watermark-module.md).

### Extend the Management UI

- [Overview of MWA and MWM for IIS 7.0 and Above](../../develop/extending-the-management-ui/overview-of-mwa-and-mwm-for-iis.md).
- [How to Create a Simple IIS Manager Module](../../develop/extending-the-management-ui/how-to-create-a-simple-iis-manager-module.md).
- [How to Get Started Extending Module Properties for IIS 7.0 and Above in IIS Manager](../../develop/extending-the-management-ui/how-to-get-started-extending-module-properties-for-iis-in-iis-manager.md).
- [Understanding UI Extension Authoring](../../develop/extending-the-management-ui/understanding-ui-extension-authoring.md)

### Extend the Configuration

- [Configuration Extensibility](../../develop/extending-iis-configuration/configuration-extensibility.md).
- [Extending IIS Configuration](../../develop/extending-iis-configuration/extending-iis-configuration.md).
- [Extending IIS 7.0 and Above Schema and Accessing the Custom Sections Using MWA](../../develop/extending-iis-configuration/extending-iis-schema-and-accessing-the-custom-sections-using-mwa.md).

### Develop for FTP 7.5

Microsoft has created a new File Transfer Protocol (FTP) service that has been completely rewritten for Windows Server® 2008. This new FTP service incorporates many new features that enable Web authors to publish content better than before, and offers Web administrators more security and deployment options.

The new FTP 7.5 service supports extensibility that allows you to extend the built-in functionality that ships with the FTP service. More specifically, FTP 7.5 supports creating your own authentication and authorization providers. You can also create providers for custom FTP logging and for determining the home directory information for your FTP users.

For managed code (C#), see:

- [How to Use Managed Code (C#) to Create a Simple FTP Authentication Provider](../../develop/developing-for-ftp/how-to-use-managed-code-c-to-create-a-simple-ftp-authentication-provider.md).
- [How to Use Managed Code (C#) to Create a Simple FTP Home Directory Provider](../../develop/developing-for-ftp/how-to-use-managed-code-c-to-create-a-simple-ftp-home-directory-provider.md).
- [How to Use Managed Code (C#) to Create a Simple FTP Logging Provider](../../develop/developing-for-ftp/how-to-use-managed-code-c-to-create-a-simple-ftp-logging-provider.md).
- [How to Use Managed Code (C#) to Create an FTP Authentication Provider using an XML Database](../../develop/developing-for-ftp/how-to-use-managed-code-c-to-create-an-ftp-authentication-provider-using-an-xml-database.md).
- [How to Use Managed Code (C#) to Create an FTP Provider that Sends an Email when Files are Uploaded](../../develop/developing-for-ftp/how-to-use-managed-code-c-to-create-an-ftp-provider-that-sends-an-email-when-files-are-uploaded.md).
- [How to Use Managed Code (C#) to Create an FTP Authentication Provider with Dynamic IP Restrictions](../../develop/developing-for-ftp/how-to-use-managed-code-c-to-create-an-ftp-authentication-provider-with-dynamic-ip-restrictions.md).

For native code (C++), see:

- [How to Use Native Code (C++) to Create a Simple FTP Authentication Provider](../../develop/developing-for-ftp/how-to-use-native-code-c-to-create-a-simple-ftp-authentication-provider.md).
- [How to Use Native Code (C++) to Create a Simple FTP Home Directory Provider](../../develop/developing-for-ftp/how-to-use-native-code-c-to-create-a-simple-ftp-home-directory-provider.md).
- [How to Use Native Code (C++) to Create a Simple FTP Logging Provider](../../develop/developing-for-ftp/how-to-use-native-code-c-to-create-a-simple-ftp-logging-provider.md).

For managed code (Microsoft® Visual Basic®), see:

- [How to Use Managed Code (Visual Basic) to Create a Simple FTP Home Directory Provider](../../develop/developing-for-ftp/how-to-use-managed-code-visual-basic-to-create-a-simple-ftp-home-directory-provider.md).
- [How to Use Managed Code (Visual Basic) to Create a Simple FTP Logging Provider.](../../develop/developing-for-ftp/how-to-use-managed-code-visual-basic-to-create-a-simple-ftp-logging-provider.md)
  
  
[Discuss in IIS Forums](https://forums.iis.net/1030.aspx)