---
title: ManifestStream.TimeScale Property
description: Describes the ManifestStream.TimeScale property and provides the property's syntax, property value, and requirements.
TOCTitle: TimeScale Property
ms:assetid: e6b219af-b960-4422-881e-c71eacf3fa84
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822858(v=VS.90)
ms:contentKeyID: 50079612
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# ManifestStream.TimeScale Property

**Applies to:** Windows Store apps only

Gets the stream 'TimeScale' field.

## Syntax

```csharp
public long TimeScale { get; }
```

```cpp
public:
virtual property long long TimeScale {
long long get () sealed;
}
```

```jscript
final function get TimeScale () : long
```

## Property Value

The stream 'TimeScale' field.

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
