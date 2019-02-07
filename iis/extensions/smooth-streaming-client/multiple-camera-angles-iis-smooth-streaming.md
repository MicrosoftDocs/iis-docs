---
title: Multiple Camera Angles (IIS Smooth Streaming)
TOCTitle: Multiple Camera Angles (IIS Smooth Streaming)
ms:assetid: 2c2a8b91-a760-426f-853a-5806163170d3
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Gg134026(v=VS.90)
ms:contentKeyID: 32316488
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- xml
- csharp
---

# Multiple Camera Angles (IIS Smooth Streaming)

In IIS Smooth Streaming client applications, you can select from multiple camera angles for the video display. The CameraAngle custom attribute of the [TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md) class enables you to identify the tracks for each camera angle in the [AvailableTracks](streaminfo-availabletracks-property-microsoft-web-media-smoothstreaming_1.md) collection.

## Configuring Multiple Camera Angles in the Manifest

In the client manifest, QualityLevel elements represent video, audio, and text tracks. The manifest includes multiple QualityLevel elements to represent the multiple tracks needed to adapt to variable-network bandwidth and processor capacities. The Bitrate attribute of the QualityLevel element identifies the rate of each track. When multiple camera angles are available, the CameraAngle custom attribute identifies the camera angle associated with each track.

The following example shows a manifest segment that applies the CameraAngle custom attribute to QualityLevel elements in conjunction with the Bitrate attribute in order to specify various bitrates of the tracks that represent Camera1 and Camera2.

``` xml
<?xml version="1.0" encoding="utf-16" ?> 
<SmoothStreamingMedia MajorVersion="2" MinorVersion="0" Duration="2997995000">
  <StreamIndex Type="video" 
      Chunks="150" 
      QualityLevels="35" 
      MaxWidth="1280" 
      MaxHeight="720" 
      DisplayWidth="1280" 
      DisplayHeight="720"
      Url="QualityLevels({bitrate},{CustomAttributes})/Fragments(video={start time})">
    <QualityLevel Index="0" Bitrate="3450000" FourCC="WVC1" 
        MaxWidth="1280" MaxHeight="720"
        CodecPrivateData="250000010FD3FE27F1678A27F859E80C9082E948C1CD400000010E5A67F840">
      <CustomAttributes>
        <Attribute Name="CameraAngle" Value="Camera1" /> 
      </CustomAttributes>
    </QualityLevel>
    <QualityLevel Index="1" Bitrate="2250000" FourCC="WVC1" 
        MaxWidth="960" MaxHeight="540"
        CodecPrivateData="250000010FD3FE1DF10D8A1DF843680C908244A9D5D4400000010E5A67F840">
      <CustomAttributes>
        <Attribute Name="CameraAngle" Value="Camera1" /> 
      </CustomAttributes>
    </QualityLevel>
    <QualityLevel Index="2" Bitrate="1500000" FourCC="WVC1" 
        MaxWidth="720" MaxHeight="404"
        CodecPrivateData="250000010FCBEE1670C98A167832680C9081ADC67270400000010E5A67F840">
      <CustomAttributes>
        <Attribute Name="CameraAngle" Value="Camera1" /> 
      </CustomAttributes>
    </QualityLevel>
    <QualityLevel Index="3" Bitrate="950000" FourCC="WVC1" 
        MaxWidth="544" MaxHeight="304"
        CodecPrivateData="250000010FCBDC10F0978A10F825E80C90819CFD487A400000010E5A67F840">
      <CustomAttributes>
        <Attribute Name="CameraAngle" Value="Camera1" /> 
      </CustomAttributes>
    </QualityLevel>
      <QualityLevel Index="4" Bitrate="600000" FourCC="WVC1" 
        MaxWidth="400" MaxHeight="224"
        CodecPrivateData="250000010FC3D20C706F8A0C781BE80C9081124F5B8D400000010E5A67F840">
      <CustomAttributes>
        <Attribute Name="CameraAngle" Value="Camera1" /> 
      </CustomAttributes>
    </QualityLevel>
    <QualityLevel Index="5" Bitrate="350000" FourCC="WVC1" 
        MaxWidth="288" MaxHeight="160"
        CodecPrivateData="250000010FC3CA08F04F8A08F813E80C90808AADEACF400000010E5A67F840">
      <CustomAttributes>
        <Attribute Name="CameraAngle" Value="Camera1" /> 
      </CustomAttributes>
    </QualityLevel>
    <QualityLevel Index="6" Bitrate="50000" FourCC="WVC1" 
        MaxWidth="112" MaxHeight="64"
        CodecPrivateData="250000010FC2C003701F8A037807EC077D08001861E8440000010E5A67F840">
      <CustomAttributes>
        <Attribute Name="CameraAngle" Value="Camera1" /> 
      </CustomAttributes>
      </QualityLevel>
    <QualityLevel Index="7" Bitrate="3450000" FourCC="WVC1" 
        MaxWidth="1280" MaxHeight="720"
        CodecPrivateData="250000010FD3FE27F1678A27F859E80C9082E948C1CD400000010E5A67F840">
      <CustomAttributes>
        <Attribute Name="CameraAngle" Value="Camera2" /> 
        </CustomAttributes>
    </QualityLevel>
    <QualityLevel Index="8" Bitrate="2250000" FourCC="WVC1" 
        MaxWidth="960" MaxHeight="540"
        CodecPrivateData="250000010FD3FE1DF10D8A1DF843680C908244A9D5D4400000010E5A67F840">
      <CustomAttributes>
        <Attribute Name="CameraAngle" Value="Camera2" /> 
      </CustomAttributes>
    </QualityLevel>
    <QualityLevel Index="9" Bitrate="1500000" FourCC="WVC1" 
        MaxWidth="720" MaxHeight="404"
        CodecPrivateData="250000010FCBEE1670C98A167832680C9081ADC67270400000010E5A67F840">
      <CustomAttributes>
        <Attribute Name="CameraAngle" Value="Camera2" /> 
      </CustomAttributes>
    </QualityLevel>
    <QualityLevel Index="10" Bitrate="950000" FourCC="WVC1" 
        MaxWidth="544" MaxHeight="304"
        CodecPrivateData="250000010FCBDC10F0978A10F825E80C90819CFD487A400000010E5A67F840">
      <CustomAttributes>
        <Attribute Name="CameraAngle" Value="Camera2" /> 
      </CustomAttributes>
    </QualityLevel>
    <QualityLevel Index="11" Bitrate="600000" FourCC="WVC1" 
        MaxWidth="400" MaxHeight="224"
        CodecPrivateData="250000010FC3D20C706F8A0C781BE80C9081124F5B8D400000010E5A67F840">
      <CustomAttributes>
        <Attribute Name="CameraAngle" Value="Camera2" /> 
      </CustomAttributes>
    </QualityLevel>
    <QualityLevel Index="12" Bitrate="350000" FourCC="WVC1" 
        MaxWidth="288" MaxHeight="160"
        CodecPrivateData="250000010FC3CA08F04F8A08F813E80C90808AADEACF400000010E5A67F840">
      <CustomAttributes>
        <Attribute Name="CameraAngle" Value="Camera2" /> 
      </CustomAttributes>
    </QualityLevel>
    <QualityLevel Index="13" Bitrate="50000" FourCC="WVC1" 
        MaxWidth="112" MaxHeight="64"
        CodecPrivateData="250000010FC2C003701F8A037807EC077D08001861E8440000010E5A67F840">
      <CustomAttributes>
        <Attribute Name="CameraAngle" Value="Camera2" /> 
      </CustomAttributes>
    </QualityLevel> 

    <!-- Additional settings here.  -->

  </StreamIndex>
</SmoothStreamingMedia>
```

