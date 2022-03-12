---
title: ISmoothStreamingCache Methods (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ISmoothStreamingCache Methods
ms:assetid: Methods.T:Microsoft.Web.Media.SmoothStreaming.ISmoothStreamingCache
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.ismoothstreamingcache_methods(v=VS.95)
ms:contentKeyID: 46307589
ms.date: 05/31/2012
mtps_version: v=VS.95
---

# ISmoothStreamingCache Methods

The [ISmoothStreamingCache](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md) type exposes the following members.

## Methods

|Method Type|Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method") ![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[BeginPersist](ismoothstreamingcache-beginpersist-method-microsoft-web-media-smoothstreaming_1.md)|Begins to persist a cache response. This function is called whenever in the course of normal playback a Smooth Streaming object chunk, manifest, or key frame is received from the network and it might be useful to persist the item for later use.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method") ![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[BeginRetrieve](ismoothstreamingcache-beginretrieve-method-microsoft-web-media-smoothstreaming_1.md)|Begins an asynchronous cache response retrieval.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[CloseMedia](ismoothstreamingcache-closemedia-method-microsoft-web-media-smoothstreaming.md)|Ends [ISmoothStreamingCache](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md) operations for the specified media.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method") ![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[EndPersist](ismoothstreamingcache-endpersist-method-microsoft-web-media-smoothstreaming_1.md)|A [AsyncCallback](https://msdn.microsoft.com/library/ckbe7yh5(v=vs.95)) delegate method to complete the operation started by the [BeginPersist](ismoothstreamingcache-beginpersist-method-microsoft-web-media-smoothstreaming_1.md) method.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method") ![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[EndRetrieve](ismoothstreamingcache-endretrieve-method-microsoft-web-media-smoothstreaming_1.md)|Ends an asynchronous cache response retrieval started by the [BeginRetrieve](ismoothstreamingcache-beginretrieve-method-microsoft-web-media-smoothstreaming_1.md) method.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[OpenMedia](ismoothstreamingcache-openmedia-method-microsoft-web-media-smoothstreaming.md)|Opens the specified media for [ISmoothStreamingCache](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md) operations.|

## See Also

### Reference

[ISmoothStreamingCache Interface](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
