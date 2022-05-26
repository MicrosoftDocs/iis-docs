---
title: Timeline Markers and Events (IIS Smooth Streaming)
description: Describes timeline markers and events for the IIS Smooth Streaming application and outlines how to create and specify navigation markers.
TOCTitle: Timeline Markers and Events (IIS Smooth Streaming)
ms:assetid: afe85bdd-ff5f-4e07-b8ca-6471ff1f04b2
ms:mtpsurl: https://msdn.microsoft.com/library/Ee958034(v=VS.90)
ms:contentKeyID: 28407136
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Timeline Markers and Events (IIS Smooth Streaming)

Applications can handle timeline events that occur while a media stream plays or use markers to find specified locations in the stream. The [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) class in the [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md) client library corresponds to StreamIndex element in the XML manifest.

This topic shows how to extract time and text data from StreamIndex elements and initialize [TimelineMarker](https://msdn.microsoft.com/library/cc672550) objects. The example extends the examples implemented in the [Silverlight Applications (IIS Smooth Streaming)](silverlight-applications.md), [Events (IIS Smooth Streaming)](events.md), and [Position in Stream (IIS Smooth Streaming)](position-in-stream.md) topics in order to create a table of contents that specifies chapter headings. A downloadable sample is available that contains all the code: [Download](https://go.microsoft.com/fwlink/?linkid=182167).

## Defining Timeline Events in the Manifest

The client manifest file, which has the extension .ismc, uses XML to specify metadata for Smooth Streaming media. There are three types of StreamIndex elements in the manifest: Video, Audio, and Script. Each type is also identified as a member of the [MediaStreamType](https://msdn.microsoft.com/library/cc672180) enumeration.

Timeline events are specified in a StreamIndex element as shown in the following example. The manifest can contain as many StreamIndex elements as are required in order to implement markers, captions, animations, or other features that are activated at time-specified locations in the media stream. (For more information about captions, see [Manifest Merge (IIS Smooth Streaming)](manifest-merge.md).) Using manifest syntax, you can identify each StreamIndex element by type and attributes.

The following XML creates a table of contents that lists chapter headings located at time intervals in the stream.

```xml
<StreamIndex Type="text"
    Name="MARKERS"
    Subtype="CHAPTER"
    TimeScale="10000000"
    ParentStreamIndex="video"
    ManifestOutput="TRUE"
    QualityLevels="1" Chunks="9"
    Url="QualityLevels({bitrate},{CustomAttributes})/Fragments(MARKERS={start time})">
    <QualityLevel Index="0" Bitrate="1000" CodecPrivateData="" FourCC=""/>
    <c n="0" t="596416667">
    <f>Q2hhcHRlciAx</f>
    </c>
    <c n="1" t="1192833334">
    <f>Q2hhcHRlciAy</f>
    </c>
    <c n="2" t="1789250001">
    <f>Q2hhcHRlciAz</f>
    </c>
    <c n="3" t="2385666668">
    <f>Q2hhcHRlciA0</f>
    </c>
    <c n="4" t="2982083335">
    <f>Q2hhcHRlciA1</f>
    </c>
    <c n="5" t="3578500002">
    <f>Q2hhcHRlciA2</f>
    </c>
    <c n="6" t="4174916669">
    <f>Q2hhcHRlciA3</f>
    </c>
    <c n="7" t="4771333335">
    <f>Q2hhcHRlciA4</f>
    </c>
    <c n="8" t="5367750040">
    <f>Q2hhcHRlciA5</f>
    </c>
</StreamIndex>
```

The ParentStreamIndex="video" attribute indicates that the timing of this StreamIndex item is keyed to the video stream. StreamIndex elements are sparse streams. The data in sparse streams is not contiguous but occurs at distinct locations in the stream and must be keyed to the video stream.

The c elements are chunks of data that designate each packet using number (n) and time (t) attributes, such as the following:

```xml
<c n="5" t="3578500002">
```

The data itself is contained in the f element. In the previous example, the f elements are chapter headings that are specified as base-64 encoded strings, such as the following:

```xml
<f>Q2hhcHRlciAx</f>
```

The TimeScale attribute (here set to 10000000) indicates the tick units by which time intervals and duration are measured: hundred nanosecond (hns) units The manifest can contain data for each fragment \<f\> of the stream only when the attribute ManifestOutput attribute is set to true.

## Extracting Timeline Events and Assigning Markers

When a [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) object loads Smooth Streaming media files, the AvailableStreams()()()() property of the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) contains metadata for all the streams defined by the manifest. StreamIndex elements in manifest XML correspond to [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) objects in application code.

The following example shows how to use the [MediaOpened](smoothstreamingmediaelement-mediaopened-event-microsoft-web-media-smoothstreaming_1.md) event and the asynchronous [BeginGetChunk](trackinfo-begingetchunk-method-microsoft-web-media-smoothstreaming_1.md) and [EndGetChunk](trackinfo-endgetchunk-method-microsoft-web-media-smoothstreaming_1.md) methods to add the markers and initialize the [Markers](smoothstreamingmediaelement-markers-property-microsoft-web-media-smoothstreaming_1.md) collection.

The first step is to assign a delegate to handle the [MediaOpened](smoothstreamingmediaelement-mediaopened-event-microsoft-web-media-smoothstreaming_1.md) event, as shown in the following example:

```csharp
SmoothPlayer.MediaOpened +=
                    new RoutedEventHandler(SmoothPlayer_MediaOpened);
```

The next step is to access the [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) objects from the [AvailableStreams](segmentinfo-availablestreams-property-microsoft-web-media-smoothstreaming_1.md) property of the first [SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md) instance in the [ManifestInfo](manifestinfo-class-microsoft-web-media-smoothstreaming_1.md) object. The following code shows how to loop through the available streams and identify the markers stream by type ([Type](streaminfo-type-property-microsoft-web-media-smoothstreaming_1.md)) and attributes.

The StreamIndex element in the manifest that contains markers is identified in code as a Script stream. This stream is not included by default in the [SelectedTracks](streaminfo-selectedtracks-property-microsoft-web-media-smoothstreaming_1.md) collection. The video and audio streams are required and are included by default. In order to access the markers script stream from application code, you have to identify the stream and include it in the [SelectedTracks](streaminfo-selectedtracks-property-microsoft-web-media-smoothstreaming_1.md) collection.

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
                                chunk.TimeStamp, new AsyncCallback(AddMarkers), streamInfo.UniqueId );
                        }
                    }
                }
            }
        }
    }
}
```

The previous code example calls the [BeginGetChunk](trackinfo-begingetchunk-method-microsoft-web-media-smoothstreaming_1.md) method and specifies the AddMarkers callback method to handle the results. The AddMarkers method is shown below. It calls the [EndGetChunk](trackinfo-endgetchunk-method-microsoft-web-media-smoothstreaming_1.md) method and initializes the markers.

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
> Applications should parse the manifest for markers during the [MediaOpened](smoothstreamingmediaelement-mediaopened-event-microsoft-web-media-smoothstreaming_1.md) event, but not earlier. Specifically, applications should not parse the manifest during the [ManifestReady](smoothstreamingmediaelement-manifestready-event-microsoft-web-media-smoothstreaming_1.md) event, because all markers set before the [MediaOpened](smoothstreamingmediaelement-mediaopened-event-microsoft-web-media-smoothstreaming_1.md) event is raised are erased in Silverlight during the [MediaOpened](smoothstreamingmediaelement-mediaopened-event-microsoft-web-media-smoothstreaming_1.md) event.

## Creating a Timeline Event Handler

After the [TimeLineMarker](https://go.microsoft.com/fwlink/?linkid=181858) objects are initialized in the [Markers](smoothstreamingmediaelement-markers-property-microsoft-web-media-smoothstreaming_1.md) collection, application code can catch and respond to timeline events identified by markers

To do this, assign a delegate to handle the [MarkerReached](smoothstreamingmediaelement-markerreached-event-microsoft-web-media-smoothstreaming_1.md) event as shown in the following example:

```csharp
SmoothPlayer.MarkerReached +=
    new TimelineMarkerRoutedEventHandler(SmoothPlayer_MarkerReached);
