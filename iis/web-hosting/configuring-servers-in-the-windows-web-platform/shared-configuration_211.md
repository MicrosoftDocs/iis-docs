---
title: "Shared Configuration | Microsoft Docs"
author: walterov
description: "In IIS 6.0, synchronizing and replicating configuration between servers was difficult because no built-in functionality existed. Although the server administ..."
ms.author: iiscontent
manager: soshir
ms.date: 12/02/2007
ms.topic: article
ms.assetid: 4c423bc4-1dac-4d0d-9be3-5c9b87b06e86
ms.technology: iis-hosting
ms.prod: iis
msc.legacyurl: /learn/web-hosting/configuring-servers-in-the-windows-web-platform/shared-configuration_211
msc.type: authoredcontent
---
Shared Configuration
====================
by [Walter Oliver](https://github.com/walterov)

## Introduction

In IIS 6.0, synchronizing and replicating configuration between servers was difficult because no built-in functionality existed. Although the server administrator could use the script iiscnfg.vbs to copy configuration between servers, this would still leave ACLs on the metabase and machine-specific paths like the Windows directory to be fixed.

## Shared Configuration in IIS

In IIS 7.0 and above, the shared configuration feature enables administrators to store the IIS server configuration files applicationHost.config and administration.config on a remote share. It can be used when building a Web farm to resolve issues related to replication and synchronization of configuration.

**What is exported by shared configuration?**

- applicationHost.config
- administration.config
- Encryption keys for IIS and ASP.NET (exported as configEncKey.key)

**What is not exported?**

- machine.config
- root Web.config
- Web.config files for sites and applications (these are part of the Web site content and can be stored on a share)
- Web site content (can be stored on a share)
- Custom modules
- Installed modules (the installed modules should be configured the same way on each server)

## Setup

**To set up shared configuration**

1. Create a user that will access the share containing the configuration. This can be a domain user or a local user, if the machine is not joined to a domain.   
  
    > [!NOTE]
    > If the machine is not joined to the domain, the account will need to be created on the Web server(s) and the file server.
2. Create a share for storing the configuration files and set permissions. This can be done using the following commands:  
  
		md %SystemDrive%\centralconfig  
		net share centralconfig$=%SystemDrive%\centralconfig /grant:ConfigUser,Read /grant:Administrators,Full
3. Navigate to **Administrative Tools** and click **Internet Information Services (IIS) Manager**.
4. Click the server name node.
5. Double-click the **Shared Configuration** icon.
6. On the **Shared Configuration** page, to export the configuration files from the local machine to another location, click **Export Configuration** in the **Actions** pane.
7. In the **Export Configuration** dialog box, type a path in the **Physical path** text box.
8. Click **Connect As...** and type a user account and password, and then click **OK**. This account will be used to access the share. You should use a restricted Active Directory account that is not the domain administrator.
9. In the **Export Configuration** dialog box, type a password that will be used to protect the encryption keys, and then click **OK**.
10. On the **Shared Configuration** page, check **Enable shared configuration**.
11. Type the physical path, user account, and password that you entered previously, and then click **Apply** in the **Actions** pane.
12. In the **Encryption Keys Password** dialog box, type the encryption key password that you set earlier, and then click **OK**.
13. In the **Shared Configuration** dialog box, click **OK**.
14. Click **OK**.
15. Close and reopen IIS Manager.
16. Double-click the **Management Service** icon.
17. In the **Actions** pane, click **Restart**.

By clicking the Export Configuration task, the UI exports the applicationHost.config and administration.config files to the path, as well as the encryption keys that IIS uses to encrypt properties like custom application pool identity passwords. By default, there are no encrypted properties in the applicationHost.config file, unless the server administrator has entered custom identities for an application pool or Web site.

Shared configuration works by using a new file named redirection.config, located in the `%windir%\system32\inetsrv\config` folder, to specify a path and username for accessing the configuration files. When the shared configuration check box is enabled, the UI updates the redirection.config file with the path and username.

While this task can be performed manually (or programmatically) by xcopying the files and updating the redirection.config file, the server administrator must export and import the encryption keys unless they intend not to use encryption. The UI handles all of these tasks seamlessly for the administrator.

For more information, go to [Shared Configuration](../../manage/managing-your-configuration-settings/shared-configuration_264.md).