---
title: IAdaptiveSourceManager.ManifestReadyEvent Event
TOCTitle: ManifestReadyEvent Event
ms:assetid: 8b74b85d-6a03-4c6d-bd43-7287487ddb35
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822774(v=VS.90)
ms:contentKeyID: 50079529
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
---

# IAdaptiveSourceManager.ManifestReadyEvent Event

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
|**Metadata**|SSMFSourceplugin.idl|


