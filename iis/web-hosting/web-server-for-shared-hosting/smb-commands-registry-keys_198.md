---
title: "SMB Commands Registry Keys"
author: walterov
description: "On Windows servers, each connection employs the identity of a unique user to connect to another server by using an SMB (Server Message Block) connection. A c..."
ms.date: 12/01/2007
ms.assetid: 952b8892-957e-4ad6-be68-6bc1c0f6702f
msc.legacyurl: /learn/web-hosting/web-server-for-shared-hosting/smb-commands-registry-keys_198
msc.type: authoredcontent
---
SMB Commands Registry Keys
====================
by [Walter Oliver](https://github.com/walterov)

## Introduction

On Windows servers, each connection employs the identity of a unique user to connect to another server by using an SMB (Server Message Block) connection. A connection is used when you browse to a Web page and IIS impersonates the configured user account to access the files.

For each connection, there are a number of work items or work contexts used. By default, this limit is set low, and when storing IIS content or configuration on a remote file server, you may run out quickly. This causes the error "The network BIOS command limit has been reached." There may be other errors, such as an ASP.NET or ASP 500 error.

There are registry keys that control how many commands and work items are permitted. On the IIS servers, a registry key is used to control the number of connections or commands that can be made to a file server.

When using a remote file server for content or configuration files, you must set the registry keys on both the file server if it is running Windows 2003 or lower, and the Web server.

> [!NOTE]
> If you are running Windows Server® 2008 on both the Web server and the file server, these registry changes are unnecessary. If they are set, Windows Server 2008 will ignore them.

## Configuring

To configure the registry key on the Web server, use the following:

1. From the command prompt, run regedt32 to open the Registry Editor.
2. Navigate to HKEY\_LOCAL\_MACHINE\SYSTEM\CurrentControlSet\Services\lanmanworkstation\parameters.
3. If it does not exist, create a DWORD "MaxCmds" and set the value to 800 hexadecimal. This specifies a value of 2,048.

> [!NOTE]
> The server must be rebooted before this setting will take effect.

For more information, go to "IIS runs out of work items and causes RPC failures when connection to a remote UNC path" at [https://support.microsoft.com/kb/221790/](https://support.microsoft.com/kb/221790/). 

For information on the length limitation of the pathname of the share (\\server\share) see [https://msdn.microsoft.com/en-us/library/cc246567.aspx](https://msdn.microsoft.com/en-us/library/cc246567.aspx)

For instructions to configure the File Server SMB registry keys see: [https://www.iis.net/learn/web-hosting/configuring-servers-in-the-windows-web-platform/smb-commands-registry-keys\_196](../configuring-servers-in-the-windows-web-platform/smb-commands-registry-keys_196.md)