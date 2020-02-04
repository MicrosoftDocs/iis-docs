---
title: CacheRequest2 Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CacheRequest2 Class
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.CacheRequest2
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.cacherequest2(v=VS.95)
ms:contentKeyID: 46307926
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.CacheRequest2
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheRequest2
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# CacheRequest2 Class

Provides an extension of the [CacheRequest](cacherequest-class-microsoft-web-media-smoothstreaming_1.md) class that enables creation of a CacheRequest object based on a specified stream or a specified [HttpWebRequest](https://msdn.microsoft.com/library/8y7x3zz2\(v=vs.95\)) object and list of selectable tracks.

## Inheritance Hierarchy

 [System.Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\))  
  [Microsoft.Web.Media.SmoothStreaming.CacheRequest](cacherequest-class-microsoft-web-media-smoothstreaming_1.md)  
    Microsoft.Web.Media.SmoothStreaming.CacheRequest2  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Class CacheRequest2 _
    Inherits CacheRequest
'Usage

Dim instance As CacheRequest2
```

```csharp
public class CacheRequest2 : CacheRequest
```

```cpp
public ref class CacheRequest2 : public CacheRequest
```

``` fsharp
type CacheRequest2 =  
    class
        inherit CacheRequest
    end
```

```jscript
public class CacheRequest2 extends CacheRequest
```

The CacheRequest2 type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[CacheRequest2(Stream)](cacherequest2-constructor-stream-microsoft-web-media-smoothstreaming.md)|Initializes a new instance of the CacheRequest2 class based on the specified stream.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[CacheRequest2(HttpWebRequest, IList<TrackInfo>)](cacherequest2-constructor-httpwebrequest-ilist-trackinfo-microsoft-web-media-smoothstreaming.md)|Initializes a new instance of the CacheRequest2 class based on the specified web request and list of selectable tracks.|


## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[CanonicalUri](cacherequest-canonicaluri-property-microsoft-web-media-smoothstreaming_1.md)|The Uri of the request. (Inherited from [CacheRequest](cacherequest-class-microsoft-web-media-smoothstreaming_1.md).)|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[SelectableTracks](cacherequest2-selectabletracks-property-microsoft-web-media-smoothstreaming.md)|Gets a list of suggested tracks for the cache plug-in to choose for downloading.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[WebRequest](cacherequest2-webrequest-property-microsoft-web-media-smoothstreaming.md)|Gets or sets a web request that the media element downloader uses for downloading.|

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[ReadFrom](cacherequest-readfrom-method-microsoft-web-media-smoothstreaming_1.md)|Reads the request from a [Stream](https://msdn.microsoft.com/library/8f86tw9e(v=vs.95)) object. There is no default implementation for this method. Calling the method without implementing an override will result in a [NotSupportedException](https://msdn.microsoft.com/library/8a7a4e64(v=vs.95)). (Inherited from [CacheRequest](cacherequest-class-microsoft-web-media-smoothstreaming_1.md).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[WriteTo](cacherequest-writeto-method-microsoft-web-media-smoothstreaming_1.md)|Writes the request to a [Stream](https://msdn.microsoft.com/library/8f86tw9e(v=vs.95)) object. (Inherited from [CacheRequest](cacherequest-class-microsoft-web-media-smoothstreaming_1.md).)|


## Version Information

### Silverlight

Supported in: 5  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

