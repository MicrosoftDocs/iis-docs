---
title: AdaptiveSourceManager.SetLiveBeginOffsetSec Method
TOCTitle: SetLiveBeginOffsetSec Method
ms:assetid: 5bf63905-3b78-4740-9df8-95cbb6b12661
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822742(v=VS.90)
ms:contentKeyID: 50079497
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# AdaptiveSourceManager.SetLiveBeginOffsetSec Method

**Applies to:** Windows Store apps only

Sets the seconds after first chunk to start playing at when tuning to left edge, when tuning to live.

## Syntax

```csharp
public void SetLiveBeginOffsetSec(
uint liveBeginOffsetSec
)
```

```cpp
public:
virtual void SetLiveBeginOffsetSec(
[InAttribute] unsigned int liveBeginOffsetSec
) sealed
```

```jscript
public final function SetLiveBeginOffsetSec(
liveBeginOffsetSec : uint
)
```

## Parameters

  - liveBeginOffsetSec  
    Type: System.UInt32

  - The begin offset value in seconds. The value should be between zero and the max value for a UInt32 data type; however, it should not exceed the DVR window length. The default value is 6 seconds.  

## Return Value

If the method succeeds, it returns S\_OK. Otherwise, it returns an HRESULT error code.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
