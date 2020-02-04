---
title: AdaptiveSourceFailedEventHandler Delegate
TOCTitle: AdaptiveSourceFailedEventHandler Delegate
ms:assetid: debc6975-a965-488b-80bc-be84b77ac056
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822849(v=VS.90)
ms:contentKeyID: 50079603
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
---

# AdaptiveSourceFailedEventHandler Delegate

**Applies to:** Windows Store apps only

The actual handler for the failed event.

## Syntax

```csharp
[GuidAttribute(, , , , , , , , , , )]
[VersionAttribute()]
public delegate void AdaptiveSourceFailedEventHandler(
AdaptiveSource sender,
AdaptiveSourceFailedEventArgs args
)
```

```cpp
[GuidAttribute(, , , , , , , , , , )]
[VersionAttribute()]
public delegate void AdaptiveSourceFailedEventHandler(
[InAttribute] AdaptiveSource^ sender, 
[InAttribute] AdaptiveSourceFailedEventArgs^ args
)
```

## Parameters

  - sender  
    Adaptive source this event belongs to.

  - AdaptiveSourceFailedEventArgs  
    Event arguments.

## Return Value

If the method succeeds, it returns S\_OK. Otherwise, it returns an HRESULT error code.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

