---
title: Manifest.MinorVersion Property
description: Describes the Manifest.MinorVersion property and provides the property's syntax, property value, and requirements.
TOCTitle: MinorVersion Property
ms:assetid: e11e9da6-93cc-4ad3-ac35-15628cf853b1
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822851(v=VS.90)
ms:contentKeyID: 50079605
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# Manifest.MinorVersion Property

**Applies to:** Windows Store apps only

Gets the manifest 'MinorVersion' field.

## Syntax

```csharp
public uint MinorVersion { get; }
```

```cpp
public:
virtual property unsigned int MinorVersion {
unsigned int get () sealed;
}
```

```jscript
final function get MinorVersion () : uint
```

## Property Value

The manifest 'MinorVersion' field.

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
