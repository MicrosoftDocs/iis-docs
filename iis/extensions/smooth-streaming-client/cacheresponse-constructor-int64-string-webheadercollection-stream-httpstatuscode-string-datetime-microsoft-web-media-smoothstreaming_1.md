---
title: CacheResponse Constructor (Int64, String, WebHeaderCollection, Stream, HttpStatusCode, String, DateTime) (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CacheResponse Constructor (Int64, String, WebHeaderCollection, Stream, HttpStatusCode, String, DateTime)
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.CacheResponse.#ctor(System.Int64,System.String,System.Net.WebHeaderCollection,System.IO.Stream,System.Net.HttpStatusCode,System.String,System.DateTime)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.cacheresponse.cacheresponse(v=VS.95)
ms:contentKeyID: 46500543
ms.date: 05/31/2012
mtps_version: v=VS.95
dev_langs:
- vb
- csharp
- cpp
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse..ctor
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# CacheResponse Constructor (Int64, String, WebHeaderCollection, Stream, HttpStatusCode, String, DateTime)

Initializes a new instance of the [CacheResponse](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md) class from the parameters.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Sub New ( _
    contentLength As Long, _
    contentType As String, _
    headers As WebHeaderCollection, _
    response As Stream, _
    statusCode As HttpStatusCode, _
    statusDescription As String, _
    downloadTime As DateTime _
)
'Usage

Dim contentLength As Long
Dim contentType As String
Dim headers As WebHeaderCollection
Dim response As Stream
Dim statusCode As HttpStatusCode
Dim statusDescription As String
Dim downloadTime As DateTime

Dim instance As New CacheResponse(contentLength, _
    contentType, headers, response, statusCode, _
    statusDescription, downloadTime)
```

```csharp
public CacheResponse(
    long contentLength,
    string contentType,
    WebHeaderCollection headers,
    Stream response,
    HttpStatusCode statusCode,
    string statusDescription,
    DateTime downloadTime
)
```

```cpp
public:
CacheResponse(
    long long contentLength,
    String^ contentType,
    WebHeaderCollection^ headers,
    Stream^ response,
    HttpStatusCode statusCode,
    String^ statusDescription,
    DateTime downloadTime
)
```

``` fsharp
new :
        contentLength:int64 *
        contentType:string *
        headers:WebHeaderCollection *
        response:Stream *
        statusCode:HttpStatusCode *
        statusDescription:string *
        downloadTime:DateTime -> CacheResponse
```

```jscript
public function CacheResponse(
    contentLength : long,
    contentType : String,
    headers : WebHeaderCollection,
    response : Stream,
    statusCode : HttpStatusCode,
    statusDescription : String,
    downloadTime : DateTime
)
```

### Parameters

  - contentLength  
    Type: [System.Int64](https://msdn.microsoft.com/library/6yy583ek\(v=vs.95\))  
    A long integer that contains the length of the response in bytes.

<!-- end list -->

  - contentType  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\))  
    A string object that identifies the content type.

<!-- end list -->

  - headers  
    Type: [System.Net.WebHeaderCollection](https://msdn.microsoft.com/library/1beth6ct\(v=vs.95\))  
    A System.NetWebHeaderCollection.

<!-- end list -->

  - response  
    Type: [System.IO.Stream](https://msdn.microsoft.com/library/8f86tw9e\(v=vs.95\))  
    A [Stream](https://msdn.microsoft.com/library/8f86tw9e\(v=vs.95\)) object that contains the response.

<!-- end list -->

  - statusCode  
    Type: [System.Net.HttpStatusCode](https://msdn.microsoft.com/library/f92ssyy1\(v=vs.95\))  
    An [System.Net.HTTPStatusCode](https://msdn.microsoft.com/library/f92ssyy1\(v=vs.95\)) enumeration object.

<!-- end list -->

  - statusDescription  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\))  
    A string that contains the status description.

<!-- end list -->

  - downloadTime  
    Type: [System.DateTime](https://msdn.microsoft.com/library/03ybds8y\(v=vs.95\))  
    A [DateTime](https://msdn.microsoft.com/library/03ybds8y\(v=vs.95\)) object.

## Version Information

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[CacheResponse Class](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md)

[CacheResponse Overload](cacheresponse-constructor-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
