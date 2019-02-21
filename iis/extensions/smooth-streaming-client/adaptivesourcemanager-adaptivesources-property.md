---
title: AdaptiveSourceManager.AdaptiveSources Property
TOCTitle: AdaptiveSources Property
ms:assetid: 4876a0b2-6da2-41d3-a8de-f122335bfc2f
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822727(v=VS.90)
ms:contentKeyID: 50079482
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- "cpp"
- jscript
---

# AdaptiveSourceManager.AdaptiveSources Property

**Applies to:** Windows Store apps only

Gets the list of opened adaptive sources.

## Syntax

```csharp
public IVectorView<IAdaptiveSource> AdaptiveSources { get; }
```

```cpp
public:
virtual property IVectorView<IAdaptiveSource^>^ AdaptiveSources {
IVectorView<IAdaptiveSource^>^ get () sealed;
}
```

```jscript
final function get AdaptiveSources () : IVectorView<IAdaptiveSource>
```

## Property Value

The list of opened adaptive sources.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

