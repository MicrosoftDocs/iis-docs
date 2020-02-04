---
title: AdaptiveSourceManager.AdaptiveSourceStatusUpdatedEvent Event
TOCTitle: AdaptiveSourceStatusUpdatedEvent Event
ms:assetid: fa8b8e57-c632-45b5-b9da-c65e5bc271de
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822875(v=VS.90)
ms:contentKeyID: 50079629
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
---

# AdaptiveSourceManager.AdaptiveSourceStatusUpdatedEvent Event

**Applies to:** Windows Store apps only

Adds or removes a subscription to AdaptiveSourceStatusUpdatedEvent events. Those events fire when the adaptive source status is updated.

## Syntax

```csharp
public event AdaptiveSourceStatusUpdatedEventHandler AdaptiveSourceStatusUpdatedEvent
```

```cpp
public:
virtual  event AdaptiveSourceStatusUpdatedEventHandler^ AdaptiveSourceStatusUpdatedEvent {
void add (AdaptiveSourceStatusUpdatedEventHandler^ value);
void remove (AdaptiveSourceStatusUpdatedEventHandler^ value);
}
```

## Event information

|||
|--- |--- |
|Delegate|[AdaptiveSourceStatusUpdatedEventHandler Delegate](adaptivesourcestatusupdatedeventhandler-delegate.md)|


## Remarks

Subscribing to events at the AdaptiveSourceManager level means that all AdaptiveSourceStatusUpdatedEvent events from all AdaptiveSource objects will be handled by this event handler. If you want to differentiate the AdaptiveSources, you need to get the AdaptiveSource.Uri or listen to individual events under each AdaptiveSources object.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

