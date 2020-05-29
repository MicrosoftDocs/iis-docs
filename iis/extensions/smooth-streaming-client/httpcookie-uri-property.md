---
title: HttpCookie.Uri Property
TOCTitle: Uri Property
ms:assetid: de54d836-935a-4a25-a465-0810ab9d3119
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822847(v=VS.90)
ms:contentKeyID: 50079601
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# HttpCookie.Uri Property

**Applies to:** Windows Store apps only

Gets the URI of the http cookie.

## Syntax

```csharp
public Uri Uri { get; set; }
```

```cpp
public:
virtual property Uri^ Uri {
Uri^ get () sealed;
void set (Uri^ value) sealed;
}
```

```jscript
final function get Uri () : Uri
final function set Uri (value : Uri)
```

## Property Value

The URI.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
