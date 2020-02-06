---
title: ISmoothStreamingCache Interface (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ISmoothStreamingCache Interface
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.ISmoothStreamingCache
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.ismoothstreamingcache(v=VS.90)
ms:contentKeyID: 31469159
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ISmoothStreamingCache
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ISmoothStreamingCache
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ISmoothStreamingCache Interface

Interface definition for writing a cache plug-in.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Interface ISmoothStreamingCache
'Usage

  Dim instance As ISmoothStreamingCache
```

```csharp
  public interface ISmoothStreamingCache
```

```cpp
  public interface class ISmoothStreamingCache
```

```jscript
  public interface ISmoothStreamingCache
```

The ISmoothStreamingCache type exposes the following members.

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[BeginPersist](ismoothstreamingcache-beginpersist-method-microsoft-web-media-smoothstreaming_1.md)|Begins to persist a cache response. This function is called whenever in the course of normal playback a Smooth Streaming object chunk, manifest, or key frame is received from the network and it might be useful to persist the item for later use.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[BeginRetrieve](ismoothstreamingcache-beginretrieve-method-microsoft-web-media-smoothstreaming_1.md)|Begins an asynchronous cache response retrieval.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[EndPersist](ismoothstreamingcache-endpersist-method-microsoft-web-media-smoothstreaming_1.md)|A [AsyncCallback](https://msdn.microsoft.com/library/ckbe7yh5) delegate method to complete the operation started by the [BeginPersist](ismoothstreamingcache-beginpersist-method-microsoft-web-media-smoothstreaming_1.md) method.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[EndRetrieve](ismoothstreamingcache-endretrieve-method-microsoft-web-media-smoothstreaming_1.md)|Ends an asynchronous cache response retrieval started by the [BeginRetrieve](ismoothstreamingcache-beginretrieve-method-microsoft-web-media-smoothstreaming_1.md) method.|

## Remarks

The ISmoothStreamingCache interface supports offline playback scenarios. When the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) needs a chunk or manifest, it first checks with the registered cache plug-in. If the plug-in has it, the chunk is used. Otherwise, the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) downloads it by HTTP. After the download, [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) provides an option for the plug-in to persist the downloaded chunk.

The cache implementation is independent of any particular codec requirements. The [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) makes the same requests of the cache provider that it would over the wire to the server. A cache implementation can have a downloader that reads the client manifest and mimics the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) by making requests to the server and storing the responses on the disk. When the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) makes requests to the cache implementation, the cache provider replies with the pre-downloaded response now serialized to the disk.

## Examples

You can assign a cache plug-in that implements ISmoothStreamingCache to the [SmoothStreamingCache](smoothstreamingmediaelement-smoothstreamingcache-property-microsoft-web-media-smoothstreaming_1.md) property of the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md). Every time the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) downloads a manifest or data chunk, the plug-in calls [BeginRetrieve(CacheRequest, AsyncCallback, Object)](ismoothstreamingcache-beginretrieve-method-microsoft-web-media-smoothstreaming_1.md) or [BeginPersist(CacheRequest, CacheResponse, AsyncCallback, Object)](ismoothstreamingcache-beginpersist-method-microsoft-web-media-smoothstreaming_1.md) to provide an option to use cache data instead of downloading from the network or to save the data for future use.

A [Silverlight IIS Smooth Streaming Offline Cache Sample](http://www.iis.net/community/default.aspx?tabid=34&g=6&i=2013) that demonstrates implementation of ISmoothStreamingCache is available on the IIS Website.

For documentation of the sample, see [Cache Plug-in Implementation of ISmoothStreamingCache](cache-plug-in-implementation-of-ismoothstreamingcache_1.md).

The following example assigns the cache plug-in when the media element loads.

```csharp
    private void SmoothPlayer_Loaded(object sender, RoutedEventArgs e)
    {
        SmoothPlayer.SmoothStreamingCache = new SmoothStreaming.SmoothStreamingOfflineCache();
    }
```

> [!CAUTION]  
> Do not set SSME.SmoothStreamingSource to a Uri that contains a query, such as `http://domain/MultiAudio.ism/Manifest?foo=axjrjrn1`. If this query is set and config.xml includes ResponseCacheEnabled=&quot;true&quot; instead of ResponseCacheEnabled=&quot;false&quot;, the whole Uri including the query could be persisted in the response cache.

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## See Also

### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)