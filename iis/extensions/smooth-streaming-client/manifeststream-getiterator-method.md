---
title: ManifestStream.GetIterator Method
TOCTitle: GetIterator Method
description: Gets the last chunk iterator within the specified time range.
ms:assetid: 73aa4861-e973-48bb-a4d4-67b233875c42
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822758(v=VS.90)
ms:contentKeyID: 50079513
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# ManifestStream.GetIterator Method

**Applies to:** Windows Store apps only

Gets the last chunk iterator within the specified time range.

## Syntax

```csharp
public IChunkIter GetIterator(
long minTime,
long time
)
```

```cpp
public:
virtual IChunkIter^ GetIterator(
[InAttribute] long long minTime, 
[InAttribute] long long time
) sealed
```

```jscript
public final function GetIterator(
minTime : long, 
time : long
) : IChunkIter
```

## Parameters

  - minTime  
    Type: System.Int64

  - time  
    Type: System.Int64

## Return Value

If the method succeeds, it returns S\_OK. Otherwise, it returns an HRESULT error code.

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