### Parsing the Manifest and Sorting Tracks for Multiple Camera Angles

To work with multiple camera angles in application code, you can use the CameraAngle custom attribute to identify [TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md) objects that correspond to multiple-camera-angle QualityLevel tracks in the [AvailableTracks](streaminfo-availabletracks-property-microsoft-web-media-smoothstreaming_1.md) collection of the video [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) object.

In Smooth Streaming applications, the [SegmentInfo](segmentinfo-class-microsoft-web-media-smoothstreaming_1.md) object corresponds to the SmoothStreamingMedia element in the client manifest, and [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) objects correspond to StreamIndex elements. [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) objects represent video, audio, and text streams.

When an IIS Smooth Streaming application loads a variable-bit-rate presentation, it automatically parses the manifest and assigns StreamIndex elements to [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) objects in the [AvailableStreams](segmentinfo-availablestreams-property-microsoft-web-media-smoothstreaming_1.md) collection. It assigns QualityLevel elements to [TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md) objects in the [AvailableTracks](streaminfo-availabletracks-property-microsoft-web-media-smoothstreaming_1.md) collection. If multiple-camera-angle tracks are available, application code can switch between camera angles by sorting the [TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md) objects based on the CameraAngle custom attribute.

The following example shows how to sort [TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md) objects. In this case, the sorting is done in the handler for the [ManifestReady](smoothstreamingmediaelement-manifestready-event-microsoft-web-media-smoothstreaming_1.md) event. The outermost foreach loop processes each segment of the manifest. The second foreach loop finds [AvailableStreams](segmentinfo-availablestreams-property-microsoft-web-media-smoothstreaming_1.md) objects, in which video streams are identified by [Type](streaminfo-type-property-microsoft-web-media-smoothstreaming_1.md) values. Generic lists of the [TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md) type are initialized to contain the [TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md) objects for five camera angles.

