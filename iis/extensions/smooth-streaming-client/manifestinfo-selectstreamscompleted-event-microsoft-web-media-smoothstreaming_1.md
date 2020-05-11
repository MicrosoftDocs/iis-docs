---
title: ManifestInfo.SelectStreamsCompleted Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SelectStreamsCompleted Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.ManifestInfo.SelectStreamsCompleted
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.manifestinfo.selectstreamscompleted(v=VS.95)
ms:contentKeyID: 46307509
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.SelectStreamsCompleted
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.add_SelectStreamsCompleted
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.remove_SelectStreamsCompleted
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.SelectStreamsCompleted
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ManifestInfo.SelectStreamsCompleted Event

Event activated when a [SelectStreamsAsync](segmentinfo-selectstreamsasync-method-microsoft-web-media-smoothstreaming_1.md) call has completed in any of the segments contained in [Segments](manifestinfo-segments-property-microsoft-web-media-smoothstreaming_1.md).

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Event SelectStreamsCompleted As EventHandler(Of StreamUpdatedListEventArgs)
'Usage

Dim instance As ManifestInfo
Dim handler As EventHandler(Of StreamUpdatedListEventArgs)

AddHandler instance.SelectStreamsCompleted, handler
```

```csharp
public event EventHandler<StreamUpdatedListEventArgs> SelectStreamsCompleted
```

```cpp
public:
 event EventHandler<StreamUpdatedListEventArgs^>^ SelectStreamsCompleted {
    void add (EventHandler<StreamUpdatedListEventArgs^>^ value);
    void remove (EventHandler<StreamUpdatedListEventArgs^>^ value);
}
```

``` fsharp
member SelectStreamsCompleted : <EventHandler<StreamUpdatedListEventArgs>,
    StreamUpdatedListEventArgs>
```

```jscript
JScript supports the use of events, but not the declaration of new ones.
```

## Remarks

By convention, the list of [StreamUpdatedEventArgs](streamupdatedeventargs-class-microsoft-web-media-smoothstreaming_1.md) is ordered such that all de-selections happen first, followed by selections.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[ManifestInfo Class](manifestinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
