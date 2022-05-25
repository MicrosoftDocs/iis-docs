---
title: AdaptiveSourceManager.SetLiveBackoffSec Method
description: This article contains information about syntax, parameters, return value, and requirements for the AdaptiveSourceManager.SetLiveBackoffSec method.
TOCTitle: SetLiveBackoffSec Method
ms:assetid: 19691763-2ca4-471a-8ef1-eebb5b8e8f11
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822689(v=VS.90)
ms:contentKeyID: 50079444
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# AdaptiveSourceManager.SetLiveBackoffSec Method

**Applies to:** Windows Store apps only

Sets the seconds backed off from current live server time.

## Syntax

```csharp
public void SetLiveBackoffSec(
uint liveBackOffSec
)
```

```cpp
public:
virtual void SetLiveBackoffSec(
[InAttribute] unsigned int liveBackOffSec
) sealed
```

```jscript
public final function SetLiveBackoffSec(
liveBackOffSec : uint
)
```

## Parameters

  - liveBackOffSec  
    The back off time value in seconds. The value should be between zero and the value of downloadBufferSec. The default is 3 seconds.

  -  

## Return Value

If the method succeeds, it returns S\_OK. Otherwise, it returns an HRESULT error code.

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
