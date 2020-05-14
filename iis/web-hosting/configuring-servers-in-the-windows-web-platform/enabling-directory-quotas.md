---
title: "Directory Quotas and FSRM"
author: walterov
description: "Starting with Windows Server ® 2003 R2, File Server Resource Manager (FSRM) offers advanced quota and directory management. The quota system can now be based..."
ms.date: 12/01/2007
ms.assetid: b08212c6-af36-4506-9cb0-0502dfa81af5
msc.legacyurl: /learn/web-hosting/configuring-servers-in-the-windows-web-platform/enabling-directory-quotas
msc.type: authoredcontent
---
Directory Quotas and FSRM
====================
by [Walter Oliver](https://github.com/walterov)

## Introduction

Starting with Windows Server® 2003 R2, File Server Resource Manager (FSRM) offers advanced quota and directory management. The quota system can now be based on directories, rather than set by a Windows user. This enables a quick and convenient way to restrict the amount of content uploaded to a Web site's root directory, rather than configuring per user.

But new to Windows Server® 2008 is the ability to programmatically manage the quotas and other features offered by FSRM. For more information, go to [https://msdn.microsoft.com/library/bb613366.aspx](https://msdn.microsoft.com/library/bb613366.aspx).

## Installing, Creating, and Setting Quotas

**To install the File Server Resource Manager**

1. Navigate to **Administrative Tools** and click **Server Manager**.
2. Select the **Features** node in the left-hand tree view.
3. Click **Add Features**.
4. In the Select Features page of the Add Features Wizard, check  **File** **Server Resource Manager (FSRM)**, and then click **Next**.
5. Click **Install** to start the installation.
6. On the **Installation Results** page, click **Close**.

**To create a quota template**

1. Navigate to **Administrative Tools** and click **File Server Resource Manager**.
2. Expand the **Quota Management** node in the left-hand tree view.
3. Right-click **Quota Templates**, and select **Create Quota Template**.
4. Copy the properties of an existing template by selecting a template from the **Copy properties from quota template** drop-down list. Then click **Copy**.
5. In the **Template Name** text box, type a name for the new template, such as Hosting Default Quota.
6. In the **Label** text box, type an optional description that will appear next to any quotas derived from the template.
7. In the **Limit** text box, type a number and choose a unit (KB, MB, GB, or TB).
8. Click **Hard quota** or **Soft quota**.
  
   (A hard quota prevents users from saving files after the space limit is reached and generates notifications when the volume of data reaches each configured threshold. A soft quota does not enforce the quota limit, but it generates all configured notifications.)
9. You can configure one or more optional threshold notifications for your quota template, as described in the procedure that follows. After you have selected all the quota template properties that you want to use, click **OK** to save the template.

**To set the quota template for a directory**

1. Navigate to **Administrative Tools** and click **File Server Resource Manager**.
2. Expand the **Quota Management** node in the left-hand tree view.
3. Right-click **Quotas**, and select **Create Quota**.
4. Under **Quota path**, type or browse to the folder that the quota will apply to.
5. By default, **Create quota on path** is checked.
6. Under **Derive properties from this quota template**, select the template that should apply, such as the Shared Hosting Default template created in the steps above.
7. Click **Create**.

Quotas can also be created using the command-line tool dirquota.exe (see [C# and PowerShell Scripts Samples](../configuring-components/powershell-scripts.md)). The following command-line sets the directory quota limit to 500 MB for a site directory:

[!code-console[Main](enabling-directory-quotas/samples/sample1.cmd)]

For more information about the File Server Resource Manager, see [File Server Resource Manager overview](https://docs.microsoft.com/windows-server/storage/fsrm/fsrm-overview).
