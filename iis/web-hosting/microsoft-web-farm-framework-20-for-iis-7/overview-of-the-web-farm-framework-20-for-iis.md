---
title: "Overview of the Web Farm Framework 2.0 for IIS 7 | Microsoft Docs"
author: rick-anderson
description: "In the past, setting up web farm servers, deploying content to them, and then managing them has been a tedious and error-prone process. It has required many..."
ms.author: iiscontent
manager: soshir
ms.date: 07/21/2010
ms.topic: article
ms.assetid: b87030cf-5086-476c-9320-454459d036af
ms.technology: iis-hosting
ms.prod: iis
msc.legacyurl: /learn/web-hosting/microsoft-web-farm-framework-20-for-iis-7/overview-of-the-web-farm-framework-20-for-iis
msc.type: authoredcontent
---
Overview of the Web Farm Framework 2.0 for IIS 7
====================
by Randall DuBois

In the past, setting up web farm servers, deploying content to them, and then managing them has been a tedious and error-prone process. It has required many manual and repetitive steps and ongoing tracking of the platform components, along with writing and using a combination of scripts and code.

The Microsoft Web Farm Framework (WFF) 2.0 for IIS 7 and above simplifies the provisioning, scaling, and management of multiple servers for administrators and hosting providers. Administrators can seamlessly provision multiple servers, deploy content to them, and use them to enable elastic scale. Using WFF, you can also run operations on a server or an entire server farm through a unified interface that provides up-to-date status of server farm provisioning and health. You can also reduce management costs, leverage web infrastructure in an efficient manner, and simplify ongoing server farm management.

## Seamless Provisioning and Deployment

The Web Farm Framework 2.0 is designed to enable you to create group of servers and set up provisioning for them with a one-step process that is automated and keeps the server farm up to date. You can customize the components that are provisioned and include additional platform components. You can configure provisioning policy and add additional content to the farm. In addition, you can use WFF to view up-to-date status of provisioning and of the health of the servers in the farm.

## Elastic Scaling and Load Balancing

The Web Farm Framework 2.0 integrates with Application Request Routing (ARR) for load balancing and elastic scale through the same one-step process. WFF works with third-party load-balancing products and enhances the ability to upgrade, swap, and add servers by simplifying the underlying logistics. It also provides a snapshot of server readiness so that you can easily view servers that are available for load balancing.

## Simplified Server and Farm Management

The Web Farm Framework 2.0 provides one view and user interface to see the status of operations running throughout the server farm. You can also use the interface to run the most frequently used operations on the farm as a whole or on individual server in the farm. Additionally, you can interact programmatically with WFF functionality by using Web Farm Framework APIs and Windows PowerShell cmdlets.

## Web Farm Framework Features

The main features of the Web Farm Framework 2.0 include:

- One-step provisioning of servers added to a farm.
- Platform provisioning using Web Platform Installer.
- Application provisioning using Microsoft Web Deploy.
- Policy-based provisioning.
- Installation of additional platform components and content.
- Reduced down time with load-balancing integration using ARR.
- Up-to-date status and trace logs of servers in the farm.
- An extensible model that lets you write additional providers.
- Workflow Builder can be used to define and schedule custom tasks that can be run on all servers in the web farm. - Windows Credential Store support that enables you to securely store administrator credentials used for server provisioning. - Third party load balancers support. - Improved support for advanced Web Deploy operations. - Improved support for syncing large amount of files.

## Key Terms and Concepts

The following key terms and concepts are used in the Web Farm Framework articles:

**Server farm** Also called a web farm. A collection of servers grouped together for simplified management, provisioning, and deployment.

**Controller server** The server that manages provisioning of the servers in the server farm. This can not be combined with Primary or Secondary Servers.

**Primary server** The server that is used to define the platform applications and components to install. The primary server also defines the configuration of those applications and components and the content that is provisioned and synchronized to the secondary servers in the server farm.

**Secondary server** Additional servers that are synchronized to the primary server for platform applications and components, configuration settings, content, and applications.

