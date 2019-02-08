---
title: ManifestTrack.GetCustomAttribute Method
TOCTitle: GetCustomAttribute Method
ms:assetid: a7aa7fdf-b76a-447b-8dd6-b49b4ea50e6c
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822805(v=VS.90)
ms:contentKeyID: 50079559
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# ManifestTrack.GetCustomAttribute Method

**Applies to:** Windows Store apps only

Gets the track level custom attributes from the manifest.

## Syntax

``` csharp
public string GetCustomAttribute(
string name
)
```

``` c++
public:
virtual String^ GetCustomAttribute(
[InAttribute] String^ name
) sealed
```

``` jscript
public final function GetCustomAttribute(
name : String
) : String
```

## Parameters

  - name  
    Type: System.String

## Return Value

If the method succeeds, it returns S\_OK. Otherwise, it returns an HRESULT error code.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

