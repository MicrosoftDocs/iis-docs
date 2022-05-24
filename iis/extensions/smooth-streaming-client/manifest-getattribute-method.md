---
title: Manifest.GetAttribute Method
TOCTitle: GetAttribute Method
description: "The Manifest.GetAttribute method gets the stream level attributes from the manifest. This article describes its syntax, return value, and requirements."
ms:assetid: 94e846e7-90f8-489c-81f7-1b8a0190672a
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822786(v=VS.90)
ms:contentKeyID: 50079540
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# Manifest.GetAttribute Method

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

## Return Value

If the method succeeds, it returns S\_OK. Otherwise, it returns an HRESULT error code.

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
