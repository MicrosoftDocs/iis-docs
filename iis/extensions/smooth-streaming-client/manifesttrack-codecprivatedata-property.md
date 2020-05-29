---
title: ManifestTrack.CodecPrivateData Property
TOCTitle: CodecPrivateData Property
ms:assetid: 54a2f4e5-e1db-4cb1-9655-64977680b9f0
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822737(v=VS.90)
ms:contentKeyID: 50079492
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# ManifestTrack.CodecPrivateData Property

**Applies to:** Windows Store apps only

Gets the CodecPrivateData.

## Syntax

```csharp
public byte[] CodecPrivateData { get; }
```

```cpp
public:
virtual property array<unsigned char>^ CodecPrivateData {
array<unsigned char>^ get () sealed;
}
```

```jscript
final function get CodecPrivateData () : byte[]
```

## Property Value

The CodecPrivateData.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
