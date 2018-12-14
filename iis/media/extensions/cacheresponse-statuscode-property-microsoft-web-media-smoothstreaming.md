---
title: CacheResponse.StatusCode Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: StatusCode Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.CacheResponse.StatusCode
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.cacheresponse.statuscode(v=VS.90)
ms:contentKeyID: 31469201
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.get_StatusCode
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.set_StatusCode
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.StatusCode
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.get_StatusCode
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.set_StatusCode
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.StatusCode
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# StatusCode Property

An HTTPStatusCode enumeration object.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicPropertyStatusCodeAsHttpStatusCode
'Usage
DiminstanceAsCacheResponseDimvalueAsHttpStatusCodevalue = instance.StatusCode
```

``` csharp
publicHttpStatusCodeStatusCode { get; privateset; }
```

``` c++
public:
propertyHttpStatusCodeStatusCode {
    HttpStatusCodeget ();
    private: voidset (HttpStatusCodevalue);
}
```

``` jscript
function getStatusCode () : HttpStatusCodeprivatefunction setStatusCode (value : HttpStatusCode)
```

#### Property Value

Type: [System.Net. . :: . .HttpStatusCode](https://msdn.microsoft.com/en-us/library/f92ssyy1\(v=vs.90\))  
An HTTPStatusCode enumeration object.  

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[CacheResponse Class](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

