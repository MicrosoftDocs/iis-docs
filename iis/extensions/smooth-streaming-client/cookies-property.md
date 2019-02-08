---
title: Cookies Property
TOCTitle: Cookies Property
ms:assetid: 2150049e-946d-4de2-ba4e-f8a92c7d6c54
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822701(v=VS.90)
ms:contentKeyID: 50079456
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# Cookies Property

**Applies to:** Windows Store apps only

Gets the potential cookie information.

## Syntax

``` csharp
public IVectorView<IHttpCookie> Cookies { get; }
```

``` c++
public:
virtual property IVectorView<IHttpCookie^>^ Cookies {
IVectorView<IHttpCookie^>^ get () sealed;
}
```

``` jscript
final function get Cookies () : IVectorView<IHttpCookie>
```

## Property Value

The potential cookie information.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

