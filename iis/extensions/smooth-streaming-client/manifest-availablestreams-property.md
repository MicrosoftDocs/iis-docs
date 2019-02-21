---
title: Manifest.AvailableStreams Property
TOCTitle: AvailableStreams Property
ms:assetid: cb531c1a-55e3-43d9-851f-3839dd53b3a6
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822834(v=VS.90)
ms:contentKeyID: 50079588
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# Manifest.AvailableStreams Property

**Applies to:** Windows Store apps only

Gets the available streams.

## Syntax

```csharp
public IVectorView<IManifestStream> AvailableStreams { get; }
```

```cpp
public:
virtual property IVectorView<IManifestStream^>^ AvailableStreams {
IVectorView<IManifestStream^>^ get () sealed;
}
```

```jscript
final function get AvailableStreams () : IVectorView<IManifestStream>
```

## Property Value

Type: IVectorView(IManifestStream)

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

