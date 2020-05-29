---
title: SmoothSchemeHandler.SetProperties Method
TOCTitle: SetProperties Method
ms:assetid: a42dacd8-8095-44cc-ba55-df395894f295
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822801(v=VS.90)
ms:contentKeyID: 50079555
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# SmoothSchemeHandler.SetProperties Method

**Applies to:** Windows Store apps only

Sets the properties of the Smooth Scheme Handler.

## Syntax

```csharp
public void SetProperties(
IPropertySet configuration|
)
```

```cpp
public:
virtual void SetProperties(
[InAttribute] IPropertySet^ configuration
) sealed
```

```jscript
public final function SetProperties(
configuration : IPropertySet
)
```

## Parameters

  - configuration  
    Type: IPropertySet

## Return Value

If the method succeeds, it returns S\_OK. Otherwise, it returns an HRESULT error code.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
