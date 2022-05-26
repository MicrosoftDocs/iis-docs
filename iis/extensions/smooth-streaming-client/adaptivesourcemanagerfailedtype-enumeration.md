---
title: AdaptiveSourceManagerFailedType Enumeration
description: Learn how the AdaptiveSourceManagerFailedType enumeration represents the adaptive source manager failed type enumeration.
TOCTitle: AdaptiveSourceManagerFailedType Enumeration
ms:assetid: 8b35b3ed-32a7-4451-a2c7-57cf70d68b11
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822773(v=VS.90)
ms:contentKeyID: 50079528
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# AdaptiveSourceManagerFailedType Enumeration

**Applies to:** Windows Store apps only

Represents the adaptive source manager failed type enumeration.

## Syntax

```csharp
[VersionAttribute()]
public enum AdaptiveSourceManagerFailedType
```

```cpp
[VersionAttribute()]
public enum class AdaptiveSourceManagerFailedType
```

```jscript
public enum AdaptiveSourceManagerFailedType
```

## Enumeration Values

|Name|Value|Description|
|--- |--- |--- |
|Unknown|100|Generic error.|
|SetDownloadBufferFailed|200|The download buffer failed.|
|SetBufferDelayFailed|201|The buffer delay failed.|
|SetLiveBackoffFailed|202|The live back off failed.|
|SetPlaybackOffsetFailed|203|The playback off set failed.|
|SetLiveBeginOffsetFailed|204|The live begin off set failed.|

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
