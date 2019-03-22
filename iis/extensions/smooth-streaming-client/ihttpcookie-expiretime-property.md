---
title: IHttpCookie.ExpireTime Property
TOCTitle: ExpireTime Property
ms:assetid: c2b8ba4d-7fde-4104-994d-6e708b6766ab
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822827(v=VS.90)
ms:contentKeyID: 50079581
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# IHttpCookie.ExpireTime Property

**Applies to:** Windows Store apps only

Represents the HTTP cookie expire time.

## Syntax

```csharp
DateTime ExpireTime { get; set; }
```

```cpp
property DateTime ExpireTime {
DateTime get ();
void set (DateTime value);
}
```

```jscript
function get ExpireTime () : DateTime
function set ExpireTime (value : DateTime)
```

## Property Value

The expire time of the HTTP cookie.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

