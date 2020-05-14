---
title: Select and Monitor Bit Rate (IIS Smooth Streaming)
TOCTitle: Select and Monitor Bit Rate (IIS Smooth Streaming)
ms:assetid: e2d27108-4d9b-4fca-9f10-a638f7232032
ms:mtpsurl: https://msdn.microsoft.com/library/Ff182017(v=VS.90)
ms:contentKeyID: 28440968
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Select and Monitor Bit Rate (IIS Smooth Streaming)

The bit rate of Smooth Streaming media automatically adjusts to the bandwidth capacity of the network and client processors. Applications can monitor the bit rate and apply limits that are based on commercial or security requirements.

This example uses the events [PlaybackTrackChanged](smoothstreamingmediaelement-playbacktrackchanged-event-microsoft-web-media-smoothstreaming_1.md) and [ManifestReady](smoothstreamingmediaelement-manifestready-event-microsoft-web-media-smoothstreaming_1.md) to demonstrate a simple performance monitor and implementation of bandwidth limits according to customer account privileges. You can [download a Visual Studio solution](https://go.microsoft.com/fwlink/?linkid=182167) that contains all the code.

## Playback Track Changed Event

Bit rate changes while a stream is playing raise the [PlaybackTrackChanged](smoothstreamingmediaelement-playbacktrackchanged-event-microsoft-web-media-smoothstreaming_1.md) event. Applications can monitor the bit rate in the delegate that handles the event. The following implementation reads the new bit rate from the [TrackChangedEventArgs](trackchangedeventargs-class-microsoft-web-media-smoothstreaming_1.md) and prints it to a text block.

```
    void SmoothPlayer_PlaybackTrackChanged(object sender, TrackChangedEventArgs e)
    {
        OutputText.Text = "Current bit rate: " + e.NewTrack.Bitrate.ToString();
    }
```

## Manifest Ready Event

In some applications it is useful to set the bit rate rather than allowing the rate to adjust automatically according to bandwidth capacity. For example, an application might limit high performance bit rates to customers who pay for premium service.

The following example limits the bit rate for customers who do not have premium accounts. First it gets the [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) object for the video stream. Next the method [AvailableTracks](streaminfo-availabletracks-property-microsoft-web-media-smoothstreaming_1.md) gets the available tracks of the video stream. The highRate variable allows only bit rates less than this number to users with non-premium accounts. (Addition of 1 tick to the highRate variable simplifies the lambda expression in the next step.)

The lambda expression re-initializes a list of type [TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md) that contains only the bit rates that are less than highRate. The method [SelectTracks](streaminfo-selecttracks-method-microsoft-web-media-smoothstreaming_1.md) assigns usable tracks to the lower bit rates.

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
                        // Limit bit-rate to 866000.
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

[Events (IIS Smooth Streaming)](events.md)

[Silverlight Applications (IIS Smooth Streaming)](silverlight-applications.md)

### Other Resources

[IIS Smooth Streaming Sample Application](https://go.microsoft.com/fwlink/?linkid=182167)
