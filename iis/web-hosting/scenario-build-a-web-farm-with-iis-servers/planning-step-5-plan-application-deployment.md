---
title: "Planning Step 5: Plan Application Deployment"
author: rmcmurray
description: "When your web farm is up and working, you will want to update your website or add new websites to your server. File Transfer Protocol (FTP) has existed since..."
ms.date: 04/14/2013
ms.assetid: 636c5de3-1510-41ba-af0a-a5de9a86ba89
msc.legacyurl: /learn/web-hosting/scenario-build-a-web-farm-with-iis-servers/planning-step-5-plan-application-deployment
msc.type: authoredcontent
---
# Planning Step 5: Plan Application Deployment

by [Keith Newman and Robert McMurray](https://github.com/rmcmurray)

When your web farm is up and working, you will want to update your website or add new websites to your server. File Transfer Protocol (FTP) has existed since the early days of the internet for this purpose. Microsoft's Web Deployment Tool (Web Deploy) simplifies deployment of the complex web applications of today.

In this step of building a web farm, you plan the installation and configuration of FTP and Web Deploy for you web farm.

When you are done with these tasks, record your design decisions before going on to [Step 1: Install IIS Web Farm Infrastructure](configuring-step-1-install-iis-web-farm-infrastructure.md).

<a id="51"></a>
## 5.1. Deploy Websites with FTP

File Transfer Protocol (FTP) simple is a protocol for transferring files between computer systems. IIS 8 includes an FTP server that is easy to configure. For the web farm in this scenario, install FTP on the load balancing computer (ARR server) and configure it to point to the back-end shared content. For more information about FTP configuration, see [Build an FTP Site on IIS](../../publish/using-the-ftp-service/scenario-build-an-ftp-site-on-iis.md).

<a id="52"></a>
## 5.2. Deploy Web Applications with Web Deploy

The Web Deployment Tool (Web Deploy) enables IIS to synchronize, package, and deploy web applications, websites, or web server content and configuration. It has numerous features that let you include those components that you want to process and exclude those components that you do not. For you to be able to use Web Deploy, first install IIS on the source and destination computers.

The easiest way to install Web Deploy is by using the Web Platform Installer. You can install Web Deploy by running the Web Deploy Windows® Installer or from the command line by using Msiexec.exe. The Web Platform Installer requires fewer steps, while the other methods allow you to customize your installation. In all cases, log on as an administrator.

For more information about Web Deploy, see [Web Deployment Tool Overview](https://technet.microsoft.com/library/dd569058(v=ws.10)) and [Introduction to Web Deploy](https://www.iis.net/learn/publish/using-web-deploy/introduction-to-web-deploy).

## See Also

- [Step 1: Install IIS Web Farm Infrastructure](configuring-step-1-install-iis-web-farm-infrastructure.md)
- [Step 4: Plan SSL Central Certificate Store](planning-step-4-plan-ssl-central-certificate-store.md)
- [Configure a Web Farm with IIS Servers](configure-a-web-farm-with-iis-servers.md)
- [Plan a Web Farm with IIS Servers](plan-a-web-farm-with-iis-servers.md)
- [Build a Web Farm with IIS Servers](overview-build-a-web-farm-with-iis-servers.md)
- [Hosting-Friendly Web Server Platform (IIS): Scenario Overview](../../get-started/introduction-to-iis/hosting-friendly-web-server-platform-iis-scenario-overview.md)
