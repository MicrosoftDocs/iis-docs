---
title: HttpCookie.ExpireTime Property
TOCTitle: ExpireTime Property
ms:assetid: e20dd9e5-262d-4e6b-9671-f6a2434f7cfe
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822854(v=VS.90)
ms:contentKeyID: 50079608
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# HttpCookie.ExpireTime Property

**Applies to:** Windows Store apps only

Gets the expire time.

## Syntax

```csharp
 public DateTime ExpireTime { get; set; }
```

```cpp
 public:
virtual property DateTime ExpireTime {
DateTime get () sealed;
void set (DateTime value) sealed;
}
```

```jscript
 final function get ExpireTime () : DateTime
final function set ExpireTime (value : DateTime)
```

## Property Value

The expire time.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

