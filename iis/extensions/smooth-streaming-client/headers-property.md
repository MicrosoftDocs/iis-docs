---
title: Headers Property
description: This article contains information about syntax, property value, and requirements for the Headers property.
TOCTitle: Headers Property
ms:assetid: fff38b05-57c8-43fe-9542-820baa63c0f0
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822882(v=VS.90)
ms:contentKeyID: 50079636
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# Headers Property

**Applies to:** Windows Store apps only

Gets the headers.

## Syntax

```csharp
public IMapView<string, string> Headers { get; }
```

```cpp
public:
virtual property IMapView<String^, String^>^ Headers {
IMapView<String^, String^>^ get () sealed;
}
```

```jscript
final function get Headers () : IMapView<String, String>
```

## Property Value

The headers.

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
