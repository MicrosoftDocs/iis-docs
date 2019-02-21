---
title: IAdaptiveSource.ManifestReadyEvent Event
TOCTitle: ManifestReadyEvent Event
ms:assetid: 8bfe927b-9bc7-47b8-a8af-9c976831ff75
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822776(v=VS.90)
ms:contentKeyID: 50079531
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- "cpp"
---

# IAdaptiveSource.ManifestReadyEvent Event

**Applies to:** Windows Store apps only

Adds the manifest ready event handler.

## Syntax

```csharp
event ManifestReadyEventHandler ManifestReadyEvent
```

```cpp
event ManifestReadyEventHandler^ ManifestReadyEvent {
void add (ManifestReadyEventHandler^ value);
void remove (ManifestReadyEventHandler^ value);
}
```

## Event information

|||
|--- |--- |
|Delegate|[ManifestReadyEventHandler Delegate](manifestreadyeventhandler-delegate.md)|


## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

