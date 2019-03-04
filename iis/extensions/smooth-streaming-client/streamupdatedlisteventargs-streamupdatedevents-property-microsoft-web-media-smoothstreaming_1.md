---
title: StreamUpdatedListEventArgs.StreamUpdatedEvents Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: StreamUpdatedEvents Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.StreamUpdatedListEventArgs.StreamUpdatedEvents
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.streamupdatedlisteventargs.streamupdatedevents(v=VS.95)
ms:contentKeyID: 46307891
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedListEventArgs.get_StreamUpdatedEvents
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedListEventArgs.StreamUpdatedEvents
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedListEventArgs.get_StreamUpdatedEvents
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedListEventArgs.StreamUpdatedEvents
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# StreamUpdatedListEventArgs.StreamUpdatedEvents Property

Gets the list of stream updated events.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public ReadOnly Property StreamUpdatedEvents As IList(Of StreamUpdatedEventArgs)
    Get
'Usage

Dim instance As StreamUpdatedListEventArgs
Dim value As IList(Of StreamUpdatedEventArgs)

value = instance.StreamUpdatedEvents
```

```csharp
public IList<StreamUpdatedEventArgs> StreamUpdatedEvents { get; }
```

```cpp
public:
property IList<StreamUpdatedEventArgs^>^ StreamUpdatedEvents {
    IList<StreamUpdatedEventArgs^>^ get ();
}
```

``` fsharp
member StreamUpdatedEvents : IList<StreamUpdatedEventArgs>
```

```jscript
function get StreamUpdatedEvents () : IList<StreamUpdatedEventArgs>
```

### Property Value

Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/library/5y536ey6\(v=vs.95\))\<[StreamUpdatedEventArgs](streamupdatedeventargs-class-microsoft-web-media-smoothstreaming_1.md)\>  
An IList of [StreamUpdatedEventArgs](streamupdatedeventargs-class-microsoft-web-media-smoothstreaming_1.md) objects.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[StreamUpdatedListEventArgs Class](streamupdatedlisteventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

