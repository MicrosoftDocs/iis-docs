---
title: ClipProgress Enumeration (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ClipProgress Enumeration
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.ClipProgress
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.clipprogress(v=VS.95)
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
- csharp
- jscript
- vb
- FSharp
- cpp
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
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ClipProgress Enumeration

Enumeration that specifies the stages of progress through a media clip.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Enumeration ClipProgress
'Usage

Dim instance As ClipProgress
```

```csharp
public enum ClipProgress
```

```cpp
public enum class ClipProgress
```

``` fsharp
type ClipProgress
```

```jscript
public enum ClipProgress
```

## Members

||Member name|Description|
|--- |--- |--- |
||Start|The media clip is at the start of its duration.|
||FirstQuartile|The media clip has reached the end of the first 25% of its duration.|
||Midpoint|The media clip is at the midpoint of its duration.|
||ThirdQuartile|The media clip has reached the end of the third 25% of its duration.|
||Complete|The media clip has reached the end.|
||Unknown|The progress of the media clip is unknown.|

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
