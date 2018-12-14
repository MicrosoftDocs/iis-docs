---
title: ManifestInfo.ChunkListChanged Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ChunkListChanged Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.ManifestInfo.ChunkListChanged
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.manifestinfo.chunklistchanged(v=VS.90)
ms:contentKeyID: 31469283
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.ChunkListChanged
dev_langs:
- CSharp
- JScript
- VB
- c++
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
ROBOTS: INDEX,FOLLOW
---

# ChunkListChanged Event

Event activated when the fragment info of a new text/binary chunk in live scenario is added to the manifest. This event will fire on the UI thread.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
Public Event ChunkListChangedAsEventHandler(OfStreamUpdatedEventArgs)
'Usage
DiminstanceAsManifestInfoDimhandlerAsEventHandler(OfStreamUpdatedEventArgs)

AddHandler instance.ChunkListChanged, handler
```

``` csharp
public event EventHandler<StreamUpdatedEventArgs> ChunkListChanged
```

``` c++
public:
 eventEventHandler<StreamUpdatedEventArgs^>^ ChunkListChanged {
    voidadd (EventHandler<StreamUpdatedEventArgs^>^ value);
    voidremove (EventHandler<StreamUpdatedEventArgs^>^ value);
}
```

``` jscript
JScript does not support events.
```

## Version Information

#### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[ManifestInfo Class](manifestinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

