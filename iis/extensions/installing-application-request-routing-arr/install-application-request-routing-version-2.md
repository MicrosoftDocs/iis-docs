---
title: "Install Application Request Routing Version 2 | Microsoft Docs"
author: rick-anderson
description: "This topic leads the reader through the steps to install Microsoft Application Request Routing (ARR) Version 2 for IIS 7 and above . Goal To successfully ins..."
ms.author: iiscontent
manager: soshir
ms.date: 03/18/2009
ms.topic: article
ms.assetid: aaed5a3c-0fcf-4589-9ae0-f33e2adf592f
ms.technology: iis-extensions
ms.prod: iis
msc.legacyurl: /learn/extensions/installing-application-request-routing-arr/install-application-request-routing-version-2
msc.type: authoredcontent
---
Install Application Request Routing Version 2
====================
by IIS Team

This topic leads the reader through the steps to install Microsoft Application Request Routing (ARR) **Version 2 for IIS 7 and above**.

## Goal

To successfully install Microsoft Application Request Routing Version 2 for IIS 7 and above and its dependent modules.

The ARR Version 2 installer package contains the following components:

- Microsoft Application Request Routing Version 2 for IIS 7 and above.
- Microsoft URL Rewrite Module Version 2 for IIS 7 RC2 and above.
- Microsoft Web Farm Management Version 1 for IIS 7 and above.
- Microsoft External Cache Version 1 for IIS 7 and above.

The steps outlined in this document will install all four components.

## Prerequisites

This walkthrough requires the following prerequisites:

- IIS 7.0 or above on Windows 2008 (any SKU) or newer where Application Request Routing will be installed.

> [!IMPORTANT]
> ARR Version 2 RTW supports upgrading from ARR Version 1 RTW and from ARR Version 2 RC. If any other version of ARR is already installed, uninstall both ARR and URL Rewrite before proceeding.

> [!NOTE]
> Note that the corresponding configurations will be lost.

## Step 1 - Download Microsoft Application Request Routing Version 2.

Download the Microsoft Application Request Routing release from the following locations:

