---
title: Scheduling Media Clips
TOCTitle: Scheduling Media Clips
ms:assetid: d56b53f9-6cff-4145-a447-917e0bd55147
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Ee958036(v=VS.95)
ms:contentKeyID: 46359334
ms.date: 05/31/2012
mtps_version: v=VS.95
---

# Scheduling Media Clips

You can schedule media clips to play before, during, and after a Smooth Streaming media presentation. This topic shows an example of how to insert advertising clips during programming.

## Scheduling Clips by Marker

One way to insert a clip into Smooth Streaming programming is to call the [ScheduleClip](smoothstreamingmediaelement-scheduleclip-method-microsoft-web-media-smoothstreaming_1.md) method from a handler for the [MarkerReached](smoothstreamingmediaelement-markerreached-event-microsoft-web-media-smoothstreaming_1.md) event. (This scenario depends on functionality that was implemented in the example code in [Timeline Markers and Events](timeline-markers-and-events.md).)

### Adding Clip Information

To schedule a clip, initialize a [ClipInformation](clipinformation-class-microsoft-web-media-smoothstreaming_1.md) object that specifies the media clip to play by setting its [ClipUri](clipinformation-clipuri-property-microsoft-web-media-smoothstreaming_1.md) and [Duration](clipinformation-duration-property-microsoft-web-media-smoothstreaming_1.md) property values, as shown in the following example:

```csharp
// List for advertising clips.
List<ClipInformation> clips = new List<ClipInformation>(5);

private void InsertClipCheckbox_Checked(object sender, RoutedEventArgs e)
{
    clips.Add(new ClipInformation(true,
    new Uri("http://serverName/clip.ism/Manifest"),
    new Uri("http://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.aspx"),
    new TimeSpan(1789250001)));
}
```

In this example, when the media stream hits the marker that is 1,789,250,000 ticks from the beginning of the stream, the clip identified by the [ClipInformation](clipinformation-class-microsoft-web-media-smoothstreaming_1.md) object at clips\[0\] will interrupt the currently playing stream, play the clip to the end of its duration, and then resume the media stream that was interrupted.

### Scheduling the Clip by the Marker-Reached Event

To handle the [MarkerReached](smoothstreamingmediaelement-markerreached-event-microsoft-web-media-smoothstreaming_1.md) event, assign a delegate for it as shown in the following code:

```csharp
SmoothPlayer.MarkerReached += 
        new TimelineMarkerRoutedEventHandler(SmoothPlayer_MarkerReached);
```

In the [MarkerReached](smoothstreamingmediaelement-markerreached-event-microsoft-web-media-smoothstreaming_1.md) handler, identify the marker that will trigger the insertion of the media clip. The following example selects a marker if the [System.Windows.Media.TimelineMarker.Text](https://go.microsoft.com/fwlink/?linkid=204790) member of the [System.Windows.Media.TimelineMarkerRoutedEventArgs](https://go.microsoft.com/fwlink/?linkid=204791) object that is passed to the event handler equals "Chapter 3" and if a UI element named InsertClipCheckbox is selected. The code uses the [ScheduleClip(ClipInformation, Boolean, Object)](smoothstreamingmediaelement-scheduleclip-method-clipinformation-boolean-object-microsoft-web-media-smoothstreaming_1.md) method to insert the clip. The method takes parameters that specify a [ClipInformation](clipinformation-class-microsoft-web-media-smoothstreaming_1.md) instance, a Boolean value that indicates whether to pause when the clip is finished playing, and the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) object that will play the clip.

```csharp
void SmoothPlayer_MarkerReached(object sender, TimelineMarkerRoutedEventArgs e)
{

    if (e.Marker.Text.Contains("Chapter 3") && InsertClipCheckbox.IsChecked.Value == true)
    {
        SmoothPlayer.ScheduleClip(clips[0], true, SmoothPlayer);
    }
}
```

### Passing Information Using the userData Parameter

The third parameter of the [ScheduleClip(ClipInformation, ClipContext, Object)](smoothstreamingmediaelement-scheduleclip-method-clipinformation-clipcontext-object-microsoft-web-media-smoothstreaming_1.md) method is the userData parameter. The value of the parameter is saved as a member of the [ClipContext](clipcontext-class-microsoft-web-media-smoothstreaming_1.md) instance that is created by the [ScheduleClip(ClipInformation, ClipContext, Object)](smoothstreamingmediaelement-scheduleclip-method-clipinformation-clipcontext-object-microsoft-web-media-smoothstreaming_1.md) method. The application can use this parameter to pass anything it requires; typically, the parameter is used to pass something that can identify the [ClipContext](clipcontext-class-microsoft-web-media-smoothstreaming_1.md) type. In the following example, SmoothPlayer is passed as the value of userData. Code that appears later in this document shows how to cast the userData value to type [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) in order to retrieve the Smooth Streaming client (player) that generated the [ClipContext](clipcontext-class-microsoft-web-media-smoothstreaming_1.md) instance.

```csharp
SmoothPlayer.ScheduleClip(clips[0], new TimeSpan(0), true, SmoothPlayer);
```

If the application must pass more information than is shown in this example, it can create a class to contain all the data and then pass that type as the userData value.

### Specifying the Click-Through Action for a Clip

If the user clicks the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) surface while the inserted clip is playing, the method that handles the event can access the object assigned to the [Context](clipeventargs-context-property-microsoft-web-media-smoothstreaming_1.md) property from the [ClipEventArgs](clipeventargs-class-microsoft-web-media-smoothstreaming_1.md) instance that is passed to the method. The [ClipInformation](clipcontext-clipinformation-property-microsoft-web-media-smoothstreaming_1.md) property contains the [ClickThroughUri](clipinformation-clickthroughuri-property-microsoft-web-media-smoothstreaming_1.md) value that was assigned when the [ClipInformation](clipinformation-class-microsoft-web-media-smoothstreaming_1.md) object was initialized.

