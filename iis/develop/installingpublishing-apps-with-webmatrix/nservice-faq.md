---
title: "nService FAQ"
author: rick-anderson
description: "WebMatrix supports installing open source community applications from the Web Application Gallery, and publishing to hosting providers, including a set of Be..."
ms.date: 07/06/2010
ms.assetid: 6a66077a-b338-48bc-a336-90f43288401e
msc.legacyurl: /learn/develop/installingpublishing-apps-with-webmatrix/nservice-faq
msc.type: authoredcontent
---
# nService FAQ

by Faith A

WebMatrix supports installing open source community applications from the Web Application Gallery, and publishing to hosting providers, including a set of Beta partner hosting providers. This FAQ contains information about installing and publishing, as well as any issues that may occur after publishing.

## Installing and Publishing nService

#### Q: How do I install nService?

A: To install nService, use the following steps:

1. Open WebMatrix and select **Site from Web Gallery**.
2. Select the **Tools** category on the left-hand side.
3. Find **nService** in the list and install it.
4. In any workspace, on the **Home** tab, in the **Site** group, click **Run** or press F12 to open the site in your default web browser.
5. Follow the instructions to complete installation.

#### Q: How do I publish my nService website?

A: To publish a nService website, use the following steps:

1. In any workspace, on the **Home** tab, in the **Site** group, click **Publish**.
2. On the **Publishing Settings** dialog, enter the server info you received from your web host.
3. Click **Validate Connection** to ensure that the settings are correct.
4. Click **Publish**.
5. If you have not published your database before, select the Database checkbox.
6. After previewing the changes, click **Continue**.

## Common Issues

#### Q: Why do I get a "500 Internal Server Error" when browsing to my website?

A: If you are publishing to a server where the web site is configured to run in a .NET 4 application pool, you will receive this error because the application requires .NET 2.0. You will also see the following error message displayed:

> **Error**: The requested page cannot be accessed because the related configuration data for the page is invalid.
> 
> ![](nservice-faq/_static/image1.png)

To resolve this issue, use your hosting control panel to set your .NET framework version to 2.0 or 3.5.
