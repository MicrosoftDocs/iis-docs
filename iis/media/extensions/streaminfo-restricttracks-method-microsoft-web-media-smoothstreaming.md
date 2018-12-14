---
title: StreamInfo.RestrictTracks Method  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: RestrictTracks Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.StreamInfo.RestrictTracks(System.Collections.Generic.IList{Microsoft.Web.Media.SmoothStreaming.TrackInfo})
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.streaminfo.restricttracks(v=VS.90)
ms:contentKeyID: 32316459
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.RestrictTracks
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.RestrictTracks
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# RestrictTracks Method

Replaces [AvailableTracks](streaminfo-availabletracks-property-microsoft-web-media-smoothstreaming_1.md) with the list of available tracks supplied by the parameter. Also restricts decoder initialization to the given list of available tracks to avoid initializing the decoder with unsupported modes.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicSubRestrictTracks ( _
    availableTracksAsIList(OfTrackInfo) _
)
'Usage
DiminstanceAsStreamInfoDimavailableTracksAsIList(OfTrackInfo)

instance.RestrictTracks(availableTracks)
```

``` csharp
publicvoidRestrictTracks(
    IList<TrackInfo> availableTracks
)
```

``` c++
public:
voidRestrictTracks(
    IList<TrackInfo^>^ availableTracks
)
```

``` jscript
publicfunctionRestrictTracks(
    availableTracks : IList<TrackInfo>
)
```

#### Parameters

  - availableTracks  
    Type: [System.Collections.Generic. . :: . .IList](https://msdn.microsoft.com/en-us/library/5y536ey6\(v=vs.90\))\< (Of \< ( \<'[TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)\> ) \> ) \>  
    A new list of available tracks. The list must be a strict subset of current [AvailableTracks](streaminfo-availabletracks-property-microsoft-web-media-smoothstreaming_1.md).  

## Remarks

The [SelectTracks(IList\<(Of \<\<'(TrackInfo\>)\>\>), Boolean)](streaminfo-selecttracks-method-microsoft-web-media-smoothstreaming_1.md) method will automatically be called with the given list of available tracks. Note that [SelectedTracks](streaminfo-selectedtracks-property-microsoft-web-media-smoothstreaming_1.md) will not be updated until after the [ManifestReady](smoothstreamingmediaelement-manifestready-event-microsoft-web-media-smoothstreaming_1.md) event. Only video track restriction is supported in this release.

The RestrictTracks(IList\<(Of \<\<'(TrackInfo\>)\>\>)) method is used to work around some of the limitations of Windows Phone 7. Windows Phone 7 does not support dynamic resolution changes, and H264 support extends only to level 3.0. These are Windows Phone 7 limitations, not specific to the Smooth Streaming Media Element.

The following example restricts tracks to tracks of the same resolution.

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

## Version Information

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[StreamInfo Class](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

