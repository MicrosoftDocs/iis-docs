---
title: ServerConnections Element
TOCTitle: ServerConnections Element
ms:assetid: be105438-17e3-4e1d-8af1-fb692c481f76
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Hh547059(v=VS.90)
ms:contentKeyID: 37836900
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# ServerConnections Element

Enables the publishing point to return live streams when they are requested by publishing points on other Live Smooth Streaming servers in a distributed network.

    <ServerConnections enabled="true|false">
       <SendEndOfStreamOnStop />
    </ServerConnections>

### Attributes

|Attribute|Description|
|--- |--- |
|enabled|Required. true to enable server connections; otherwise, false.|


### Child Elements

[SendEndOfStreamOnStop Element](sendendofstreamonstop-element.md)


### Parent Element

[Settings Element](settings-element.md)

### Example

    <ServerConnections enabled="true">
      <SendEndOfStreamOnStop>true</SendEndOfStreamOnStop>
    </ServerConnections>

