---
title: IAdaptiveSourceManager.SetLiveBeginOffsetSec Method
description: Describes the IAdaptiveSourceManager.SetLiveBeginOffsetSec method and provides the method's syntax, parameters, return value, and requirements.
TOCTitle: SetLiveBeginOffsetSec Method
ms:assetid: 6a33c1cc-8cf9-41b2-befa-bb80b3b80949
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822755(v=VS.90)
ms:contentKeyID: 50079510
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# IAdaptiveSourceManager.SetLiveBeginOffsetSec Method

**Applies to:** Windows Store apps only

Sets the seconds after first chunk to start playing at when tuning to left edge, when tuning to live.

## Syntax

```csharp
void SetLiveBeginOffsetSec(
uint liveBeginOffsetSec
)
```

```cpp
void SetLiveBeginOffsetSec(
[InAttribute] unsigned int liveBeginOffsetSec
)
```

```jscript
function SetLiveBeginOffsetSec(
liveBeginOffsetSec : uint
)
```

## Parameters

  - liveBeginOffsetSec  
    Begin offset value.

## Return Value

If the method succeeds, it returns S\_OK. Otherwise, it returns an HRESULT error code.

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
