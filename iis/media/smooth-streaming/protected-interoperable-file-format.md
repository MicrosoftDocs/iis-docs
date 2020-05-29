---
title: "Protected Interoperable File Format"
description: "The Protected Interoperable File Format (PIFF) specification defines a standard multimedia file format for delivery and playback of multimedia content. It in..."
ms.date: 09/08/2009
ms.assetid: e7587892-9223-4ab5-8b65-16a43b12d841
msc.legacyurl: /learn/media/smooth-streaming/protected-interoperable-file-format
msc.type: authoredcontent
---
# Protected Interoperable File Format

by [Microsoft](https://github.com/Microsoft)

The [Protected Interoperable File Format (PIFF) specification](https://go.microsoft.com/?linkid=9682897 "Protected Interoperable File Format") defines a standard multimedia file format for delivery and playback of multimedia content. It includes the audio-video container, stream encryption, and metadata to support content delivery for multiple bit rate adaptive streaming, optionally using a standard encryption scheme capable of supporting multiple DRM systems.

[IIS Smooth Streaming](https://www.iis.net/downloads/microsoft/smooth-streaming "IIS Smooth Streaming") is a specific adaptive streaming technology for which PIFF is particularly well suited. Learn more about the related [Smooth Streaming Transport Protocol specification](smooth-streaming-transport-protocol.md "Smooth Streaming Transport Protocol specificatio").

PIFF provides a simple, efficient solution to the problem of DRM interoperability. It enables content to be encrypted once – rather than once per DRM technology used – for delivery in a variety of scenarios. PIFF is standards-based and provides new efficiencies in the creation and delivery of protected content.

> 1 Scope And Justification
>
> 2 References
>
> > 2.1 Normative References  
> > 2.2 Informational References
>
>
> 3 Terminology And Conventions
>
> > 3.1 Conventions  
> > 3.2 Terminology  
> > 3.3 Notation
>
>
> 4 Introduction
>
> 5 Protected Interoperable File Format (PIFF)
>
> > 5.1 PIFF File Structure  
> > 5.2 PIFF Constraints On ISO Base Media File Format  
> > 5.3 PIFF Extensions To ISO Base Media File Format  
> > 5.4 Decryption Flow Of A Protected PIFF File (Informative)
>
>
> 6 Encryption Of Track Level Data
>
> > 6.1 IV Handling  
> > 6.2 AVC Video Tracks – NAL Unit As The Basic Encryption Element  
> > 6.3 Non-AVC Encrypted Tracks – Sample As The Basic Encryption Element
>
>
> 7 Formatting Of UUID Data
>
> 8 Revision History

Click on the link to download version 1.1 of the specification, updated March 9, 2010: [Protected Interoperable File Format specification](https://go.microsoft.com/?linkid=9682897 "Protected Interoperable File Format").
