---
title: PublishingPoint Element
TOCTitle: PublishingPoint Element
ms:assetid: 863b8bf0-67ba-4d6c-b7c4-28059d5ef9c1
ms:mtpsurl: https://msdn.microsoft.com/library/Hh547048(v=VS.90)
ms:contentKeyID: 37836889
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# PublishingPoint Element

The URL of a Live Smooth Streaming publishing point.

    <PublishingPoint credentialName="name">
      "publishingpointurl"
    </PublishingPoint>

### Attributes

|Attribute|Description|
|--- |--- |
|credentialName|Optional. The name of a credential on the server to use for connections to the publishing point.|

### Child Elements

None.

### Parent Element

[PublishingPoints Element](publishingpoints-element.md)

## Remarks

The publishing point can be either a Pull or Push publishing point, depending on the parent element.
