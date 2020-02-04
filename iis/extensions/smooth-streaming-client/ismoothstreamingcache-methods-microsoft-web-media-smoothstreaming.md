---
title: ISmoothStreamingCache Methods (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ISmoothStreamingCache Methods
ms:assetid: Methods.T:Microsoft.Web.Media.SmoothStreaming.ISmoothStreamingCache
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.ismoothstreamingcache_methods(v=VS.90)
ms:contentKeyID: 31469255
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# ISmoothStreamingCache Methods

The [ISmoothStreamingCache](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md) type exposes the following members.

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[BeginPersist](ismoothstreamingcache-beginpersist-method-microsoft-web-media-smoothstreaming_1.md)|Begins to persist a cache response. This function is called whenever in the course of normal playback a Smooth Streaming object chunk, manifest, or key frame is received from the network and it might be useful to persist the item for later use.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[BeginRetrieve](ismoothstreamingcache-beginretrieve-method-microsoft-web-media-smoothstreaming_1.md)|Begins an asynchronous cache response retrieval.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[EndPersist](ismoothstreamingcache-endpersist-method-microsoft-web-media-smoothstreaming_1.md)|A [AsyncCallback](https://msdn.microsoft.com/library/ckbe7yh5) delegate method to complete the operation started by the [BeginPersist](ismoothstreamingcache-beginpersist-method-microsoft-web-media-smoothstreaming_1.md) method.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[EndRetrieve](ismoothstreamingcache-endretrieve-method-microsoft-web-media-smoothstreaming_1.md)|Ends an asynchronous cache response retrieval started by the [BeginRetrieve](ismoothstreamingcache-beginretrieve-method-microsoft-web-media-smoothstreaming_1.md) method.|


## See Also

### Reference

[ISmoothStreamingCache Interface](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

