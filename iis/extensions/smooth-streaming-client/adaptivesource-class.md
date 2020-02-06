---
title: AdaptiveSource Class
TOCTitle: AdaptiveSource Class
ms:assetid: a9628170-8425-4e70-98f9-26f255731f5c
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822807(v=VS.90)
ms:contentKeyID: 50079561
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# AdaptiveSource Class

**Applies to:** Windows Store apps only

Represents the list of opened adaptive sources.

## Syntax

```csharp
[VersionAttribute()]
[ActivatableAttribute()]
public sealed class AdaptiveSource : IAdaptiveSource
```

```cpp
[VersionAttribute()]
[ActivatableAttribute()]
public ref class AdaptiveSource sealed : IAdaptiveSource
```

```jscript
public final class AdaptiveSource implements IAdaptiveSource
```

## Members

This class exposes the following members.

### Properties

|Property|Description|
|--- |--- |
|[Manifest Property](adaptivesource-manifest-property.md)|Gets the manifest.|
|[Uri Property](adaptivesource-uri-property.md)|Gets the URI.|


### Events

|Event|Description|
|--- |--- |
|[AdaptiveSourceFailedEvent Event](adaptivesource-adaptivesourcefailedevent-event.md)|Occurs when the AdaptiveSource event failed.|
|[AdaptiveSourceStatusUpdatedEvent Event](adaptivesource-adaptivesourcestatusupdatedevent-event.md)|Occurs when the status of the adaptive source is updated.|
|[ManifestReadyEvent Event](adaptivesource-manifestreadyevent-event.md)|Occurs when the manifest is ready.|


## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|


