---
title: AdaptiveSourceManager.SetDownloadBufferSec Method
TOCTitle: SetDownloadBufferSec Method
ms:assetid: dfd4f31a-248b-4db9-b556-441f33865582
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822850(v=VS.90)
ms:contentKeyID: 50079604
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- "cpp"
- jscript
---

# AdaptiveSourceManager.SetDownloadBufferSec Method

**Applies to:** Windows Store apps only

Sets the downloader buffer in seconds.

## Syntax

```csharp
public void SetDownloadBufferSec(
float bufferSec
)
```

```cpp
public:
virtual void SetDownloadBufferSec(
[InAttribute] float bufferSec
) sealed
```

```jscript
public final function SetDownloadBufferSec(
bufferSec : float
)
```

## Parameters

  - bufferSec  
    The download buffer size value in seconds. The value should be between 6 and 60. The default is 30 seconds.

## Return Value

If the method succeeds, it returns S\_OK. Otherwise, it returns an HRESULT error code.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

