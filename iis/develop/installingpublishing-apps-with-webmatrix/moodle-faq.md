---
title: "Moodle FAQ | Microsoft Docs"
author: rick-anderson
description: "WebMatrix supports installing open source community applications from the Web Application Gallery, and publishing to hosting providers, including a set of Be..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 07/06/2010
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/develop/installingpublishing-apps-with-webmatrix/moodle-faq
msc.type: authoredcontent
---
Moodle FAQ
====================
by Faith A

WebMatrix supports installing open source community applications from the Web Application Gallery, and publishing to hosting providers, including a set of Beta partner hosting providers. This FAQ contains information about installing and publishing, as well as any issues that may occur after publishing.

## Installing and Publishing Moodle

#### Q: How do I install Moodle?

A: To install Moodle, use the following steps:

1. Open WebMatrix and select **Site from Web Gallery**.
2. Select the **CMS** category on the left-hand side.
3. Find **Moodle** in the list and install it.
4. In any workspace, on the **Home** tab, in the **Site** group, click **Run** or press F12 to open the site in your default web browser.
5. Follow the instructions to complete installation.

#### Q: How do I publish my Moodle website?

A: To publish a Moodle website, use the following steps:

1. In any workspace, on the **Home** tab, in the **Site** group, click **Publish**.
2. On the **Publishing Settings** dialog, enter the server info you received from your web host.
3. Click **Validate Connection** to ensure that the settings are correct.
4. Click **Publish**.
5. If you have not published your database before, select the Database checkbox.
6. After previewing the changes, click **Continue**.

## Known Issues

**Issue:** Moodle website layout and links are broken after publishing  
**Workaround:** Add a trailing slash ‘/' to the Site Name field in Publish Settings and publish again.
  
  
[Discuss in IIS Forums](https://forums.iis.net/1166.aspx)