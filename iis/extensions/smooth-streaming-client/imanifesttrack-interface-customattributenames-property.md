---
title: IManifestTrack Interface.CustomAttributeNames Property
TOCTitle: CustomAttributeNames Property
ms:assetid: 08043f81-e8bb-4e50-9614-b05abdee82b7
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822672(v=VS.90)
ms:contentKeyID: 50079427
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# IManifestTrack Interface.CustomAttributeNames Property

**Applies to:** Windows Store apps only

Gets the track level custom attributes names.

## Syntax

```csharp
IVectorView<string> CustomAttributeNames { get; }
```

```cpp
property IVectorView<String^>^ CustomAttributeNames {
IVectorView<String^>^ get ();
}
```

```jscript
function get CustomAttributeNames () : IVectorView<String>
```

## Property Value

The track level custom attributes names.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

