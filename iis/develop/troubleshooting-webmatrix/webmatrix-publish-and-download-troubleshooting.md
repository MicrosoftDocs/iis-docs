---
title: "WebMatrix Publish and Download Troubleshooting | Microsoft Docs"
author: rick-anderson
description: "Use this troubleshooting guide when you are run into problems with publishing or downloading sites in WebMatrix. Publishing Errors Bad gateway / proxy error..."
ms.author: iiscontent
manager: soshir
ms.date: 06/06/2012
ms.topic: article
ms.assetid: 681f566a-7879-4df4-b3ae-6c4b825b82d2
ms.technology: iis-develop
ms.prod: iis
msc.legacyurl: /learn/develop/troubleshooting-webmatrix/webmatrix-publish-and-download-troubleshooting
msc.type: authoredcontent
---
WebMatrix Publish and Download Troubleshooting
====================
by Faith A

Use this troubleshooting guide when you are run into problems with publishing or downloading sites in WebMatrix.

### Publishing Errors

- Bad gateway / proxy error
- "Could not connect to the remote computer"
- "Could not connect to the destination computer"
- "Connected to the remote computer ("computername") using the Web Management Service, but could not authorize"
- "Unable to read beyond the end of the stream"
- "Could not complete the request to remote agent URL"

#### Bad gateway / proxy error

**Cause:** A proxy server is most likely blocking access to the server.

**Things You Can Try:** Try installing your corporation's required firewall client, and disabling all settings in Internet Explorer &gt; Tools &gt; Options &gt; Connections &gt; LAN settings.

<a id="P1"></a>

#### Could not connect to the remote computer

**Cause:** The server was contacted but did not respond to the publishing. This is often due to the Web Management Service not being started on the server.

**Things You Can Try:** Contact your server administrator or hosting provider.

#### Could not connect to the destination computer

**Cause:** The server was contacted but did not respond to the publishing. This is often due to the Web Management Service not being started on the server.

**Things You Can Try:** Contact your server administrator or hosting provider.

#### Connected to the remote computer using the Web Management Service, but could not authorize

**Cause:** WebMatrix connected to the server, but your username is not authorized for the site name.

**Things You Can Try:** Check the publish settings to verify that your site name is correct. If everything looks correct, contact your server administrator or hosting provider.

#### Unable to read beyond end of the stream

**Cause:** Either the server or a device such as a router between your computer and the server closed the connection. This can be due to firewall or server configuration.

**Things You Can Try:** If you still get this error consistently after several publishing attempts, try when connected to another network. If it still occurs, contact your server administrator or hosting provider.

#### Could not complete the request to remote agent URL

**Cause:** This is a transient issue when the network is busy.

**Things You Can Try:** Try the publishing again. If it continues to happen, contact your server administrator or hosting provider.