---
title: "Diagnosing Failures with Remote Administration | Microsoft Docs"
author: NitashaV
description: "This article will help you diagnose and fix issues found while using RemoteMgr. This is based on frequently asked questions on the iis.net forums. Cannot con..."
ms.author: iiscontent
manager: soshir
ms.date: 02/14/2008
ms.topic: article
ms.assetid: 
ms.technology: iis-troubleshoot
ms.prod: iis
msc.legacyurl: /learn/troubleshoot/remote-administration-issues/diagnosing-failures-with-remote-administration
msc.type: authoredcontent
---
Diagnosing Failures with Remote Administration
====================
by [Nitasha Verma](https://github.com/NitashaV)

## Introduction

This article will help you diagnose and fix issues found while using RemoteMgr. This is based on frequently asked questions on the iis.net forums.

## Cannot connect to the remote server?

Make sure the client and the server are using the same build. For example, a Server Beta 3 remoteMgr will not work with a RC1 server build.

Refer to the [blog post about Remote Management Behavior Matrix](https://blogs.iis.net/nitashav/archive/2007/04/23/remote-management-behavior-matrix.aspx). There might be a problem related to the access control lists (ACLs).

Look at the Event Viewer (eventvwr.msc) log. WMSVC has a good supportability story. Events are logged with detailed error messages and a stack trace. Looking at the Event Viewer often tells you what the problem might be.

## Cannot connect to the remote server after updating wmsvc bindings?

If this happens after updating the port on which WMSVC is configured to run, check to see if the firewall is turned on for the server. If it is, add a new exception rule for the port on which WMSVC is running (default value: 8172). Then try connecting to the server again.

If this does not solve the problem, run the following commands from cmdline:

### netsh http show sslcert


[!code-console[Main](diagnosing-failures-with-remote-administration/samples/sample1.cmd)]


Ensure that the port 8172 (the one on which WMSVC is running) has SSL certificate bindings. Also make sure the cert hash matches the one to which WMSVC is bound to (in the Management Service UI).

Sample output:


[!code-console[Main](diagnosing-failures-with-remote-administration/samples/sample2.cmd)]


### netsh http show urlacl


[!code-console[Main](diagnosing-failures-with-remote-administration/samples/sample3.cmd)]


Ensure that the URL [https://\*:8172/](https://*:8172/) (the port on which WMSVC is configured to run) appears in the list of reserved URLs.  
  
Sample output:


[!code-console[Main](diagnosing-failures-with-remote-administration/samples/sample4.cmd)]


Use netsh commands in the previous paragraph to determine if the bindings are not correctly configured. The problem might be that the machine key does not have permissions for the administrator trying to adjust the WMSVC bindings. In that case, try the following:

1. Take ownership of the machine key:<br?

    [!code-unknown[Main](diagnosing-failures-with-remote-administration/samples/sample-127040-5.unknown)]
2. Configure the ACLs of the machine key such that the administrator group has read permissions:  

    [!code-unknown[Main](diagnosing-failures-with-remote-administration/samples/sample-127040-6.unknown)]
3. Reserve the port 8172 for WMSVC:  

    [!code-console[Main](diagnosing-failures-with-remote-administration/samples/sample7.cmd)]
4. Associate the cert with the port:  

    [!code-console[Main](diagnosing-failures-with-remote-administration/samples/sample8.cmd)]

## Do not want to see the prompt on the client every time you connect to the remote server?

Make sure the server uses a trusted root certificate for WMSVC. Create a trusted root certificate (if you do not already have it) and on the Management Service feature page, assign this certificate to be used by the service. This ensures that the client does not get a prompt asking if they trust the server (since the certificate is not trusted).

## If all else fails:

Post the issue on the [iis.net forums](https://forums.iis.net/) with reproduced steps and details. Please include the eventvwr.msc log along with exception and call stack.

Here are details on how to get the exception and call stack:

1. Attach windbg to wmsvc.exe

    [!code-unknown[Main](diagnosing-failures-with-remote-administration/samples/sample-127040-9.unknown)]
2. Load the sos.dll and set a break point if a managed exception happens

    [!code-unknown[Main](diagnosing-failures-with-remote-administration/samples/sample-127040-10.unknown)]
3. Then hit go

    [!code-unknown[Main](diagnosing-failures-with-remote-administration/samples/sample-127040-11.unknown)]
4. When it breaks, print the exception and the call stack and send it to iis.net/forums.

    [!code-unknown[Main](diagnosing-failures-with-remote-administration/samples/sample-127040-12.unknown)]

[Discuss in IIS Forums](https://forums.iis.net/1111.aspx)