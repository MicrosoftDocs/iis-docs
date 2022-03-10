---
title: AdaptiveSourceManager.AdaptiveSourceFailedEvent Event
TOCTitle: AdaptiveSourceFailedEvent Event
ms:assetid: ff921d34-f2d5-4688-977c-252f294ce636
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822880(v=VS.90)
ms:contentKeyID: 50079634
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
---

# AdaptiveSourceManager.AdaptiveSourceFailedEvent Event

**Applies to:** Windows Store apps only

Adds or removes a subscription to AdaptiveSourceFailedEvent events. Those events fire when the adaptive source has failed.

## Syntax

```csharp
public event AdaptiveSourceFailedEventHandler AdaptiveSourceFailedEvent
```

```cpp
public:
virtual  event AdaptiveSourceFailedEventHandler^ AdaptiveSourceFailedEvent {
void add (AdaptiveSourceFailedEventHandler^ value);
void remove (AdaptiveSourceFailedEventHandler^ value);
}
```

## Event information

|Type|Event|
|--- |--- |
|Delegate|[AdaptiveSourceFailedEventHandler Delegate](adaptivesourcefailedeventhandler-delegate.md)|

## Remarks

Subscribing to events at the AdaptiveSourceManager level means that all AdaptiveSourceFailedEvent events from all AdaptiveSource objects will be handled by this event handler. If you want to differentiate the AdaptiveSources, you need to get the AdaptiveSource.Uri or listen to individual events under each AdaptiveSources object.

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
