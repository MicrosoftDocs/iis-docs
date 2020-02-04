---
title: IAdaptiveSource.AdaptiveSourceFailedEvent Event
TOCTitle: AdaptiveSourceFailedEvent Event
ms:assetid: 3a38a94d-34a1-4f1b-927f-b0d9cc7c0105
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822719(v=VS.90)
ms:contentKeyID: 50079474
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
---

# IAdaptiveSource.AdaptiveSourceFailedEvent Event

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

|||
|--- |--- |
|Delegate|[AdaptiveSourceManagerFailedEventHandler Delegate](adaptivesourcemanagerfailedeventhandler-delegate.md)|


## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

