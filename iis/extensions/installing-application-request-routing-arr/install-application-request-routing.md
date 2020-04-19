---
title: "Install Application Request Routing"
author: rick-anderson
description: "This topic leads the reader through the steps to install Microsoft Application Request Routing (ARR) Version 1 on IIS 7.0 and above. Goal To successfully ins..."
ms.date: 07/02/2008
ms.assetid: 3447e132-fb7d-436e-9789-5cddc7044745
msc.legacyurl: /learn/extensions/installing-application-request-routing-arr/install-application-request-routing
msc.type: authoredcontent
---
# Install Application Request Routing

This topic leads the reader through the steps to install Microsoft Application Request Routing (ARR) Version 1 on IIS 7.0 and above.

## Goal

To successfully install Microsoft Application Request Routing Version 1 and dependent modules on IIS. The Application Request Routing installer package contains the following components:

- Microsoft URL Rewrite Module for IIS.
- Microsoft Web Farm Management Version 1 for IIS.
- Microsoft Application Request Routing Version 1 for IIS.
- Microsoft External Cache Version 1 for IIS.

The steps outlined in this document will install all four components.

## Prerequisites

This walkthrough requires the following prerequisites:

- IIS 7.0 and above on Windows 2008 (any SKU) or newer where Application Request Routing would be installed.
- If the target system already has the following IIS modules installed, remove them using Add/Remove programs:

  - Microsoft URL Rewrite Module for IIS 7.0 CTP1.
  - Microsoft Application Request Routing for IIS 7.0 CTP1.

> [!NOTE]
>
> - **Upgrading from CTP1 to RTW release is *not* supported.** CTP1 release must be removed manually before proceeding. All configuration settings will be lost.
> - **Upgrading from RC to RTW release is supported** and, therefore, RC release does not need to be removed. No configuration settings will be lost.

## Step 1 – Download Microsoft Application Request Routing Version 1

Download the Microsoft Application Request Routing release from the following locations:

- Microsoft Application Request Routing Version 1 for IIS 7 (x86) [here](https://iis.net/downloads/default.aspx?tabid=34&amp;g=6&amp;i=1709).
- Microsoft Application Request Routing Version 1 for IIS 7 (x64) [here](https://iis.net/downloads/default.aspx?tabid=34&amp;g=6&amp;i=1712).

## Step 2 – Install Microsoft Application Request Routing Version 1

### To install Application Request Routing

1. As an **administrator**, open a command prompt window.
2. Stop **WAS** and **WMSVC** processes by typing. This step is necessary because ARR installs a Hotfix ([KB 954438](https://support.microsoft.com/kb/954438)).  

   [!code-console[Main](install-application-request-routing/samples/sample1.cmd)]

   [!code-console[Main](install-application-request-routing/samples/sample2.cmd)]
3. run ARR\_&lt;architecture&gt;\_exe:

   [!code-console[Main](install-application-request-routing/samples/sample3.cmd)]

   or

   [!code-console[Main](install-application-request-routing/samples/sample4.cmd)]
4. Accept the End User License Agreement (EULA).
5. The installers for the four components are launched one after another.
6. Complete the installation.
7. To check on the installation status, refer to %TEMP%\arr\_setup.log. If all packages have been installed successfully, you should see the following:  

    [!code-console[Main](install-application-request-routing/samples/sample5.cmd)]

8. (***Optional***) For troubleshooting purposes, the downloaded executable can be unpackaged. Launch the executable file with /T:&lt;full path&gt; and /C options. This command will unpackage just the four MSIs, which can be launched manually one at a time. If the MSIs are being installed manually, they must be installed in the following order:  

    [!code-console[Main](install-application-request-routing/samples/sample6.cmd)]

   For more information, launch the executable file with the /? option.
9. Start **WAS** and **WMSVC** processes by typing:  

   [!code-console[Main](install-application-request-routing/samples/sample7.cmd)]

   [!code-console[Main](install-application-request-routing/samples/sample8.cmd)]

## Step 3 – Change application pool process model for Application Request Routing

All HTTP requests and responses for the content sites go through Application Request Routing. Given this, you would want the worker process of Default Web Site on Application Request Routing to always be running regardless of whether the worker processes for some of the sites are running or not.

In this step, you will disable the Idle Time-Out under application pool process model for Default Web Site.

### To change the application pool process model using the UI

1. Launch IIS Manager.  
2. Select **Application Pools**.

   ![](install-application-request-routing/_static/image1.jpg)
3. By default, **DefaultAppPool** is the corresponding application pool for **Default Web Site**. Select **DefaultAppPool**. Under **Actions**, under **Edit Application Pool**, select **Advanced Settings…**.

   ![](install-application-request-routing/_static/image3.jpg)
4. Change the **Idle Time-out (minutes)** to 0 to disable the setting. Click **OK** to save the changes.

### To change the application pool process model using the command-line

1. Open a command prompt with **administrator** privileges.
2. Navigate to `%windir%\system32\inetsrv`.
3. Using appcmd, enter **appcmd.exe set apppool "DefaultAppPool" -processModel.idleTimeout:"00:00:00" /commit:apphost**.

## Repair

Repairing Application Request Routing involves re-running the downloaded package. Follow the steps outlined in **Step 2 - Install Microsoft Application Request Routing Version 1.**

## Remove

To remove Application Request Routing completely, the 4 packaged components must be removed individually.

- Open **Control Panel**.
- Select **Program and Features**.
- Locate the following 4 components and uninstall one at a time:  

    1. Microsoft Application Request Routing Version 1 for IIS
    2. Microsoft External Cache Version 1 for IIS
    3. Microsoft URL Rewrite Module for IIS
    4. Microsoft Web Farm Framework Version 1 for IIS

## Summary

You have now successfully installed Application Request Routing and the dependent modules, and are ready to configure and use the features. You may also want to read a quick overview at `%PROGRAMFILES%\IIS\Application Request Routing\ARR\_ReadMe.htm` for more information.