To handle the [ClipClickThrough](smoothstreamingmediaelement-clipclickthrough-event-microsoft-web-media-smoothstreaming_1.md) event, assign a delegate as shown in the following example:

```csharp
SmoothPlayer.ClipClickThrough +=
    new EventHandler<ClipEventArgs>(SmoothPlayer_ClipClickThrough);
```

The following implementation of ClipClickThrough shows how to open a new browser window in order to navigate to the target specified in the [ClickThroughUri](clipinformation-clickthroughuri-property-microsoft-web-media-smoothstreaming_1.md) property.

```csharp
void SmoothPlayer_ClipClickThrough(object sender, ClipEventArgs e)
{
    System.Windows.Browser.HtmlPage.Window.Navigate(e.Context.ClipInformation.ClickThroughUri, "_newWindow");
}
```

The marker-reached event is one method of scheduling clips. Other applications might use sparse tracks or polling for live ad insertions. For more information, see [Manifest Merge](manifest-merge.md).

> [!NOTE]  
> Smooth Streaming clips scheduled by using [ScheduleClip](smoothstreamingmediaelement-scheduleclip-method-microsoft-web-media-smoothstreaming_1.md) methods require manifests that start at the zero time stamp.

## Scheduling a Pre-Roll Scenario

The pre-roll scenario schedules a clip or clips to run immediately before the main video starts. The [ManifestReady](smoothstreamingmediaelement-manifestready-event-microsoft-web-media-smoothstreaming_1.md) event provides an opportunity to schedule clips to precede the main presentation.

To use the pre-roll scenario, handle the [ManifestReady](smoothstreamingmediaelement-manifestready-event-microsoft-web-media-smoothstreaming_1.md) event. The following event handler shows how to initialize the pre-roll clip. The ScheduleClip method is an overloaded method. The pre-roll scenario uses the [ScheduleClip(ClipInformation, TimeSpan, Boolean, Object)](smoothstreamingmediaelement-scheduleclip-method-clipinformation-timespan-boolean-object-microsoft-web-media-smoothstreaming_1.md) method overload that contains the StartTime parameter. Setting the StartTime parameter to zero schedules the clip to play at the beginning of the Smooth Streaming presentation. As in the previous example, the pauseTimeline parameter is set to true so the viewer does not miss the segment of the playback that would otherwise run in the background while the scheduled clip plays. (Setting the pauseTimeline parameter to false is useful for live streaming.)

The following example shows how to schedule a pre-roll scenario.

```csharp
void SmoothPlayer_ManifestReady(object sender, EventArgs e)
{
    if (!PremiumAccount)
    {
        if (InsertClipCheckbox.IsChecked == true)
        {     
            SmoothPlayer.ScheduleClip(clips[0], new TimeSpan(0), true, SmoothPlayer );
            SmoothPlayer.Play();
        }
    }
}
```

## Chaining Clips

You can schedule clips to run in a series, or chain them. This scenario uses the [ScheduleClip(ClipInformation, ClipContext, Object)](smoothstreamingmediaelement-scheduleclip-method-clipinformation-clipcontext-object-microsoft-web-media-smoothstreaming_1.md) method overload that has the clipToAppendTo parameter, which is of type [ClipContext](clipcontext-class-microsoft-web-media-smoothstreaming_1.md). To chain clips, assign the [ClipContext](clipcontext-class-microsoft-web-media-smoothstreaming_1.md) instance of a running clip to the clipToAppendTo parameter of the clip that will follow it in the series.

The following example uses the [ClipProgressUpdate](smoothstreamingmediaelement-clipprogressupdate-event-microsoft-web-media-smoothstreaming_1.md) event handler to schedule a clip to follow the clip that is reporting its progress in this event. In this case, the event will schedule successive clips up to the count of clips in the clips collection.

```csharp
void SmoothPlayer_ClipProgressUpdate(object sender, ClipPlaybackEventArgs e)
{
    if (clipIndex < (clips.Count - 1) && e.Progress == ClipProgress.ThirdQuartile)
    {
        SmoothPlayer.ScheduleClip(clips[++clipIndex], e.Context, SmoothPlayer);
    }
}
```

## See Also

### Concepts

[Events](events.md)

[Timeline Markers and Events](timeline-markers-and-events.md)

[Manifest Merge](manifest-merge.md)
