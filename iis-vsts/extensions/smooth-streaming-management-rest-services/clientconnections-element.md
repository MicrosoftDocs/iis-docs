---
title: ClientConnections Element
TOCTitle: ClientConnections Element
ms:assetid: d106d15a-9b41-4d62-b52d-5fcec1c54558
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Hh547062(v=VS.90)
ms:contentKeyID: 37836903
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# ClientConnections Element

Enables the publishing point to return live streams when they are requested by clients.

    <ClientConnections enabled="true|false">
      <WindowLength />
      <LiveCacheLength />
      <ClientManifestVersion />
    </ClientConnections>

### Attributes

|Attribute|Description|
|--- |--- |
|enabled|Required. true to enable the publishing point to return live streams; otherwise, false.|


### Child Elements

[WindowLength Element](windowlength-element.md)  
[LiveCacheLength Element](livecachelength-element.md)  
[ClientManifestVersion Element](clientmanifestversion-element.md)

### Parent Element

[Settings Element](settings-element.md)

### Example

    <ClientConnections enabled="true">
      <ClientManifestVersion>2.0</ClientManifestVersion>
    </ClientConnections>

