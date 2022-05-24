---
title: IAdaptiveSourceManager.AdaptiveSourceFailedEvent Event
description: Describes the IAdaptiveSourceManager.AdaptiveSourceFailedEvent event and provides the event's syntax, event information, and requirements.
TOCTitle: AdaptiveSourceFailedEvent Event
ms:assetid: 6719debe-d6c9-4be3-84ca-1fe1b2837f82
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822753(v=VS.90)
ms:contentKeyID: 50079508
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
---

# IAdaptiveSourceManager.AdaptiveSourceFailedEvent Event

**Applies to:** Windows Store apps only

Adds the failed event handler.

## Syntax

```csharp
event AdaptiveSourceFailedEventHandler AdaptiveSourceFailedEvent
```

```cpp
event AdaptiveSourceFailedEventHandler^ AdaptiveSourceFailedEvent {
void add (AdaptiveSourceFailedEventHandler^ value);
void remove (AdaptiveSourceFailedEventHandler^ value);
}
```

## Event information

|Type|Event|
|--- |--- |
|Delegate|[AdaptiveSourceFailedEventHandler Delegate](adaptivesourcefailedeventhandler-delegate.md)|

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
