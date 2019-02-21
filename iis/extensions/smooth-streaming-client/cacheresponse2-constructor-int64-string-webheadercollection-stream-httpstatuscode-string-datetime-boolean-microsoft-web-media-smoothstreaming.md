---
title: CacheResponse2 Constructor (Int64, String, WebHeaderCollection, Stream, HttpStatusCode, String, DateTime, Boolean) (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CacheResponse2 Constructor (Int64, String, WebHeaderCollection, Stream, HttpStatusCode, String, DateTime, Boolean)
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.CacheResponse2.#ctor(System.Int64,System.String,System.Net.WebHeaderCollection,System.IO.Stream,System.Net.HttpStatusCode,System.String,System.DateTime,System.Boolean)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.cacheresponse2.cacheresponse2(v=VS.95)
ms:contentKeyID: 46631282
ms.date: 05/31/2012
mtps_version: v=VS.95
dev_langs:
- vb
- csharp
- "cpp"
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse2..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# CacheResponse2 Constructor (Int64, String, WebHeaderCollection, Stream, HttpStatusCode, String, DateTime, Boolean)

Initializes a new instance of the [CacheResponse2](cacheresponse2-class-microsoft-web-media-smoothstreaming.md) class that is fully finalized and ready for use.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

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
    downloadTime As DateTime, _
    continueProcessing As Boolean _
)
'Usage

Dim contentLength As Long
Dim contentType As String
Dim headers As WebHeaderCollection
Dim response As Stream
Dim statusCode As HttpStatusCode
Dim statusDescription As String
Dim downloadTime As DateTime
Dim continueProcessing As Boolean

Dim instance As New CacheResponse2(contentLength, _
    contentType, headers, response, statusCode, _
    statusDescription, downloadTime, _
    continueProcessing)
```

```csharp
public CacheResponse2(
    long contentLength,
    string contentType,
    WebHeaderCollection headers,
    Stream response,
    HttpStatusCode statusCode,
    string statusDescription,
    DateTime downloadTime,
    bool continueProcessing
)
```

```cpp
public:
CacheResponse2(
    long long contentLength, 
    String^ contentType, 
    WebHeaderCollection^ headers, 
    Stream^ response, 
    HttpStatusCode statusCode, 
    String^ statusDescription, 
    DateTime downloadTime, 
    bool continueProcessing
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
        downloadTime:DateTime * 
        continueProcessing:bool -> CacheResponse2
```

```jscript
public function CacheResponse2(
    contentLength : long, 
    contentType : String, 
    headers : WebHeaderCollection, 
    response : Stream, 
    statusCode : HttpStatusCode, 
    statusDescription : String, 
    downloadTime : DateTime, 
    continueProcessing : boolean
)
```

### Parameters

  - contentLength  
    Type: [System.Int64](https://msdn.microsoft.com/library/6yy583ek\(v=vs.95\))  
    The final value of the [ContentLength](cacheresponse-contentlength-property-microsoft-web-media-smoothstreaming_1.md) property.

<!-- end list -->

  - contentType  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\))  
    The final value of the [ContentType](cacheresponse-contenttype-property-microsoft-web-media-smoothstreaming_1.md) property.

<!-- end list -->

  - headers  
    Type: [System.Net.WebHeaderCollection](https://msdn.microsoft.com/library/1beth6ct\(v=vs.95\))  
    The final value of the [Headers](cacheresponse-headers-property-microsoft-web-media-smoothstreaming_1.md) property.

<!-- end list -->

  - response  
    Type: [System.IO.Stream](https://msdn.microsoft.com/library/8f86tw9e\(v=vs.95\))  
    The final value of the [Response](cacheresponse-response-property-microsoft-web-media-smoothstreaming_1.md) property.

<!-- end list -->

  - statusCode  
    Type: [System.Net.HttpStatusCode](https://msdn.microsoft.com/library/f92ssyy1\(v=vs.95\))  
    The final value of the [StatusCode](cacheresponse-statuscode-property-microsoft-web-media-smoothstreaming_1.md) property.

<!-- end list -->

  - statusDescription  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\))  
    The final value of the [StatusDescription](cacheresponse-statusdescription-property-microsoft-web-media-smoothstreaming_1.md) property.

<!-- end list -->

  - downloadTime  
    Type: [System.DateTime](https://msdn.microsoft.com/library/03ybds8y\(v=vs.95\))  
    The time at which the response finished downloading. This value is used for computing the expiry time of the response.

<!-- end list -->

  - continueProcessing  
    Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50\(v=vs.95\))  
    true to continue processing to the next module in case of a cache miss; otherwise, false.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[CacheResponse2 Class](cacheresponse2-class-microsoft-web-media-smoothstreaming.md)

[CacheResponse2 Overload](cacheresponse2-constructor-microsoft-web-media-smoothstreaming.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

