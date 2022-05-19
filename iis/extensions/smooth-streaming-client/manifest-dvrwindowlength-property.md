---
title: Manifest.DVRWindowLength Property
TOCTitle: DVRWindowLength Property
description: "Manifest.DVRWindowLength property gets the manifest DVRWindowLength field. This article describes its syntax, property value, and requirements."
ms:assetid: 8adfc663-46e2-4f60-9ad5-8ba4d905a619
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822771(v=VS.90)
ms:contentKeyID: 50079526
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# Manifest.DVRWindowLength Property

**Applies to:** Windows Store apps only

Gets the manifest 'DVRWindowLength' field.

## Syntax

```csharp
public long DVRWindowLength { get; }
```

```cpp
public:
virtual property long long DVRWindowLength {
long long get () sealed;
}
```

```jscript
final function get DVRWindowLength () : long
```

## Property Value

The manifest 'DVRWindowLength' field.

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
