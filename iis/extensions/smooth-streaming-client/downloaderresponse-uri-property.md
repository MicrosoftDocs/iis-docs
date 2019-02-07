---
title: DownloaderResponse.Uri Property
TOCTitle: Uri Property
ms:assetid: 96aab3f5-03e6-4479-82c2-56393cd14086
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822788(v=VS.90)
ms:contentKeyID: 50079542
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# DownloaderResponse.Uri Property

**Applies to:** Windows Store apps only

Gets the uri for the response.

## Syntax

``` csharp
public Uri Uri { get; }
```

``` c++
public:
virtual property Uri^ Uri {
Uri^ get () sealed;
}
```

``` jscript
final function get Uri () : Uri
```

## Property Value

Type: Uri. The URI, which may be original or modified.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

