---
title: IManifestStream.GetAttribute Method
TOCTitle: GetAttribute Method
ms:assetid: 06636435-83a0-44e8-ad4c-992afdfa58bd
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822669(v=VS.90)
ms:contentKeyID: 50079424
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# IManifestStream.GetAttribute Method

**Applies to:** Windows Store apps only

Gets the stream level attributes from the manifest.

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

If the method succeeds, it returns S\_OK. Otherwise, it returns an HRESULT error code.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

