---
title: IAdaptiveSourceManager.AdaptiveSourceStatusUpdatedEvent Event
TOCTitle: AdaptiveSourceStatusUpdatedEvent Event
ms:assetid: 9368d96a-29ec-48e1-9eaa-4fb7b0fd0b67
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822785(v=VS.90)
ms:contentKeyID: 50079539
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
---

# IAdaptiveSourceManager.AdaptiveSourceStatusUpdatedEvent Event

**Applies to:** Windows Store apps only

Adds the status updated event handler.

## Syntax

```csharp
event AdaptiveSourceStatusUpdatedEventHandler AdaptiveSourceStatusUpdatedEvent
```

```cpp
event AdaptiveSourceStatusUpdatedEventHandler^ AdaptiveSourceStatusUpdatedEvent {
void add (AdaptiveSourceStatusUpdatedEventHandler^ value);
void remove (AdaptiveSourceStatusUpdatedEventHandler^ value);
}
```

## Event information

|||
|--- |--- |
|Delegate|[AdaptiveSourceStatusUpdatedEventHandler Delegate](adaptivesourcestatusupdatedeventhandler-delegate.md)|

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
