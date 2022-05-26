---
title: StreamChangedResult.Stream Property
TOCTitle: Steam Property
description: "The StreamChangedResult.Stream property gets a stream that is selected or de-selected. This article describes its syntax, property value, and requirements."
ms:assetid: 5d5166cb-6096-4e81-9105-57594353134d
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822743(v=VS.90)
ms:contentKeyID: 50079498
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# StreamChangedResult.Stream Property

**Applies to:** Windows Store apps only

Gets a stream that is selected or de-selected.

## Syntax

```csharp
public IManifestStream Stream { get; }
```

```cpp
public:
virtual property IManifestStream^ Stream {
IManifestStream^ get () sealed;
}
```

```jscript
final function get Stream () : IManifestStreama
```

## Property Value

The stream that is selected or de-selected.

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
