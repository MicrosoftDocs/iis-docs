---
title: ManifestReadyEventArgs.AdaptiveSource Property
TOCTitle: AdaptiveSource Property
ms:assetid: 89d49cea-c72f-478f-b9da-a12a23282080
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822769(v=VS.90)
ms:contentKeyID: 50079524
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# ManifestReadyEventArgs.AdaptiveSource Property

**Applies to:** Windows Store apps only

Gets the actual handler for the manifest ready event.

## Syntax

``` csharp
public AdaptiveSource AdaptiveSource { get; }
```

``` c++
public:
virtual property AdaptiveSource^ AdaptiveSource {
AdaptiveSource^ get () sealed;
}
```

``` jscript
final function get AdaptiveSource () : AdaptiveSource
```

## Property Value

The actual handler for the manifest ready event.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

