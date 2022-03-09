---
title: AdaptiveSourceOpenedEventHandler Delegate
TOCTitle: AdaptiveSourceOpenedEventHandler Delegate
ms:assetid: cc23564e-b381-44ba-bcd3-26f3cbcb5301
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822835(v=VS.90)
ms:contentKeyID: 50079589
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
---

# AdaptiveSourceOpenedEventHandler Delegate

**Applies to:** Windows Store apps only

The actual handler for the adaptive source opened event.

## Syntax

```csharp
[VersionAttribute()]
[GuidAttribute(, , , , , , , , , , )]
public delegate void AdaptiveSourceOpenedEventHandler(
AdaptiveSource sender,
AdaptiveSourceOpenedEventArgs args
)
```

```cpp
[VersionAttribute()]
[GuidAttribute(, , , , , , , , , , )]
public delegate void AdaptiveSourceOpenedEventHandler(
[InAttribute] AdaptiveSource^ sender, 
[InAttribute] AdaptiveSourceOpenedEventArgs^ args
)
```

## Parameters

  - sender  
    Adaptive source this event belongs to

  - AdaptiveSourceOpenedEventArgs  
    Event arguments

## Return Value

If the method succeeds, it returns S\_OK. Otherwise, it returns an HRESULT error code.

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
