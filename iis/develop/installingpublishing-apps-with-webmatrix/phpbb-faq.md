---
title: "phpBB FAQ"
author: rick-anderson
description: "WebMatrix supports installing open source community applications from the Web Application Gallery, and publishing to hosting providers, including a set of Be..."
ms.date: 07/06/2010
ms.assetid: ed03be9b-b0b1-4845-bb4e-b1355989af0d
msc.legacyurl: /learn/develop/installingpublishing-apps-with-webmatrix/phpbb-faq
msc.type: authoredcontent
---
phpBB FAQ
====================
by Faith A

WebMatrix supports installing open source community applications from the Web Application Gallery, and publishing to hosting providers, including a set of Beta partner hosting providers. This FAQ contains information about installing and publishing, as well as any issues that may occur after publishing.

## Installing and Publishing phpBB

#### Q: How do I install phpBB?

A: To install phpBB, use the following steps:

1. Open WebMatrix and select **Site from Web Gallery**.
2. Select the **Forums** category on the left-hand side.
3. Find **phpBB** in the list and install it.
4. In any workspace, on the **Home** tab, in the **Site** group, click **Run** or press F12 to open the site in your default web browser.
5. Follow the instructions to complete installation.

#### Q: How do I publish my phpBB website?

A: To publish a phpBB website, use the following steps:

1. Prior to publishing the application, you should remove the install directory or only the application's administrative console will be available:

    1. Go to the **Files** workspace.
    2. In the navigation pane, select the directory called *install* and press the delete key.
2. In any workspace, on the **Home** tab, in the **Site** group, click **Publish**.
3. On the **Publishing Settings** dialog, enter the server info you received from your web host.
4. Click **Validate Connection** to ensure that the settings are correct.
5. Click **Publish**.
6. If you have not published your database before, select the Database checkbox.
7. After previewing the changes, click **Continue**.

## Known Issues

**Issue:** phpBB gives a "Service is unavailable" error after publishing  
**Workound:** In WebMatrix, click Publish Settings and add a slash "\" after the server name. Publish the application again.
