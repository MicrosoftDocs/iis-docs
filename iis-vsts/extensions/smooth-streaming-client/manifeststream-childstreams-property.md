---
title: ManifestStream.ChildStreams Property
TOCTitle: ChildStreams Property
ms:assetid: 5a4899ff-d440-423f-baa2-543c9ce634cf
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822739(v=VS.90)
ms:contentKeyID: 50079494
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# ManifestStream.ChildStreams Property

**Applies to:** Windows Store apps only

Gets the child (sparse) streams of this stream.

## Syntax

```csharp
public IVectorView<IManifestStream> ChildStreams { get; }
```

```cpp
public:
virtual property IVectorView<IManifestStream^>^ ChildStreams {
IVectorView<IManifestStream^>^ get () sealed;
}
```

```jscript
final function get ChildStreams () : IVectorView<IManifestStream>
```

## Property Value

The child (sparse) streams of this stream.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

