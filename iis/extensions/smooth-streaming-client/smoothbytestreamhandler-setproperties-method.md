---
title: SmoothByteStreamHandler.SetProperties Method
TOCTitle: SetProperties Method
description: Sets the Smooth Byte Stream Handler properties.
ms:assetid: 1797d7e6-4646-4c00-9bdc-c51462705e66
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822685(v=VS.90)
ms:contentKeyID: 50079440
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# SmoothByteStreamHandler.SetProperties Method

**Applies to:** Windows Store apps only

Sets the Smooth Byte Stream Handler properties.

## Syntax

```csharp
public void SetProperties(
IPropertySet configuration
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

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
