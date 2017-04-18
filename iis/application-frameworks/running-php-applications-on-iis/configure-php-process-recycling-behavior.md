---
title: "Configure PHP Process Recycling Behavior | Microsoft Docs"
author: rick-anderson
description: "Introduction Make sure that FastCGI always recycles the php-cgi.exe processes before the native PHP recycling kicks in. The FastCGI process recycling behavio..."
ms.author: iiscontent
manager: soshir
ms.date: 11/15/2009
ms.topic: article
ms.assetid: 2caf4f65-32b2-454e-8613-c9e90b178363
ms.technology: iis-appfx
ms.prod: iis
msc.legacyurl: /learn/application-frameworks/running-php-applications-on-iis/configure-php-process-recycling-behavior
msc.type: authoredcontent
---
Configure PHP Process Recycling Behavior
====================
by Tali Smith

## Introduction

Make sure that FastCGI always recycles the php-cgi.exe processes before the native PHP recycling kicks in. The FastCGI process recycling behavior is controlled by the configuration property **instanceMaxRequests**. This property specifies how many requests the FastCGI process will process before recycling. PHP also has a similar process recycling functionality that is controlled by an environment variable **PHP\_FCGI\_MAX\_REQUESTS**. By setting **instanceMaxRequests** to be smaller or equal to **PHP\_FCGI\_MAX\_REQUESTS**, you can ensure that the native PHP process recycling logic will never kick in.

The FastCGI settings can be configured either by using IIS Manager or by using the command-line tool AppCmd.

## Use the IIS Manager

1. To configure FastCGI recycling settings by using IIS Manager, you must install Administration Pack for IIS 7.0 and above, and then select FastCGI Settings at the server level.  

    [![](configure-php-process-recycling-behavior/_static/image2.jpg)](configure-php-process-recycling-behavior/_static/image1.jpg)  
*Figure 1: IIS Manager, FastCGI Settings*
2. Next, select the FastCGI application that you want to configure, and then click **Edit** in the **Actions** pane on the right side.  

    [![](configure-php-process-recycling-behavior/_static/image4.jpg)](configure-php-process-recycling-behavior/_static/image3.jpg)  
*Figure 2: FastCGI Settings page*
3. In the **Edit FastCGI Application** dialog box, set **InstanceMaxRequest** to **10000,** and then click on the **browse** button next to the **EnvironmentVariables** setting.  

    [![](configure-php-process-recycling-behavior/_static/image6.jpg)](configure-php-process-recycling-behavior/_static/image5.jpg)  
*Figure 3: Edit FastCGI Application dialog box*
4. Add the **PHP\_FCGI\_MAX\_REQUESTS** environment variable, and set its value to **10000**.  
    > [!NOTE]
    > If you do not configure these settings, then the following default settings are used:     **InstanceMaxRequests** of 200,     **PHP\_FCGI\_MAX\_REQUESTS** of 500 (on most PHP builds).  

    [![](configure-php-process-recycling-behavior/_static/image8.jpg)](configure-php-process-recycling-behavior/_static/image7.jpg)  
*Figure 4: Environment Variables Collection Editor dialog box*

## Use the Command Line

To configure the recycling behavior of FastCGI and PHP via **appcmd**, use the following commands:


[!code-console[Main](configure-php-process-recycling-behavior/samples/sample1.cmd)]


[!code-console[Main](configure-php-process-recycling-behavior/samples/sample2.cmd)]


## Links for Further Information

[Using FastCGI to Host PHP Applications on IIS 7.0 and Above](../install-and-configure-php-applications-on-iis/using-fastcgi-to-host-php-applications-on-iis.md).