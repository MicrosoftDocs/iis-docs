---
title: Select and Monitor Bitrate
TOCTitle: Select and Monitor Bitrate
ms:assetid: e2d27108-4d9b-4fca-9f10-a638f7232032
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Ff182017(v=VS.95)
ms:contentKeyID: 46359333
ms.date: 05/31/2012
mtps_version: v=VS.95
---

# Select and Monitor Bitrate

The bitrate of Smooth Streaming media automatically adjusts to the bandwidth capacity of the network and client processors. Applications can monitor the bitrate and apply limits that are based on commercial or security requirements.

This example uses the events [PlaybackTrackChanged](smoothstreamingmediaelement-playbacktrackchanged-event-microsoft-web-media-smoothstreaming_1.md) and [ManifestReady](smoothstreamingmediaelement-manifestready-event-microsoft-web-media-smoothstreaming_1.md) to demonstrate a simple performance monitor and implementation of bandwidth limits according to customer account privileges.

## Playback Track Changed Event

Bitrate changes while a stream is playing raise the [PlaybackTrackChanged](smoothstreamingmediaelement-playbacktrackchanged-event-microsoft-web-media-smoothstreaming_1.md) event. Applications can monitor the bitrate in the delegate that handles the event. The following implementation reads the new bitrate from the [TrackChangedEventArgs](trackchangedeventargs-class-microsoft-web-media-smoothstreaming_1.md) and prints it to a text block.

``` 
    void SmoothPlayer_PlaybackTrackChanged(object sender, TrackChangedEventArgs e)
    {
        OutputText.Text = "Current bitrate: " + e.NewTrack.Bitrate.ToString();
    }
```

## Manifest Ready Event

In some applications it is useful to set the bitrate rather than allowing the rate to adjust automatically according to bandwidth capacity. For example, an application might limit high performance bitrates to customers who pay for premium service.

The following example limits the bitrate for customers who do not have premium accounts. First it gets the [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) object for the video stream. Next the method [AvailableTracks](streaminfo-availabletracks-property-microsoft-web-media-smoothstreaming_1.md) gets the available tracks of the video stream. The highRate variable allows only bitrates less than this number to users with non-premium accounts. (Addition of 1 tick to the highRate variable simplifies the lambda expression in the next step.)

The lambda expression re-initializes a list of type [TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md) that contains only the bitrates that are less than highRate. The method [SelectTracks](streaminfo-selecttracks-method-microsoft-web-media-smoothstreaming_1.md) assigns usable tracks to the lower bitrates.

``` 
    // Switch for track selection.
    Boolean PremiumAccount = false;
    void SmoothPlayer_ManifestReady(object sender, EventArgs e)
    {
        if (!PremiumAccount)
        {
            foreach (SegmentInfo segment in SmoothPlayer.ManifestInfo.Segments)
            {
                IList<StreamInfo> streamInfoList = segment.AvailableStreams;
                foreach (StreamInfo stream in streamInfoList)
                {
                    if (stream.Type == MediaStreamType.Video)
                    {
                        // Limit bitrate to 866000.
                        ulong highRate = 866000 + 1;
                        List<TrackInfo> tracks = new List<TrackInfo>();
   
                        tracks = stream.AvailableTracks.ToList<TrackInfo>();
                        IList<TrackInfo> allowedTracks = tracks.Where((ti) => ti.Bitrate < highRate).ToList();
                        stream.SelectTracks(allowedTracks, false);
                    }
                }
            }
        }
    }
```

## See Also

### Concepts

[Events](events.md)

[Silverlight Applications](silverlight-applications.md)

