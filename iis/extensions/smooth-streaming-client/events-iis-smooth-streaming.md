---
title: Events (IIS Smooth Streaming)
description: Describes the IIS Smooth Streaming events and outlines the media ended event, seek completed event, and exception event.
TOCTitle: Events (IIS Smooth Streaming)
ms:assetid: 875f74b0-e627-4e0a-8397-1e7fbe2bf8eb
ms:mtpsurl: https://msdn.microsoft.com/library/Ee958033(v=VS.90)
ms:contentKeyID: 28407135
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Events (IIS Smooth Streaming)

The [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md) namespace defines events that occur when Smooth Streaming manifest files load and the media content plays. You can assign delegate methods to handle events, extend application features, and manage exceptions. The event handlers demonstrated in the previous topic, [Silverlight Applications (IIS Smooth Streaming)](silverlight-applications.md), were automatically implemented by the Silverlight application framework. You have to write a little more code to define application logic that handles events of the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md).

This topic demonstrates the use of three events.

  - [MediaEnded](smoothstreamingmediaelement-mediaended-event-microsoft-web-media-smoothstreaming_1.md)

  - [SeekCompleted](smoothstreamingmediaelement-seekcompleted-event-microsoft-web-media-smoothstreaming_1.md)

  - [SmoothStreamingErrorOccurred](smoothstreamingmediaelement-smoothstreamingerroroccurred-event-microsoft-web-media-smoothstreaming_1.md)

