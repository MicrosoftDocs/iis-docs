---
title: IAdaptiveSourceManager.SetDownloaderPlugin Method
TOCTitle: SetDownloaderPlugin Method
ms:assetid: 438b7531-f6b0-4ad3-b3f0-09b212f0433e
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822724(v=VS.90)
ms:contentKeyID: 50079479
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# IAdaptiveSourceManager.SetDownloaderPlugin Method

**Applies to:** Windows Store apps only

Sets the downloader plugin.

## Syntax

```csharp
void SetDownloaderPlugin(
IDownloaderPlugin pPlugin
)
```

```cpp
void SetDownloaderPlugin(
[InAttribute] IDownloaderPlugin^ pPlugin
)
```

```jscript
function SetDownloaderPlugin(
pPlugin : IDownloaderPlugin
)
```

## Parameters

  - pPlugin  
    Pointer to downloader plugin.

  -  

## Return Value

If the method succeeds, it returns S\_OK. Otherwise, it returns an HRESULT error code.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