## FAQs

**What are the dependencies of the Web Farm Framework?** Microsoft Web Farm Framework uses the  Microsoft Web Platform Installer V3 and  Microsoft Web Deploy V2, which must both be installed on the controller server.

**Does Web Farm Framework require setup of ARR for load balancing?**  
No, ARR is not required. You can use the Microsoft Web Farm Framework with a third-party load balancing environment.

**What other configurations are needed for Web Farm Framework?** Firewall exceptions must allow Core Networking and Remote Administration through the firewall. For more information, see [System and Platform Requirements](system-and-platform-requirements-for-the-web-farm-framework-20-for-iis.md).

**Can I create a server farm without setting up provisioning?**  
Yes. You can enable, disable, and modify settings for provisioning at any time.

## More information

Additional IIS Learn articles:

- [System and Platform Requirements for the Web Farm Framework for IIS 7 and Above](system-and-platform-requirements-for-the-web-farm-framework-20-for-iis.md)
- [Setting up a Server Farm with the Web Farm Framework for IIS 7 and Above](setting-up-a-server-farm-with-the-web-farm-framework-20-for-iis.md)
- [Managing a Server Farm with the Web Farm Framework for IIS 7 and Above](provisioning-a-server-farm-with-the-web-farm-framework-20-for-iis.md)
- [Running Server Operations Using the Web Farm Framework 2.0 for IIS 7 and Above](running-server-operations-using-the-web-farm-framework-20-for-iis.md)
- [Skipping Folders while Provisioning with Web Farm Framework 2.0 for IIS 7 and Above](skipping-folders-while-provisioning-with-web-farm-framework-20-for-iis.md)
- [Building Workflows with Web Farm Framework 2.0 for IIS 7 and Above](building-workflows-with-web-farm-framework-20-for-iis.md)
- [Web Farm Framework 2.0 for IIS 7 and Above Code Sample](web-farm-framework-20-for-iis-code-sample.md)
- [Web Farm Framework 2.0 for IIS 7 and Above cmdlets for Windows PowerShell](web-farm-framework-20-for-iis-cmdlets-for-windows-powershell.md)

WFF team blogs:

- [How to Write a Web Farm Framework Provider](https://blogs.iis.net/gursing/archive/2010/09/06/how-to-write-a-web-farm-framework-provider.aspx) ([Gupreet's Blog](https://blogs.iis.net/gursing/default.aspx))
- [How to do Skip Directives using default provider in Web Farm Framework 2.0](https://blogs.iis.net/gurupurna/archive/2011/01/25/how-to-do-skip-directives-using-default-provider-in-web-farm-framework-2-0-wff-2-0-by-changing-the-applicationhost-config.aspx) ([Gurupurna](https://blogs.iis.net/gurupurna/default.aspx))
- [How to integrate F5 with Web Farm Framework](https://blogs.iis.net/gursing/archive/2011/01/21/how-to-integrate-f5-with-web-farm-framework.aspx) ([Gupreet's Blog](https://blogs.iis.net/gursing/default.aspx))
- [Web Farm Framework 2.0 – Work Flow Builder &amp; Extensibility](https://blogs.iis.net/yaftab/archive/2011/01/27/web-farm-framework-2-0-work-flow-builder-amp-extensibility.aspx) ([Younus' Blog](https://blogs.iis.net/yaftab/default.aspx))
- [Run Existing Web Farm Framework 2.0 providers using CreateRunOptions](https://blogs.iis.net/gursing/archive/2010/10/04/run-existing-web-farm-framework-2-0-provider-using-createrunoptions.aspx) ([Gupreet's Blog](https://blogs.iis.net/gursing/default.aspx))
- [Microsoft Web Farm Framework 2.0](https://weblogs.asp.net/scottgu/archive/2011/01/20/microsoft-web-farm-framework-2-0.aspx) ([ScottGu's Blog](https://weblogs.asp.net/scottgu/default.aspx))