The third foreach loop in the following code sorts the [AvailableTracks](streaminfo-availabletracks-property-microsoft-web-media-smoothstreaming_1.md) collection based on the custom attribute identified by track.CustomAttributes\["CameraAngle"\]. Finally, after the camera angles are sorted into lists, the code segment selects the tracks for camera1 by calling [SelectTracks(IList\<(Of \<\<'(TrackInfo\>)\>\>), Boolean)](streaminfo-selecttracks-method-microsoft-web-media-smoothstreaming_1.md).

``` csharp
List<List<TrackInfo>> _cameraAngles = new List<List<TrackInfo>>();

foreach (SegmentInfo segment in SmoothPlayer.ManifestInfo.Segments)
{
    foreach (StreamInfo stream in segment.AvailableStreams)
    {
        if (MediaStreamType.Video == stream.Type)
        {
            // Add more lists if more than 5 tracks are available.
            List<TrackInfo> camera1Tracks = new List<TrackInfo>();
            List<TrackInfo> camera2Tracks = new List<TrackInfo>();
            List<TrackInfo> camera3Tracks = new List<TrackInfo>();
            List<TrackInfo> camera4Tracks = new List<TrackInfo>();
            List<TrackInfo> camera5Tracks = new List<TrackInfo>();

            foreach (TrackInfo track in stream.AvailableTracks)
            {
                if ((track.CustomAttributes == null) ||
                    (!track.CustomAttributes.ContainsKey("CameraAngle")))
                {
                    continue;
                }

                switch (track.CustomAttributes["CameraAngle"].ToLower())
                {
                    case "camera1":
                        _foundCameraAngles = true;
                        camera1Tracks.Add(track);
                        break;

                    case "camera2":
                        _foundCameraAngles = true;
                        camera2Tracks.Add(track);
                        break;

                    case "camera3":
                        _foundCameraAngles = true;
                        camera3Tracks.Add(track);
                        break;

                    case "camera4":
                        _foundCameraAngles = true;
                        camera4Tracks.Add(track);
                        break;

                    case "camera5":
                        _foundCameraAngles = true;
                        camera5Tracks.Add(track);
                        break;

                    default:
                        break;
                }
            }

            if (_foundCameraAngles)
            {
                bool fResult = stream.SelectTracks(camera1Tracks, false);

                _cameraAngles.Add(camera1Tracks);
                _cameraAngles.Add(camera2Tracks);
                _cameraAngles.Add(camera3Tracks);
                _cameraAngles.Add(camera4Tracks);
                _cameraAngles.Add(camera5Tracks);
            }
        }
    }
}
```

### Changing Camera Angles

To let users change camera angles while the application is displaying video, you typically include UI such as a button and a corresponding event handler, as shown in the following example. The code uses the same loops as those shown in the previous section, but in the switch statement that checks for the CameraAngle attribute, the code adds a track to the cameraTracks list only if the CameraAngle custom attribute matches an integer variable (newCameraAngle) that identifies a single track. Each time the click event occurs, the handler increments the newCameraAngle value by 1, so the user can repeatedly click the button to cycle through the camera angles.

``` csharp
    private void CameraAngleButton_Click(object sender, RoutedEventArgs e)
    {
        List<TrackInfo> cameraTracks = new List<TrackInfo>();

        foreach (SegmentInfo segment in SmoothPlayer.ManifestInfo.Segments)
        {
            foreach (StreamInfo stream in segment.AvailableStreams)
            {
                if (MediaStreamType.Video == stream.Type)
                {
                    foreach (TrackInfo track in stream.AvailableTracks)
                    {
                        if ((track.CustomAttributes == null) ||
                            (!track.CustomAttributes.ContainsKey("CameraAngle")))
                        {
                            continue;
                        }

                        switch (track.CustomAttributes["CameraAngle"].ToLower())
                        {
                            case "camera1":
                                if(newCameraAngle==1)
                                    cameraTracks.Add(track);
                                break;

                            case "camera2":
                                if (newCameraAngle == 2)
                                    cameraTracks.Add(track);
                                break;

                            case "camera3":
                                if (newCameraAngle == 3) 
                                    cameraTracks.Add(track);
                                break;

                            case "camera4":
                                if (newCameraAngle == 4)
                                    cameraTracks.Add(track);
                                break;

                            case "camera5":
                                if (newCameraAngle == 5)
                                    cameraTracks.Add(track);
                                break;

                            default:
                                break;
                        }                            
                    }
                }
                bool fResult = stream.SelectTracks(cameraTracks, false);
                break;
            }

        }

        if (newCameraAngle == 5) newCameraAngle = 1; else newCameraAngle++;
    }
```

## See Also

#### Concepts

[Select and Monitor Bit Rate (IIS Smooth Streaming)](select-and-monitor-bitrate.md)

