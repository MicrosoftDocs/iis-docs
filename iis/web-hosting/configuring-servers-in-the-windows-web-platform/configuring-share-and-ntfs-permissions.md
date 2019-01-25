---
title: "Share and NTFS Permissions"
author: walterov
description: "The file server permissions must be carefully implemented to provide appropriate access to content. This involves locking down permissions on the share and p..."
ms.date: 12/01/2007
ms.assetid: 141816d0-0345-476e-be88-58deff95c9b2
msc.legacyurl: /learn/web-hosting/configuring-servers-in-the-windows-web-platform/configuring-share-and-ntfs-permissions
msc.type: authoredcontent
---
Share and NTFS Permissions
====================
by [Walter Oliver](https://github.com/walterov)

## Introduction

The file server permissions must be carefully implemented to provide appropriate access to content. This involves locking down permissions on the share and physical folders.

## Permissions

The following table lists permissions that were used for the file server share and folders in the [Shared Hosting Setup](../planning-the-web-hosting-architecture/shared-hosting-configuration.md) mentioned in the [Planning the Web Hosting Architecture](../planning-the-web-hosting-architecture/index.md) section of the Hosting Guidance. Based on the shared hosting environment used, server administrators should develop their own custom permissions that meet their needs.

| **Path** | **Permissions** | **Reason** |
| --- | --- | --- |
| \\server\share$ (*share*) | Domain Administrators - Full Control Domain Users - Change MachineAccounts$ - Full Control | The share permissions need to allow the administrators and site accounts to access the content. The physical path will be restricted to actual needed permissions. |
| E:\Content (*physical path of share*) | Administrators - Full Control System - Full Control | This is the folder that is shared. It does not need permissions for any accounts aside from the built-in Administrators group and System account. |
| E:\Content\&lt;sitename&gt; (the container for a specific site or user) | Administrators - Full Control System - Full Control Site Owner - List Folder Contents | This folder is used as a container for folders like the site's home directory and its log files. The Site Owner should be able to read this folder but does not need write access. |
| E:\Content\&lt;sitename&gt; \wwwroot (the IIS home directory for the site) | Administrators - Full Control System - Full Control Site Owner - Modify App Pool Username - Read | This is the root of a Web site belonging to the user account. App Pool Username is used as both the application pool identity and the anonymous username for the Web site. |
| E:\Content\&lt;sitename&gt;\Logs (the container for logs) | Administrators - Full Control System - Full Control Site Owner - Read | Note that this folder for logs is stored ABOVE the root of the site, so that it is not accessible by a visitor browsing the site. It is not recommended that you put this folder in any location accessible from a Web browser, for security purposes. |
| E:\Content\&lt;sitename&gt;\Logs\FailedReqLogs (the container for failed request tracing logs) | Administrators - Full Control System - Full Control App Pool Username - Full Control | This is the folder used to store Failed Request log files, which allow a site owner to diagnose problems with their Web site. These logs are written by the worker process identity, App Pool Username. |
| E:\Content\&lt;sitename&gt;\Logs\W3SVCLogFiles (the container for W3SVC traffic logs) | Administrators - Full Control System - Full Control MachineAccount$ - Full Control | This is the folder used to store the log files for the Web site, which allow a site owner to see their traffic patterns. If the server administrator does not wish to share these files or wants to provide an alternate method for determining traffic, these files can be stored elsewhere. MachineAccount$ is the Web server's machine account, as these logs are written by HTTP.SYS. |

## Configuring Permissions

**To configure permissions for the share**

1. In Windows Explorer, right-click the folder you want to share, and then click **Properties**.
2. On the **Sharing** tab, click **Advanced Sharing**.
3. In User Account Control, click **Continue** to accept the prompt that Windows needs your permission to perform the action.
4. In the **Advanced Sharing** dialog box, check **Share this folder**.
5. Set the **Share name** and **Comments** as appropriate. To make the share hidden, add a $ to the end of the share name.   
  
    > [!NOTE]
    > Hiding a share means that when you connect to [\\server](file://server/) you will not see the share unless you specifically enter the path [\\server\share$](file://server/share$).
6. Click **Permissions**.
7. In the **Permissions** dialog box, remove the Everyone group, if it exists.
8. Add the appropriate user or group that should have access to the share.
9. Specify the permissions (Full Control, Change, Read) for the user or group.
10. Click **OK** twice and then click **Close** to close the dialog boxes.

**To configure permissions for the folder structure**

1. In Windows Explorer, right-click the folder you want to share, and then click **Properties**.
2. On the **Security** tab, click **Edit**.
3. In the **Permissions** dialog box, add the appropriate users or groups that should have access at each level of the folder structure.
4. Specify the permissions (Full control, Modify, Read &amp; execute, List folder contents, Read, Write Special permissions) for the users or groups.
5. Click **OK** twice to close the dialog boxes.

See [C# and PowerShell Scripts Samples](../configuring-components/powershell-scripts.md) for a sample script to configure default documents. as an example of creation of a share and setting of permissions.