```

Implement the delegate that will run when the event occurs. The following code shows how to write both the timeline position in ticks and the text of the marker to a Silverlight [TextBlock](https://go.microsoft.com/fwlink/?linkid=181864) object.

```csharp
void SmoothPlayer_MarkerReached(object sender, TimelineMarkerRoutedEventArgs e)
{
    OutputText.Text = "  Marker Text: " + e.Marker.Text ;
}
```

To see another way to handle the [MarkerReached](smoothstreamingmediaelement-markerreached-event-microsoft-web-media-smoothstreaming_1.md) event, see [Scheduling Media Clips (IIS Smooth Streaming)](scheduling-media-clips.md).

## Specifying Navigation to Markers

The following example shows how to add a **Chapter** button to activate a chapter navigation window. (This example assumes that you are extending the application implemented in the topics [Silverlight Applications (IIS Smooth Streaming)](silverlight-applications.md) and [Events (IIS Smooth Streaming)](events.md))

```xaml
<Button x:Name="ChaptersSeekButton" Width="50" Content="Chapter"
                                                                Click="ChaptersSeekButton_Click"/>
```

Set the enabled property of the ChapterSeekButton object to false in MainPage.xaml. Add the following code to the PlayButton\_Click method to enable the ChaptersSeekButton instance only when there are markers in the [Markers](smoothstreamingmediaelement-markers-property-microsoft-web-media-smoothstreaming_1.md) collection.

```csharp
if (SmoothPlayer.Markers.Count != 0)
    ChaptersSeekButton.IsEnabled = true;
