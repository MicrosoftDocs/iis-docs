---
title: CacheResponse2 Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CacheResponse2 Class
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.CacheResponse2
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.cacheresponse2(v=VS.95)
ms:contentKeyID: 46307930
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse2
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse2
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# CacheResponse2 Class

Provides an extension of the [CacheResponse](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md) class that enables creation of a CacheResponse object that is based on a specified stream or is fully finalized and ready for use.

## Inheritance Hierarchy

 [System.Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\))  
  [Microsoft.Web.Media.SmoothStreaming.CacheResponse](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md)  
    Microsoft.Web.Media.SmoothStreaming.CacheResponse2  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Class CacheResponse2 _
    Inherits CacheResponse
'Usage

Dim instance As CacheResponse2
```

```csharp
public class CacheResponse2 : CacheResponse
```

```cpp
public ref class CacheResponse2 : public CacheResponse
```

``` fsharp
type CacheResponse2 =  
    class
        inherit CacheResponse
    end
```

```jscript
public class CacheResponse2 extends CacheResponse
```

The CacheResponse2 type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[CacheResponse2(Stream, Boolean)](cacheresponse2-constructor-stream-boolean-microsoft-web-media-smoothstreaming.md)|Initializes a new instance of the CacheResponse2 class based on the specified stream.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[CacheResponse2(Int64, String, WebHeaderCollection, Stream, HttpStatusCode, String, DateTime, Boolean)](cacheresponse2-constructor-int64-string-webheadercollection-stream-httpstatuscode-string-datetime-boolean-microsoft-web-media-smoothstreaming.md)|Initializes a new instance of the CacheResponse2 class that is fully finalized and ready for use.|


## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[ContentLength](cacheresponse-contentlength-property-microsoft-web-media-smoothstreaming_1.md)|The length in bytes. (Inherited from [CacheResponse](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md).)|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[ContentType](cacheresponse-contenttype-property-microsoft-web-media-smoothstreaming_1.md)|A string object that identifies the content type. (Inherited from [CacheResponse](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md).)|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[ContinueProcessing](cacheresponse-continueprocessing-property-microsoft-web-media-smoothstreaming.md)|Gets a Boolean value indicating whether cache response processing continues to the next cache module (including HTTP download) in case of a cache miss. (Inherited from [CacheResponse](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md).)|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[ExpiryTime](cacheresponse-expirytime-property-microsoft-web-media-smoothstreaming_1.md)|A [DateTime](https://msdn.microsoft.com/library/03ybds8y(v=vs.95)) object that contains the time of response expiration. (Inherited from [CacheResponse](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md).)|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[Headers](cacheresponse-headers-property-microsoft-web-media-smoothstreaming_1.md)|Gets a metadata collection of responses. (Inherited from [CacheResponse](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md).)|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[PerceivedBandwidth](cacheresponse2-perceivedbandwidth-property-microsoft-web-media-smoothstreaming.md)|Gets or sets the perceived bandwidth while downloading individual media chunks.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[Response](cacheresponse-response-property-microsoft-web-media-smoothstreaming_1.md)|A [Stream](https://msdn.microsoft.com/library/8f86tw9e(v=vs.95)) object that contains the response. (Inherited from [CacheResponse](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md).)|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[StatusCode](cacheresponse-statuscode-property-microsoft-web-media-smoothstreaming_1.md)|An [System.Net.HTTPStatusCode](https://msdn.microsoft.com/library/f92ssyy1(v=vs.95)) enumeration object. (Inherited from [CacheResponse](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md).)|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[StatusDescription](cacheresponse-statusdescription-property-microsoft-web-media-smoothstreaming_1.md)|A string that contains the status description. (Inherited from [CacheResponse](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md).)|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[UsedTrack](cacheresponse2-usedtrack-property-microsoft-web-media-smoothstreaming.md)|Gets or sets the track the cache plug-in uses for downloading a media chunk.|

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[ReadFrom](cacheresponse-readfrom-method-microsoft-web-media-smoothstreaming_1.md)|Reads the response from a [Stream](https://msdn.microsoft.com/library/8f86tw9e(v=vs.95)) object. There is no default implementation for this method. Calling the method without implementing an override will result in a [NotSupportedException](https://msdn.microsoft.com/library/8a7a4e64(v=vs.95)). (Inherited from [CacheResponse](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[WriteTo](cacheresponse-writeto-method-microsoft-web-media-smoothstreaming_1.md)|Writes the response to a [Stream](https://msdn.microsoft.com/library/8f86tw9e(v=vs.95)) object. (Inherited from [CacheResponse](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md).)|


## Version Information

### Silverlight

Supported in: 5  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

