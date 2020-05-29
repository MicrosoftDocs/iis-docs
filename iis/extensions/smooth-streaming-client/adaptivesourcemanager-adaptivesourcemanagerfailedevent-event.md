---
title: AdaptiveSourceManager.AdaptiveSourceManagerFailedEvent Event
TOCTitle: AdaptiveSourceManagerFailedEvent Event
ms:assetid: 1c56fae3-c783-4385-bafb-833ccfb11455
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822692(v=VS.90)
ms:contentKeyID: 50079447
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
---

# AdaptiveSourceManager.AdaptiveSourceManagerFailedEvent Event

**Applies to:** Windows Store apps only

Adds or removes a subscription to AdaptiveSourceManagerFailedEvent events. Those events fire when the AdaptiveSourceManager event failed.

## Syntax

```csharp
public event AdaptiveSourceManagerFailedEventHandler AdaptiveSourceManagerFailedEvent
```

```cpp
public:
virtual  event AdaptiveSourceManagerFailedEventHandler ^ AdaptiveSourceManagerFailedEvent {
void add (AdaptiveSourceManagerFailedEventHandler ^ value);
void remove (AdaptiveSourceManagerFailedEventHandler ^ value);
}
```

## Event information

|||
|--- |--- |
|Delegate|[AdaptiveSourceManagerFailedEventHandler Delegate](adaptivesourcemanagerfailedeventhandler-delegate.md)|

## Remarks

Subscribing to events at the AdaptiveSourceManager level means that all AdaptiveSourceManagerFailedEvent events from all AdaptiveSource objects will be handled by this event handler. If you want to differentiate the AdaptiveSources, you need to get the AdaptiveSource.Uri or listen to individual events under each AdaptiveSources object.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
