---
title: ManifestInfo.ChunkListChanged Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ChunkListChanged Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.ManifestInfo.ChunkListChanged
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.manifestinfo.chunklistchanged(v=VS.95)
ms:contentKeyID: 46307508
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.ChunkListChanged
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.add_ChunkListChanged
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.ChunkListChanged
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.remove_ChunkListChanged
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# ManifestInfo.ChunkListChanged Event

Event activated when the fragment info of a new text/binary chunk in a live scenario is added to the manifest. This event will fire on the UI thread.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Event ChunkListChanged As EventHandler(Of StreamUpdatedEventArgs)
'Usage

Dim instance As ManifestInfo
Dim handler As EventHandler(Of StreamUpdatedEventArgs)

AddHandler instance.ChunkListChanged, handler
```

```csharp
public event EventHandler<StreamUpdatedEventArgs> ChunkListChanged
```

```cpp
public:
 event EventHandler<StreamUpdatedEventArgs^>^ ChunkListChanged {
    void add (EventHandler<StreamUpdatedEventArgs^>^ value);
    void remove (EventHandler<StreamUpdatedEventArgs^>^ value);
}
```

``` fsharp
member ChunkListChanged : <EventHandler<StreamUpdatedEventArgs>,
    StreamUpdatedEventArgs>
```

```jscript
JScript supports the use of events, but not the declaration of new ones.
```

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[ManifestInfo Class](manifestinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

