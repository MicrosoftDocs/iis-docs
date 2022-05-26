---
title: IStreamChangedResult Interface
description: This article contains information on syntax, members, and requirements for the IStreamChangedResult interface. 
TOCTitle: IStreamChangedResult Interface
ms:assetid: 9e3acbba-11bd-437a-a96d-4a4382e83fce
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822796(v=VS.90)
ms:contentKeyID: 50079550
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# IStreamChangedResult Interface

**Applies to:** Windows Store apps only

Stream changed result interface.

## Syntax

```csharp
[VersionAttribute()]
[GuidAttribute(, , , , , , , , , , )]
public interface IStreamChangedResult
```

```cpp
[VersionAttribute()]
[GuidAttribute(, , , , , , , , , , )]
public interface class IStreamChangedResult
```

```jscript
public interface IStreamChangedResult
```

## Members

This interface exposes the following members.

### Properties

|Property|Description|
|--- |--- |
|[Action](istreamchangedresult-action-property.md)|Gets the action of the stream.|
|[ResultCode](istreamchangedresult-resultcode-property.md)|Gets the result code.|
|[Stream](istreamchangedresult-stream-property.md)|Gets the stream that is selected or de-selected.|

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
