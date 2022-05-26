---
title: ManifestStream.Name Property
TOCTitle: Name Property
description: "The ManifestStream.Name property gets the stream Name field. This article describes its syntax, property value, and requirements."
ms:assetid: fc98a5f8-fb3b-44f5-a9a0-a7ddabfed863
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822878(v=VS.90)
ms:contentKeyID: 50079632
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# ManifestStream.Name Property

**Applies to:** Windows Store apps only

Gets the stream 'Name' field.

## Syntax

```csharp
public string Name { get; }
```

```cpp
public:
virtual property String^ Name {
String^ get () sealed;
}
```

```jscript
final function get Name () : String
```

## Property Value

The stream 'Name' field.

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
