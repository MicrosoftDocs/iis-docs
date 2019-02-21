---
title: Manifest.SelectedStreams Property
TOCTitle: SelectedStreams Property
ms:assetid: 5201803e-d8bf-44e8-b34d-95c86d88f305
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822735(v=VS.90)
ms:contentKeyID: 50079490
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- "cpp"
- jscript
---

# Manifest.SelectedStreams Property

**Applies to:** Windows Store apps only

Gets the selected streams.

## Syntax

```csharp
public IVectorView<IManifestStream> SelectedStreams { get; }
```

```cpp
public:
virtual property IVectorView<IManifestStream^>^ SelectedStreams {
IVectorView<IManifestStream^>^ get () sealed;
}
```

```jscript
final function get SelectedStreams () : IVectorView<IManifestStream>
```

## Property Value

The selected streams.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

