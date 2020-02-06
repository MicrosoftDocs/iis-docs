---
title: IManifestTrack Interface.GetAttribute Method
TOCTitle: GetAttribute Method
ms:assetid: 260ffd2a-e641-4f56-8c29-8013bb7393fe
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822705(v=VS.90)
ms:contentKeyID: 50079460
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# IManifestTrack Interface.GetAttribute Method

**Applies to:** Windows Store apps only

Gets the track level attributes from the manifest.

## Syntax

```csharp
string GetAttribute(
string name
)
```

```cpp
String^ GetAttribute(
[InAttribute] String^ name
)
```

```jscript
function GetAttribute(
name : String
) : String
```

## Parameters

  - name  
    Type: [String](https://msdn.microsoft.com/library/s1wwdcbf)

## Return Value

The track level attributes from the manifest.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

