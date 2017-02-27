---
title: "Smooth Streaming Transport Protocol | Microsoft Docs"
author: rick-anderson
description: "IIS Smooth Streaming , part of IIS Media Services , is Microsoft's adaptive streaming technology, based on the HTTP and MP4 file format standards. It deliver..."
ms.author: aspnetcontent
manager: wpickett
ms.date: 09/08/2009
ms.topic: article
ms.assetid: 
ms.technology: dotnet-webforms
ms.prod: .net-framework
msc.legacyurl: /learn/media/smooth-streaming/smooth-streaming-transport-protocol
msc.type: authoredcontent
---
Smooth Streaming Transport Protocol
====================
by John A. Bocharov

IIS Smooth Streaming, part of [IIS Media Services](https://www.iis.net/media), is Microsoft's adaptive streaming technology, based on the HTTP and MP4 file format standards. It delivers the highest quality, reliable online video experience for both on-demand content and live events. By utilizing standards-based HTTP to take advantage of massive existing HTTP caching resources, Smooth Streaming takes advantage of the scale of HTTP to provide full HD (up to 1080p) experiences to [Silverlight](https://www.microsoft.com/silverlight)-based media players.

The [IIS Smooth Streaming Transport Protocol Specification](https://go.microsoft.com/?linkid=9682896 "IIS Smooth Streaming Transport Protocol Specification") describes how live and on-demand Smooth Streaming audio/video content is distributed and cached over an HTTP network. This specification is being released under the Community Promise Initiative, so as to enable third parties who wish to build their own client implementations that interoperate with IIS Media Services.

Microsoft has ensured that the related [Protected Interoperable File Format (PIFF) specification](protected-interoperable-file-format.md "Protected Interoperable File Format (PIFF) specification") is compatible with the IIS Smooth Streaming Transport Protocol specification. It is particularly well suited for the creation, delivery, and protection of Smooth Streaming content.

The IIS Smooth Streaming Transport Protocol Specification includes the following topics:

> 1 Introduction
> 
> > 1.1 Glossary  
> > 1.2 References  
> > 1.3 Protocol Overview (Synopsis)  
> > 1.4 Relationship to other Protocols  
> > 1.5 Prerequisites/Preconditions  
> > 1.6 Applicability Statement  
> > 1.7 Versioning and Capability Negotiation  
> > 1.8 Vendor-Extensible Fields  
> > 1.9 Standards Assignments
> 
> 
> 2 Messages
> 
> > 2.1 Transport  
> > 2.2 Message Syntax
> 
> 
> 3 Protocol Details
> 
> > 3.1 Client Details  
> > 3.2 Server Details
> 
> 
> 4 Protocol Examples
> 
> 5 Security
> 
> > 5.1 Security Considerations for Implementers  
> > 5.2 Index of Security Parameters
> 
> 
> 6 Appendix A: Product Behavior
> 
> 7 Change Tracking


Click here to download the specification: [IIS Smooth Streaming Transport Protocol Specification](https://go.microsoft.com/?linkid=9682896 "IIS Smooth Streaming Transport Protocol Specification")
  
  
[Discuss in IIS Forums](https://forums.iis.net/1145.aspx)