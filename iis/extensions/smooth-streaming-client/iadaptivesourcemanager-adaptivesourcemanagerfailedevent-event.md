---
title: IAdaptiveSourceManager.AdaptiveSourceManagerFailedEvent Event
TOCTitle: AdaptiveSourceManagerFailedEvent Event
ms:assetid: 5f97ba70-027c-412c-84be-98bb841d25ed
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822747(v=VS.90)
ms:contentKeyID: 50079502
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
---

# IAdaptiveSourceManager.AdaptiveSourceManagerFailedEvent Event

**Applies to:** Windows Store apps only

Adds the adaptive source manager failed event handler.

## Syntax

``` csharp
event AdaptiveSourceManagerFailedEventHandler AdaptiveSourceManagerFailedEvent
```

``` c++
event AdaptiveSourceManagerFailedEventHandler^ AdaptiveSourceManagerFailedEvent {
void add (AdaptiveSourceManagerFailedEventHandler^ value);
void remove (AdaptiveSourceManagerFailedEventHandler^ value);
}
```

## Event information

|||
|--- |--- |
|Delegate|[AdaptiveSourceManagerFailedEventHandler Delegate](adaptivesourcemanagerfailedeventhandler-delegate.md)|


## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

