---
title: HttpCookie Class
TOCTitle: HttpCookie Class
ms:assetid: e853230c-f7c2-44f5-b87c-0ec826d3fbb8
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822861(v=VS.90)
ms:contentKeyID: 50079615
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- "cpp"
- jscript
---

# HttpCookie Class

**Applies to:** Windows Store apps only

HttpCookie interface.

## Syntax

```csharp
[ActivatableAttribute()]

[VersionAttribute()]
public sealed class HttpCookie : IHttpCookie
```

```cpp
[ActivatableAttribute()]
[VersionAttribute()]
public ref class HttpCookie sealed : IHttpCookie
```

```jscript
public final class HttpCookie implements IHttpCookie
```

## Members

This class exposes the following members.

### Properties

|Property|Description|
|--- |--- |
|[ExpireTime](httpcookie-expiretime-property.md)|Gets the expire time.|
|[Flags](httpcookie-flags-property.md)|Gets the flags.|
|[Name](httpcookie-name-property.md)|Gets the name.|
|[P3PPolicy](httpcookie-p3ppolicy-property.md)|Gets the P3P policy.|
|[Uri](httpcookie-uri-property.md)|Gets the URI.|
|[Value](httpcookie-value-property.md)|Gets the value of the http cookie.|


## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

