---
title: IAdaptiveSourceManager.AdaptiveSourceOpenedEvent Event
TOCTitle: AdaptiveSourceOpenedEvent Event
ms:assetid: 0a53331b-023c-4c9e-b8f8-d491f2d49d77
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822674(v=VS.90)
ms:contentKeyID: 50079429
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
---

# IAdaptiveSourceManager.AdaptiveSourceOpenedEvent Event

**Applies to:** Windows Store apps only

Specifies the adaptive source opened event handler.

## Syntax

```csharp
event AdaptiveSourceOpenedEventHandler AdaptiveSourceOpenedEvent
```

```cpp
event AdaptiveSourceOpenedEventHandler^ AdaptiveSourceOpenedEvent {
void add (AdaptiveSourceOpenedEventHandler^ value);
void remove (AdaptiveSourceOpenedEventHandler^ value);
}
```

## Event information

|Type|Event|
|--- |--- |
|Delegate|[AdaptiveSourceOpenedEventHandler Delegate](adaptivesourceopenedeventhandler-delegate.md)|

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
