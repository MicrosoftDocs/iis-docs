---
title: StreamUpdatedEventArgs.StreamUpdatedAction Enumeration (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: StreamUpdatedEventArgs.StreamUpdatedAction Enumeration
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.StreamUpdatedAction
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.streamupdatedeventargs.streamupdatedaction(v=VS.95)
ms:contentKeyID: 46307951
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.StreamUpdatedAction
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.StreamUpdatedAction.ChunkAdded
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.StreamUpdatedAction.ChunkRemoved
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.StreamUpdatedAction.StreamDeselected
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.StreamUpdatedAction.StreamSelected
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedAction
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.StreamUpdatedAction.ChunkAdded
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.StreamUpdatedAction.StreamSelected
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.StreamUpdatedAction.ChunkRemoved
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.StreamUpdatedAction.StreamDeselected
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# StreamUpdatedEventArgs.StreamUpdatedAction Enumeration

Action enumeration for the Microsoft.Web.Media.SmoothStreaming.ManifestInfo.StreamSelected, Microsoft.Web.Media.SmoothStreaming.ManifestInfo.ChunkAdded and Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.StreamUpdatedAction.TracksSelected in the [StreamUpdatedEventArgs](streamupdatedeventargs-class-microsoft-web-media-smoothstreaming_1.md) class.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Enumeration StreamUpdatedAction
'Usage

Dim instance As StreamUpdatedEventArgs.StreamUpdatedAction
```

``` csharp
public enum StreamUpdatedAction
```

``` c++
public enum class StreamUpdatedAction
```

``` fsharp
type StreamUpdatedAction
```

``` jscript
public enum StreamUpdatedAction
```

## Members

<table>
<thead>
<tr class="header">
<th></th>
<th>Member name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td>StreamSelected</td>
<td>Stream selected. See <a href="streaminfo-class-microsoft-web-media-smoothstreaming_1.md">StreamInfo</a>.</td>
</tr>
<tr class="even">
<td><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td>StreamDeselected</td>
<td>Stream unselected. See <a href="streaminfo-class-microsoft-web-media-smoothstreaming_1.md">StreamInfo</a>.</td>
</tr>
<tr class="odd">
<td><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td>ChunkAdded</td>
<td>Chunk added. See <a href="chunkinfo-class-microsoft-web-media-smoothstreaming_1.md">ChunkInfo</a>.</td>
</tr>
<tr class="even">
<td><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td>ChunkRemoved</td>
<td>Chunk removed. See <a href="chunkinfo-class-microsoft-web-media-smoothstreaming_1.md">ChunkInfo</a>.</td>
</tr>
</tbody>
</table>


## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

