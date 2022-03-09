---
title: AdaptiveSourceManager.ManifestReadyEvent Event
TOCTitle: ManifestReadyEvent Event
ms:assetid: c86cae95-9b84-45bd-8512-68183ceb72ec
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822833(v=VS.90)
ms:contentKeyID: 50079587
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
---

# AdaptiveSourceManager.ManifestReadyEvent Event

**Applies to:** Windows Store apps only

Adds or removes a subscription to ManifestReadyEvent events. Those events fire when the manifest is ready.

## Syntax

```csharp
public event ManifestReadyEventHandler ManifestReadyEvent
```

```cpp
public:
virtual  event ManifestReadyEventHandler^ ManifestReadyEvent {
void add (ManifestReadyEventHandler^ value);
void remove (ManifestReadyEventHandler^ value);
}
```

## Event information

|Type|Event|
|--- |--- |
|Delegate|[ManifestReadyEventHandler Delegate](manifestreadyeventhandler-delegate.md)|

## Remarks

Subscribing to events at the AdaptiveSourceManager level means that all ManifestReadyEvent events from all AdaptiveSource objects will be handled by this event handler. If you want to differentiate the AdaptiveSources, you need to get the AdaptiveSource.Uri or listen to individual events under each AdaptiveSources object.

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
