---
title: StreamChangedResult Class
TOCTitle: StreamChangedResult Class
ms:assetid: 0515e63d-b0e8-4902-a477-e9dea0cdc485
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822668(v=VS.90)
ms:contentKeyID: 50079423
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# StreamChangedResult Class

**Applies to:** Windows Store apps only

Represents the results when the stream is changed.

## Syntax

```csharp
[VersionAttribute()]
public sealed class StreamChangedResult : IStreamChangedResult
```

```cpp
[VersionAttribute()]
public ref class StreamChangedResult sealed : IStreamChangedResult
```

```jscript
public final class StreamChangedResult implements IStreamChangedResult
```

## Members

This class exposes the following members.

### Properties

|Property|Description|
|--- |--- |
|[Action](streamchangedresult-action-property.md)|Gets the action of the stream.|
|[ResultCode](streamchangedresult-resultcode-property.md)|Gets the result code.|
|[Stream](streamchangedresult-stream-property.md)|Gets a stream that is selected or de-selected.|

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
