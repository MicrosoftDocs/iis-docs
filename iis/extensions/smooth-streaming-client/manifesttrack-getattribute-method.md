---
title: ManifestTrack.GetAttribute Method
TOCTitle: GetAttribute Method
ms:assetid: b0ed9843-4ef2-4fdc-be81-738373f07492
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822809(v=VS.90)
ms:contentKeyID: 50079563
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# ManifestTrack.GetAttribute Method

**Applies to:** Windows Store apps only

Gets the track level attributes from the manifest.

## Syntax

```csharp
public string GetAttribute(
string name
)
```

```cpp
public:
virtual String^ GetAttribute(
[InAttribute] String^ name
) sealed
```

```jscript
public final function GetAttribute(
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

