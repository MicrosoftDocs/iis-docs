---
title: Archive Element
description: Describes the Archive element and details its attributes, child elements, parent elements, and code example.
TOCTitle: Archive Element
ms:assetid: af2f9adb-07d8-4c60-9bc4-036dbbe08577
ms:mtpsurl: https://msdn.microsoft.com/library/Hh547057(v=VS.90)
ms:contentKeyID: 37836898
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Archive Element

Enables archiving of live streams to on-demand Smooth Streaming presentations.

```xml
<Archive enabled="true|false">
  <SegmentLength />
  <Path />
</Archive>
```

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

```xml
<Archive enabled="true">
  <Path useEventIdOnPath="false" />
</Archive>
```
