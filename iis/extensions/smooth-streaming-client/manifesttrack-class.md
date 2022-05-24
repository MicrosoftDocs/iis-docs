---
title: ManifestTrack Class
description: This article contains information about syntax, members, and requirements for the ManifestTrack class.
TOCTitle: ManifestTrack Class
ms:assetid: 9782a68b-91c3-4a9c-9a78-b2a73c5351cd
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822790(v=VS.90)
ms:contentKeyID: 50079544
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# ManifestTrack Class

**Applies to:** Windows Store apps only

The manifest track class.

## Syntax

```csharp
[VersionAttribute()]
public sealed class ManifestTrack : IManifestTrack
```

```cpp
[VersionAttribute()]
public ref class ManifestTrack sealed : IManifestTrack
```

```jscript
public final class ManifestTrack implements IManifestTrack
```

## Members

This class exposes the following members.

### Methods

|Method|Description|
|--- |--- |
|[GetAttribute](manifesttrack-getattribute-method.md)|Gets the track level attributes from the manifest.|
|[GetCustomAttribute](manifesttrack-getcustomattribute-method.md)|Gets the track level custom attributes from the manifest.|

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