The examples in this topic extend the sample created in the topic [Silverlight Applications (IIS Smooth Streaming)](silverlight-applications.md). Other event scenarios are demonstrated in the topics linked at the bottom of the page. You can [download a Visual Studio solution](https://go.microsoft.com/fwlink/?linkid=182167) that contains all the code.

## Media Ended Event

The [MediaEnded](smoothstreamingmediaelement-mediaended-event-microsoft-web-media-smoothstreaming_1.md) event occurs when a media stream that has been playing ends. To catch and respond to the [MediaEnded](smoothstreamingmediaelement-mediaended-event-microsoft-web-media-smoothstreaming_1.md) event, define a delegate as shown in the following code segment and add it to the MainPage() constructor of the sample in the topic [Silverlight Applications (IIS Smooth Streaming)](silverlight-applications.md). The += assignment creates a new [RoutedEventHandler](https://msdn.microsoft.com/library/system.windows.routedeventhandler.aspx) and names it SmoothPlayer\_MediaEnded.

```csharp
SmoothPlayer.MediaEnded += new RoutedEventHandler(SmoothPlayer_MediaEnded);
```

The following code shows the SmoothPlayer\_MediaEnded delegate method that handles the [MediaEnded](smoothstreamingmediaelement-mediaended-event-microsoft-web-media-smoothstreaming_1.md) event. In this case, when the event occurs, the handler simply displays text in an output block beneath the player display. The current state of the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) is obtained and appended to the text by casting the sender parameter to [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) and by reading the CurrentState()()()() property. The caption of **Play** is reset.

```csharp
void SmoothPlayer_MediaEnded(object sender, RoutedEventArgs e)
{
    OutputText.Text = "Media Ended. SmoothPlayer CurrentState: " +
                    ((SmoothStreamingMediaElement)sender).CurrentState;
    PlayButton.Content = "Play";
}
```

## Position Property and Seek Completed Event

You can assign the [Position](smoothstreamingmediaelement-position-property-microsoft-web-media-smoothstreaming_1.md) property of the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) to a new position in the stream and the player will seek to the new position. Simply assign a [TimeSpan](https://msdn.microsoft.com/library/269ew577) object to the [Position](smoothstreamingmediaelement-position-property-microsoft-web-media-smoothstreaming_1.md) property. The [TimeSpan](https://msdn.microsoft.com/library/269ew577) object specifies the time interval from the beginning of the stream.

To implement a button that will seek to a new position, add the following line to MainPage.xaml of the sample application implemented in the topic [Silverlight Applications (IIS Smooth Streaming)](silverlight-applications.md). Add the SeekButton specification after the StopButton and before the ComboBox.

```xaml
<Button x:Name="SeekButton" Width="50" Content="+5 Secs" Click="SeekButton_Click" />
```

Add a variable to the MainPage class to specify the time interval that will be added to the position on each seek operation.

```csharp
TimeSpan spanAdd = new TimeSpan(0,0,5); // Five second inteval.
```

Each time the user clicks SeekButton, the following event handler adds a five-second interval to the position property until the current position plus 5 seconds is greater than the length of the media stream as specified by the [EndPosition](smoothstreamingmediaelement-endposition-property-microsoft-web-media-smoothstreaming_1.md) property.

```csharp
private void SeekButton_Click(object sender, RoutedEventArgs e)
{
    if ((SmoothPlayer.Position + spanAdd) < SmoothPlayer.EndPosition)
    {
        SmoothPlayer.Position += spanAdd;
    }
}
```

### Seek Completed Event

The [SeekCompleted](smoothstreamingmediaelement-seekcompleted-event-microsoft-web-media-smoothstreaming_1.md) event occurs when the [Position](smoothstreamingmediaelement-position-property-microsoft-web-media-smoothstreaming_1.md) set operation started by the previous code completes. Create a delegate to catch this event by adding the following code to the MainPage() constructor.

```csharp
SmoothPlayer.SeekCompleted +=
      new EventHandler<SeekCompletedEventArgs>(SmoothPlayer_SeekCompleted);
```

This is a generic event handler that specifies the type [SeekCompletedEventArgs](seekcompletedeventargs-class-microsoft-web-media-smoothstreaming_1.md). The handler method is named SmoothPlayer\_SeekCompleted. The method simply displays the new position to an output text block.

```csharp
void SmoothPlayer_SeekCompleted(object sender, SeekCompletedEventArgs e)
{
    OutputText.Text = "  Seek complete at: " +
                ((SmoothStreamingMediaElement)sender).Position;
}
```

> [!NOTE]  
> The topic [Timeline Markers and Events (IIS Smooth Streaming)](timeline-markers-and-events.md) shows how to define TimelineEvent markers in media streams and how to handle the events they generate.

You can extend event functionality in many ways. For longer media streams, it may be preferable to use a slider bar instead of the seek button shown in the previous example. For an implementation of the slider bar, see [Position in Stream (IIS Smooth Streaming)](position-in-stream.md).

## Exception Event

The [SmoothStreamingErrorOccurred](smoothstreamingmediaelement-smoothstreamingerroroccurred-event-microsoft-web-media-smoothstreaming_1.md) exception event can be handled as demonstrated for other events in this topic.

Assign a delegate to handle the event.

```csharp
SmoothPlayer.SmoothStreamingErrorOccurred +=
  new EventHandler<SmoothStreamingErrorEventArgs>(SmoothPlayer_SmoothStreamingErrorOccurred);
```

Implement the delegate.

```csharp
void SmoothPlayer_SmoothStreamingErrorOccurred(object sender,
                                SmoothStreamingErrorEventArgs e)
{
      OutputText.Text = "Error: " + e.ErrorCode + "; " + e.ErrorMessage;
}
```

This handler displays the error code and message to a text block. A full application should implement error-handling logic so that processing does not hang if an exception occurs.

## See Also

### Concepts

[Silverlight Applications (IIS Smooth Streaming)](silverlight-applications.md)

[Timeline Markers and Events (IIS Smooth Streaming)](timeline-markers-and-events.md)

[Scheduling Media Clips (IIS Smooth Streaming)](scheduling-media-clips.md)

[Select and Monitor Bit Rate (IIS Smooth Streaming)](select-and-monitor-bitrate.md)

### Other Resources

[IIS Smooth Streaming Sample Application](https://go.microsoft.com/fwlink/?linkid=182167)
