---
title: IncomingFragmentTimeStamp Element
TOCTitle: IncomingFragmentTimeStamp Element
ms:assetid: d582e33f-a7e8-4f80-80a3-d0113e27164f
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Hh547064(v=VS.90)
ms:contentKeyID: 37836905
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IncomingFragmentTimeStamp Element

Specifies the timestamp of the last fragment that was received for the track.

    <IncomingFragmentTimeStamp>
      "timestamp"
    </IncomingFragmentTimeStamp>

### Child Elements

None.

### Parent Element

[Track Element](track-element.md)


## Remarks

The timestamp value is a fragment-level metadata value and is measured in timescale units of the encoder, typically 100-nanosecond (ns) increments. The encoder creates the timestamp in each fragment header.

