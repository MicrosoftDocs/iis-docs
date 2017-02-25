---
title: "Using HTTP for Streaming and Downloading from the Same Computer | Microsoft Docs"
author: rick-anderson
description: "You can use Microsoft Windows Media Services 2008 and Internet Information Services (IIS) 7. on the same computer for digital content delivery. For example,..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 09/26/2008
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/media/windows-media-services/using-http-for-streaming-and-downloading-from-the-same-computer
msc.type: authoredcontent
---
Using HTTP for Streaming and Downloading from the Same Computer
====================
by Dave Nelson

You can use Microsoft Windows Media Services 2008 and Internet Information Services (IIS) 7. on the same computer for digital content delivery. For example, you may want to use Windows Media Services to [stream](windows-media-server-or-web-server.md#wms_streaming) a live broadcast to clients and use IIS to [download](windows-media-server-or-web-server.md#web_download) digital media files to clients. If a firewall separates clients from your server, it is advantageous to use HTTP through port 80 for digital media content delivery, as most firewalls leave this port open.

Windows Media Services and IIS can coexist on a computer when you use their default values. By default, HTTP streaming is not enabled in Windows Media Services; therefore, IIS can bind to port 80 for delivery of Web-based content. However, if you decide that you want to use HTTP streaming in Windows Media Services, additional configuration is required because both programs cannot bind to port 80 on the same Internet Protocol (IP) address. This article describes the configuration alternatives.

**In this article**

[Change the port that Windows Media Services uses for HTTP streaming](using-http-for-streaming-and-downloading-from-the-same-computer.md#port)

[Change the IP address that Windows Media Services uses for HTTP streaming](using-http-for-streaming-and-downloading-from-the-same-computer.md#ipaddress)

[Related articles](using-http-for-streaming-and-downloading-from-the-same-computer.md#related)

## Change the port that Windows Media Services uses for HTTP streaming

Because Web servers usually reserve port 80, it is easiest to change the port that Windows Media Services uses for HTTP streaming. This is one option that is available to you if you have one network adapter with one static IP address bound to it. Note, however, that this configuration has the following drawbacks:

- In the announcement file or Web page that links to your streaming content, You must specify a connection URL to the content that uses an HTTP URL moniker (http://) and includes the new port number. For example, if you change the HTTP streaming port to port 1450, you must specify the following connection URL for a player: http://*server*\_*name*:1450/*publishing*\_*point*\_*name*. When the connection URL uses the HTTP URL moniker, you cannot use [protocol rollover](https://technet.microsoft.com/en-us/library/cc771761.aspx) in Windows Media Services, which selects the best streaming protocol given network conditions. Protocol rollover is initiated when you use the MMS URL moniker (mms://) in the connection URL.
- You must open the corresponding port in [Windows Firewall](https://technet.microsoft.com/en-us/network/bb545423.aspx).

For scenarios where you want to deliver a limited number of streams to clients on a temporary basis (for example, you want to broadcast a live event), changing the HTTP port for Windows Media Services can be an adequate solution. However, on a more permanent basis, consider assigning additional IP addresses to your network adapter (or install additional network adapters). You can then use the procedures later in this article to configure Windows Media Services and IIS to use separate IP address/port 80 pairs.

**To change the port that Windows Media Services uses for HTTP streaming**

1. In the Windows Media Services console tree, click the server for which you want to change the port allocated for HTTP streaming.

2. In the details pane, click the **Properties** tab.

3. In **Category**, click **Control protocol**.

4. In **Plug-in**, click **WMS HTTP Server Control Protocol**, and then click **Properties**.

5. In **Port selection**, click **Use other port**, and then type the port number you want to use in the space provided. HTTP port numbers can range from **1** to **65535**.

6. Click **OK** to apply the change.

7. In the details pane, in **Plug-in**, click **WMS HTTP Server Control Protocol**, and then click **Enable** to make the HTTP protocol available for streaming content from your Windows Media server.

<a id="ipaddress"></a>

## Change the IP address that Windows Media Services uses for HTTP streaming

If you try to enable HTTP streaming in Windows Media Services 2008 on a computer that has IIS 7 installed, you may receive the following error:

> **Error Code**: 0xC00D158B  
> **Error Text**: One usage of each socket address (protocol/network address/port) is permitted. Verify that other services (such as IIS) or applications are not attempting to use the same port and then try to enable the plug-in again.


By default, the HTTP Listener (HTTP.sys) for the default Web site in IIS 7 listens to all requests coming in on port 80 for all static IP addresses bound to the network adapter (site binding = http:\*:80:). The list of IP addresses that HTTP.sys listens to is called the *IP Listen list*. The IP addresses that Http.sys does not listen to are available for Windows Media Services to use. This section describes how to create unique static IP address/port 80 pairs for downloading and streaming using HTTP.

> [!NOTE]
> A computer typically contains a single network adapter that is assigned one unique static IP address for use with port 80. To share port 80 for downloading and streaming, at least two unique static IP addresses are required. Your Internet Service Provider (ISP) or network administrator can assign an additional static IP address to the adapter on your computer, or you can install an additional network adapter (with a unique static IP address) on the computer.


**To determine the IP addresses available for HTTP streaming**

1. In the Windows Media Services console tree, click the server for which you want to enable HTTP streaming.

2. In the details pane, click the **Properties** tab.

3. In **Category**, click **Control protocol**.

4. In **Plug-in**, click **WMS HTTP Server Control Protocol**, and then click **Properties**.

5. In **IP addresses**, view the list of IP addresses available to Windows Media Services in **Allow selected IP addresses to use this protocol**. Although many IP addresses may be displayed, including the loopback IP address (127.0.0.1)and local IPv6 IP addresses, you should see at least two static IP addresses that you can use for port 80 (one for downloading and the other for streaming).

**To specify the IP address for HTTP downloading**

1. From a command prompt, type the appropriate command to stop the following services:

- For Windows Media Services, type **net stop wmserver**
- For IIS, type **net stop w3svc**

2. From a command prompt, type the following: **netsh http add iplisten ipaddress=x.x.x.x** where **x.x.x.x** is the static IP address that you want the Web server to monitor for HTTP requests on port 80. The static IP address that you do not specify will be reserved for Windows Media Services.

3. From a command prompt, restart the services that you stopped in step 1:

- For IIS, type **net start w3svc**
- For Windows Media Services, type **net start wmserver**

**To specify the IP address for HTTP streaming**

> [!NOTE]
> Perform the previous procedure, which reserves an IP address for HTTP streaming first.


1. In the Windows Media Services console tree, click the server for which you want to enable HTTP streaming.

2. In the details pane, click the **Properties** tab.

3. In **Category**, click **Control protocol**.

4. In **Plug-in**, click **WMS HTTP Server Control Protocol**, and then click **Properties**.

5. In **IP addresses**, click **Allow selected IP addresses to use this protocol**.

6. Select the IP address that you reserved in the previous procedure for streaming content over port 80. Do not select the IP addresses that you added to the IP Listen list in the previous procedure; otherwise, the plug-in might go into an error state when it is enabled.

7. In **Port selection**, click **Use default port (80)**.

8. Click **OK** to apply the change.

9. In the details pane, in **Plug-in**, click **WMS HTTP Server Control Protocol**, and then click **Enable** to make the HTTP protocol available for streaming content from your Windows Media server using the new IP address.

Windows Media Services will stream digital media content over port 80 for the IP address selected in the WMS HTTP Server Control Protocol plug-in while HTTP.sys will handle all other HTTP requests over port 80 using the IP address that you added to the IP listen list.

<a id="related"></a>

## Related articles

This article discussed how to configure both Windows Media Services and IIS to use port 80 on a computer that is running Windows Server 2008. If you are running versions of this software on Windows Server 2003 or Windows 2000 Server, see the following articles for configuration instructions for those platforms.

- [How to set up Windows Media Services 9 Series to use HTTP streaming on port 80 with IIS 6.0 installed (KB328728)](https://technet.microsoft.com/en-us/network/bb545423.aspx). Applies to Windows Server 2003.
- [How to Run IIS 5.0 and Windows Media Services with HTTP Streaming Enabled (KB268585)](https://support.microsoft.com/kb/268585/). Applies to Windows 2000 Server.
  
  
[Discuss in IIS Forums](https://forums.iis.net/1145.aspx)