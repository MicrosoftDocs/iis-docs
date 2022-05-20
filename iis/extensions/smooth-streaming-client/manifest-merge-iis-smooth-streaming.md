---
title: Manifest Merge (IIS Smooth Streaming)
description: The ManifestMerge event provides an option to add information to the client manifest that is used by a Smooth Streaming application.
TOCTitle: Manifest Merge (IIS Smooth Streaming)
ms:assetid: 895dbdd8-5069-4214-a18d-1e54b9986288
ms:mtpsurl: https://msdn.microsoft.com/library/Ff432455(v=VS.90)
ms:contentKeyID: 28868862
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Manifest Merge (IIS Smooth Streaming)

The [ManifestMerge](smoothstreamingmediaelement-manifestmerge-event-microsoft-web-media-smoothstreaming_1.md) event provides an option to add information to the client manifest that is used by a Smooth Streaming application. The data obtained by this process becomes an integral part of the client manifest and is available for use as defined by the application. The [ManifestMerge](smoothstreamingmediaelement-manifestmerge-event-microsoft-web-media-smoothstreaming_1.md) event occurs before the [MediaOpened](smoothstreamingmediaelement-mediaopened-event-microsoft-web-media-smoothstreaming_1.md) event and supports methods that obtain and merge information from other sources. This is useful for situations in which the manifest is inaccessible for editing or if some information depends on locale, style, or other factors that would make the manifest too large or too slow to load if all the options were included.

