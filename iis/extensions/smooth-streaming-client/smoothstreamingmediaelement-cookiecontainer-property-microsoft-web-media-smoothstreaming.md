---
title: SmoothStreamingMediaElement.CookieContainer Property - (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CookieContainer Property
description: Gets or set the cookie container that will be used with all HTTP requests.
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CookieContainer
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.cookiecontainer(v=VS.90)
ms:contentKeyID: 23961158
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CookieContainer
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_CookieContainer
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_CookieContainer
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CookieContainer
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_CookieContainer
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_CookieContainer
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# CookieContainer Property

Gets or set the cookie container that will be used with all HTTP requests.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property CookieContainer As CookieContainer
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim value As CookieContainer

value = instance.CookieContainer

instance.CookieContainer = value
```

```csharp
  public CookieContainer CookieContainer { get; set; }
```

```cpp
  public:
property CookieContainer^ CookieContainer {
    CookieContainer^ get ();
    void set (CookieContainer^ value);
}
```

```jscript
  function get CookieContainer () : CookieContainer
function set CookieContainer (value : CookieContainer)
```

### Property Value

Type: [System.Net.CookieContainer](https://msdn.microsoft.com/library/fkh73a15)  
The cookie container.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
