---
title: IAdaptiveSourceManager.SetDownloadBufferSec Method
TOCTitle: SetDownloadBufferSec Method
ms:assetid: 9cfd3bfa-0d75-467f-b4b2-d0920eccb3de
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822794(v=VS.90)
ms:contentKeyID: 50079548
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# IAdaptiveSourceManager.SetDownloadBufferSec Method

**Applies to:** Windows Store apps only

Sets the downloader buffer in seconds.

## Syntax

```csharp
void SetDownloadBufferSec(
float bufferSec
)
```

```cpp
void SetDownloadBufferSec(
[InAttribute] float bufferSec
)
```

```jscript
function SetDownloadBufferSec(
bufferSec : float
)
```

## Parameters

  - bufferSec  
    Download buffer size value.

  -  

## Return Value

If the method succeeds, it returns S\_OK. Otherwise, it returns an HRESULT error code.

## Requirements

|Category|Selection|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