> [!NOTE]  
> The examples in this topic extend features demonstrated in other topics in [IIS Smooth Streaming Client 1.5](microsoft-smooth-streaming-client-2-0.md). All the code is available for download in the [IIS Smooth Streaming Sample Application](https://go.microsoft.com/fwlink/?linkid=182167).

## ManifestMerge

To use the [ManifestMerge](smoothstreamingmediaelement-manifestmerge-event-microsoft-web-media-smoothstreaming_1.md) event, assign a delegate as shown in the following example.

```csharp
SmoothPlayer.ManifestMerge +=
  new SmoothStreamingMediaElement.ManifestMergeHandler(SmoothPlayer_ManifestMerge);
```

The following implementation of the SmoothPlayer\_ManifestMerge delegate includes options to load supplementary manifest data from sources represented by the variable mediaSelection, which is an integer assigned when the source is selected. The methods that load the new data are discussed under the headings "ParseExternalManifest" and "MergeExternalManifest," which follow the code snippet. This example can load manifest data from two sources and initialized the objects parsedExternManifest and parsedExternManifest2.

```csharp
void SmoothPlayer_ManifestMerge(SmoothStreamingMediaElement ssme)
{
    // Out parameter for ParseExternalManifest function.
    object parsedExternManifest = null;
    object parsedExternManifest2 = null;

    try
    {
        if (mediaSelection.Equals(0))
        {
            Uri uriExtManifest = new Uri("http://<serverName>/BigBuckBunnyCaptions.xml");
            SmoothPlayer.ParseExternalManifest(uriExtManifest, 3000, out parsedExternManifest);
            SmoothPlayer.MergeExternalManifest(parsedExternManifest);
        }

        if (mediaSelection.Equals(1))
        {

            Uri uriExtManifest = new Uri("http://win-qkkwoqg5tnd/AdrenalineRush.xml");
            SmoothPlayer.ParseExternalManifest(uriExtManifest, 3000, out parsedExternManifest);
            SmoothPlayer.MergeExternalManifest(parsedExternManifest);

            Uri uriExtManifest2 = new Uri("http://<serverName>/AdrenalineRushCaptions.xml");
            SmoothPlayer.ParseExternalManifest(uriExtManifest2, 3000, out parsedExternManifest2);
            SmoothPlayer.MergeExternalManifest(parsedExternManifest2);
        }
    }
    catch(Exception ex )
    {
        OutputText.Text = ex.Message + " Inner Exception: " + ex.InnerException;
    }
}
```

### ParseExternalManifest

Applications can call [ParseExternalManifest](smoothstreamingmediaelement-parseexternalmanifest-method-microsoft-web-media-smoothstreaming_1.md) only from the [ManifestMerge](smoothstreamingmediaelement-manifestmerge-event-microsoft-web-media-smoothstreaming_1.md) event handler. Outside the scope of the method [ParseExternalManifest](smoothstreamingmediaelement-parseexternalmanifest-method-microsoft-web-media-smoothstreaming_1.md), applications will throw an [InvalidOperationException](https://go.microsoft.com/fwlink/?linkid=184079).

The [ParseExternalManifest](smoothstreamingmediaelement-parseexternalmanifest-method-microsoft-web-media-smoothstreaming_1.md) method reads XML data from a source identified by the first parameter. To avoid application blocking, the second parameter sets a time-out interval in milliseconds. The third parameter is an out parameter that returns the parsed manifest data.

```csharp
// Out parameter for function.
Uri uriExtManifest = new Uri("http://serverName/BigBuckBunnyCaptions.xml");
SmoothPlayer.ParseExternalManifest(uriExtManifest, 3000, out parsedExternManifest);
```

### MergeExternalManifest

Applications can call [MergeExternalManifest](smoothstreamingmediaelement-mergeexternalmanifest-method-microsoft-web-media-smoothstreaming_1.md) only from the [ManifestMerge](smoothstreamingmediaelement-manifestmerge-event-microsoft-web-media-smoothstreaming_1.md) event handler. Outside the scope of the method \[M:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.MergeExternalManifest(System.Object),applications\] will throw an [InvalidOperationException](https://go.microsoft.com/fwlink/?linkid=184079).

The [MergeExternalManifest](smoothstreamingmediaelement-mergeexternalmanifest-method-microsoft-web-media-smoothstreaming_1.md) method integrates data in the client manifest with new XML data identified by the first parameter, which is the parsed data obtained from a previous call to [ParseExternalManifest](smoothstreamingmediaelement-parseexternalmanifest-method-microsoft-web-media-smoothstreaming_1.md).

```csharp
SmoothPlayer.MergeExternalManifest(parsedExternManifest);
```

## Supplementary Manifest Data

The data to be merged during the [ManifestMerge](smoothstreamingmediaelement-manifestmerge-event-microsoft-web-media-smoothstreaming_1.md) event must be formatted as an XML StreamIndex element, which can be defined as needed for application use. For example, the following supplementary data defines captions for display at timed intervals while the media stream plays. As in the original client manifest, an XML \<SmoothStreamingMedia\> element contains the data. In this case the data in the supplementary \<StreamIndex\> element is a list of captions. XML c elements contain each data fragment with number n and timestamp t attributes. As in the client manifest, the data fragments f are formatted as base64 strings. For more information about how to format base64 strings, see the [Encoding](https://msdn.microsoft.com/library/system.text.encoding.aspx) class.

```xml
<?xml version="1.0" encoding="utf-8"?>
<!--Created with Expression Encoder version 3.0.1332.0-->
<SmoothStreamingMedia
MajorVersion="2"
MinorVersion="0"
Duration="1093950000">

<StreamIndex Type="text" Name="ClosedCaptions" Subtype="CAPT" TimeScale="10000000"
              ParentStreamIndex="video" ManifestOutput="TRUE" QualityLevels="1"
              Chunks="18" Url="QualityLevels({bitrate}, 
              {CustomAttributes})/Fragments (ClosedCaptions={start time})">

  <QualityLevel Index="0" Bitrate="1000" CodecPrivateData="" FourCC="" />

  <c n="0" t="600000000">
    <f>PENhcHRpb24gSWQ9IjAwMCIgQWN0aW9uPSJBREQiPkNoYXB0ZXIgT25lPC9DYXB0aW9uPg==</f>
  </c>
  <c n="1" t="660000000">
    <f>PENhcHRpb24gSWQ9IjAwMCIgQWN0aW9uPSJSRU1PVkUiLz4=</f>
  </c>
  <c n="2" t="1200000000">
    <f>PENhcHRpb24gSWQ9IjExMSIgQWN0aW9uPSJBREQiPkNoYXB0ZXIgVHdvPC9DYXB0aW9uPg==</f>
  </c>
  <c n="3" t="1260000000">
    <f>PENhcHRpb24gSWQ9IjExMSIgQWN0aW9uPSJSRU1PVkUiLz4=</f>
  </c>
  <c n="4" t="1740000000">
    <f>
      PENhcHRpb24gSWQ9IjIyMiIgQWN0aW9uPSJBREQiPkluc2VydGVkIENsaXAgTmV4dC48L0NhcHRpb24+</f>
  </c>
  <c n="5" t="1760000000">
    <f>
      PENhcHRpb24gSWQ9IjIyMiIgQWN0aW9uPSJSRU1PVkUiLz4=</f>
  </c>
  <c n="6" t="2400000000">
    <f>
      PENhcHRpb24gSWQ9IjQ0NCIgQWN0aW9uPSJBREQiPkNoYXB0ZXIgRm91cjwvQ2FwdGlvbj4=</f>
  </c>
  <c n="7" t="2440000000">
    <f>PENhcHRpb24gSWQ9IjQ0NCIgQWN0aW9uPSJSRU1PVkUiLz4=</f>
  </c>
  <c n="8" t="3000000000">
    <f>
      PENhcHRpb24gSWQ9IjQ0NCIgQWN0aW9uPSJBREQiPkNoYXB0ZXIgRml2ZTwvQ2FwdGlvbj4=</f>
  </c>
  <c n="9" t="3060000000">
    <f>PENhcHRpb24gSWQ9IjQ0NCIgQWN0aW9uPSJSRU1PVkUiLz4=</f>
  </c>
  <c n="10" t="3580000000">
    <f>PENhcHRpb24gSWQ9IjU1NSIgQWN0aW9uPSJBREQiPkNoYXB0ZXIgU2l4PC9DYXB0aW9uPg==</f>
  </c>
  <c n="11" t="3620000000">
    <f>PENhcHRpb24gSWQ9IjU1NSIgQWN0aW9uPSJSRU1PVkUiLz4=</f>
  </c>
  <c n="12" t="4180000000">
    <f>PENhcHRpb24gSWQ9IjY2NiIgQWN0aW9uPSJBREQiPkNoYXB0ZXIgU2V2ZW48L0NhcHRpb24+</f>
  </c>
  <c n="13" t="4220000000">
    <f>PENhcHRpb24gSWQ9IjY2NiIgQWN0aW9uPSJSRU1PVkUiLz4=</f>
  </c>
  <c n="14" t="4780000000">
    <f>PENhcHRpb24gSWQ9Ijc3NyIgQWN0aW9uPSJBREQiPkNoYXB0ZXIgRWlnaHQ8L0NhcHRpb24+</f>
  </c>
  <c n="15" t="4820000000">
    <f>PENhcHRpb24gSWQ9Ijc3NyIgQWN0aW9uPSJSRU1PVkUiLz4=</f>
  </c>
  <c n="16" t="5380000000">
    <f>PENhcHRpb24gSWQ9Ijg4OCIgQWN0aW9uPSJBREQiPkVuZCBDcmVkaXRzPC9DYXB0aW9uPg==</f>
  </c>
  <c n="17" t="5420000000">
    <f>PENhcHRpb24gSWQ9Ijg4OCIgQWN0aW9uPSJSRU1PVkUiLz4=</f>
  </c>

</StreamIndex>
```

## Application use of Data from ManifestMerge

The captions from the preceding example are merged with the client manifest during the [ManifestMerge](smoothstreamingmediaelement-manifestmerge-event-microsoft-web-media-smoothstreaming_1.md) event. The application uses captions with the ADD attribute to display captions and those with the REMOVE attribute to remove captions during playback of the media stream. Each fragment f of the data, after decoding, contains an XML element of the following type.

```xml
<Caption Id="111" Action="ADD">Chapter One</Caption>
<Caption Id="111" Action="REMOVE">Chapter One</Caption>
```

The Caption element includes Id and Action attributes and specifies the caption text, in this case "Chapter One." The timestamp t attribute of each content chunk c specifies when to display the caption.

The supplementary manifest implemented above will be merged during the [ManifestMerge](smoothstreamingmediaelement-manifestmerge-event-microsoft-web-media-smoothstreaming_1.md) event. The new merged manifest will contain \<StreamIndex\> data of Type="text" and Name="ClosedCaptions." The captions will be synchronized to the timing of the video stream by the attribute assignment: ParentStreamIndex="video", which means that the timestamp t attributes of the merged \<StreamIndex\> element correspond to the timestamp attributes of the video StreamIndex. The data in sparse streams is not contiguous but is found at distinct locations in the stream and must be keyed to the video stream.

### Initialize Markers

The merged manifest data is shown in the following XML example. This data must be added to the [Markers](smoothstreamingmediaelement-markers-property-microsoft-web-media-smoothstreaming_1.md) collection. Each member of the collection is a [TimeLineMarker](https://msdn.microsoft.com/library/system.windows.media.timelinemarker\(vs.95\).aspx) object that will raise the [MarkerReached](smoothstreamingmediaelement-markerreached-event-microsoft-web-media-smoothstreaming_1.md) event. The following \<StreamIndex\> data was merged into the client manifest in the [ManifestMerge](smoothstreamingmediaelement-manifestmerge-event-microsoft-web-media-smoothstreaming_1.md) delegate as described above in the heading "ManifestMerge."

```xml
<?xml version="1.0" encoding="utf-8"?>
<SmoothStreamingMedia
  MajorVersion="2"
  MinorVersion="0"
  Duration="1093950000">

  <StreamIndex Type="text" Name="MARKERS"
    Subtype="CHAPTER" TimeScale="10000000" ParentStreamIndex="video" ManifestOutput="TRUE" QualityLevels="1"
    Chunks="9" 
    Url="QualityLevels({bitrate},   {CustomAttributes})/Fragments(MARKERS={start time})">
    <QualityLevel Index="0" Bitrate="1000" CodecPrivateData="" FourCC=""/>

    <c n="0" t="40870000">
      <f>Q2hhcHRlciAx</f>
    </c>
    <c n="1" t="192690000">
      <f>Q2hhcHRlciAy</f>
    </c>
    <c n="2" t="410410000">
      <f>Q2hhcHRlciAz</f>
    </c>
    <c n="3" t="621450000">
      <f>Q2hhcHRlciA0</f>
    </c>
    <c n="4" t="680680000">
      <f>Q2hhcHRlciA1</f>
    </c>
    <c n="5" t="782030000">
      <f>Q2hhcHRlciA2</f>
    </c>
    <c n="6" t="888800000">
      <f>Q2hhcHRlciA3</f>
    </c>
    <c n="7" t="980560000">
      <f>Q2hhcHRlciA4</f>
    </c>
    <c n="8" t="1042290000">
      <f>Q2hhcHRlciA5</f>
    </c>
  </StreamIndex>
</SmoothStreamingMedia>
```

After the markers specified in the previous XML are merged into the manifest, the AvailableStreams()()()() property of the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) contains [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) objects that correspond to \<StreamIndex\> elements in the manifest.

The following [MediaOpened](smoothstreamingmediaelement-mediaopened-event-microsoft-web-media-smoothstreaming_1.md) event handler parses the data contained by the AvailableStreams()()()() property. This code identifies the stream that contains the markers by the stream type and attributes. The stream containing the markers is a Script object, which is not included in by default in [SelectedStreams](segmentinfo-selectedstreams-property-microsoft-web-media-smoothstreaming_1.md). It must be selected by calling [SelectStreamsAsync](segmentinfo-selectstreamsasync-method-microsoft-web-media-smoothstreaming_1.md).

The next step is to get the marker data from a [TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md) object that contains the [ChunkInfo](chunkinfo-class-microsoft-web-media-smoothstreaming_1.md) data from which [Timeline Marker](https://go.microsoft.com/fwlink/?linkid=181858) objects can be initialized. The [Timeline Marker](https://go.microsoft.com/fwlink/?linkid=181858) class is from the System.Windows.Media class as used by Silverlight.

The following code calls [BeginGetChunk](trackinfo-begingetchunk-method-microsoft-web-media-smoothstreaming_1.md). with an [AsyncCallback](https://msdn.microsoft.com/library/system.asynccallback.aspx), name AddMarkers, that will extract the data from each chunk.

```csharp
void SmoothPlayer_MediaOpened(object sender, RoutedEventArgs e)
{
    foreach (SegmentInfo segmentInfo in SmoothPlayer.ManifestInfo.Segments)
    {
        List<StreamInfo> selectStreams = segmentInfo.SelectedStreams.ToList<StreamInfo>();
        foreach (StreamInfo streamInfo in segmentInfo.AvailableStreams)
        {
            if (streamInfo.Type == System.Windows.Media.MediaStreamType.Script)
            {
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
            }
        }
    }
}
```

After the following code runs, the markers will raise the [MarkerReached](smoothstreamingmediaelement-markerreached-event-microsoft-web-media-smoothstreaming_1.md) event. The markers can be enumerated from the [Markers](smoothstreamingmediaelement-markers-property-microsoft-web-media-smoothstreaming_1.md) collection.

```csharp
private void AddMarkers(IAsyncResult argAR)
{
    if (!Deployment.Current.Dispatcher.CheckAccess())
    {
        Deployment.Current.Dispatcher.BeginInvoke(() => AddMarkers(argAR));
    }

    foreach (SegmentInfo segmentInfo in SmoothPlayer.ManifestInfo.Segments)
    {
        foreach (StreamInfo streamInfo in segmentInfo.SelectedStreams)
        {
            if (streamInfo.UniqueId == ((string)argAR.AsyncState))
            {

                List<ChunkInfo> markerChunks = streamInfo.ChunkList.ToList<ChunkInfo>();

                foreach (TrackInfo trackInfo in streamInfo.SelectedTracks)
                {
                    ChunkResult chunkResult = trackInfo.EndGetChunk(argAR);

                    if (chunkResult.Result == ChunkResult.ChunkResultState.Succeeded)
                    {
                        System.Text.Encoding enc = System.Text.Encoding.UTF8;
                        int length = (int)chunkResult.ChunkData.Length;
                        byte[] rawData = new byte[length];
                        chunkResult.ChunkData.Read(rawData, 0, length);
                        String text = enc.GetString(rawData, 0, rawData.Length);
                        TimelineMarker newMarker = new TimelineMarker();
                        newMarker.Text = text;
                        newMarker.Time = chunkResult.Timestamp;

                        SmoothPlayer.Markers.Add(newMarker);
                    }
                }
            }
        }
    }
}
```

> [!NOTE]  
> Applications should parse the manifest for markers during the [MediaOpened](smoothstreamingmediaelement-mediaopened-event-microsoft-web-media-smoothstreaming_1.md) event, but not earlier. Specifically, applications should not parse the manifest during the [ManifestReady](smoothstreamingmediaelement-manifestready-event-microsoft-web-media-smoothstreaming_1.md) event, because all markers set before [MediaOpened](smoothstreamingmediaelement-mediaopened-event-microsoft-web-media-smoothstreaming_1.md) are erased in Silverlight during [MediaOpened](smoothstreamingmediaelement-mediaopened-event-microsoft-web-media-smoothstreaming_1.md).

For more information, see [Timeline Markers and Events (IIS Smooth Streaming)](timeline-markers-and-events.md).

### MarkerReached

The merged Caption marker elements will raise the [MarkerReached](smoothstreamingmediaelement-markerreached-event-microsoft-web-media-smoothstreaming_1.md) event. The following code assigns a delegate to handle the event.

```csharp
SmoothPlayer.MarkerReached +=
        TimelineMarkerRoutedEventHandler(SmoothPlayer_MarkerReached);
```

The data from each TimelineEvent is accessible from the TimelineMarkerRoutedEventArgs parameter of the [MarkerReached](smoothstreamingmediaelement-markerreached-event-microsoft-web-media-smoothstreaming_1.md) delegate. To get the data from the base64 encoded string, use the [Encoding](https://go.microsoft.com/fwlink/?linkid=184080) class method [GetString](https://msdn.microsoft.com/library/05cts4c3.aspx) on the EventData()()()() property from the TimelineMarkerRoutedEventArgs. The data, as described above, is of the form \<Caption Id="111" Action="ADD"\>Chapter One\</Caption\>.

Each Caption element specifies either ADD or REMOVE by its Action attribute. When the value specifies the ADD action, the code creates a new text block for the caption and formats the text. Adding the new text block to the LayoutRoot displays the caption.

If the value of the Action attribute specifies REMOVE, another code block removes the Caption identified by the Id attribute value set when it was created. Any previous captions that remain because of out-of-sequence movements through the stream are identified by Tag="Caption" so that they can be removed before new captions are displayed.

The following code implements the TimelineEventReached()()()() delegate. (All the code in this example is available for download with the [IIS Smooth Streaming Sample Application](https://go.microsoft.com/fwlink/?linkid=182167).)

```csharp
void SmoothPlayer_MarkerReached(object sender, TimelineMarkerRoutedEventArgs e)
{
    OutputText.Text = e.Marker.Text; // Display the marker text.

    try
    {
        if (e.Marker.Text != "" && e.Marker.Text.Contains("Caption"))
        {
            // base64 decode the content and load the XML fragment.
            XElement xElem = XElement.Parse(e.Marker.Text);

            // Add a caption.
            if (xElem.Attribute("Action") != null && xElem.Attribute("Action").Value == "ADD")
            {
                // Remove any previous caption from display.
                LayoutRoot.Children.Remove(LayoutRoot.Children.
                      Where((uie) => uie is FrameworkElement &&
                      (uie as FrameworkElement).Tag == "Caption").
                      FirstOrDefault() as UIElement);

                // Add a TextBlock
                LayoutRoot.Children.Add(new TextBlock()
                {
                    Name = xElem.Attribute("Id").Value,
                    Text = xElem.Value,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Bottom,
                    Margin = new Thickness(0, 0, 0, 20),
                    Foreground = new SolidColorBrush(Colors.White),
                    FontSize = 22,
                    Tag = "Caption"
                });
            }
            // Remove a caption by Id.
            if (xElem.Attribute("Action") != null &&
                xElem.Attribute("Action").Value == "REMOVE")
            {
                // Remove the TextBlock that contians the caption.
                LayoutRoot.Children.Remove(LayoutRoot.Children.
                  Where((uie) => uie is FrameworkElement &&
                    (uie as FrameworkElement).Name == (xElem.Attribute("Id").Value)).
                    FirstOrDefault() as UIElement);
            }

                if (e.Marker.Text.Contains("Inserted Clip Next.")
                      && InsertClipCheckbox.IsChecked.Value == true)
            {
                // Remove any remaining caption from display.
                LayoutRoot.Children.Remove(LayoutRoot.Children.
                      Where((uie) => uie is FrameworkElement &&
                      (uie as FrameworkElement).Tag == "Caption").
                      FirstOrDefault() as UIElement);

                SmoothPlayer.ScheduleClip(clips[0], false, SmoothPlayer);
            }
        }

    }
    catch (Exception ex)
    {
        OutputText.Text = ex.Message + " Inner exception: " + ex.InnerException;
    }

}
```

For more information, see [Timeline Markers and Events (IIS Smooth Streaming)](timeline-markers-and-events.md).

## See Also

### Concepts

[IIS Smooth Streaming Client 1.5](microsoft-smooth-streaming-client-2-0.md)

[Timeline Markers and Events (IIS Smooth Streaming)](timeline-markers-and-events.md)

### Other Resources

[IIS Smooth Streaming Sample Application](https://go.microsoft.com/fwlink/?linkid=182167)
