---
title: Manifest.MinorVersion Property
TOCTitle: MinorVersion Property
ms:assetid: e11e9da6-93cc-4ad3-ac35-15628cf853b1
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822851(v=VS.90)
ms:contentKeyID: 50079605
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# Manifest.MinorVersion Property

**Applies to:** Windows Store apps only

Gets the manifest 'MinorVersion' field.

## Syntax

``` csharp
public uint MinorVersion { get; }
```

``` c++
public:
virtual property unsigned int MinorVersion {
unsigned int get () sealed;
}
```

``` jscript
final function get MinorVersion () : uint
```

## Property Value

The manifest 'MinorVersion' field.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

