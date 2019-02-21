---
title: AdaptiveSourceManager.SetDownloaderPlugin Method
TOCTitle: SetDownloaderPlugin Method
ms:assetid: 0f7821a0-3edc-46c1-bd82-0ca4487ae1c9
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822680(v=VS.90)
ms:contentKeyID: 50079435
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- "cpp"
- jscript
---

# AdaptiveSourceManager.SetDownloaderPlugin Method

**Applies to:** Windows Store apps only

Sets the downloader plugin.

## Syntax

```csharp
public void SetDownloaderPlugin(
IDownloaderPlugin pPlugin
)
```

```cpp
public:
virtual void SetDownloaderPlugin(
[InAttribute] IDownloaderPlugin^ pPlugin
) sealed
```

```jscript
public final function SetDownloaderPlugin(
pPlugin : IDownloaderPlugin
)
```

## Parameters

  - pPlugin  
    The pointer to downloader plugin.

## Return Value

If the method succeeds, it returns S\_OK. Otherwise, it returns an HRESULT error code.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

