---
title: AdaptiveSourceManager.AdaptiveSourceClosedEvent Event
TOCTitle: AdaptiveSourceClosedEvent Event
ms:assetid: 5b610241-bcdf-45ae-8506-5bd604fe425a
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822740(v=VS.90)
ms:contentKeyID: 50079495
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
---

# AdaptiveSourceManager.AdaptiveSourceClosedEvent Event

**Applies to:** Windows Store apps only

Adds or removes a subscription to AdaptiveSourceClosedEvent events. Those events fire when the adaptive source is closed.

## Syntax

```csharp
public event AdaptiveSourceClosedEventHandler AdaptiveSourceClosedEvent
```

```cpp
public:
virtual  event AdaptiveSourceClosedEventHandler^ AdaptiveSourceClosedEvent {
void add (AdaptiveSourceClosedEventHandler^ value);
void remove (AdaptiveSourceClosedEventHandler^ value);
```

## Event information

|||
|--- |--- |
|Delegate|[AdaptiveSourceClosedEventHandler Delegate](adaptivesourceclosedeventhandler-delegate.md)|

## Remarks

Subscribing to events at the AdaptiveSourceManager level means that all AdaptiveSourceClosedEvent events from all AdaptiveSource objects will be handled by this event handler. If you want to differentiate the AdaptiveSources, you need to get the AdaptiveSource.Uri or listen to individual events under each AdaptiveSources object.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
