---
title: SmoothStreamingMediaElement.CookieContainer Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CookieContainer Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CookieContainer
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.cookiecontainer(v=VS.95)
ms:contentKeyID: 46307813
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CookieContainer
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_CookieContainer
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_CookieContainer
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CookieContainer
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_CookieContainer
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_CookieContainer
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingMediaElement.CookieContainer Property

Gets or set the cookie container that will be used with all HTTP requests.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property CookieContainer As CookieContainer
    Get
    Set
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

``` fsharp
member CookieContainer : CookieContainer with get, set
```

```jscript
function get CookieContainer () : CookieContainer
function set CookieContainer (value : CookieContainer)
```

### Property Value

Type: [System.Net.CookieContainer](https://msdn.microsoft.com/library/fkh73a15\(v=vs.95\))  
The cookie container.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

