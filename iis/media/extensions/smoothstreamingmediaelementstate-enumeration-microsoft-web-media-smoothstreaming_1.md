---
title: SmoothStreamingMediaElementState Enumeration (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SmoothStreamingMediaElementState Enumeration
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElementState
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelementstate(v=VS.95)
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
- CSharp
- JScript
- VB
- FSharp
- c++
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
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingMediaElementState Enumeration

Enumeration of possible states for the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md).

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Enumeration SmoothStreamingMediaElementState
'Usage

Dim instance As SmoothStreamingMediaElementState
```

``` csharp
public enum SmoothStreamingMediaElementState
```

``` c++
public enum class SmoothStreamingMediaElementState
```

``` fsharp
type SmoothStreamingMediaElementState
```

``` jscript
public enum SmoothStreamingMediaElementState
```

## Members

<table>
<thead>
<tr class="header">
<th></th>
<th>Member name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td>Closed</td>
<td>The <a href="smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingMediaElement</a> contains no media. The <a href="smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingMediaElement</a> displays a transparent frame. A media clip can be scheduled for play by using the <a href="smoothstreamingmediaelement-scheduleclip-method-microsoft-web-media-smoothstreaming_1.md">ScheduleClip</a> method with the <a href="smoothstreamingmediaelement-manifestready-event-microsoft-web-media-smoothstreaming_1.md">ManifestReady</a> event.</td>
</tr>
<tr class="even">
<td><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td>Opening</td>
<td>The <a href="smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingMediaElement</a> is loading the media for playback. The <a href="smoothstreamingmediaelement-position-property-microsoft-web-media-smoothstreaming_1.md">Position</a> does not advance in this state. If the <a href="smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingMediaElement</a> was already playing video, it continues to display the last displayed frame.</td>
</tr>
<tr class="odd">
<td><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td>Buffering</td>
<td>The <a href="smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingMediaElement</a> is loading the media for playback. The <a href="smoothstreamingmediaelement-position-property-microsoft-web-media-smoothstreaming_1.md">Position</a> does not advance. If the <a href="smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingMediaElement</a> was playing video, it continues to display the current frame.</td>
</tr>
<tr class="even">
<td><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td>Playing</td>
<td>The <a href="smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingMediaElement</a> is playing the media specified by its <a href="smoothstreamingmediaelement-source-property-microsoft-web-media-smoothstreaming_1.md">Source</a> or <a href="smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingSource</a> property. The <a href="smoothstreamingmediaelement-position-property-microsoft-web-media-smoothstreaming_1.md">Position</a> advances.</td>
</tr>
<tr class="odd">
<td><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td>Paused</td>
<td>The <a href="smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingMediaElement</a> is paused. The Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Position does not advance. If the <a href="smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingMediaElement</a> was playing video, it continues to display the current frame.</td>
</tr>
<tr class="even">
<td><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td>Stopped</td>
<td>The <a href="smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingMediaElement</a> contains media but is not playing or paused. The <a href="smoothstreamingmediaelement-position-property-microsoft-web-media-smoothstreaming_1.md">Position</a> is 0 and does not advance. If the loaded media is video, the <a href="smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingMediaElement</a> displays the first frame.</td>
</tr>
<tr class="odd">
<td><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td>Individualizing</td>
<td>The individualization components are being validated to make sure that the required components are installed. Before Silverlight requests the license to decrypt the content, Silverlight must first determine whether the end user’s computer has the appropriate DRM software installed. This software is called by the individualization component and is the client of DRM that is required before any protected content can be played. Once <a href="https://msdn.microsoft.com/en-us/library/cc838724(v=vs.95)">OnAcquireLicense(Stream, Uri)</a> has been called, the <a href="smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingMediaElement</a> will remain in this state until <a href="https://msdn.microsoft.com/en-us/library/cc838403(v=vs.95)">SetLicenseResponse(Stream)</a> has been called.</td>
</tr>
<tr class="even">
<td><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td>AcquiringLicense</td>
<td>The <a href="smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingMediaElement</a> is acquiring a license to play DRM protected content. Once <a href="https://msdn.microsoft.com/en-us/library/cc838724(v=vs.95)">OnAcquireLicense(Stream, Uri)</a> has been called, the <a href="smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingMediaElement</a> will remain in this state until <a href="https://msdn.microsoft.com/en-us/library/cc838403(v=vs.95)">SetLicenseResponse(Stream)</a> is called.</td>
</tr>
<tr class="odd">
<td><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td>ClipPlaying</td>
<td>The media resource has been interrupted and the <a href="smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingMediaElement</a> is playing a clip scheduled by using <a href="smoothstreamingmediaelement-scheduleclip-method-clipinformation-clipcontext-object-microsoft-web-media-smoothstreaming_1.md">ScheduleClip(ClipInformation, ClipContext, Object)</a> or one of its overloads.</td>
</tr>
</tbody>
</table>


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

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

