---
title: IManifestTrack Interface.GetCustomAttribute Method
description: Describes the IManifestTrack Interface.GetCustomAttribute method and provides the method's syntax, parameters, return value, and requirements.
TOCTitle: GetCustomAttribute Method
ms:assetid: 65e59412-e7f9-4d26-954f-8d803ce347d2
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822752(v=VS.90)
ms:contentKeyID: 50079507
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# IManifestTrack Interface.GetCustomAttribute Method

**Applies to:** Windows Store apps only

Gets the track level custom attributes from the manifest.

## Syntax

```csharp
string GetCustomAttribute(
string name
)
```

```cpp
String^ GetCustomAttribute(
[InAttribute] String^ name
)
```

```jscript
function GetCustomAttribute(
name : String
) : String
```

## Parameters

  - name  
    Type: [String](https://msdn.microsoft.com/library/s1wwdcbf)

## Return Value

The track level custom attributes from the manifest.

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
