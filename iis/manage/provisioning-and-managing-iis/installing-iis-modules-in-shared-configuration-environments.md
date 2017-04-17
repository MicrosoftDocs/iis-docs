---
title: "Installing IIS Modules in Shared Configuration Environments | Microsoft Docs"
author: walterov
description: "This article describes the steps to install an IIS Module in machines that are part of the Shared Configuration environment. The following process assumes n..."
ms.author: iiscontent
manager: soshir
ms.date: 06/01/2009
ms.topic: article
ms.assetid: 
ms.technology: iis-manage
ms.prod: iis
msc.legacyurl: /learn/manage/provisioning-and-managing-iis/installing-iis-modules-in-shared-configuration-environments
msc.type: authoredcontent
---
Installing IIS Modules in Shared Configuration Environments
====================
by [Walter Oliver](https://github.com/walterov)

## Overview

This article describes the steps to install an IIS Module in machines that are part of the Shared Configuration environment. The following process assumes n servers using a common shared configuration. Since Shared Configuration requires that all web servers are running the exact IIS configuration modules, it is important to maintain such requirement throughout the update process. This articles describes the installation process in detail.

### Prerequisites:

- The following is required to perform this operation:
- Familiarity with Shared Configuration, see: [https://www.iis.net/learn/manage/managing-your-configuration-settings/shared-configuration\_264#08](../managing-your-configuration-settings/shared-configuration_264.md#08)
- Familiarity with the Load Balancing and the Site Provisioning/Management solution used in your environment
- One available file share to be used as the new shared config location

## Step 1 - Turn off any site provisioning and management automation

If you are using an automated system for provisioning and/or managing web sites, you need to turn it off. The reason is that changes to the shared configuration files should be stopped during the Module installation process. Refer to your site provisioning system to accomplish this step.

## Step 2 - Remove server 1 from the load balance solution

The steps to accomplish this step varied depending on which technology you are using for Load Balancing.  
For Network Load Balancing review the documentation at: [https://technet.microsoft.com/en-us/library/cc732855(WS.10).aspx](https://technet.microsoft.com/en-us/library/cc732855(WS.10).aspx)   
For Application Request Routing see: [https://www.iis.net/learn/extensions/planning-for-arr/using-the-application-request-routing-module](../../extensions/planning-for-arr/using-the-application-request-routing-module.md)   
For any other solution (including hardware) see the manufacturer's provided documentation.

## Step 3 - Remove server 1 from the shared config and backup the configuration locally.

This is accomplished through the IIS Manager UI and Command line prompt. See article [https://www.iis.net/learn/manage/managing-your-configuration-settings/shared-configuration\_264#08](../managing-your-configuration-settings/shared-configuration_264.md#08) for details.

## Step 4 - Install the IIS Module in server 1

Use Web Platform Installer to install the new IIS Modules: [https://www.microsoft.com/web/downloads/platform.aspx](https://www.microsoft.com/web/downloads/platform.aspx)

## Step 5 – Export the configuration from server 1 to a new shared configuration location

Once server 1 has all the new modules installed, export its configuration to a new shared config location. All subsequent server will point to this new location as they get updated.

## Step 6 – Enable Shared Config in server 1

Now that the server's configuration has been exported to a new location, the server can point to that configuration.

## Step 7 – Add server 1 to the Network Load Balancing solution

The newly updated server can now join the set of servers under load balancing.

## Step 8 – Apply changes to each subsequent server as follows:

1. Repeat Steps 2, 3, 4, 6 (skip step 5).
2. Point the server to the new Shared Config location created in step 5.
3. Repeat Step 7.

## Step 9 – Restore the site provisioning and management automation system

Once all servers are pointing to the new shared configuration created in step 5, you can restore normal operations of the provisioning and management system.

## Step 10 – (Optional) Clean up the old shared config location

You may want to have the file location ready for the new time a new module is installed. You may want to backup and delete the current content.

## Conclusion

This article covers the steps required to install an new module in a set of Web servers using shared configuration.