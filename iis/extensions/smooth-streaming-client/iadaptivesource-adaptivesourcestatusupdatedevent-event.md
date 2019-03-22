---
title: IAdaptiveSource.AdaptiveSourceStatusUpdatedEvent Event
TOCTitle: AdaptiveSourceStatusUpdatedEvent Event
ms:assetid: d35f9a59-663d-491b-b387-65a287d766f0
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822839(v=VS.90)
ms:contentKeyID: 50079593
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
---

# IAdaptiveSource.AdaptiveSourceStatusUpdatedEvent Event

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

