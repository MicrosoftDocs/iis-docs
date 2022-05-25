---
title: IStreamChangedResult.Stream Property
TOCTitle: Stream Property
description: Gets the stream that is selected or de-selected.
ms:assetid: d17fa187-f0fd-4302-a914-3604b9368204
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822838(v=VS.90)
ms:contentKeyID: 50079592
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# IStreamChangedResult.Stream Property

**Applies to:** Windows Store apps only

Gets the stream that is selected or de-selected

## Syntax

```csharp
IManifestStream Stream { get; }
```

```cpp
property IManifestStream^ Stream {
IManifestStream^ get ();
}
```

```jscript
function get Stream () : IManifestStream
```

## Property Value

The stream that is selected or de-selected.

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
