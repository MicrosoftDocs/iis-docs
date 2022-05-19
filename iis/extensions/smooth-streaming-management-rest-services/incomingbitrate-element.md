---
title: IncomingBitRate Element
TOCTitle: IncomingBitRate Element
description: "Specifies the rate, in bits per second, that the live source sends the track data to the publishing point."
ms:assetid: d1ac089c-220b-474d-ab68-11911dc8736a
ms:mtpsurl: https://msdn.microsoft.com/library/Hh547063(v=VS.90)
ms:contentKeyID: 37836904
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IncomingBitRate Element

Specifies the incoming bit rate setting of the track, in bits per second (bps).

```xml
<IncomingBitRate>
  "rate"
</IncomingBitRate>
```

### Child Elements

None.

### Parent Element

[Track Element](track-element.md)

## Remarks

This is the rate at which the live source sends the track data to the publishing point. The value varies slightly from the actual encoded bit rate due to network conditions.