else
    ChaptersSeekButton.IsEnabled = false;
```

When a user clicks **Chapter**, the code uses the markers represented by the [Markers](smoothstreamingmediaelement-markers-property-microsoft-web-media-smoothstreaming_1.md) property of the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) object to navigate through the stream.

Application code can seek to positions in a stream from [TimeLineMarker](https://go.microsoft.com/fwlink/?linkid=181858) objects. When a user clicks **Chapter**, the following code finds the next marker and advances the media stream from the current position to the marker position. (Later in this document, you will modify this code in order to implement a navigation window that contains chapter headings.)

```csharp
private void ChaptersSeekButton_Click(object sender, RoutedEventArgs e)
{
    if (!SmoothPlayer.Markers.Equals(null))
    {
        foreach (TimelineMarker marker in SmoothPlayer.Markers)
        {
            if (SmoothPlayer.Position < marker.Time)
            {
                SmoothPlayer.Position = marker.Time;
                break;
            }
        }
    }
}
```

## Creating Table of Contents Navigation Using Markers

A Smooth Streaming application can use the [Markers](smoothstreamingmediaelement-markers-property-microsoft-web-media-smoothstreaming_1.md) property to implement a table of contents that supports navigation through the stream. The [Markers](smoothstreamingmediaelement-markers-property-microsoft-web-media-smoothstreaming_1.md) collection provides access to various positions without scrubbing through the entire stream.

To implement navigation in this scenario, follow the instructions under [Defining Timeline Events in the Manifest](timeline-markers-and-events.md) earlier in this document to define markers in the Smooth Stream client manifest .ismc file. Create a marker element in the manifest for each chapter heading that is needed in the media stream. Any media file editor that displays a timeline will provide the position in the media stream based on the interval from the beginning of the stream. Convert the time values to ticks (hundred nanosecond units) and assign them to the t attributes of the c elements as shown in the next example.

```xml
<c n="5" t="853120000">
    <f>UHVsc2UgdG8gdGhlIGxpbWl0Lg==</f>
</c>
```

To set the value of the f element, you must convert the chapter texts to base–64 encoded strings. Use the following conversion method, which is available in the [Convert](https://msdn.microsoft.com/library/dsfy6sz9) class.

```csharp
System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes("Chapter 1"));
```

Save the changes to the manifest file in the IIS folder that contains the multiple-bit-rate media files.

In the Silverlight application, parse the [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) and [TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md) objects, as shown earlier in this topic, and add the markers to the [Markers](smoothstreamingmediaelement-markers-property-microsoft-web-media-smoothstreaming_1.md) collection.

### Creating a Child Window Table of Contents

There are many ways to display these timeline markers to the user. The following example shows how to create a [Silverlight child window](https://go.microsoft.com/fwlink/?linkid=181860) that displays a list box of chapter headings as navigable options.

Add a [Silverlight child window](https://msdn.microsoft.com/library/system.windows.controls.childwindow\(vs.95\).aspx) to the project by using the template provided by the Visual Studio **Add New Item** option. The following example names the child window ChapterSeekWindow and adds the XAML for it.

```xaml
<controls:ChildWindow x:Class="Silverlight_SmoothStreaming.ChapterSeekWindow"
            xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
            xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
            xmlns:controls="clr-namespace:System.Windows.Controls;assembly=System.Windows.Controls"
            Width="400" Height="300"
            Title="Chapter Navigation Window">
    <Grid x:Name="LayoutRoot" Margin="2">
        <Grid.RowDefinitions>
            <RowDefinition Height="0.80*"></RowDefinition>

            <RowDefinition Height="0.20*"></RowDefinition>
        </Grid.RowDefinitions>
        <ListBox x:Name="ChaptersList" Width="355" Height="25" Grid.Row="0"
                    SelectionChanged="ChaptersList_SelectionChanged" SelectionMode="Single"/>

        <Button x:Name="CancelButton" Content="Cancel"
                Click="CancelButton_Click" Width="75" Height="23"
                HorizontalAlignment="Right" Margin="0,12,0,0" Grid.Row="1" />
        <Button x:Name="OKButton" Content="OK" Click="OKButton_Click"
                Width="75" Height="23" HorizontalAlignment="Right"
                Margin="0,12,79,0" Grid.Row="1" />
    </Grid>
