---
title: ManifestStream.GetAttribute Method
TOCTitle: GetAttribute Method
ms:assetid: 197c214d-1f9c-4738-b4e1-70f9a8126160
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822690(v=VS.90)
ms:contentKeyID: 50079445
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# ManifestStream.GetAttribute Method

**Applies to:** Windows Store apps only

Gets the stream level attributes from the manifest.

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

