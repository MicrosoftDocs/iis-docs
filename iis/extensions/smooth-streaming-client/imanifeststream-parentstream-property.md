---
title: IManifestStream.ParentStream Property
TOCTitle: ParentStream Property
ms:assetid: c37eda53-90cc-4b67-a1bd-185b3e186581
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822830(v=VS.90)
ms:contentKeyID: 50079584
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- "cpp"
- jscript
---

# IManifestStream.ParentStream Property

**Applies to:** Windows Store apps only

Gets the parent stream of this stream.

## Syntax

```csharp
IManifestStream ParentStream { get; }
```

```cpp
property IManifestStream^ ParentStream {
IManifestStream^ get ();
}
```

```jscript
function get ParentStream () : IManifestStream
```

## Property Value

The parent stream of this stream.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

