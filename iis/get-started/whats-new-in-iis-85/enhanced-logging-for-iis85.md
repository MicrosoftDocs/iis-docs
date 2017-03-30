---
title: "Enhanced Logging for IIS 8.5 | Microsoft Docs"
author: garyericson
description: "In IIS 8.5, the administrator has the option of logging additional custom fields from request or response headers, or from server variables."
ms.author: iiscontent
manager: soshir
ms.date: 07/11/2013
ms.topic: article
ms.assetid: 
ms.technology: iis
ms.prod: iis
msc.legacyurl: /learn/get-started/whats-new-in-iis-85/enhanced-logging-for-iis85
msc.type: authoredcontent
---
Enhanced Logging for IIS 8.5
====================
by [Gary Ericson](https://github.com/garyericson)

> In IIS 8.5, the administrator has the option of logging additional custom fields from request or response headers, or from server variables.


### Compatibility


| Version | Notes |
| --- | --- |
| IIS 8.5 and later | Enhanced Logging was introduced in IIS 8.5. |
| IIS 8.0 and earlier | Enhanced Logging was not supported prior to IIS 8.5. |


### Contents

- [**Problem**](#TOC301258515)
- [**Solution**](#TOC301258516)
- [**Step by Step Instructions**](#TOC301258517)
- [**Summary**](#TOC301258518)

<a id="TOC301258515"></a>
## Problem

Internet Information Services (IIS) on Windows Server 2012 provides limited logging capabilities for a fixed set of standard fields, without options for extensibility or customizability for logging. Administrators who need to log fields beyond this standard set must create a custom logging module.

<a id="TOC301258516"></a>
## Solution

In IIS 8.5 and later, the administrator has the option of logging additional custom fields from request or response headers, or from server variables.

<a id="TOC301258517"></a>
## Step by Step Instructions

### Configure Enhanced Logging for IIS 8.5 and later

1. Open **IIS Manager**.
2. Select the site or server in the **Connections** pane, and then double-click **Logging**. Note that enhanced logging is available only for site-level logging - if you select the server in the **Connections** pane, then the **Custom Fields** section of the **W3C Logging Fields** dialog is disabled.
3. In the **Format** field under **Log File**, select **W3C** and then click **Select Fields...**.  
    ![Select fields](enhanced-logging-for-iis85/_static/image1.jpg)
4. In the **W3C Logging Fields** dialog, click **Add Field...**. Note that enhanced logging is available only for site-level logging - if you selected the server in the **Connections** pane, then **Add Field...** is disabled.   
    ![Add custom fields](enhanced-logging-for-iis85/_static/image2.jpg)
5. In the **Add Custom Field** dialog, enter a **Field Name** to identify the custom field within the log file. Please note that the field name cannot contain spaces.
6. Select the **Source Type**. You can select **Request Header**, **Response Header**, or **Server Variable** (note that enhanced logging cannot log a server variable with a name that contains lower-case characters - to include a server variable in the event log just make sure that its name consists of all upper-case characters).
7. Select **Source**, which is the name of the HTTP header or server variable (depending on the **Source Type** you selected) that contains a value that you want to log. You also can enter your own custom source string. For example, to record the custom HTTP Header &quot;X-FORWARDED-FOR&quot;, enter that string in **Source**.  
    ![Enter custom source](enhanced-logging-for-iis85/_static/image3.jpg)
8. Click **OK**.
9. Click **Add Field...** for each additional custom field you want to add. You also can click **Remove Field** to remove a custom field you added or click **Edit Field...** to edit it.
10. Click **OK**.
11. Click **Apply** in the **Actions** pane to apply the new configuration.

Once the custom fields have been configured, IIS will create new text log files with &quot;\_x&quot; appended to the file name to indicate that the file contains custom fields.

Note that the total size of data collected from all custom fields cannot exceed 65,536 bytes. If the total exceeds 65,536 bytes, then IIS will truncate the data.

<a id="TOC301258518"></a>
## Summary

In this guide, you have configured IIS to add custom fields to the IIS logs.