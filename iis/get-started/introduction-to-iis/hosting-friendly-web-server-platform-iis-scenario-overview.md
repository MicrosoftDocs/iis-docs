---
title: "Hosting-Friendly Web Server Platform (IIS): Scenario Overview"
author: rmcmurray
description: "The IIS web server provides a secure, easy-to-manage, modular and extensible platform for reliably hosting websites, services, and applications. The web serv..."
ms.date: 04/14/2013
ms.assetid: 28268375-52de-4f43-bc11-fc878880fc38
msc.legacyurl: /learn/get-started/introduction-to-iis/hosting-friendly-web-server-platform-iis-scenario-overview
msc.type: authoredcontent
---
# Hosting-Friendly Web Server Platform (IIS): Scenario Overview

by IIS Team, [Keith Newman and Robert McMurray](https://github.com/rmcmurray)

by IIS Team, Keith Newman and [Robert McMurray](https://github.com/rmcmurray)

## Compatibility

| Version | Notes |
| --- | --- |
| IIS 7.0 and later | The features described in this article were introduced in IIS 7.0. |
| IIS 6.0 and earlier | The features described in this article were not supported prior to IIS 7.0. |

## Scenario Description

The IIS web server provides a secure, easy-to-manage, modular and extensible platform for reliably hosting websites, services, and applications. The web server scenarios provide end-to-end instructions on how to plan, install, and configure IIS to host various types of services and applications.

Each scenario is self-contained. You can read them in any order and concentrate on those scenarios that most closely meet your needs.

## Web Server Scenarios

| Scenario | Description |
| --- | --- |
| [Build a Static Website on IIS](../../manage/creating-websites/scenario-build-a-static-website-on-iis.md) | Shows how to install IIS with the minimum module configuration to server static websites. Describes how to add a website, configure anonymous authentication, set up a default document, set up static content compression, use IIS logging, and filter requests. |
| [Build a Classic ASP Website on IIS](../../application-frameworks/running-classic-asp-applications-on-iis-7-and-iis-8/scenario-build-a-classic-asp-website-on-iis.md) | Shows how to install IIS with the modules required to server classic ASP websites. Explains how to add a websites and edit ASP application settings. |
| [Build an ASP.NET Website on IIS](../../application-frameworks/scenario-build-an-aspnet-website-on-iis/overview-build-an-asp-net-website-on-iis.md) | Guides you through planning, installing, and configuring an ASP.NET website on IIS. Describes what IIS modules to install. Shows how to configure ASP.NET settings, such as session state, pages and controls, application settings, .NET compilation and globalization settings. Explains how to configure data source settings. And shows how to improve security with application isolation, .NET trust levels, .NET authentication, machine key settings, and SSL communication. |
| [Build a PHP Website on IIS](../../application-frameworks/scenario-build-a-php-website-on-iis/overview-build-a-php-website-on-iis.md) | Guides you through planning, installing, and configuring a PHP website on IIS. Describes what IIS modules to install. Describes how to configure essential PHP settings. Explains how to configure WinCache and other PHP extensions. Describes how to improve security of a PHP application on IIS. |
| [Build an FTP Site on IIS](../../publish/using-the-ftp-service/scenario-build-an-ftp-site-on-iis.md) | Shows how to install FTP on an existing IIS web server. Describes how to add an FTP site, configure FTP site defaults, fire wall support, user isolation, and directory browsing options. Shows how to configure logon attempt restrictions, request filtering, FTP logging, and FTP messages. |
| [Build a Web Farm with IIS Servers](../../web-hosting/scenario-build-a-web-farm-with-iis-servers/overview-build-a-web-farm-with-iis-servers.md) | Guides you through planning, installing, and configuring a simple server farm with IIS servers. Helps you plan and configure the farm infrastructure. Shows how set up load balancing by using Application Request Routing (ARR). Describes how to set up shared content and shared configuration. Shows how to set up a central certificate store for SSL certificates. Explains how to set up FTP and Web Deploy on the server farm. |

## Practical Applications

Whether you are an IT professional, a web developer, or you want to set up your own web server, this scenario can help you install IIS and configure it to serve your web application.

## See Also

The following table contains links to resources related to IIS 8.

|       Content Type       |                                                                                                                                                        References                                                                                                                                                        |
|--------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|      **Deployment**      |                                      [Deployment to a Hosting Provider](https://www.asp.net/web-forms/tutorials/deployment-to-a-hosting-provider/deployment-to-a-hosting-provider-introduction-1-of-12) &#124; [Web Deploy 2.0](https://www.iis.net/downloads/microsoft/web-deploy)                                      |
|      **Operations**      |                                  [IIS.NET](https://www.iis.net/) &#124; [IIS Learning Center](https://www.iis.net/learn) &#124; [IIS Media Services](https://www.iis.net/media) &#124; [What's New in IIS 8.0 for Windows 8?](https://www.iis.net/learn/get-started/whats-new-in-iis-8)                                  |
|   **Troubleshooting**    |                                                                                                                              [IIS Troubleshooters](https://www.iis.net/learn/troubleshoot)                                                                                                                               |
|       **Security**       |                                                                                                                 [Secure Windows Server 2012](https://technet.microsoft.com/library/hh831360.aspx)                                                                                                                  |
|  **Tools and Settings**  |                                                                                                [Web Server (IIS) Administration Cmdlets in Windows PowerShell](https://technet.microsoft.com/library/hh867899.aspx)                                                                                                |
| **Community Resources**  | [IIS Blogs](https://blogs.iis.net/) &#124; [IIS Forums](https://forums.iis.net/) &#124; [Robert McMurray's Blog](https://blogs.msdn.com/b/robert_mcmurray/) &#124; [Scott Forsyth's Blog](https://blogs.iis.net/owscott/default.aspx) &#124; [Steve Schofield's Blog](https://blogs.iis.net/steveschofield/default.aspx) |
| **Related Technologies** |                                                                                                     [ASP.NET](https://www.asp.net/) &#124; [ASP.NET Web Projects](https://msdn.microsoft.com/library/ywdtth2f.aspx)                                                                                                      |
