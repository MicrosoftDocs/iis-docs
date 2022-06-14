---
title: StreamUpdatedEventArgs.StreamUpdatedAction Enumeration (Microsoft.Web.Media.SmoothStreaming)
description: This article details syntax, members, and version information of the StreamUpdatedAction Enumeration.
TOCTitle: StreamUpdatedEventArgs.StreamUpdatedAction Enumeration
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.StreamUpdatedAction
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.streamupdatedeventargs.streamupdatedaction(v=VS.95)
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
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedAction
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.StreamUpdatedAction.ChunkAdded
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.StreamUpdatedAction.StreamSelected
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.StreamUpdatedAction.ChunkRemoved
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.StreamUpdatedAction.StreamDeselected
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# StreamUpdatedEventArgs.StreamUpdatedAction Enumeration

Action enumeration for the Microsoft.Web.Media.SmoothStreaming.ManifestInfo.StreamSelected, Microsoft.Web.Media.SmoothStreaming.ManifestInfo.ChunkAdded and Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.StreamUpdatedAction.TracksSelected in the [StreamUpdatedEventArgs](streamupdatedeventargs-class-microsoft-web-media-smoothstreaming_1.md) class.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Enumeration StreamUpdatedAction
'Usage

Dim instance As StreamUpdatedEventArgs.StreamUpdatedAction
```

```csharp
public enum StreamUpdatedAction
```

```cpp
public enum class StreamUpdatedAction
```

``` fsharp
type StreamUpdatedAction
```

```jscript
public enum StreamUpdatedAction
```

## Members

|Support Type|Member name|Description|
|--- |--- |--- |
|![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|StreamSelected|Stream selected. See [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md).|
|![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|StreamDeselected|Stream unselected. See [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md).|
|![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|ChunkAdded|Chunk added. See [ChunkInfo](chunkinfo-class-microsoft-web-media-smoothstreaming_1.md).|
|![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|ChunkRemoved|Chunk removed. See [ChunkInfo](chunkinfo-class-microsoft-web-media-smoothstreaming_1.md).|

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
