---
title: AdaptiveSourceManager.SetBufferDelaySec Method
TOCTitle: SetBufferDelaySec Method
ms:assetid: 3c7084a2-4270-4f87-bcb0-3bbcac268580
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822720(v=VS.90)
ms:contentKeyID: 50079475
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# AdaptiveSourceManager.SetBufferDelaySec Method

**Applies to:** Windows Store apps only

Sets the buffer delay in seconds before playback starts.

## Syntax

```csharp
public void SetBufferDelaySec(
float bufferDelaySec
)
```

```cpp
public:
virtual void SetBufferDelaySec(
[InAttribute] float bufferDelaySec
) sealed
```

```jscript
public final function SetBufferDelaySec(
bufferDelaySec : float
)
```

## Parameters

  - bufferDelaySec  
    The delay buffer size value in seconds. The value should be between 0.5 and 6. The default value is one second.

## Return Value

If the method succeeds, it returns S\_OK. Otherwise, it returns an HRESULT error code.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
