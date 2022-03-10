---
title: AdaptiveSource.ManifestReadyEvent Event
TOCTitle: ManifestReadyEvent Event
ms:assetid: 0de1bf24-1507-4a3d-a275-e8b715fd7026
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822678(v=VS.90)
ms:contentKeyID: 50079433
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
---

# AdaptiveSource.ManifestReadyEvent Event

**Applies to:** Windows Store apps only

Occurs when the manifest is ready.

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
|Delegate|ManifestReadyEventHandler|

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
