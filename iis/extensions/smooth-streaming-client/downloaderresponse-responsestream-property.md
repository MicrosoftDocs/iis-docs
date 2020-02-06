---
title: DownloaderResponse.ResponseStream Property
TOCTitle: ResponseStream Property
ms:assetid: b2c9c0dc-7ac7-4e90-bb99-b78fe62c48ff
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822811(v=VS.90)
ms:contentKeyID: 50079565
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# DownloaderResponse.ResponseStream Property

**Applies to:** Windows Store apps only

Gets the response stream.

## Syntax

```csharp
public IInputStream ResponseStream { get; }
```

```cpp
public:
virtual property IInputStream^ ResponseStream {
IInputStream^ get () sealed;
}
```

```jscript
final function get ResponseStream () : IInputStream
```

## Property Value

The response stream.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

