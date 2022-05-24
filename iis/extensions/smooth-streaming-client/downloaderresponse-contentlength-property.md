---
title: DownloaderResponse.ContentLength Property
description: "This article shares syntax, property value, and system requirements for the DownloaderResponse.ContentLength Property."
TOCTitle: ContentLength Property
ms:assetid: 06ec011f-1769-482d-8997-d92b89a338c9
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822670(v=VS.90)
ms:contentKeyID: 50079425
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# DownloaderResponse.ContentLength Property

**Applies to:** Windows Store apps only

Gets the content length.

## Syntax

```csharp
public ulong ContentLength { get; }
```

```cpp
public:
virtual property unsigned long long ContentLength {
unsigned long long get () sealed;
}
```

```jscript
final function get ContentLength () : ulong
```

## Property Value

The content length.

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
