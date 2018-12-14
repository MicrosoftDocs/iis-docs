---
title: ClipProgress Enumeration (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ClipProgress Enumeration
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.ClipProgress
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.clipprogress(v=VS.95)
ms:contentKeyID: 46307953
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipProgress.FirstQuartile
- Microsoft.Web.Media.SmoothStreaming.ClipProgress.Midpoint
- Microsoft.Web.Media.SmoothStreaming.ClipProgress.Complete
- Microsoft.Web.Media.SmoothStreaming.ClipProgress
- Microsoft.Web.Media.SmoothStreaming.ClipProgress.ThirdQuartile
- Microsoft.Web.Media.SmoothStreaming.ClipProgress.Unknown
- Microsoft.Web.Media.SmoothStreaming.ClipProgress.Start
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipProgress
- Microsoft.Web.Media.SmoothStreaming.ClipProgress.Complete
- Microsoft.Web.Media.SmoothStreaming.ClipProgress.Start
- Microsoft.Web.Media.SmoothStreaming.ClipProgress.FirstQuartile
- Microsoft.Web.Media.SmoothStreaming.ClipProgress.ThirdQuartile
- Microsoft.Web.Media.SmoothStreaming.ClipProgress.Midpoint
- Microsoft.Web.Media.SmoothStreaming.ClipProgress.Unknown
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ClipProgress Enumeration

Enumeration that specifies the stages of progress through a media clip.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Enumeration ClipProgress
'Usage

Dim instance As ClipProgress
```

``` csharp
public enum ClipProgress
```

``` c++
public enum class ClipProgress
```

``` fsharp
type ClipProgress
```

``` jscript
public enum ClipProgress
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
<td></td>
<td>Start</td>
<td>The media clip is at the start of its duration.</td>
</tr>
<tr class="even">
<td></td>
<td>FirstQuartile</td>
<td>The media clip has reached the end of the first 25% of its duration.</td>
</tr>
<tr class="odd">
<td></td>
<td>Midpoint</td>
<td>The media clip is at the midpoint of its duration.</td>
</tr>
<tr class="even">
<td></td>
<td>ThirdQuartile</td>
<td>The media clip has reached the end of the third 25% of its duration.</td>
</tr>
<tr class="odd">
<td></td>
<td>Complete</td>
<td>The media clip has reached the end.</td>
</tr>
<tr class="even">
<td></td>
<td>Unknown</td>
<td>The progress of the media clip is unknown.</td>
</tr>
</tbody>
</table>


## Version Information

#### Silverlight

Supported in: 5  

## See Also

#### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

