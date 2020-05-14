---
title: "Analyze Requests to Your Website"
author: rick-anderson
description: "[This is preliminary documentation and is subject to change.] Overview This walkthrough shows you how to analyze requests to your website using the Requests..."
ms.date: 07/06/2010
ms.assetid: 3c483e52-2bc4-4066-98d2-de7caaa3a240
msc.legacyurl: /learn/develop/using-webmatrix/analyze-requests-to-your-website
msc.type: authoredcontent
---
Analyze Requests to Your Website
====================
by [Diana Nguyen](https://twitter.com/dianaaanguyen)

[This is preliminary documentation and is subject to change.]

## Overview

This walkthrough shows you how to analyze requests to your website using the Requests feature in WebMatrix Beta. This feature lets you view the status of requests in real-time, including detailed information like the verb, URL, time elapsed, and more. You can identify where errors are occurring, and resolve these errors immediately. For example, if you see an error in your browser, you can use the Requests feature to see if more information is available about the error. This will help you to diagnose and troubleshoot the error.

IIS Express uses the following HTTP status codes:

- Status code 2xx = Success
- Status code 3xx = Information (Redirect)
- Status code 4xx = Error (Client)
- Status code 5xx = Error (Server)

> [!NOTE]
> For additional information about HTTP status codes, see the [HTTP status codes in IIS 7.0](https://support.microsoft.com/kb/943891) article in Microsoft Knowledge Base.

### Prerequisites

You must have the following installed to complete the procedures in this walkthrough:

- Windows XP or a later version.
- WebMatrix Beta 1 or a later version.

For information about how to install WebMatrix Beta, see [Microsoft Web Platform Installer 3.0](https://go.microsoft.com/fwlink/?LinkID=145510).

## Monitoring Your Site

When you make requests, you can view the results in real-time so that you can identify errors that are easy to fix, discover dependencies, and learn about your website.

1. To start WebMatrix, in Windows, click **Start** &gt; **All Programs** &gt; **Microsoft WebMatrix Beta**.
2. On the WebMatrix Beta **Quick Start** page, open your site by choosing it from **My Sites**.  
    > [!NOTE]
    > If you do not already have a site, you can open the default site (Website1) or add a new one by choosing **Site from Web Gallery**, **Site From Template**, or **Site From Folder**.
  
    [![](analyze-requests-to-your-website/_static/image3.png)](analyze-requests-to-your-website/_static/image1.png)

    WebMatrix opens your site. This walkthrough uses the Bakery website as an example.
  
    [![](analyze-requests-to-your-website/_static/image7.png)](analyze-requests-to-your-website/_static/image5.png)
3. On the **Home** tab, click **Requests**.
4. View your site in a browser by using one of the following:

    - On the **Home** tab, click **Run**.
    - Press **F12**.
5. View the results of your request in the content pane.  
  
    [![](analyze-requests-to-your-website/_static/image11.png)](analyze-requests-to-your-website/_static/image9.png)  
  
   While viewing the results, you can also do the following:

   - Search the list of results for specific request types, such as "304.0".
   - In the ribbon, in the **Requests** tab, click **Only Errors** to show only the results that are errors. Click **Only Errors** again to show the full list of results.
   - Click **Ignore Images** to ignore the results that are related to image errors, such as 404.0 File Not Found, where the image doesn't exist on the Web server. Click **Ignore Images** again to show the full list of results.
  
     [![](analyze-requests-to-your-website/_static/image15.png)](analyze-requests-to-your-website/_static/image13.png)
6. In the list, select a request to view detailed information about the request, such as the status, details, and recommendations. If the request is an error, this will help you diagnose and fix the cause.  
  
    [![](analyze-requests-to-your-website/_static/image19.png)](analyze-requests-to-your-website/_static/image17.png)
7. If the request is an error, click **Edit** in the subpane to open the file that contains the error and fix the file.
   You can also click **More Information** to get more information about the HTTP status code and possible solutions to the error from the Microsoft Support web page.
8. After you resolve the error, return to the **Site** workspace and open **Requests** again. Click **Clear All** to remove the cached requests.  
  
    [![](analyze-requests-to-your-website/_static/image23.png)](analyze-requests-to-your-website/_static/image21.png)
9. When you re-run the page, the resolved error will no longer appear in the results list.
