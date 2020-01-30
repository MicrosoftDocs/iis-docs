---
title: IHttpCookie.Flags Property
TOCTitle: Flags Property
ms:assetid: 378ce4b0-837c-4c12-bca4-c22f71ee3fcd
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822715(v=VS.90)
ms:contentKeyID: 50079470
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# IHttpCookie.Flags Property

**Applies to:** Windows Store apps only

Gets the flags of the h ttp cookie.

## Syntax

```csharp
uint Flags { get; set; }
```

```cpp
property unsigned int Flags {
unsigned int get ();
void set (unsigned int value); 
}
```

```jscript
function get Flags () : uint
function set Flags (value : uint) 
```

## Property Value

Type: System.UInt32

The flags of the http cookie.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

