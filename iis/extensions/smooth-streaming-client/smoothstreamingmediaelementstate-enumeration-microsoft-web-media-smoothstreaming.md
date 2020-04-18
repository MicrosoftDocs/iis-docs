---
title: SmoothStreamingMediaElementState Enumeration (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SmoothStreamingMediaElementState Enumeration
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElementState
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelementstate(v=VS.90)
ms:contentKeyID: 28440985
ms.date: 05/02/2012
mtps_version: v=VS.90
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

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

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

```jscript
  public enum SmoothStreamingMediaElementState
```

## Remarks

For more information and code scenarios, see [IIS Smooth Streaming Client 1.5](microsoft-smooth-streaming-client-2-0.md).

## Examples

The logic for the **Play** and **Stop** buttons is shown in the following excerpt from the example in the topic [Silverlight Applications (IIS Smooth Streaming)](silverlight-applications.md). The Playbutton\_Click delegate uses SmoothStreamingMediaElementState to set the button text and action.

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

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## See Also

### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
