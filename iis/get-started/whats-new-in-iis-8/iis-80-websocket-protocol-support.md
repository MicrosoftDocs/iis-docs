---
title: "IIS 8.0 WebSocket Protocol Support | Microsoft Docs"
author: Microsoft
description: ""
ms.author: aspnetcontent
manager: wpickett
ms.date: 11/28/2012
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/get-started/whats-new-in-iis-8/iis-80-websocket-protocol-support
msc.type: authoredcontent
---
IIS 8.0 WebSocket Protocol Support
====================
by [Microsoft](https://github.com/Microsoft)

## Compatibility


| Version | Notes |
| --- | --- |
| IIS 8.0 | The WebSocket Protocol was introduced in IIS 8.0. |
| IIS 7.5 | The WebSocket Protocol was not supported in IIS 7.5. |
| IIS 7.0 | The WebSocket Protocol was not supported in IIS 7.0. |


<a id="TOC301258515"></a>

## Problem

One of the limitations to HTTP is that it was designed as a one-directional method of communication. However, many modern web-based applications require more real-time, two-way communications in order to function optimally.

<a id="TOC301258516"></a>

## Solution

With the release of Windows Server 2012 and Windows 8, Internet Information Services (IIS) 8.0 has added support for the WebSocket Protocol.

The WebSocket Protocol is an open standard that is defined in [RFC 6455](https://go.microsoft.com/fwlink/?LinkID=252388), and developers can use this functionality to create applications that implement two-way communications over the Internet between a client and server. For more information about the WebSocket Protocol, see the following articles:

- **WebSockets**  
    [https://msdn.microsoft.com/hh673567.aspx](https://msdn.microsoft.com/hh673567.aspx)
- **WebSockets: Stable and Ready for Developers**  
    [https://msdn.microsoft.com/hh969243.aspx](https://msdn.microsoft.com/hh969243.aspx)

<a id="TOC301258517"></a>

## Step by Step Instructions

To enable support for the WebSocket Protocol on Windows Server 2012, use the following steps:

1. Open **Server Manager**.
2. Under the **Manage** menu, click **Add Roles and Features**.
3. Select **Role-based or Feature-based Installation**, and then click **Next**.
4. Select the appropriate server, (your local server is selected by default), and then click **Next**.
5. Expand **Web Server (IIS)** in the **Roles** tree, then expand **Web Server**, and then expand **Application Development**.
6. Select **WebSocket Protocol**, and then click **Next**.
7. If no additional features are needed, click **Next**.
8. Click **Install**.
9. When the installation completes, click **Close** to exit the wizard.

<a id="TOC301258519"></a>

## Issues

## Disable WebSocket when using socket.io on node.js

If you are using the WebSocket support in socket.io on node.js in your site, you will need to disable the default IIS WebSockets module by adding the below snippet to your web.config or applicationHost.config. If this is not done, the IIS WebSockets module will attempt to handle the WebSocket communication rather than letting this task fall through to node.js (and hence your application). This will result in unexpected errors when you attempt to access your site.

[!code-xml[Main](iis-80-websocket-protocol-support/samples/sample1.xml)]

<a id="TOC301258518"></a>

## Summary

IIS 8.0 has added support for WebSocket Protocol, which enables dynamic, two-way communications over the Internet. Additional information can be found on the following URLs:

- **Getting started with WebSockets in Windows 8**  
    [http://www.paulbatum.com/2011/09/getting-started-with-websockets-in.html](http://www.paulbatum.com/2011/09/getting-started-with-websockets-in.html)
- **IIS and Websockets**  
    [https://blogs.iis.net/jennylaw/archive/2012/09/05/iis-and-websockets.aspx](https://blogs.iis.net/jennylaw/archive/2012/09/05/iis-and-websockets.aspx)
- **System.Net.WebSockets Namespace**[https://msdn.microsoft.com/en-us/library/system.net.websockets.aspx](https://msdn.microsoft.com/en-us/library/system.net.websockets.aspx)