---
title: AdaptiveSourceStatusUpdatedEventHandler Delegate
TOCTitle: AdaptiveSourceStatusUpdatedEventHandler Delegate
ms:assetid: db96706d-4659-464f-8c04-43cc8f1a7277
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822844(v=VS.90)
ms:contentKeyID: 50079598
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# AdaptiveSourceStatusUpdatedEventHandler Delegate

**Applies to:** Windows Store apps only

The actual handler for the status updated event.

## Syntax

```csharp
[VersionAttribute()]
[GuidAttribute(, , , , , , , , , , )]
public delegate void AdaptiveSourceStatusUpdatedEventHandler(
AdaptiveSource sender,
AdaptiveSourceStatusUpdatedEventArgs args
)
```

```cpp
[VersionAttribute()]
[GuidAttribute(, , , , , , , , , , )]
public delegate void AdaptiveSourceStatusUpdatedEventHandler(
[InAttribute] AdaptiveSource^ sender, 
[InAttribute] AdaptiveSourceStatusUpdatedEventArgs^ args
)
```

```jscript
```

## Parameters

  - sender  
    Adaptive source this event belongs to

  - AdaptiveSourceStatusUpdatedEventArgs  
    Event arguments

## Return Value

If the method succeeds, it returns S\_OK. Otherwise, it returns an HRESULT error code.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

