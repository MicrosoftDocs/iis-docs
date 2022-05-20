---
title: DownloaderResponse.Cookies Property
TOCTitle: Cookies Property
description: Gets the cookies.
ms:assetid: 013b7696-7cc9-45db-b736-ce3b5916f7d3
ms:mtpsurl: https://msdn.microsoft.com/library/JJ851080(v=VS.90)
ms:contentKeyID: 50079419
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# DownloaderResponse.Cookies Property

**Applies to:** Windows Store apps only

Gets the cookies.

## Syntax

```csharp
public IVectorView<IHttpCookie> Cookies { get; }
```

```cpp
public:
virtual property IVectorView<IHttpCookie^>^ Cookies {
IVectorView<IHttpCookie^>^ get () sealed;
}
```

```jscript
final function get Cookies () : IVectorView<IHttpCookie>
```

## Property Value

The cookies.

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
