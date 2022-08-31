---
title: "Edge Caching for Media Delivery"
author: rick-anderson
description: "One of the advantages to using IIS Media Services is how well it integrates with the rest of the IIS Web platform. Edge caching using Application Request Rou..."
ms.date: 03/18/2009
ms.assetid: 81855ddc-e120-43e0-b2f4-8ac265261fec
msc.legacyurl: /learn/media/iis-media-services/edge-caching-for-media-delivery
msc.type: authoredcontent
---
# Edge Caching for Media Delivery

by [Chris Knowlton](https://twitter.com/chris_knowlton)

One of the advantages to using [IIS Media Services](https://www.iis.net/media "IIS Media Services") is how well it integrates with the rest of the IIS Web platform. Edge caching using [Application Request Routing](https://www.iis.net/downloads/microsoft/application-request-routing "Application Request Routing") is a great example of how the robust capabilities of IIS allow you to increase scalability, save money, and improve end user experiences when delivering audio and video.

## Edge Caching

Edge caching refers to the use of caching servers to store content closer to end users. For instance, if you visit a popular Web site and download some static content that gets cached, each subsequent user will get served that content directly from the caching server until it expires. Why is edge caching important?

Think of caching like the business of a publisher delivering an international newspaper. If all the printing were done in one location, the shipping costs to each subscriber would greatly reduce profits, and delays in receiving the paper would cause customers to cancel their subscriptions. In reality, most international newspapers send out one master "copy" to printing presses around the world, who then duplicate those newspapers and deliver them locally. These local printing presses probably print up several newspapers like this in a day, making maximum use of their facilities to increase profits. On the Web, caching servers are those local printing presses, delivering newspapers (Web content) from popular publishers (content producers) to many end users.

For content producers on the Internet, there are many options for adding edge caching to your delivery model. Many involve using Content Delivery Networks (CDNs) to take care of the all the steps between a content producer and their end users in exchange for fees based on the amount of data delivered. Geographically dispersed enterprises often build their own enterprise CDN (eCDN), use [Microsoft eCDN](/ecdn), or use a third-party eCDN primarily to reduce network congestion and costs across WAN links.

## Traditional Challenges for Media

The idea of edge caching is great for Web pages and other content delivered via HTTP. However, when it comes to media, especially for live events delivered with traditional streaming, a new layer of challenges gets introduced.

**Scale**. Especially for live events, media is traditionally delivered by relatively few dedicated streaming servers (typically 1 for every 10 or more HTTP edge caches) using non-standard protocols. Large events require special provisioning of streaming servers, and increasingly, even that is not enough. (Read [The Day the Internet Died](http://blog.broadcastengineering.com/brad/2009/01/28/the-day-the-internet-died/) to learn more.)

**Cost**. In terms of size, measured in bytes delivered, audio and video content is more like a 26-volume encyclopedia than a newspaper. To support that kind of throughput at scale results in significantly higher hardware and network capacity requirements.

**User Experience**. The previous challenges can result in poor user experiences – buffering, poor quality playback, hitting bandwidth caps.

## What IIS Offers

Built on an extensible architecture, IIS provides a powerful and highly flexible platform for delivering rich Web experiences, including:

**Media.** Unlike traditional streaming, IIS Media Services is focused on innovative new ways of delivering audio and video using standard HTTP. Two great examples of this are Smooth Streaming and Live Smooth Streaming, which deliver video that adapts to each end user's unique network and video rendering abilities to provide a compelling, uninterrupted viewing experience. These technologies use standard HTTP, and they deliver content in small cacheable fragments rather than in whole-file downloads or stateful streams. This means IIS edge caches and any downstream caches can keep re-using the same fragments as new requests come in, without needing to set up thousands of stateful streaming sessions per server.

**Caching &amp; Proxying.** Application Request Routing Version 2 for IIS (ARRv2) is a proxy-based HTTP request routing module with disk-based caching capabilities. This allows IIS to be a true edge caching server, with cache hierarchy management and support for the Cache Array Routing Protocol (CARP).

## Solving the Challenges

When put together, IIS Media Services and ARRv2 make a powerful edge caching combination for media. Recalling the challenges mentioned above, here is how IIS solves them…

**Scale**. If all of your HTTP edge caches are also now your media cache/proxy servers, you just increased your media delivery scale by about 10x, with no special media provisioning required, ever. ARR works with Smooth Streaming to simply cache and re-use the media fragments at the edge.

**Cost**. Eliminating the build-out and management of a non-standard-HTTP streaming server network is compelling by itself. Knowing that you can also increase your revenues by handling larger live events on your HTTP edge caching network should make you feel even better.

**User Experience**. With 10x scalability and uninterrupted playback that adapts to local conditions, your end users will have a great experience – and you'll be able to support a lot more of them.

## Summary

ARR and IIS Media Services provide a compelling Edge Caching solution that will keep your customers coming back for more. To learn more and try these IIS features today, follow the links below.

## Related Content

- [IIS Media Services](https://www.iis.net/media)
- [Integrated Media Platform](https://www.iis.net/overview/choice/integratedmediaplatform)
- [Application Request Routing](https://www.iis.net/downloads/microsoft/application-request-routing "Application Request Routing")
- [Application Request Routing Version 2](../../extensions/planning-for-arr/application-request-routing-version-2-overview.md)
- [Configure and enable disk cache in Application Request Routing](../../extensions/configuring-application-request-routing-arr/configure-and-enable-disk-cache-in-application-request-routing.md)
