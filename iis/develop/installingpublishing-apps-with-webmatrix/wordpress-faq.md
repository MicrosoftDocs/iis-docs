---
title: "WordPress FAQ | Microsoft Docs"
author: rick-anderson
description: "WebMatrix supports installing open source community applications from the Web Application Gallery, and publishing to hosting providers, including a set of Be..."
ms.author: iiscontent
manager: soshir
ms.date: 07/06/2010
ms.topic: article
ms.assetid: 
ms.technology: iis-develop
ms.prod: iis
msc.legacyurl: /learn/develop/installingpublishing-apps-with-webmatrix/wordpress-faq
msc.type: authoredcontent
---
WordPress FAQ
====================
by Faith A

WebMatrix supports installing open source community applications from the Web Application Gallery, and publishing to hosting providers, including a set of Beta partner hosting providers. This FAQ contains information about installing and publishing, as well as any issues that may occur after publishing.

## Installing and Publishing WordPress

#### Q: How do I install WordPress?

A: To install WordPress, use the following steps:

1. Open WebMatrix and select **Site from Web Gallery**.
2. Select the **Blogs** category on the left-hand side.
3. Find **WordPress** in the list and install it.
4. In any workspace, on the **Home** tab, in the **Site** group, click **Run** or press F12 to open the site in your default web browser.
5. Follow the instructions to complete installation.

#### Q: How do I publish my WordPress website?

A: To publish a WordPress website, use the following steps:

1. In any workspace, on the **Home** tab, in the **Site** group, click **Publish**.
2. On the **Publishing Settings** dialog, enter the server info you received from your web host.
3. Click **Validate Connection** to ensure that the settings are correct.
4. Click **Publish**.
5. If you have not published your database before, select the Database checkbox.
6. After previewing the changes, click **Continue**.

Known Issues

**Issue:** Wordpress fail to publish with a database error indicating that a particular line of SQL could not be processed  
WebMatrix installs MySQL with the UTF-8 character set by default. If you install MySQL on your own, and the character set is not UTF-8 (e.g. it may be Latin1), publishing databases may fail  
**Workaround:** 1) Change the character set for MySQL to UTF-8. [More information](http://dev.mysql.com/doc/refman/5.0/en/charset-server.html).  
2) Re-install the application  
3) Re-publish the application
  
  
[Discuss in IIS Forums](https://forums.iis.net/1166.aspx)