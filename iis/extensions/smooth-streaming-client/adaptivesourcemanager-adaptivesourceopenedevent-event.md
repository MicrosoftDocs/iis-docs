---
title: AdaptiveSourceManager.AdaptiveSourceOpenedEvent Event
TOCTitle: AdaptiveSourceOpenedEvent Event
ms:assetid: b77b4f93-3775-46ae-b986-ddc53e532400
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822816(v=VS.90)
ms:contentKeyID: 50079570
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
---

# AdaptiveSourceManager.AdaptiveSourceOpenedEvent Event

**Applies to:** Windows Store apps only

Adds or removes a subscription to AdaptiveSourceOpenedEvent events. Those events fire when the Adaptive Source is opened.

## Syntax

```csharp
public event AdaptiveSourceOpenedEventHandler AdaptiveSourceOpenedEvent
```

```cpp
public:
virtual  event AdaptiveSourceOpenedEventHandler^ AdaptiveSourceOpenedEvent {
void add (AdaptiveSourceOpenedEventHandler^ value);
void remove (AdaptiveSourceOpenedEventHandler^ value);
}
```

## Event information

|||
|--- |--- |
|Delegate|[AdaptiveSourceOpenedEventHandler Delegate](adaptivesourceopenedeventhandler-delegate.md)|

## Remarks

Subscribing to events at the AdaptiveSourceManager level means that all AdaptiveSourceOpenedEvent events from all AdaptiveSource objects will be handled by this event handler. If you want to differentiate the AdaptiveSources, you need to get the AdaptiveSource.Uri or listen to individual events under each AdaptiveSources object.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
