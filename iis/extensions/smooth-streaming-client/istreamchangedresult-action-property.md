---
title: IStreamChangedResult.Action Property
description: This article contains information about syntax, property value, and requirements for the IStreamChangedResult.Action property.
TOCTitle: Action Property
ms:assetid: baa176ea-018f-42b5-b1f4-9749eff35a34
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822817(v=VS.90)
ms:contentKeyID: 50079571
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# IStreamChangedResult.Action Property

**Applies to:** Windows Store apps only

Gets the action of the stream.

## Syntax

```csharp
 StreamChangedAction Action { get; }
```

```cpp
 property StreamChangedAction Action {
StreamChangedAction get ();
}
```

```jscript
 function get Action () : StreamChangedAction
```

## Property Value

Indicates whether the stream is selected or de-selected.

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
