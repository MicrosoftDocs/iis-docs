---
title: IManifestStream.GetIterator Method
TOCTitle: GetIterator Method
ms:assetid: 6f7a05a1-98ca-4aa4-941d-6c4f835ad830
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822757(v=VS.90)
ms:contentKeyID: 50079512
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# IManifestStream.GetIterator Method

**Applies to:** Windows Store apps only

Gets the last chunk iterator within the specified time range.

## Syntax

```csharp
IChunkIter GetIterator(
long minTime,
long time
)
```

```cpp
IChunkIter^ GetIterator(
[InAttribute] long long minTime, 
[InAttribute] long long time
)
```

```jscript
function GetIterator(
minTime : long, 
time : long
) : IChunkIter
```

## Parameters

  - minTime  
    Type: [Int64](https://msdn.microsoft.com/library/6yy583ek)

  - time  
    Type: [Int64](https://msdn.microsoft.com/library/6yy583ek)

## Return Value

If the method succeeds, it returns S\_OK. Otherwise, it returns an HRESULT error code.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

