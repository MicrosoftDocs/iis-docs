---
title: IManifestTrack Interface.CodecPrivateData Property
TOCTitle: CodecPrivateData Property
ms:assetid: e9b3f56b-2a72-4ae0-8b41-cbe54df464ae
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822862(v=VS.90)
ms:contentKeyID: 50079616
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# IManifestTrack Interface.CodecPrivateData Property

**Applies to:** Windows Store apps only

Gets the CodecPrivateData.

## Syntax

```csharp
byte[] CodecPrivateData { get; }
```

```cpp
property array<unsigned char>^ CodecPrivateData {
array<unsigned char>^ get ();
}
```

```jscript
function get CodecPrivateData () : byte[]
```

## Property Value

The CodecPrivateData.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

