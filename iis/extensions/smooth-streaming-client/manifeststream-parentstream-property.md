---
title: ManifestStream.ParentStream Property
TOCTitle: ParentStream Property
ms:assetid: 12414628-3a17-4353-9b3b-32b11a4dfd46
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822681(v=VS.90)
ms:contentKeyID: 50079436
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# ManifestStream.ParentStream Property

Gets the parent stream of this stream. This stream is typically a sparse stream.

## Syntax

```csharp
public IManifestStream ParentStream { get; }
```

```cpp
public:
virtual property IManifestStream^ ParentStream {
IManifestStream^ get () sealed;
}
```

```jscript
final function get ParentStream () : IManifestStream
```

## Property Value

The parent stream of this stream. This stream is typically a sparse stream.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

