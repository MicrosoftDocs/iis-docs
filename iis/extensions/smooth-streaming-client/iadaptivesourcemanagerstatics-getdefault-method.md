---
title: IAdaptiveSourceManagerStatics.GetDefault Method
TOCTitle: GetDefault Method
ms:assetid: 9c5cdd6b-72c1-490f-870f-db85a9d1bc9f
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822792(v=VS.90)
ms:contentKeyID: 50079546
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# IAdaptiveSourceManagerStatics.GetDefault Method

**Applies to:** Windows Store apps only

Gets the source manager singleton.

## Syntax

```csharp
IAdaptiveSourceManager GetDefault()
```

```cpp
IAdaptiveSourceManager^ GetDefault()
```

```jscript
function GetDefault() : IAdaptiveSourceManager
```

## Parameters

  - ppAdaptiveSourceManager  
    The pointer to the source manager.

  -  

## Return Value

If the method succeeds, it returns S\_OK. Otherwise, it returns an HRESULT error code.

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
