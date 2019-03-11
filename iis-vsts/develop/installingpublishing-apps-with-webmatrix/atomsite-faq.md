---
title: "AtomSite FAQ"
author: rick-anderson
description: "WebMatrix supports installing open source community applications from the Web Application Gallery, and publishing to hosting providers, including a set of Be..."
ms.date: 07/06/2010
ms.assetid: efcc228a-b43c-4730-bdaa-9824bbd6f956
msc.legacyurl: /learn/develop/installingpublishing-apps-with-webmatrix/atomsite-faq
msc.type: authoredcontent
---
AtomSite FAQ
====================
by Faith A

WebMatrix supports installing open source community applications from the Web Application Gallery, and publishing to hosting providers, including a set of Beta partner hosting providers. This FAQ contains information about installing and publishing, as well as any issues that may occur after publishing.

## Installing and Publishing AtomSite

#### Q: How do I install AtomSite?

A: To install AtomSite, use the following steps:

1. Open WebMatrix and select **Site from Web Gallery**.
2. Select the **CMS** category on the left-hand side.
3. Find **AtomSite** in the list and install it.
4. In any workspace, on the **Home** tab, in the **Site** group, click **Run** or press F12 to open the site in your default web browser.
5. Follow the instructions to complete installation.

#### Q: How do I publish my AtomSite website?

A: To publish a AtomSite website, use the following steps:

1. In any workspace, on the **Home** tab, in the **Site** group, click **Publish**.
2. On the **Publishing Settings** dialog, enter the server info you received from your web host.
3. Click **Validate Connection** to ensure that the settings are correct.
4. Click **Publish**.
5. After previewing the changes, click **Continue**.

## Known Issues

**Issue:** Some links in AtomSite are broken after you download a published site  
**Workaround:** This is a known issue. A workaround is to perform a string replace for service.config, users.config, and all .xml files of the remote URL string (i.e. "[http://myhost.com/atomsite](http://myhost.com/atomsite)") to the local one (i.e. "[http://localhost:1239](http://localhost:1239/)").