- Microsoft Application Request Routing Version 2 for IIS 7 (x86) [here](https://download.microsoft.com/download/4/D/F/4DFDA851-515F-474E-BA7A-5802B3C95101/ARRv2_setup_x86.EXE).
- Microsoft Application Request Routing Version 2 for IIS 7 (x64) [here](https://download.microsoft.com/download/3/4/1/3415F3F9-5698-44FE-A072-D4AF09728390/ARRv2_setup_x64.EXE).

## Step 2 - Install Microsoft Application Request Routing Version 2.

**To install Application Request Routing:** 

1. Open a command prompt with administrator user rights.
2. Stop the WAS and WMSVC processes by entering the following: 

    [!code-console[Main](install-application-request-routing-version-2/samples/sample1.cmd)]

    [!code-console[Main](install-application-request-routing-version-2/samples/sample2.cmd)]

 This step is necessary because ARR installs a Hotfix ([KB 954438](https://support.microsoft.com/kb/954438)).
3. Run ARRv2\_setup\_&lt;architecture&gt;.exe; for example: 

    [!code-console[Main](install-application-request-routing-version-2/samples/sample3.cmd)]

    [!code-console[Main](install-application-request-routing-version-2/samples/sample4.cmd)]
4. Accept the End User License Agreement (EULA).
5. The installers for the four components are launched one after another.
6. Complete the installation.
7. To check the installation status, refer to the %TEMP%\arr\_setup.log file. If all packages have installed successfully, you will see the following: 

    - Completed the Microsoft Application Request Routing for IIS7 Setup.
    - Installation results - Look in the respective msi log files (msiname.log) for more details. 

        - rewrite.msi Success
        - webfarm.msi Success
        - requestrouter.msi Success
        - externaldiskcache.msi Success
8. (***Optional***) For troubleshooting purposes, the downloaded executable can be unpackaged. Launch the executable file with /T:&lt;full path&gt; and /C options. This command will unpackage just the four MSIs, which can be launched manually one at a time. If the MSIs are installed manually, they must be installed in the following order: 

    - rewrite.msi
    - webfarm.msi
    - requestrouter.msi
    - externaldiskcache.msi

 For more information, launch the executable file with the /? option.
9. Start the **WAS** and **WMSVC** processes by entering the following: 

    [!code-console[Main](install-application-request-routing-version-2/samples/sample5.cmd)]

    [!code-console[Main](install-application-request-routing-version-2/samples/sample6.cmd)]

    [!code-console[Main](install-application-request-routing-version-2/samples/sample7.cmd)]

## Step 3 – Change application pool process model for Application Request Routing.

**This step is optional but recommended.**

All HTTP requests and responses for the content sites go through Application Request Routing. Given this, you would want the worker process for the Default Web Site on Application Request Routing to always run, regardless of whether the worker processes for some of the sites are running or not.

In this step, you will disable the Idle Time-Out under the application pool process model for the Default Web Site.

**To change the application pool process model using the UI:** 

1. Launch IIS Manager.
2. Select **Application Pools**.  
  
    [![](install-application-request-routing-version-2/_static/image3.jpg)](install-application-request-routing-version-2/_static/image2.jpg)
3. By default, **DefaultAppPool** is the corresponding application pool for the **Default Web Site**. Select **DefaultAppPool**. In the **Actions** pane, under **Edit Application Pool**, click **Advanced Settings…**[![](install-application-request-routing-version-2/_static/image5.jpg)](install-application-request-routing-version-2/_static/image4.jpg)
4. Change the **Idle Time-out (minutes)** value to **0** to disable the setting. Click **OK** to save the changes.

**To change the application pool process model using the command-line:** 

1. Open a command prompt with administrator user rights.
2. Navigate to `%windir%\system32\inetsrv`.
3. Using appcmd, enter 

    [!code-console[Main](install-application-request-routing-version-2/samples/sample8.cmd)]

## Step 4 – Change application pool recycling settings for Application Request Routing.

**This step is optional but recommended.**

Similarly, disable the application pool recycle setting so that the application pool does not recycle unexpectedly for ARR.

**To change the application pool recycle setting using the UI:** 

1. Launch IIS Manager.
2. Select **Application Pools**.  
  
    [![](install-application-request-routing-version-2/_static/image7.jpg)](install-application-request-routing-version-2/_static/image6.jpg)
3. By default, **DefaultAppPool** is the corresponding application pool for the **Default Web Site**. Select **DefaultAppPool**. In the **Actions** pane, under **Edit Application Pool**, click **Recycling…**[![](install-application-request-routing-version-2/_static/image9.jpg)](install-application-request-routing-version-2/_static/image8.jpg)
4. Clear the **Regular time intervals (in minutes)** checkbox.

**To change the application pool recycle setting using the command-line:** 

1. Open a command prompt with administrator user rights.
2. Navigate to `%windir%\system32\inetsrv`.
3. Using appcmd, enter 

    [!code-console[Main](install-application-request-routing-version-2/samples/sample9.cmd)]

## Repair

Repairing Application Request Routing involves running the downloaded package again. Follow the steps outlined in **Step 2 - Install Microsoft Application Request Routing Version 2.**

## Remove

To remove Application Request Routing completely, you must remove the four packaged components individually.

1. Open **Control Panel**.
2. Click **Program and Features**.
3. Locate the following four components and uninstall one at a time:

    - Microsoft Application Request Routing Version 2 for IIS 7
    - Microsoft External Cache Version 1 for IIS 7
    - Microsoft URL Rewrite Module Version 2 for IIS 7 RC2
    - Microsoft Web Farm Framework Version 1 for IIS 7

## Summary

You have now successfully installed Application Request Routing and the dependent modules, and are ready to configure and use the features. For a quick overview and more information, see `%PROGRAMFILES%\IIS\Application Request Routing\ARR\_ReadMe.htm`.