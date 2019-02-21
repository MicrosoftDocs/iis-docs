---
title: CacheRequest2.SelectableTracks Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SelectableTracks Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.CacheRequest2.SelectableTracks
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.cacherequest2.selectabletracks(v=VS.95)
ms:contentKeyID: 46307741
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.CacheRequest2.set_SelectableTracks
- Microsoft.Web.Media.SmoothStreaming.CacheRequest2.get_SelectableTracks
- Microsoft.Web.Media.SmoothStreaming.CacheRequest2.SelectableTracks
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheRequest2.get_SelectableTracks
- Microsoft.Web.Media.SmoothStreaming.CacheRequest2.SelectableTracks
- Microsoft.Web.Media.SmoothStreaming.CacheRequest2.set_SelectableTracks
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# CacheRequest2.SelectableTracks Property

Gets a list of suggested tracks for the cache plug-in to choose for downloading.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property SelectableTracks As IList(Of TrackInfo)
    Get
    Private Set
'Usage

Dim instance As CacheRequest2
Dim value As IList(Of TrackInfo)

value = instance.SelectableTracks
```

```csharp
public IList<TrackInfo> SelectableTracks { get; private set; }
```

```cpp
public:
property IList<TrackInfo^>^ SelectableTracks {
    IList<TrackInfo^>^ get ();
    private: void set (IList<TrackInfo^>^ value);
}
```

``` fsharp
member SelectableTracks : IList<TrackInfo> with get, private set
```

```jscript
function get SelectableTracks () : IList<TrackInfo>
private function set SelectableTracks (value : IList<TrackInfo>)
```

### Property Value

Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/library/5y536ey6\(v=vs.95\))\<[TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)\>  
An [IList\<T\>](https://msdn.microsoft.com/library/5y536ey6\(v=vs.95\)) object that represents the list of tracks.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[CacheRequest2 Class](cacherequest2-class-microsoft-web-media-smoothstreaming.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

