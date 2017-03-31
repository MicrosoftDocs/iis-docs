---
title: "DotNetNuke ® Community Edition FAQ | Microsoft Docs"
author: rick-anderson
description: "WebMatrix supports installing open source community applications from the Web Application Gallery, and publishing to hosting providers, including a set of Be..."
ms.author: iiscontent
manager: soshir
ms.date: 07/06/2010
ms.topic: article
ms.assetid: 
ms.technology: iis-develop
ms.prod: iis
msc.legacyurl: /learn/develop/installingpublishing-apps-with-webmatrix/dotnetnuke-community-edition-faq
msc.type: authoredcontent
---
DotNetNuke ® Community Edition FAQ
====================
by Faith A

WebMatrix supports installing open source community applications from the Web Application Gallery, and publishing to hosting providers, including a set of Beta partner hosting providers. This FAQ contains information about installing and publishing, as well as any issues that may occur after publishing.

## Installing and Publishing DotNetNuke Community Edition

### Q: How do I install DotNetNuke Community Edition?

A: To install DotNetNuke Community Edition, use the following steps:

1. Open WebMatrix and select **Site from Web Gallery**.
2. Select the **CMS** category on the left-hand side.
3. Find **DotNetNuke® Community Edition** in the list and install it.
4. In any workspace, on the **Home** tab, in the **Site** group, click **Run** or press F12 to open the site in your default web browser.
5. Follow the instructions to complete installation.

### Q: How do I publish my DotNetNuke Community Edition website?

A: To publish a DotNetNuke Community Edition website, use the following steps:

1. In any workspace, on the **Home** tab, in the **Site** group, click **Publish**.
2. On the **Publishing Settings** dialog, enter the server info you received from your web host.
3. Click **Validate Connection** to ensure that the settings are correct.
4. Click **Publish**.
5. If you have not published your database before, select the Database checkbox.
6. After previewing the changes, click **Continue**.

## Known Issues

**Issue**: Some links are not visible in DotNetNuke after publishing or downloading the site. If you publish or download a DotNetNuke site, you may need to clear the cache to get the new links to appear on the site.

**Workaround**:

1. Log in as Host.
2. Go to the host menu and select "Host Settings"
3. Scroll down and expand the "Performance Settings" under "Advanced Settings"
4. Click the "Clear Cache" Link for pages.
5. Go to the bottom of the page and restart the application.

**Issue**: "Download published site…" fails with a database error  
 If you try to download an application from a server and you have administrator credentials in the database connection string in the Publish Settings dialog, you may see this error in the publish log:  
 1:28:29 PM: An error occurred during execution of the database script. The approximate location of the error was between lines '3260' and '3262' of the script. The verbose log may have more information about the error. The command started with :  
 1:28:29 PM: CREATE LOGIN [MACHINE\Administrator] FROM WINDOW  
 1:28:29 PM: [https://go.microsoft.com/fwlink/?LinkId=178587](https://go.microsoft.com/fwlink/?LinkId=178587)

**Workaround**:

Publish the site in the first place using non-administrator credentials for the database in Publish Settings.

[Discuss in IIS Forums](https://forums.iis.net/1166.aspx)