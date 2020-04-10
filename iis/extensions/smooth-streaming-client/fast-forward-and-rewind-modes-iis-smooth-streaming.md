---
title: Fast Forward and Rewind Modes (IIS Smooth Streaming)
TOCTitle: Fast Forward and Rewind Modes (IIS Smooth Streaming)
ms:assetid: c46bc9ab-d3ef-4b4d-8dc6-46ba1bb14233
ms:mtpsurl: https://msdn.microsoft.com/library/Ff402323(v=VS.90)
ms:contentKeyID: 28731579
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Fast Forward and Rewind Modes (IIS Smooth Streaming)

The [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) includes the [SetPlaybackRate](smoothstreamingmediaelement-setplaybackrate-method-microsoft-web-media-smoothstreaming_1.md) method to set the rate to fast forward or rewind. This mode is sometimes called trick play. The speed and direction of playback is determined by selecting one of the values available in the [SupportedPlaybackRates](smoothstreamingmediaelement-supportedplaybackrates-property-microsoft-web-media-smoothstreaming_1.md) collection. When running forward or backward in this mode, the visible display shows intermittent frames of the video stream and the audio is muted.

## Set Playback Rate

To set the playback rate, use the [SetPlaybackRate](smoothstreamingmediaelement-setplaybackrate-method-microsoft-web-media-smoothstreaming_1.md) method with a value from the [SupportedPlaybackRates](smoothstreamingmediaelement-supportedplaybackrates-property-microsoft-web-media-smoothstreaming_1.md) collection.

The following example gets the available playback rates.

    // Usable playback rates
        IList<double> playbackRates = SmoothPlayer.SupportedPlaybackRates;

After the previous line of code runs the list will contain the following usable values:

    -8.0, -4.0, 0.5, 1, 4.0, 8.0.

Positive decimal values set the playback rate to: half the normal speed, 4.0 times the normal speed, or 8.0 times the normal speed. Negative values rewind the media stream at rates that are multiples of the normal speed by factors of -4.0 or -8.0.

## Fast Forward and Rewind Mode Implementation

The following stack panel adds three buttons to the user interface, one for fast forward, one for rewind, and one to reset to the normal rate. (This implementation extends the example in [Silverlight Applications (IIS Smooth Streaming)](silverlight-applications.md) and following topics.)

``` 
    <StackPanel Orientation="Horizontal" Grid.Row="2">
        
        <Button x:Name="REWTrickModeButton" Width="50" Margin="2" Content="&lt;&lt;"
          Click="REWTrickModeButton_Click"  Loaded="PlayButton_Loaded" />
        
        <Button x:Name="TrickModeButton" Width="50" Margin="2" Content="Reset"
              Click="TrickModeButton_Click"  Loaded="PlayButton_Loaded" />
        
        <Button x:Name="FFWDTrickModeButton" Width="50" Margin="2" Content="&gt;&gt;"
              Click="FFWDTrickModeButton_Click"  Loaded="PlayButton_Loaded" />        
    
        <TextBlock x:Name="OutputText" VerticalAlignment="Center" 
              Width="850" Margin="10" /> 
    </StackPanel>
```

The following code implements delegates that handle the button events. Because the playback rate cannot be changed while the player is stopped or paused, the click event handlers check for the stopped or paused states and return without action when the player is stopped or paused.

If the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) is playing, the method [SetPlaybackRate](smoothstreamingmediaelement-setplaybackrate-method-microsoft-web-media-smoothstreaming_1.md) sets the [PlaybackRate](smoothstreamingmediaelement-playbackrate-property-microsoft-web-media-smoothstreaming_1.md) to the next available fast-forward rate, to half speed, or to one of the rewind rates.

``` 
        private void FFWDTrickModeButton_Click(object sender, RoutedEventArgs e)
        {            
            // If paused or stopped, setting playback rate has no effect. Return.
            if (SmoothPlayer.CurrentState.Equals(SmoothStreamingMediaElementState.Paused) ||
                SmoothPlayer.CurrentState.Equals(SmoothStreamingMediaElementState.Stopped))
                return;

            playbackRates = SmoothPlayer.SupportedPlaybackRates;
            // rates: -8.0, -4.0, 0.5, 1, 4.0, 8.0
            int rateIndex = playbackRates.IndexOf(SmoothPlayer.PlaybackRate.Value);

            if (rateIndex < 4)
            {
                SmoothPlayer.SetPlaybackRate(playbackRates[4]);
                TrickModeButton.Content = playbackRates[4].ToString();
                return;
            }
            else if (rateIndex == 4)
            {
                SmoothPlayer.SetPlaybackRate(playbackRates[5]);
                TrickModeButton.Content = playbackRates[5].ToString();
            }
        }

        private void REWTrickModeButton_Click(object sender, RoutedEventArgs e)
        {
            // If paused or stopped, setting playback rate has no effect. Return.
            if (SmoothPlayer.CurrentState.Equals(SmoothStreamingMediaElementState.Paused) ||
                SmoothPlayer.CurrentState.Equals(SmoothStreamingMediaElementState.Stopped))
                return;

            playbackRates = SmoothPlayer.SupportedPlaybackRates;
            // rates: -8.0, -4.0, 0.5, 1, 4.0, 8.0
            int rateIndex = playbackRates.IndexOf(SmoothPlayer.PlaybackRate.Value);
            
            switch (rateIndex)
            {
                case 1:
                    SmoothPlayer.SetPlaybackRate(playbackRates[0]);
                    TrickModeButton.Content = playbackRates[0].ToString();
                    break;

                case 2:
                    SmoothPlayer.SetPlaybackRate(playbackRates[1]);
                    TrickModeButton.Content = playbackRates[1].ToString();
                    break;

                case 3:
                    SmoothPlayer.SetPlaybackRate(playbackRates[2]);
                    TrickModeButton.Content = playbackRates[2].ToString();
                    break;

                case 4:
                    SmoothPlayer.SetPlaybackRate(playbackRates[2]);
                    TrickModeButton.Content = playbackRates[2].ToString();
                    break;

                case 5:
                    SmoothPlayer.SetPlaybackRate(playbackRates[2]);
                    TrickModeButton.Content = playbackRates[2].ToString();
                    break;
        
            }
        }

        private void TrickModeButton_Click(object sender, RoutedEventArgs e)
        {

            playbackRates = SmoothPlayer.SupportedPlaybackRates;
            // rates: -8.0, -4.0, 0.5, 1, 4.0, 8.0

            if (SmoothPlayer.CurrentState.Equals(SmoothStreamingMediaElementState.Paused) ||
                SmoothPlayer.CurrentState.Equals(SmoothStreamingMediaElementState.Stopped))
                return;

            SmoothPlayer.SetPlaybackRate(playbackRates[3]);
            TrickModeButton.Content = playbackRates[3].ToString();

        }
```

You can [download a Visual Studio solution](https://go.microsoft.com/fwlink/?linkid=182167) that demonstrates the code shown in this topic.

## See Also

### Concepts

[Silverlight Applications (IIS Smooth Streaming)](silverlight-applications.md)

[Events (IIS Smooth Streaming)](events.md)

[Position in Stream (IIS Smooth Streaming)](position-in-stream.md)

[Timeline Markers and Events (IIS Smooth Streaming)](timeline-markers-and-events.md)

### Other Resources

[IIS Smooth Streaming Sample Application](https://go.microsoft.com/fwlink/?linkid=182167)
