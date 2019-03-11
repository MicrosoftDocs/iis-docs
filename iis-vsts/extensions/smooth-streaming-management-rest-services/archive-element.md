---
title: Archive Element
TOCTitle: Archive Element
ms:assetid: af2f9adb-07d8-4c60-9bc4-036dbbe08577
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Hh547057(v=VS.90)
ms:contentKeyID: 37836898
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Archive Element

Enables archiving of live streams to on-demand Smooth Streaming presentations.

    <Archive enabled="true|false">
      <SegmentLength />
      <Path />
    </Archive>

## Attributes

|Attribute|Description|
|--- |--- |
|enabled|Required. true to enable archiving of live streams to on-demand Smooth Streaming presentations; otherwise, false.|


## Child Elements

[SegmentLength Element](segmentlength-element.md)  
[Path Element](path-element.md)


## Parent Element

[Settings Element](settings-element.md)


## Example

    <Archive enabled="true">
      <Path useEventIdOnPath="false" />
    </Archive>

