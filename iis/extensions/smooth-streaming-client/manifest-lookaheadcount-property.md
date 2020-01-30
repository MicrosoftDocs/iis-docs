---
title: Manifest.LookAheadCount Property
TOCTitle: LookAheadCount Property
ms:assetid: 8e0e38cc-99e6-464c-8860-0bd0aa1141dc
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822780(v=VS.90)
ms:contentKeyID: 50079534
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# Manifest.LookAheadCount Property

**Applies to:** Windows Store apps only

Gets the manifest 'LookAheadFragmentCount' field.

## Syntax

```csharp
public uint LookAheadCount { get; }
```

```cpp
public:
virtual property unsigned int LookAheadCount {
unsigned int get () sealed;
}
```

```jscript
final function get LookAheadCount () : uint
```

## Property Value

The manifest 'LookAheadFragmentCount' field.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

