---
title: RequestUri Property
TOCTitle: RequestUri Property
ms:assetid: f0c9b71d-227c-4f80-b438-36581e5bd79f
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822870(v=VS.90)
ms:contentKeyID: 50079624
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# RequestUri Property

**Applies to:** Windows Store apps only

Gets the original request URI.

## Syntax

``` csharp
public Uri RequestUri { get; }
```

``` c++
public:
virtual property Uri^ RequestUri {
Uri^ get () sealed;
}
```

``` jscript
final function get RequestUri () : Uri
```

## Property Value

The request URI.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

