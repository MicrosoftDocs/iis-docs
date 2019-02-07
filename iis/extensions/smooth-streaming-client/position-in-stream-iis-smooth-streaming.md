---
title: Position in Stream (IIS Smooth Streaming)
TOCTitle: Position in Stream (IIS Smooth Streaming)
ms:assetid: 17d0f9d6-f8c2-4e8e-8db2-1db8b36c3834
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Ff355190(v=VS.90)
ms:contentKeyID: 28511392
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Position in Stream (IIS Smooth Streaming)

You can assign the [Position](smoothstreamingmediaelement-position-property-microsoft-web-media-smoothstreaming_1.md) property of the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) to a new position and the player will seek to the new position in the stream. Simply assign a [TimeSpan](https://msdn.microsoft.com/en-us/library/269ew577\(v=vs.90\)) object to the [Position](smoothstreamingmediaelement-position-property-microsoft-web-media-smoothstreaming_1.md) property. The [TimeSpan](http://go.microsoft.com/fwlink/?linkid=181852) object specifies the time interval from the beginning of the stream.

The current topic extends the functionality of previous examples in [Silverlight Applications (IIS Smooth Streaming)](silverlight-applications.md) and [Events (IIS Smooth Streaming)](events.md). You can [download a Visual Studio solution](http://go.microsoft.com/fwlink/?linkid=182167) that contains all the code.

## Position from Slider Bar

To implement a slider that seeks back and forth in a media stream, add a slider to MainPage.xaml after the combo box.

``` 
  <Slider x:Name="SliderBar" Width="200" ValueChanged="SliderBar_ValueChanged"/>
```

The ValueChanged event of the slider shown above specifies the handler for slider movements. The Value property of the slider will require some calculation to convert the slider Value to a [TimeSpan](http://go.microsoft.com/fwlink/?linkid=181852) object that can be assigned to the [Position](smoothstreamingmediaelement-position-property-microsoft-web-media-smoothstreaming_1.md) property of the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md). Add the following variables to the MainPage class.

``` 
    // Slider seek variables.
    double sliderProportion;
    double sliderLengthSeconds;
    double conversion;
    TimeSpan tsPositionFromSlider = new TimeSpan();
```

### Calculate New Position from Slider

The following event handler uses the seek variables shown above to calculate a new position value and to reassign the [Position](smoothstreamingmediaelement-position-property-microsoft-web-media-smoothstreaming_1.md) property so that the media stream will resume playing at a new position.

``` 
    private void SliderBar_ValueChanged(object sender,
                             RoutedPropertyChangedEventArgs<double> e)
    {
        // Calculate proportion of slider length at current position.
        sliderProportion =  ((Slider)sender).Value/((Slider)sender).Maximum;
        // Get media length in seconds.
        sliderLengthSeconds = SmoothPlayer.EndPosition.TotalSeconds;
        // Calculate position in seconds.
        conversion = sliderProportion * sliderLengthSeconds;
        // Convert seconds to a TimeSpan object.
        tsPositionFromSlider = TimeSpan.FromSeconds(conversion);
        // Assign new position by TimeSpan.
        SmoothPlayer.Position = tsPositionFromSlider;
    }
```

### Reset Slider

When the media stream ends or the user clicks **Stop**, the slider should return to the zero value. The [MediaEnded](smoothstreamingmediaelement-mediaended-event-microsoft-web-media-smoothstreaming_1.md) event can be used to reset the slider value when the stream ends. This code also resets the caption of **Play**.

``` 
    void SmoothPlayer_MediaEnded(object sender, RoutedEventArgs e)
    {
        OutputText.Text = "Media Ended. SmoothPlayer CurrentState: " +
                    ((SmoothStreamingMediaElement)sender).CurrentState;
        SliderBar.Value = 0;
        PlayButton.Content = "Play";
    }
```

Add SliderBar.Value = 0 to the click event to correctly position the slider when the user stops the playback.

``` 
    private void StopButton_Click(object sender, RoutedEventArgs e)
    {
        SmoothPlayer.Stop();
        SliderBar.Value = 0;
        PlayButton.Content = "Play";
    }
```

These changes complete implementation of the slider. The user can navigate to any position in the media stream by dragging the slider thumb to a position forward or backward along its range.

The topic [Timeline Markers and Events (IIS Smooth Streaming)](timeline-markers-and-events.md) demonstrates how to capture TimelineEvent markers and seek to them and/or handle the events they generate.

## See Also

#### Concepts

[Events (IIS Smooth Streaming)](events.md)

#### Other Resources

[IIS Smooth Streaming Sample Application](http://go.microsoft.com/fwlink/?linkid=182167)

