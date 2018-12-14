﻿---
title: SmoothStreamingMediaElement.CookieContainer Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CookieContainer Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CookieContainer
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.cookiecontainer(v=VS.90)
ms:contentKeyID: 23961158
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CookieContainer
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_CookieContainer
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_CookieContainer
dev_langs:
- CSharp
- JScript
- VB
- c++
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

# CookieContainer Property

Gets or set the cookie container that will be used with all HTTP requests.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicPropertyCookieContainerAsCookieContainer
'Usage
DiminstanceAsSmoothStreamingMediaElementDimvalueAsCookieContainervalue = instance.CookieContainer

instance.CookieContainer = value
```

``` csharp
publicCookieContainerCookieContainer { get; set; }
```

``` c++
public:
propertyCookieContainer^ CookieContainer {
    CookieContainer^ get ();
    voidset (CookieContainer^ value);
}
```

``` jscript
function getCookieContainer () : CookieContainerfunction setCookieContainer (value : CookieContainer)
```

#### Property Value

Type: [System.Net. . :: . .CookieContainer](https://msdn.microsoft.com/en-us/library/fkh73a15\(v=vs.90\))  
The cookie container.  

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
