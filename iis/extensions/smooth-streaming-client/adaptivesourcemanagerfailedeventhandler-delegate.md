---
title: AdaptiveSourceManagerFailedEventHandler Delegate
description: Learn how the AdaptiveSourceManagerFailedEventHandler delegate is the actual handler for the adaptive source manager failed event handler.
TOCTitle: AdaptiveSourceManagerFailedEventHandler Delegate
ms:assetid: 16ef48ff-cdfc-445d-8f84-cdc52cc5f575
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822683(v=VS.90)
ms:contentKeyID: 50079438
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
---

# AdaptiveSourceManagerFailedEventHandler Delegate

**Applies to:** Windows Store apps only

The actual handler for the adaptive source manager failed event handler.

## Syntax

```csharp
[GuidAttribute(, , , , , , , , , , )]
[VersionAttribute()]
public delegate void AdaptiveSourceManagerFailedEventHandler(
AdaptiveSourceManager sender,
AdaptiveSourceManagerFailedEventArgs args
)
```

```cpp
[GuidAttribute(, , , , , , , , , , )]
[VersionAttribute()]
public delegate void AdaptiveSourceManagerFailedEventHandler(
[InAttribute] AdaptiveSourceManager^ sender, 
[InAttribute] AdaptiveSourceManagerFailedEventArgs^ args
)
```

## Parameters

  - sender  
    Adaptive source manager this event belongs to

  - AdaptiveSourceManagerFailedEventArgs  
    Event arguments

## Return Value

If the method succeeds, it returns S\_OK. Otherwise, it returns an HRESULT error code.

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
