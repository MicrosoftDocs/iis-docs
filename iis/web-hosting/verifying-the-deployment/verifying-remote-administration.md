---
title: "Verifying Remote Administration | Microsoft Docs"
author: walterov
description: "An important characteristic of Shared Hosting with IIS is that Hosters can empower their users to administer their sites remotely as described in IIS Managem..."
ms.author: iiscontent
manager: soshir
ms.date: 01/17/2009
ms.topic: article
ms.assetid: 7f6dd0dd-96ba-4258-994c-ed58a0a73b14
ms.technology: iis-hosting
ms.prod: iis
msc.legacyurl: /learn/web-hosting/verifying-the-deployment/verifying-remote-administration
msc.type: authoredcontent
---
Verifying Remote Administration
====================
by [Walter Oliver](https://github.com/walterov)

## Introduction

An important characteristic of [Shared Hosting](../planning-the-web-hosting-architecture/shared-hosting-configuration.md) with IIS is that Hosters can empower their users to administer their sites remotely as described in [IIS Management and Administration](../../manage/provisioning-and-managing-iis/iis-management-and-administration.md). This article provides hosters with a set of steps to verify that the Remote Administration user experience is indeed enabled.

## User Experience Verification

### Prerequisites:

- Delegated administration must have been enabled in the server, enabling remote connections and starting the WMSVC service, see:

    - This article &lt;link: [https://www.iis.net/learn/manage/remote-administration/configuring-remote-administration-and-feature-delegation-in-iis-7](../../manage/remote-administration/configuring-remote-administration-and-feature-delegation-in-iis-7.md)&gt; provides a step-by-step guide for Configuring Remote Administration and Feature Delegation in IIS.
    - This article &lt;link: [https://www.iis.net/learn/web-hosting/web-server-for-shared-hosting/delegated-administration](../web-server-for-shared-hosting/delegated-administration.md)&gt; has a list of Feature Delegation settings relevant to Shared Hosting and instructions on how to configure them and enable remote connections (the latter is also covered in the previous bullet).
- A windows or user account with access to the user's site.
- For a Vista client the InetMgr Remote Administration must be installed. See this article &lt;link: [https://www.iis.net/learn/manage/remote-administration/remote-manager-for-windows-2003-xp-and-vista-sp1](../../manage/remote-administration/remote-manager-for-windows-2003-xp-and-vista-sp1.md)&gt;

### Steps:

1. Within a Windows Server 2008 R2, Windows 7, or Windows Vista computer run InetMgr.exe.
2. From the Connections pane select Connect to Site:  
    [![](verifying-remote-administration/_static/image2.jpg)](verifying-remote-administration/_static/image1.jpg)
3. Enter the Server and Site names and press next:  
    [![](verifying-remote-administration/_static/image4.jpg)](verifying-remote-administration/_static/image3.jpg)
4. Enter the User Credentials and press next:  
    [![](verifying-remote-administration/_static/image6.jpg)](verifying-remote-administration/_static/image5.jpg)
5. Enter a name for your Connection:  
    [![](verifying-remote-administration/_static/image8.jpg)](verifying-remote-administration/_static/image7.jpg)
6. A dialog listing the new available IIS Manager Modules should be displayed, press OK to install the new modules:  
    [![](verifying-remote-administration/_static/image10.jpg)](verifying-remote-administration/_static/image9.jpg)
7. After installation of the new modules IIS Manager will display the modules available, the example below has the Database Manager highlighted.   
    [![](verifying-remote-administration/_static/image12.jpg)](verifying-remote-administration/_static/image11.jpg)

## Conclusion

This article described the steps to verify that the Delegated Administration User Experience is enabled.