---
title: Manifest.Type Property
TOCTitle: Type Property
ms:assetid: bfc7c8b2-bb68-46c4-8ee6-0203b8485eb9
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822823(v=VS.90)
ms:contentKeyID: 50079577
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# Manifest.Type Property

**Applies to:** Windows Store apps only

Gets the manifest type.

## Syntax

```csharp
public ManifestType Type { get; }
```

```cpp
public: 
virtual property ManifestType Type {
ManifestType get () sealed; 
}
```

```jscript
final function get Type () : ManifestType
```

## Property Value

Type: [AdaptiveStreaming.ManifestType](manifesttype-enumeration.md)

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
