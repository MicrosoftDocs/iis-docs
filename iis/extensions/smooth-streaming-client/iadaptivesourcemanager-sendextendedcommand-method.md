---
title: IAdaptiveSourceManager.SendExtendedCommand Method
TOCTitle: SendExtendedCommand Method
ms:assetid: 2ce10730-3944-4f32-910e-416cbdba2eab
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822708(v=VS.90)
ms:contentKeyID: 50079463
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# IAdaptiveSourceManager.SendExtendedCommand Method

**Applies to:** Windows Store apps only

Reserved for future use.

## Syntax

```csharp
void SendExtendedCommand(
string cmd,
string parameter
)
```

```cpp
void SendExtendedCommand(
[InAttribute] String^ cmd,
[InAttribute] String^ parameter
)
```

```jscript
function SendExtendedCommand(
cmd : String,
parameter : String
)
```

## Parameters

  - cmd  
    Type: System.String

  - parameter  
    Type: System.String

## Return Value

If the method succeeds, it returns S\_OK. Otherwise, it returns an HRESULT error code.

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
