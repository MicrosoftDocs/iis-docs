---
title: ISmoothStreamingCache Methods (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ISmoothStreamingCache Methods
ms:assetid: Methods.T:Microsoft.Web.Media.SmoothStreaming.ISmoothStreamingCache
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.ismoothstreamingcache_methods(v=VS.95)
ms:contentKeyID: 46307589
ms.date: 05/31/2012
mtps_version: v=VS.95
---

# ISmoothStreamingCache Methods

Include Protected Members  
Include Inherited Members  

Include Silverlight Members  
Include Windows Phone Members  

The [ISmoothStreamingCache](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md) type exposes the following members.

## Methods

<table>
<thead>
<tr class="header">
<th> </th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /> <img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="ismoothstreamingcache-beginpersist-method-microsoft-web-media-smoothstreaming_1.md">BeginPersist</a></td>
<td>Begins to persist a cache response. This function is called whenever in the course of normal playback a Smooth Streaming object chunk, manifest, or key frame is received from the network and it might be useful to persist the item for later use.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /> <img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="ismoothstreamingcache-beginretrieve-method-microsoft-web-media-smoothstreaming_1.md">BeginRetrieve</a></td>
<td>Begins an asynchronous cache response retrieval.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="ismoothstreamingcache-closemedia-method-microsoft-web-media-smoothstreaming.md">CloseMedia</a></td>
<td>Ends <a href="ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md">ISmoothStreamingCache</a> operations for the specified media.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /> <img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="ismoothstreamingcache-endpersist-method-microsoft-web-media-smoothstreaming_1.md">EndPersist</a></td>
<td>A <a href="https://msdn.microsoft.com/en-us/library/ckbe7yh5(v=vs.95)">AsyncCallback</a> delegate method to complete the operation started by the <a href="ismoothstreamingcache-beginpersist-method-microsoft-web-media-smoothstreaming_1.md">BeginPersist</a> method.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /> <img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="ismoothstreamingcache-endretrieve-method-microsoft-web-media-smoothstreaming_1.md">EndRetrieve</a></td>
<td>Ends an asynchronous cache response retrieval started by the <a href="ismoothstreamingcache-beginretrieve-method-microsoft-web-media-smoothstreaming_1.md">BeginRetrieve</a> method.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="ismoothstreamingcache-openmedia-method-microsoft-web-media-smoothstreaming.md">OpenMedia</a></td>
<td>Opens the specified media for <a href="ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md">ISmoothStreamingCache</a> operations.</td>
</tr>
</tbody>
</table>


Top

## See Also

#### Reference

[ISmoothStreamingCache Interface](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

