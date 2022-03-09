---
title: CacheRequest Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CacheRequest Class
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.CacheRequest
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.cacherequest(v=VS.90)
ms:contentKeyID: 31469236
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.CacheRequest
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheRequest
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# CacheRequest Class

The object describing the request being made.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  Microsoft.Web.Media.SmoothStreaming..::..CacheRequest  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Class CacheRequest
'Usage

  Dim instance As CacheRequest
```

```csharp
  public class CacheRequest
```

```cpp
  public ref class CacheRequest
```

```jscript
  public class CacheRequest
```

The CacheRequest type exposes the following members.

## Constructors

|Method Type|Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[CacheRequest(Stream)](cacherequest-constructor-stream-microsoft-web-media-smoothstreaming_1.md)|Initializes a new instance of the CacheRequest class from a [Stream](https://msdn.microsoft.com/library/8f86tw9e) object.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[CacheRequest(Uri)](cacherequest-constructor-uri-microsoft-web-media-smoothstreaming_1.md)|Initializes a new instance of the CacheRequest class from a [Uri](https://msdn.microsoft.com/library/txt7706a) object.|

## Properties

|Property Type|Name|Description|
|--- |--- |--- |
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[CanonicalUri](cacherequest-canonicaluri-property-microsoft-web-media-smoothstreaming_1.md)|The Uri of the request.|

## Methods

|Method Type|Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[ReadFrom](cacherequest-readfrom-method-microsoft-web-media-smoothstreaming_1.md)|Reads the request from a [Stream](https://msdn.microsoft.com/library/8f86tw9e) object. There is no default implementation for this method. Calling the method without implementing an override will result in a [NotSupportedException](https://msdn.microsoft.com/library/8a7a4e64).|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[WriteTo](cacherequest-writeto-method-microsoft-web-media-smoothstreaming_1.md)|Writes the request to a [Stream](https://msdn.microsoft.com/library/8f86tw9e) object.|

## Remarks

The CacheRequest class supports offline playback scenarios. When the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) needs a chunk or manifest, it first checks with the registered cache plug-in. If the plug-in has it, the chunk is used. Otherwise, SSME downloads it by HTTP. After the download, [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) provides an option for the plug-in to persist the downloaded chunk.

A template example for implementation of the cache plug-in ships with Microsoft Expression Encoder 4.

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
