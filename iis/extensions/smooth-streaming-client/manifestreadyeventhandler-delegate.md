---
title: ManifestReadyEventHandler Delegate
TOCTitle: ManifestReadyEventHandler Delegate
ms:assetid: 11612fc5-187b-4658-b09e-554a145bbea3
ms:mtpsurl: https://msdn.microsoft.com/library/JJ573658(v=VS.90)
ms:contentKeyID: 49080900
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# ManifestReadyEventHandler Delegate

**Applies to:** Windows Store apps only

The actual handler for the manifest ready event.

## Syntax

```csharp
[GuidAttribute(, , , , , , , , , , )]
[VersionAttribute()]
public delegate void ManifestReadyEventHandler(
AdaptiveSource sender,
ManifestReadyEventArgs args
)
```

```cpp
[GuidAttribute(, , , , , , , , , , )]
[VersionAttribute()]
public delegate void ManifestReadyEventHandler(
[InAttribute] AdaptiveSource^ sender,
[InAttribute] ManifestReadyEventArgs^ args
)
```

```jscript
```

## Parameters

  - sender  
    Adaptive source this event belongs to

  - ManifestReadyEventArgs  
    Event arguments

## Return Value

If the method succeeds, it returns S\_OK. Otherwise, it returns an HRESULT error code.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

