---
title: AdaptiveSource.AdaptiveSourceStatusUpdatedEvent Event
TOCTitle: AdaptiveSourceStatusUpdatedEvent Event
ms:assetid: 89b0d5a7-926f-4136-b771-5d5a544b23ad
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822768(v=VS.90)
ms:contentKeyID: 50079523
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
---

# AdaptiveSource.AdaptiveSourceStatusUpdatedEvent Event

**Applies to:** Windows Store apps only

Occurs when the status of the adaptive source is updated.

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

|Type|Event|
|--- |--- |
|Delegate|AdaptiveSourceStatusUpdatedEventHandler|

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
