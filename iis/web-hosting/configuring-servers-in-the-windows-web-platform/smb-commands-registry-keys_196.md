---
title: "SMB Command Registry Keys | Microsoft Docs"
author: walterov
description: "On Windows servers, each connection uses the identity of a unique user to connect to another server by using an SMB (Server Message Block) connection. A conn..."
ms.author: iiscontent
manager: soshir
ms.date: 12/01/2007
ms.topic: article
ms.assetid: 
ms.technology: iis-hosting
ms.prod: iis
msc.legacyurl: /learn/web-hosting/configuring-servers-in-the-windows-web-platform/smb-commands-registry-keys_196
msc.type: authoredcontent
---
SMB Command Registry Keys
====================
by [Walter Oliver](https://github.com/walterov)

## Introduction

On Windows servers, each connection uses the identity of a unique user to connect to another server by using an SMB (Server Message Block) connection. A connection is used when you open a remote file share in Windows Explorer or via a net use command.

For each connection, there are a number of work items or work contexts used. By default, this limit is set low, and when storing IIS content or configurations on a remote file server, you may run out quickly. This causes the error "The network BIOS command limit has been reached." There may be other errors, such as an ASP.NET or ASP 500 error.

## Registry Keys

There are registry keys that control how many commands and work items are permitted. On the file server, two registry keys control the number of connections and work items that are allowed.

When using a remote file server for content or configuration files, you must set the registry keys on both the file server if it is running Windows 2003 or lower, and the Web server.

> [!NOTE]
> If you are running Windows Server® 2008 on both the Web server and the file server, these registry changes are unnecessary. If they are set, Windows Server 2008 will ignore them.

**To configure the registry key on the file server (Windows Server 2003)**

1. From the command prompt, run regedt32 to open the Registry Editor.
2. Navigate to HKEY\_LOCAL\_MACHINE\SYSTEM\CurrentControlSet\Services\lanmanserver\parameters.
3. If it does not exist, create a DWORD "MaxMpxCt" and set the value to 800 hexadecimal. This specifies a value of 2,048 decimal.
4. If it does not exist, create a DWORD "MaxWorkItems" and set the value to 2000 hexadecimal. This specifies a value of 8,192 decimal, or 4x the MaxMptCt.
5. Reboot the machine.

For information on the length limitation of the pathname of the share (\\server\share) see [https://msdn.microsoft.com/en-us/library/cc246567.aspx](https://msdn.microsoft.com/en-us/library/cc246567.aspx)

For instructions to configure the Web Server SMB registry keys see: [https://www.iis.net/learn/web-hosting/web-server-for-shared-hosting/smb-commands-registry-keys\_198](../web-server-for-shared-hosting/smb-commands-registry-keys_198.md)