---
title: StreamInfo.RestrictTracks Method  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: RestrictTracks Method
description: Describes the StreamInfo.RestrictTracks method and provides the namespace, assembly, syntax, parameters, and version information.
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.StreamInfo.RestrictTracks(System.Collections.Generic.IList{Microsoft.Web.Media.SmoothStreaming.TrackInfo})
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.streaminfo.restricttracks(v=VS.95)
ms:contentKeyID: 46307706
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.RestrictTracks
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.RestrictTracks
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# StreamInfo.RestrictTracks Method

Replaces [AvailableTracks](streaminfo-availabletracks-property-microsoft-web-media-smoothstreaming_1.md) with the specified list of available tracks.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Sub RestrictTracks ( _
    availableTracks As IList(Of TrackInfo) _
)
'Usage

Dim instance As StreamInfo
Dim availableTracks As IList(Of TrackInfo)

instance.RestrictTracks(availableTracks)
```

```csharp
public void RestrictTracks(
    IList<TrackInfo> availableTracks
)
```

```cpp
public:
void RestrictTracks(
    IList<TrackInfo^>^ availableTracks
)
```

``` fsharp
member RestrictTracks : 
        availableTracks:IList<TrackInfo> -> unit 
```

```jscript
public function RestrictTracks(
    availableTracks : IList<TrackInfo>
)
```

### Parameters

  - availableTracks  
    Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/library/5y536ey6\(v=vs.95\))\<[TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)\>  
    A new list of available tracks. The list must be a strict subset of current [AvailableTracks](streaminfo-availabletracks-property-microsoft-web-media-smoothstreaming_1.md).

## Remarks

The RestrictTracks method is supported for video and audio tracks. It restricts decoder initialization to the given list of available tracks to avoid initializing the decoder with unsupported modes.

You can use the RestrictTracks method to enable scenarios in which multiple audio languages are present in the manifest, each with 5.1 and stereo encoding.

The [SelectTracks(IList\<TrackInfo\>, Boolean)](streaminfo-selecttracks-method-microsoft-web-media-smoothstreaming_1.md) method will automatically be called with the given list of available tracks. Note that [SelectedTracks](streaminfo-selectedtracks-property-microsoft-web-media-smoothstreaming_1.md) will not be updated until after the [ManifestReady](smoothstreamingmediaelement-manifestready-event-microsoft-web-media-smoothstreaming_1.md) event.

RestrictTracks can be used to handle scenarios in which there may be differing support for multiple-resolution content. For example, early versions of Windows Phone do not support dynamic resolution changes. For more information, see [Supported Media Codecs for Windows Phone](https://msdn.microsoft.com/library/ff462087\(v=vs.92\).aspx).

The following example restricts tracks to tracks of the same resolution.

```csharp
void OnManifestReady(object sender, EventArgs e)
{
    SmoothStreamingMediaElement ssme = sender as SmoothStreamingMediaElement;

    if (ssme == null)
    {
        return;
    }

    // Select the highest band of tracks which all have the same resolution.
    // maxMobileBitrate depends on the encoding settings
    const ulong maxMobileBitrate = 1000000;
    foreach (SegmentInfo segment in ssme.ManifestInfo.Segments)
    {
        foreach (StreamInfo streamInfo in segment.AvailableStreams)
        {
            if (MediaStreamType.Video == streamInfo.Type)
            {
                List<TrackInfo> widestBand = new List<TrackInfo>();
                List<TrackInfo> currentBand = new List<TrackInfo>();
                ulong lastHeight = 0;
                ulong lastWidth = 0;
                ulong index = 0;

                foreach (TrackInfo track in streamInfo.AvailableTracks)
                {
                    index += 1;

                    string strMaxWidth;
                    string strMaxHeight;
                    // If can't find width/height, choose only the top bitrate.
                    ulong ulMaxWidth = index;
                    // If can't find width/height, choose only the top bitrate.
                    ulong ulMaxHeight = index;
                    // V2 manifests require "MaxWidth", while v1 manifests used "Width".
                    if (track.Attributes.TryGetValue("MaxWidth", out strMaxWidth) ||
                        track.Attributes.TryGetValue("Width", out strMaxWidth))
                    {
                        ulong.TryParse(strMaxWidth, out ulMaxWidth);
                    }

                    if (track.Attributes.TryGetValue("MaxHeight", out strMaxHeight) ||
                        track.Attributes.TryGetValue("Height", out strMaxHeight))
                    {
                        ulong.TryParse(strMaxHeight, out ulMaxHeight);
                    }

                    if (ulMaxWidth != lastWidth ||
                        ulMaxHeight != lastHeight)
                    {
                        // Current band is now finished, check if it is the widest.
                        // If same size, current band preferred over previous
                        // widest, because it will be of higher bitrate.
                        if (currentBand.Count >= widestBand.Count)
                        {
                            //  A new widest band:
                            widestBand = currentBand;
                            currentBand = new List<TrackInfo>();
                        }
                    }

                    if (track.Bitrate > maxMobileBitrate)
                    {
                        break;
                    }

                    // Current track always gets added to current band.
                    currentBand.Add(track);
                    lastWidth = ulMaxWidth;
                    lastHeight = ulMaxHeight;
                }

                if (0 == widestBand.Count &&
                    0 == currentBand.Count)
                {
                    // Lowest bitrate band is > maxMobileBitrate.
                    widestBand.Add(streamInfo.AvailableTracks[0]);
                }
                else if (currentBand.Count >= widestBand.Count)
                {
                    // Need to check the last band which was constructed.
                    Debug.Assert(currentBand.Count > 0);
                    widestBand = currentBand; // Winner by default.
                }

                Debug.Assert(widestBand.Count >= 1);
                streamInfo.RestrictTracks(widestBand);
            }
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

[StreamInfo Class](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
