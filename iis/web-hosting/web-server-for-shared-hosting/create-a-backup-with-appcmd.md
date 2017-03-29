---
title: "Create a Backup with appcmd | Microsoft Docs"
author: walterov
description: "After you install IIS 7.0, you can backup your configuration by using the built-in command-line tool, AppCmd.exe. You can run AppCmd.exe to create a backup o..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 12/01/2007
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/web-hosting/web-server-for-shared-hosting/create-a-backup-with-appcmd
msc.type: authoredcontent
---
Create a Backup with appcmd
====================
by [Walter Oliver](https://github.com/walterov)

After you install IIS 7.0, you can backup your configuration by using the built-in command-line tool, AppCmd.exe. You can run AppCmd.exe to create a backup of your Web server before you have changed any configuration.

**To create a backup using AppCmd.exe**

1. Open a command prompt as administrator and change to the %windir%\system32\inetsrv\ directory.
2. At the command prompt, type *appcmd add backup "FirstBackup"* and then press **Enter**.

This creates a backup with the name "FirstBackup". At a later date, if you need to restore the backup, use *appcmd restore backup "FirstBackup"*. For more information about AppCmd.exe, see [https://www.iis.net/default.aspx?tabid=2&amp;subtabid=25&amp;i=954](../../get-started/getting-started-with-iis/getting-started-with-appcmdexe.md)