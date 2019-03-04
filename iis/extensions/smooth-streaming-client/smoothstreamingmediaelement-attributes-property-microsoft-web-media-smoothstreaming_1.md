---
title: SmoothStreamingMediaElement.Attributes Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Attributes Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Attributes
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.attributes(v=VS.95)
ms:contentKeyID: 46307810
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Attributes
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_Attributes
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_Attributes
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Attributes
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_Attributes
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_Attributes
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingMediaElement.Attributes Property

Gets or sets the attributes dictionary.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property Attributes As Dictionary(Of String, String)
    Get
    Set
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As Dictionary(Of String, String)

value = instance.Attributes

instance.Attributes = value
```

```csharp
public Dictionary<string, string> Attributes { get; set; }
```

```cpp
public:
property Dictionary<String^, String^>^ Attributes {
    Dictionary<String^, String^>^ get ();
    void set (Dictionary<String^, String^>^ value);
}
```

``` fsharp
member Attributes : Dictionary<string, string> with get, set
```

```jscript
function get Attributes () : Dictionary<String, String>
function set Attributes (value : Dictionary<String, String>)
```

### Property Value

Type: [System.Collections.Generic.Dictionary](https://msdn.microsoft.com/library/xfhwa508\(v=vs.95\))\<[String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\)), [String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\))\>  
A dictionary object that contains name/value pairs for the attributes.

## Examples

The following example shows how to get attributes.

``` 
    if (streamInfo.Attributes["Name"] == "ClosedCaptions" ||
                            streamInfo.Attributes["Name"] == "MARKERS")
    {
        selectStreams.Add(streamInfo);
        segmentInfo.SelectStreamsAsync(selectStreams);

        foreach (TrackInfo trackInfo in streamInfo.SelectedTracks)
        {
            foreach (ChunkInfo chunk in streamInfo.ChunkList.ToList<ChunkInfo>())
            {
                IAsyncResult ar =
                    trackInfo.BeginGetChunk(
                    chunk.TimeStamp, new AsyncCallback(AddMarkers), streamInfo.UniqueId);
            }
        }
    }
```

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

