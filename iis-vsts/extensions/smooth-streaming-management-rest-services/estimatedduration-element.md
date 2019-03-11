---
title: EstimatedDuration Element
TOCTitle: EstimatedDuration Element
ms:assetid: c4281a2c-9d44-413c-9f79-62402a355427
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Hh547060(v=VS.90)
ms:contentKeyID: 37836901
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# EstimatedDuration Element

An xs:duration value that specifies the estimated duration of the live stream.

    <EstimatedDuration>
      "duration"
    </EstimatedDuration>

## Child Elements

None.

## Parent Element

[Settings Element](settings-element.md)

## Remarks

The duration is specified using a format like "PT1H15M30.5S". A client's seek bars are scaled according to this value.

