---
title: IIS Smooth Streaming Client Manifest - ProtectionHeader Element
TOCTitle: <ProtectionHeader>
ms:assetid: cd963d56-b289-48ab-90b7-8e07ad6f2328
ms:mtpsurl: https://msdn.microsoft.com/library/Ee673439(v=VS.90)
ms:contentKeyID: 26179482
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IIS Smooth Streaming Client Manifest - ProtectionHeader Element

The ProtectionHeader element provides a content Protection System-specific header used by the client to enable playback.

[IIS Smooth Streaming Client Manifest - SmoothStreamingMedia Element](iis-smooth-streaming-client-manifest-smoothstreamingmedia-element.md)  
  [IIS Smooth Streaming Client Manifest - Protection Element](iis-smooth-streaming-client-manifest-protection-element.md)  

    <Protection>
    </Protection>

## Attributes and Elements

The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|--- |--- |
|**SystemID**|(Required) Identifies the content protection system used to provide playback capability.|

### Child Elements

None

### Parent Elements

|Element|Description|
|--- |--- |
|**Protection**|Container for content protection playback info|

## Remarks

The information in each ProtectionHeader element is targeted only to the Content Protection System identified by the SystemID attribute. This element allows the same capabilities for targeting a single presentation to multiple Content Protection Systems by use of multiple ProtectionHeader element, each targeted to a different System. The data is represented in Base64-encoded form, appropriate for inclusion in the XML-based [IIS Smooth Streaming Client Manifest Format](iis-smooth-streaming-client-manifest-format.md).

## See Also

### Reference

[IIS Smooth Streaming Client Manifest - SmoothStreamingMedia Element](iis-smooth-streaming-client-manifest-smoothstreamingmedia-element.md)

[IIS Smooth Streaming Client Manifest - Protection Element](iis-smooth-streaming-client-manifest-protection-element.md)
