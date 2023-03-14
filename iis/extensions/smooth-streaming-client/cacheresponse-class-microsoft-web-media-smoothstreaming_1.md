---
title: The CacheResponse Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CacheResponse Class
description: "The CacheResponse class is the object describing the response from the cache. This article describes the syntax, constructors, properties, and methods."
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.CacheResponse
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.cacheresponse(v=VS.95)
ms:contentKeyID: 46307928
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# The CacheResponse Class

The object describing the response from the cache.

## Inheritance Hierarchy

 [System.Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\))  
  Microsoft.Web.Media.SmoothStreaming.CacheResponse  
    [Microsoft.Web.Media.SmoothStreaming.CacheResponse2](cacheresponse2-class-microsoft-web-media-smoothstreaming.md)  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Class CacheResponse
'Usage

Dim instance As CacheResponse
```

```csharp
public class CacheResponse
```

```cpp
public ref class CacheResponse
```

``` fsharp
type CacheResponse =  class end
```

```jscript
public class CacheResponse
```

The CacheResponse type exposes the following members.

## Constructors

|Method Type|Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[CacheResponse(Stream)](cacheresponse-constructor-stream-microsoft-web-media-smoothstreaming_1.md)|Initializes a new instance of the CacheResponse class from a [Stream](https://msdn.microsoft.com/library/8f86tw9e(v=vs.95)) object.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[CacheResponse(Stream, Boolean)](cacheresponse-constructor-stream-boolean-microsoft-web-media-smoothstreaming.md)|Initializes a new instance of the CacheResponse class from a [Stream](https://msdn.microsoft.com/library/8f86tw9e(v=vs.95)) object specifying whether to continue processing in case of a cache miss.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[CacheResponse(Int64, String, WebHeaderCollection, Stream, HttpStatusCode, String, DateTime)](cacheresponse-constructor-int64-string-webheadercollection-stream-httpstatuscode-string-datetime-microsoft-web-media-smoothstreaming_1.md)|Initializes a new instance of the CacheResponse class from the parameters.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[CacheResponse(Int64, String, WebHeaderCollection, Stream, HttpStatusCode, String, DateTime, Boolean)](cacheresponse-constructor-int64-string-webheadercollection-stream-httpstatuscode-string-datetime-boolean-microsoft-web-media-smoothstreaming.md)|Initializes a new instance of the CacheResponse class from the parameters.|

## Properties

|Property Type|Name|Description|
|--- |--- |--- |
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[ContentLength](cacheresponse-contentlength-property-microsoft-web-media-smoothstreaming_1.md)|The length in bytes.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[ContentType](cacheresponse-contenttype-property-microsoft-web-media-smoothstreaming_1.md)|A string object that identifies the content type.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[ContinueProcessing](cacheresponse-continueprocessing-property-microsoft-web-media-smoothstreaming.md)|Gets a Boolean value indicating whether cache response processing continues to the next cache module (including HTTP download) in case of a cache miss.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[ExpiryTime](cacheresponse-expirytime-property-microsoft-web-media-smoothstreaming_1.md)|A [DateTime](https://msdn.microsoft.com/library/03ybds8y(v=vs.95)) object that contains the time of response expiration.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[Headers](cacheresponse-headers-property-microsoft-web-media-smoothstreaming_1.md)|Gets a metadata collection of responses.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[Response](cacheresponse-response-property-microsoft-web-media-smoothstreaming_1.md)|A [Stream](https://msdn.microsoft.com/library/8f86tw9e(v=vs.95)) object that contains the response.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[StatusCode](cacheresponse-statuscode-property-microsoft-web-media-smoothstreaming_1.md)|An [System.Net.HTTPStatusCode](https://msdn.microsoft.com/library/f92ssyy1(v=vs.95)) enumeration object.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[StatusDescription](cacheresponse-statusdescription-property-microsoft-web-media-smoothstreaming_1.md)|A string that contains the status description.|

## Methods

|Method Type|Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[Equals](https://msdn.microsoft.com/library/bsc2ak47(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[GetType](https://msdn.microsoft.com/library/dfwy45w9(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[ReadFrom](cacheresponse-readfrom-method-microsoft-web-media-smoothstreaming_1.md)|Reads the response from a [Stream](https://msdn.microsoft.com/library/8f86tw9e(v=vs.95)) object. There is no default implementation for this method. Calling the method without implementing an override will result in a [NotSupportedException](https://msdn.microsoft.com/library/8a7a4e64(v=vs.95)).|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[WriteTo](cacheresponse-writeto-method-microsoft-web-media-smoothstreaming_1.md)|Writes the response to a [Stream](https://msdn.microsoft.com/library/8f86tw9e(v=vs.95)) object.|

## Remarks

The CacheResponse class supports offline playback scenarios. When the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) needs a chunk or manifest, it first checks with the registered cache plug-in. If the plug-in has it, the chunk is used. Otherwise, SSME downloads it by HTTP. After the download, [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) provides an option for the plug-in to persist the downloaded chunk.

A template example for implementation of the cache plug-in ships with Microsoft Expression Encoder 4.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
