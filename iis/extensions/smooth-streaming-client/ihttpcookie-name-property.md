---
title: IHttpCookie.Name Property
TOCTitle: Name Property
description: "The IHttpCookie.Name property gets the name. This article describes its syntax, property value, and requirements."
ms:assetid: 6f2e3d49-ea0e-45f1-8cf7-3684dd2dcd8b
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822756(v=VS.90)
ms:contentKeyID: 50079511
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# IHttpCookie.Name Property

**Applies to:** Windows Store apps only

Gets the name.

## Syntax

```csharp
public string Name { get; set; }
```

```cpp
public:
virtual property String^ Name {
String^ get () sealed;
void set (String^ value) sealed;
}
```

```jscript
final function get Name () : String
final function set Name (value : String)
```

## Property Value

Type: [String](https://msdn.microsoft.com/library/s1wwdcbf)

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
