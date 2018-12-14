---
title: ManifestInfo.SelectStreamsCompleted Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SelectStreamsCompleted Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.ManifestInfo.SelectStreamsCompleted
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.manifestinfo.selectstreamscompleted(v=VS.90)
ms:contentKeyID: 31469224
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.SelectStreamsCompleted
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.add_SelectStreamsCompleted
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.remove_SelectStreamsCompleted
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.SelectStreamsCompleted
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SelectStreamsCompleted Event

Event activated when a [SelectStreamsAsync](segmentinfo-selectstreamsasync-method-microsoft-web-media-smoothstreaming_1.md) call has completed in any of the segments contained in [Segments](manifestinfo-segments-property-microsoft-web-media-smoothstreaming_1.md).

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
Public Event SelectStreamsCompletedAsEventHandler(OfStreamUpdatedListEventArgs)
'Usage
DiminstanceAsManifestInfoDimhandlerAsEventHandler(OfStreamUpdatedListEventArgs)

AddHandler instance.SelectStreamsCompleted, handler
```

``` csharp
public event EventHandler<StreamUpdatedListEventArgs> SelectStreamsCompleted
```

``` c++
public:
 eventEventHandler<StreamUpdatedListEventArgs^>^ SelectStreamsCompleted {
    voidadd (EventHandler<StreamUpdatedListEventArgs^>^ value);
    voidremove (EventHandler<StreamUpdatedListEventArgs^>^ value);
}
```

``` jscript
JScript does not support events.
```

## Remarks

By convention, the list of [StreamUpdatedEventArgs](streamupdatedeventargs-class-microsoft-web-media-smoothstreaming_1.md) is ordered such that all de-selections happen first, followed by selections.

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[ManifestInfo Class](manifestinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

