---
title: HttpCookie.Flags Property
description: Describes the HttpCookie.Flags property and provides the property's syntax, property value, requirements, and minimum supported client and server.
TOCTitle: Flags Property
ms:assetid: 379945b4-79f8-46a0-8931-020a6be57e2c
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822716(v=VS.90)
ms:contentKeyID: 50079471
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# HttpCookie.Flags Property

**Applies to:** Windows Store apps only

Gets the flags of the http cookie.

## Syntax

```csharp
public uint Flags { get; set; }
```

```cpp
public:
virtual property unsigned int Flags {
unsigned int get () sealed;
void set (unsigned int value) sealed;
}
```

```jscript
final function get Flags () : uint
final function set Flags (value : uint)
```

## Property Value

The flags.

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
