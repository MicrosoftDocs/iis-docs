---
title: SmoothStreamingMediaElementState Enumeration (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SmoothStreamingMediaElementState Enumeration
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElementState
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelementstate(v=VS.95)
ms:contentKeyID: 46307964
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElementState
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElementState.AcquiringLicense
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElementState.Buffering
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElementState.ClipPlaying
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElementState.Closed
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElementState.Playing
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElementState.Individualizing
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElementState.Paused
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElementState.Opening
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElementState.Stopped
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElementState
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElementState.AcquiringLicense
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElementState.Buffering
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElementState.ClipPlaying
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElementState.Closed
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElementState.Individualizing
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElementState.Opening
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElementState.Paused
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElementState.Playing
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElementState.Stopped
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElementState Enumeration

Enumeration of possible states for the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md).

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Enumeration SmoothStreamingMediaElementState
'Usage

Dim instance As SmoothStreamingMediaElementState
```

```csharp
public enum SmoothStreamingMediaElementState
```

```cpp
public enum class SmoothStreamingMediaElementState
```

``` fsharp
type SmoothStreamingMediaElementState
```

```jscript
public enum SmoothStreamingMediaElementState
```

## Members

|Support Type|Member name|Description|
|--- |--- |--- |
|![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|Closed|The [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) contains no media. The [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) displays a transparent frame. A media clip can be scheduled for play by using the [ScheduleClip](smoothstreamingmediaelement-scheduleclip-method-microsoft-web-media-smoothstreaming_1.md) method with the [ManifestReady](smoothstreamingmediaelement-manifestready-event-microsoft-web-media-smoothstreaming_1.md) event.|
|![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|Opening|The [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) is loading the media for playback. The [Position](smoothstreamingmediaelement-position-property-microsoft-web-media-smoothstreaming_1.md) does not advance in this state. If the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) was already playing video, it continues to display the last displayed frame.|
|![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|Buffering|The [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) is loading the media for playback. The [Position](smoothstreamingmediaelement-position-property-microsoft-web-media-smoothstreaming_1.md) does not advance. If the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) was playing video, it continues to display the current frame.|
|![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|Playing|The [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) is playing the media specified by its [Source](smoothstreamingmediaelement-source-property-microsoft-web-media-smoothstreaming_1.md) or [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md) property. The [Position](smoothstreamingmediaelement-position-property-microsoft-web-media-smoothstreaming_1.md) advances.|
|![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|Paused|The [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) is paused. The Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Position does not advance. If the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) was playing video, it continues to display the current frame.|
|![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|Stopped|The [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) contains media but is not playing or paused. The [Position](smoothstreamingmediaelement-position-property-microsoft-web-media-smoothstreaming_1.md) is 0 and does not advance. If the loaded media is video, the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) displays the first frame.|
|![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|Individualizing|The individualization components are being validated to make sure that the required components are installed. Before Silverlight requests the license to decrypt the content, Silverlight must first determine whether the end user’s computer has the appropriate DRM software installed. This software is called by the individualization component and is the client of DRM that is required before any protected content can be played. Once [OnAcquireLicense(Stream, Uri)](https://msdn.microsoft.com/library/cc838724(v=vs.95)) has been called, the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) will remain in this state until [SetLicenseResponse(Stream)](https://msdn.microsoft.com/library/cc838403(v=vs.95)) has been called.|
|![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|AcquiringLicense|The [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) is acquiring a license to play DRM protected content. Once [OnAcquireLicense(Stream, Uri)](https://msdn.microsoft.com/library/cc838724(v=vs.95)) has been called, the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) will remain in this state until [SetLicenseResponse(Stream)](https://msdn.microsoft.com/library/cc838403(v=vs.95)) is called.|
|![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|ClipPlaying|The media resource has been interrupted and the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) is playing a clip scheduled by using [ScheduleClip(ClipInformation, ClipContext, Object)](smoothstreamingmediaelement-scheduleclip-method-clipinformation-clipcontext-object-microsoft-web-media-smoothstreaming_1.md) or one of its overloads.|

## Remarks

For more information and code scenarios, see [Microsoft Smooth Streaming Client 2.0](microsoft-smooth-streaming-client-2-0.md).

## Examples

The logic for the **Play** and **Stop** buttons is shown in the following excerpt from the example in the topic [Silverlight Applications](silverlight-applications.md). The Playbutton\_Click delegate uses SmoothStreamingMediaElementState to set the button text and action.

``` 
    private void PlayButton_Loaded(object sender, RoutedEventArgs e)
    {
        switch (SmoothPlayer.AutoPlay)
        {
            case false:
                PlayButton.Content = "Play";
                break;
            case true:
                PlayButton.Content = "Pause";
                break;
        }
        
    }

    private void PlayButton_Click(object sender, RoutedEventArgs e)
    {
        switch (SmoothPlayer.CurrentState)
        {
            case SmoothStreamingMediaElementState.Playing:
                SmoothPlayer.Pause();
                PlayButton.Content = "Play";
                break;

            case SmoothStreamingMediaElementState.Paused:
                SmoothPlayer.Play();
                PlayButton.Content = "Pause";
                break;

            case SmoothStreamingMediaElementState.Stopped:
                SmoothPlayer.Play();
                PlayButton.Content = "Pause";
                break;

        }

    }

    private void StopButton_Click(object sender, RoutedEventArgs e)
    {
        SmoothPlayer.Stop();
        PlayButton.Content = "Play";
    }
```

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
