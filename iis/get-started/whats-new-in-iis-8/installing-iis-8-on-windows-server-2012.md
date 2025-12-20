---
title: "Installing IIS 8 on Windows Server 2012"
author: rmcmurray
description: "Version Notes IIS 8.0 IIS 8.0 is only available in Windows Server 2012 and Windows 8. IIS 7.5 IIS 7.0 Contents Overview Step by Step Instructions Summary Ove..."
ms.date: 02/29/2012
ms.assetid: 44dd8251-9f28-4b60-bd30-c866a80e5e14
msc.legacyurl: /learn/get-started/whats-new-in-iis-8/installing-iis-8-on-windows-server-2012
msc.type: authoredcontent
ms.custom: sfi-image-nochange
---
# Installing IIS 8 on Windows Server 2012

by [Robert McMurray](https://github.com/rmcmurray)

### Compatibility

| Version | Notes |
| --- | --- |
| IIS 8.0 | IIS 8.0 is only available in Windows Server 2012 and Windows 8. |
| IIS 7.5 |
| IIS 7.0 |

<a id="TOC301258515"></a>

## Overview

Server Manager in Windows Server 2012 is new and accordingly, the user experience has changed as well.

This step-by-step instruction is not unique to installing IIS. It is meant to assist IIS customers with navigating through the new Server Manager quickly.

<a id="TOC301258517"></a>

## Step by Step Instructions

#### Prerequisites:

- Windows Server 2012 has been installed.

#### Workarounds for known bugs:

- There are no known bugs for this feature at this time.

### Installing IIS 8 with the Default Settings

To install IIS 8, use the following steps:

1. Open **Server Manager**.
2. Under **Manage** menu, select **Add Roles and Features**:  
    ![Screenshot of the Server Manager dashboard page. The Manage menu item is expanded.](installing-iis-8-on-windows-server-2012/_static/image1.png)
3. Select **Role-based or Feature-based Installation**:  
    ![Screenshot of the Add Roles and Features Wizard window. The Select installation type page is in the main pane.](installing-iis-8-on-windows-server-2012/_static/image5.png)
4. Select the appropriate server (local is selected by default), as shown below:  
    ![Screenshot of the Add Roles and Features Wizard window. The Select destination server page is in the main pane. ](installing-iis-8-on-windows-server-2012/_static/image9.png)
5. Select **Web Server (IIS)**:  
    ![Screenshot of the Add Roles and Features Wizard window. The Select server roles page is in the main pane.](installing-iis-8-on-windows-server-2012/_static/image13.png)
6. No additional features are needed for IIS, so click **Next**:  
    ![Screenshot of the Add Roles and Features Wizard window. The Select features page is in the main pane.](installing-iis-8-on-windows-server-2012/_static/image17.png)
7. Click **Next**:  
    ![Screenshot of the Add Roles and Features Wizard window. The Web Server Role page is in the main pane.](installing-iis-8-on-windows-server-2012/_static/image21.png)
8. Customize your installation of IIS, or accept the default settings that have already been selected for you, and then click **Next**:  
    ![Screenshot of the Add Roles and Features Wizard window. The Select role services page is in the main pane.](installing-iis-8-on-windows-server-2012/_static/image25.png)
9. Click **Install**:  
    ![Screenshot of the Add Roles and Features Wizard. The Confirmation installation selections page is in the main pane.](installing-iis-8-on-windows-server-2012/_static/image29.png)
10. When the IIS installation completes, the wizard reflects the installation status:  
    ![Screenshot of the Add Roles and Features Wizard. The Installation progress page is in the main pane.](installing-iis-8-on-windows-server-2012/_static/image33.png)
11. Click **Close** to exit the wizard.

<a id="TOC301258518"></a>

## Summary

IIS 8.0 has been installed successfully by using Server Manager in Windows Server 2012.