</controls:ChildWindow>
```

To pass the [Markers](smoothstreamingmediaelement-markers-property-microsoft-web-media-smoothstreaming_1.md) collection to the child window, add a ChapterSeekWindow constructor to the window's partial class definition that includes a parameter for the [TimelineMarkerCollection](https://go.microsoft.com/fwlink/?linkid=181862) object, as shown in the following example. This code uses the collection argument to populate the ChaptersList list box in the child window. You also must have the members (shown before the constructor in the following code) in order to keep the markers collection in scope and to return results from the child window to the main page.

```csharp
TimelineMarkerCollection markersCollection;
public TimelineMarker chapterMarker { get; set; }

public ChapterSeekWindow(TimelineMarkerCollection markers)
{
    InitializeComponent();
    markersCollection = markers;
    foreach (TimelineMarker chap in markers)
    {
        if(chap.Text.Contains("Chapter") && !chap.Text.Contains("Caption"))
        {
            ChaptersList.Items.Add(chap.Text);
            ChaptersList.Height += 20;
        }
    }

}
```

To handle the user's selection from the list box, add the following method to the child window partial class. The single line of code in this handler assigns the user's selection to the chapterMarker variable declared in the previous partial-class code segment.

```csharp
private void ChaptersList_SelectionChanged(object sender,
                                SelectionChangedEventArgs e)
{
    chapterMarker = markersCollection[((ListBox)sender).SelectedIndex];
}
```

In the MainPage.xaml.cs file, change the ChaptersSeekButton Click event to instantiate the child window. You must also have a variable that holds a reference to the window class that is instantiated by the Click method.

```csharp
// Child window for chapter selection.
ChapterSeekWindow chaptersWindow;
```

The if block in the following method assures that the method runs only when the [Markers](smoothstreamingmediaelement-markers-property-microsoft-web-media-smoothstreaming_1.md) collection contains markers. The code passes the markers collection to the child window and assigns a delegate method to handle the user's selection that is returned from the child window. There can be several kinds of markers in the collection, so the following code checks the marker text for Chapter and eliminates those with an Action value that might indicate the marker is intended for captions or some other feature activated by markers.

```csharp
private void ChaptersSeekButton_Click(object sender, RoutedEventArgs e)
{
    if (!SmoothPlayer.Markers.Equals(null))
    {
        TimelineMarkerCollection chapterMarkers = new TimelineMarkerCollection();
        foreach (TimelineMarker marker in SmoothPlayer.Markers)
        {
            if (marker.Text.Contains("Chapter") && !marker.Text.Contains("Action"))
            {
                TimelineMarker copyMarker = new TimelineMarker();
                copyMarker.Text = marker.Text;
                copyMarker.Time = marker.Time;
                copyMarker.Type = marker.Type;
                chapterMarkers.Add(copyMarker);
            }
        }
        chaptersWindow = new ChapterSeekWindow(chapterMarkers);
        chaptersWindow.Closed +=
                        new EventHandler(chaptersWindow_Closed);
        chaptersWindow.Show();
    }
}
```

The next code segment is the delegate method that gets the user's selection, if any, from the list box of chapter options. If there is no selection by the user, the dialog box result is false, so there is no reassignment of the [Position](smoothstreamingmediaelement-position-property-microsoft-web-media-smoothstreaming_1.md) property and no navigation, and the method returns without action. If the user has made a chapter selection, the position indicated by the marker is assigned to the [Position](smoothstreamingmediaelement-position-property-microsoft-web-media-smoothstreaming_1.md) property of the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) object, which then causes the player to seek to the new position in the stream. The last few lines of code calculate the new position for the slider and adjust the thumb position as a proportion of its range.

```csharp
double mediaProportionSeconds;

void chaptersWindow_Closed(object sender, EventArgs e)
{
    ChapterSeekWindow window = (ChapterSeekWindow)sender;

    if(window.DialogResult.Equals(false))
    {
        chaptersWindow.Closed -= new EventHandler(chaptersWindow_Closed);
        return;
    }

    if (window.ChaptersList.SelectedItem != null)
    {
        chapterMark = window.chapterMarker;
        SmoothPlayer.Position = chapterMark.Time;

        // Calculate proportion of media length at current position.
        mediaProportionSeconds =
            SmoothPlayer.Position.TotalSeconds/SmoothPlayer.EndPosition.TotalSeconds;
        // Set slider value (position).
        SliderBar.Value = mediaProportionSeconds * SliderBar.Maximum;

    }

    chaptersWindow.Closed -= new EventHandler(chaptersWindow_Closed);

}
```

## See Also

### Concepts

[Events (IIS Smooth Streaming)](events.md)

[Manifest Merge (IIS Smooth Streaming)](manifest-merge.md)

[Select and Monitor Bit Rate (IIS Smooth Streaming)](select-and-monitor-bitrate.md)

### Other Resources

[IIS Smooth Streaming Sample Application](https://go.microsoft.com/fwlink/?linkid=182167)
