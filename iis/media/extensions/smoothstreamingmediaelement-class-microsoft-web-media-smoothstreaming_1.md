---
title: SmoothStreamingMediaElement Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SmoothStreamingMediaElement Class
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement(v=VS.95)
ms:contentKeyID: 46307968
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingMediaElement Class

Represents a media player that provides [MediaElement](https://msdn.microsoft.com/en-us/library/ms611595\(v=vs.95\)) capabilities and advertising integration. The class is designed to support Smooth Streaming.

## Inheritance Hierarchy

 [System.Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.95\))  
  [System.Windows.DependencyObject](https://msdn.microsoft.com/en-us/library/ms589309\(v=vs.95\))  
    [System.Windows.UIElement](https://msdn.microsoft.com/en-us/library/ms590078\(v=vs.95\))  
      [System.Windows.FrameworkElement](https://msdn.microsoft.com/en-us/library/ms602714\(v=vs.95\))  
        [System.Windows.Controls.Control](https://msdn.microsoft.com/en-us/library/ms609826\(v=vs.95\))  
          Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

<TemplatePartAttribute(Name := "MediaElement", Type := GetType(MediaElement))> _
<TemplatePartAttribute(Name := "RootElement", Type := GetType(Panel))> _
<TemplateVisualStateAttribute(Name := "Normal", GroupName := "PlaybackModes")> _
<TemplateVisualStateAttribute(Name := "ClipPlayback", GroupName := "PlaybackModes")> _
Public Class SmoothStreamingMediaElement _
    Inherits Control _
    Implements IDisposable
'Usage

Dim instance As SmoothStreamingMediaElement
```

``` csharp
[TemplatePartAttribute(Name = "MediaElement", Type = typeof(MediaElement))]
[TemplatePartAttribute(Name = "RootElement", Type = typeof(Panel))]
[TemplateVisualStateAttribute(Name = "Normal", GroupName = "PlaybackModes")]
[TemplateVisualStateAttribute(Name = "ClipPlayback", GroupName = "PlaybackModes")]
public class SmoothStreamingMediaElement : Control, 
    IDisposable
```

``` c++
[TemplatePartAttribute(Name = L"MediaElement", Type = typeof(MediaElement))]
[TemplatePartAttribute(Name = L"RootElement", Type = typeof(Panel))]
[TemplateVisualStateAttribute(Name = L"Normal", GroupName = L"PlaybackModes")]
[TemplateVisualStateAttribute(Name = L"ClipPlayback", GroupName = L"PlaybackModes")]
public ref class SmoothStreamingMediaElement : public Control, 
    IDisposable
```

``` fsharp
[<TemplatePartAttribute(Name = "MediaElement", Type = typeof(MediaElement))>]
[<TemplatePartAttribute(Name = "RootElement", Type = typeof(Panel))>]
[<TemplateVisualStateAttribute(Name = "Normal", GroupName = "PlaybackModes")>]
[<TemplateVisualStateAttribute(Name = "ClipPlayback", GroupName = "PlaybackModes")>]
type SmoothStreamingMediaElement =  
    class
        inherit Control
        interface IDisposable
    end
```

``` jscript
public class SmoothStreamingMediaElement extends Control implements IDisposable
```

The SmoothStreamingMediaElement type exposes the following members.

## Constructors

<table>
<thead>
<tr class="header">
<th> </th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-constructor-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingMediaElement</a></td>
<td>Initializes a new instance of the SmoothStreamingMediaElement class.</td>
</tr>
</tbody>
</table>


Top

## Properties

<table>
<thead>
<tr class="header">
<th> </th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms600871(v=vs.95)">ActualHeight</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms600872(v=vs.95)">ActualWidth</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms588665(v=vs.95)">AllowDrop</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-attributes-property-microsoft-web-media-smoothstreaming_1.md">Attributes</a></td>
<td>Gets or sets the attributes dictionary.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-audiostreamcount-property-microsoft-web-media-smoothstreaming_1.md">AudioStreamCount</a></td>
<td>Gets or sets the audio stream count. (This property is available only for Windows Media Video (.wmv) content.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-audiostreamindex-property-microsoft-web-media-smoothstreaming_1.md">AudioStreamIndex</a></td>
<td>Gets or sets the audio stream index. (This property is available only for Windows Media Video (.wmv) content.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-autoplay-property-microsoft-web-media-smoothstreaming_1.md">AutoPlay</a></td>
<td>Gets or sets a value that specifies whether the media element starts automatically.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms592510(v=vs.95)">Background</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-balance-property-microsoft-web-media-smoothstreaming_1.md">Balance</a></td>
<td>Gets or sets the audio balance.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms592511(v=vs.95)">BorderBrush</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms592512(v=vs.95)">BorderThickness</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-bufferingprogress-property-microsoft-web-media-smoothstreaming_1.md">BufferingProgress</a></td>
<td>Gets or sets the buffering progress. (This property is available only for Windows Phone clients, not for Silverlight.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-bufferingtime-property-microsoft-web-media-smoothstreaming_1.md">BufferingTime</a></td>
<td>Gets or sets the duration of media content that will be buffered before playback can start or continue.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/dd491303(v=vs.95)">CacheMode</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-canpause-property-microsoft-web-media-smoothstreaming_1.md">CanPause</a></td>
<td>Gets or sets a value that specifies whether the stream can be paused.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-canseek-property-microsoft-web-media-smoothstreaming_1.md">CanSeek</a></td>
<td>Gets or sets whether the position in the stream can be reset.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/gg712892(v=vs.95)">CharacterSpacing</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms588677(v=vs.95)">Clip</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="smoothstreamingmediaelement-clipmediaelementstyle-property-microsoft-web-media-smoothstreaming_1.md">ClipMediaElementStyle</a></td>
<td>Gets or sets the style object for the window.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="smoothstreamingmediaelement-clipposition-property-microsoft-web-media-smoothstreaming_1.md">ClipPosition</a></td>
<td>Gets or sets the position in a clip stream.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-configpath-property-microsoft-web-media-smoothstreaming_1.md">ConfigPath</a></td>
<td>Gets or sets the path of the configuration file.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-cookiecontainer-property-microsoft-web-media-smoothstreaming_1.md">CookieContainer</a></td>
<td>Gets or set the cookie container that will be used with all HTTP requests.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="smoothstreamingmediaelement-currentlinearclipcontext-property-microsoft-web-media-smoothstreaming.md">CurrentLinearClipContext</a></td>
<td>Gets the current linear clip context.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-currentsegmentindex-property-microsoft-web-media-smoothstreaming_1.md">CurrentSegmentIndex</a></td>
<td>Gets the index of the currently playing segment.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-currentstate-property-microsoft-web-media-smoothstreaming_1.md">CurrentState</a></td>
<td>Gets or sets the current state of playback.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms600874(v=vs.95)">Cursor</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms600875(v=vs.95)">DataContext</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Ee230846.protproperty(en-us,VS.90).gif" title="Protected property" alt="Protected property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/cc626455(v=vs.95)">DefaultStyleKey</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms588686(v=vs.95)">DesiredSize</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/cc190851(v=vs.95)">Dispatcher</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms589309(v=vs.95)">DependencyObject</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-downloadprogress-property-microsoft-web-media-smoothstreaming_1.md">DownloadProgress</a></td>
<td>Gets or sets the download progress.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-downloadprogressoffset-property-microsoft-web-media-smoothstreaming_1.md">DownloadProgressOffset</a></td>
<td>Gets or sets the progress offset as a percentage.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-droppedframespersecond-property-microsoft-web-media-smoothstreaming_1.md">DroppedFramesPerSecond</a></td>
<td>Gets or sets the percentage of dropped frames per second.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/cc489982(v=vs.95)">Effect</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-enablegpuacceleration-property-microsoft-web-media-smoothstreaming_1.md">EnableGPUAcceleration</a></td>
<td>Gets or sets a value that indicates whether Global Processing Unit (GPU) acceleration is enabled</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-endposition-property-microsoft-web-media-smoothstreaming_1.md">EndPosition</a></td>
<td>Gets or sets the end position.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms600877(v=vs.95)">FlowDirection</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms592513(v=vs.95)">FontFamily</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms592514(v=vs.95)">FontSize</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms592515(v=vs.95)">FontStretch</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms592516(v=vs.95)">FontStyle</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms592517(v=vs.95)">FontWeight</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms592518(v=vs.95)">Foreground</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms600880(v=vs.95)">Height</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms600881(v=vs.95)">HorizontalAlignment</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms592520(v=vs.95)">HorizontalContentAlignment</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="smoothstreamingmediaelement-isdecodingongpu-property-microsoft-web-media-smoothstreaming.md">IsDecodingOnGPU</a></td>
<td>Gets a value that indicates whether Global Processing Unit (GPU) decoding is enabled.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/cc838493(v=vs.95)">IsEnabled</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms588707(v=vs.95)">IsHitTestVisible</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-islive-property-microsoft-web-media-smoothstreaming_1.md">IsLive</a></td>
<td>Gets or sets a value that indicates whether the current position is close to the live broadcast position.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-isliveposition-property-microsoft-web-media-smoothstreaming_1.md">IsLivePosition</a></td>
<td>Gets or sets a value that indicates whether the current position is close to the live broadcast position.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-ismuted-property-microsoft-web-media-smoothstreaming_1.md">IsMuted</a></td>
<td>Gets or sets a value that indicates whether the audio track is muted.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms592521(v=vs.95)">IsTabStop</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms600886(v=vs.95)">Language</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-licenseacquirer-property-microsoft-web-media-smoothstreaming_1.md">LicenseAcquirer</a></td>
<td>Gets or sets the license acquirer.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="smoothstreamingmediaelement-livebackoff-property-microsoft-web-media-smoothstreaming_1.md">LiveBackOff</a></td>
<td>Gets or sets the duration of content closest to live that cannot yet be downloaded.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="smoothstreamingmediaelement-liveplaybackoffset-property-microsoft-web-media-smoothstreaming_1.md">LivePlaybackOffset</a></td>
<td>Gets or sets how far back from the live position, excluding <a href="smoothstreamingmediaelement-livebackoff-property-microsoft-web-media-smoothstreaming_1.md">LiveBackOff</a>, to start playback when joining a live presentation.  Increasing this value allows the pre-roll buffer to fill faster than real time and creates a buffer against network jitter, but increases the end-to-end latency of the presentation. The default value is 7 seconds. Changes that are made to this value after the <a href="smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingSource</a> property has been set are disregarded.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-liveplaybackstartposition-property-microsoft-web-media-smoothstreaming_1.md">LivePlaybackStartPosition</a></td>
<td>Gets or sets the starting position to use during live playback.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-liveposition-property-microsoft-web-media-smoothstreaming_1.md">LivePosition</a></td>
<td>Gets the position that is nearest to the live stream that a client can seek to.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-manifestinfo-property-microsoft-web-media-smoothstreaming_1.md">ManifestInfo</a></td>
<td>Gets the manifest info object.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms600890(v=vs.95)">Margin</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="smoothstreamingmediaelement-markers-property-microsoft-web-media-smoothstreaming_1.md">Markers</a></td>
<td>Gets the markers collection.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="smoothstreamingmediaelement-master-property-microsoft-web-media-smoothstreaming_1.md">Master</a></td>
<td>Gets or sets the master (parent) object.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms600891(v=vs.95)">MaxHeight</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms600892(v=vs.95)">MaxWidth</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms600893(v=vs.95)">MinHeight</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms600894(v=vs.95)">MinWidth</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms600895(v=vs.95)">Name</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-naturalduration-property-microsoft-web-media-smoothstreaming_1.md">NaturalDuration</a></td>
<td>Gets the duration of the current stream when it plays to the end.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-naturalvideoheight-property-microsoft-web-media-smoothstreaming_1.md">NaturalVideoHeight</a></td>
<td>Gets the height of the video display at which the resource appears best.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-naturalvideowidth-property-microsoft-web-media-smoothstreaming_1.md">NaturalVideoWidth</a></td>
<td>Gets the width of video display at which the resource appears best.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms588741(v=vs.95)">Opacity</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms588745(v=vs.95)">OpacityMask</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms592522(v=vs.95)">Padding</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms600897(v=vs.95)">Parent</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="smoothstreamingmediaelement-pipmode-property-microsoft-web-media-smoothstreaming_1.md">PipMode</a></td>
<td>Gets or sets a value that indicates whether the media stream is in picture-in-picture (PIP) mode.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-playbackrate-property-microsoft-web-media-smoothstreaming_1.md">PlaybackRate</a></td>
<td>Gets the playback rate.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-position-property-microsoft-web-media-smoothstreaming_1.md">Position</a></td>
<td>Gets or sets the position in the current stream.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/dd459686(v=vs.95)">Projection</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-renderedframespersecond-property-microsoft-web-media-smoothstreaming_1.md">RenderedFramesPerSecond</a></td>
<td>Gets the rate of rendered frames.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms588747(v=vs.95)">RenderSize</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms588750(v=vs.95)">RenderTransform</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms588752(v=vs.95)">RenderTransformOrigin</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms600898(v=vs.95)">Resources</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-smoothstreamingcache-property-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingCache</a></td>
<td>Gets or sets the Smooth Streaming cache to use during main content playback.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-smoothstreamingplaybackmode-property-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingPlaybackMode</a></td>
<td>Gets or sets the Smooth Streaming playback mode to use during main content playback.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingSource</a></td>
<td>Gets or sets the URI of the Smooth Streaming source.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-source-property-microsoft-web-media-smoothstreaming_1.md">Source</a></td>
<td>Gets or sets a media stream source that is not a Smooth Streaming source.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-startposition-property-microsoft-web-media-smoothstreaming_1.md">StartPosition</a></td>
<td>Gets or sets the start position of the current stream.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-stretch-property-microsoft-web-media-smoothstreaming_1.md">Stretch</a></td>
<td>Gets or sets an object that determines how to stretch the media display.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms600899(v=vs.95)">Style</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-supportedplaybackrates-property-microsoft-web-media-smoothstreaming_1.md">SupportedPlaybackRates</a></td>
<td>Gets or sets the playback rates list.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms592523(v=vs.95)">TabIndex</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/cc190692(v=vs.95)">TabNavigation</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms600900(v=vs.95)">Tag</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms592524(v=vs.95)">Template</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-totalbytesdownloaded-property-microsoft-web-media-smoothstreaming_1.md">TotalBytesDownloaded</a></td>
<td>Gets the total bytes downloaded.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-trailingwindowduration-property-microsoft-web-media-smoothstreaming_1.md">TrailingWindowDuration</a></td>
<td>Gets or sets the trailing window duration.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms600903(v=vs.95)">Triggers</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/cc838610(v=vs.95)">UseLayoutRounding</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms600904(v=vs.95)">VerticalAlignment</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms592525(v=vs.95)">VerticalContentAlignment</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-videodownloadtrack-property-microsoft-web-media-smoothstreaming_1.md">VideoDownloadTrack</a></td>
<td>Gets the video download track.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-videohighestplayabletrack-property-microsoft-web-media-smoothstreaming_1.md">VideoHighestPlayableTrack</a></td>
<td>Gets the track that has the highest available bandwidth.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-videoplaybacktrack-property-microsoft-web-media-smoothstreaming_1.md">VideoPlaybackTrack</a></td>
<td>Gets the video playback track.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms588755(v=vs.95)">Visibility</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-volume-property-microsoft-web-media-smoothstreaming_1.md">Volume</a></td>
<td>Gets or sets the audio volume.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms600906(v=vs.95)">Width</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
</tbody>
</table>


Top

## Methods

<table>
<thead>
<tr class="header">
<th> </th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms598899(v=vs.95)">AddHandler</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/cc190802(v=vs.95)">ApplyTemplate</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms598904(v=vs.95)">Arrange</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms598098(v=vs.95)">ArrangeOverride</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms598907(v=vs.95)">CaptureMouse</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/cc190403(v=vs.95)">CheckAccess</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms589309(v=vs.95)">DependencyObject</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms597464(v=vs.95)">ClearValue</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms589309(v=vs.95)">DependencyObject</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-dispose-method-microsoft-web-media-smoothstreaming_1.md">Dispose</a></td>
<td>Disposes the SmoothStreamingMediaElement object.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bsc2ak47(v=vs.95)">Equals</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/4k87zsw7(v=vs.95)">Finalize</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms598120(v=vs.95)">FindName</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-flushbuffers-method-microsoft-web-media-smoothstreaming_1.md">FlushBuffers</a></td>
<td>Flushes audio and video buffers, retaining a specified amount of content if possible.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/cc189949(v=vs.95)">Focus</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/cc190722(v=vs.95)">GetAnimationBaseValue</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms589309(v=vs.95)">DependencyObject</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms598124(v=vs.95)">GetBindingExpression</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.95)">GetHashCode</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/cc190737(v=vs.95)">GetTemplateChild</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/dfwy45w9(v=vs.95)">GetType</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms597469(v=vs.95)">GetValue</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms589309(v=vs.95)">DependencyObject</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms598917(v=vs.95)">InvalidateArrange</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms598918(v=vs.95)">InvalidateMeasure</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms598921(v=vs.95)">Measure</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms598227(v=vs.95)">MeasureOverride</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/57ctke0a(v=vs.95)">MemberwiseClone</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="smoothstreamingmediaelement-mergeexternalmanifest-method-microsoft-web-media-smoothstreaming_1.md">MergeExternalManifest</a></td>
<td>Replaces some elements of the main manifest with others from an external manifest or adds new elements to the main manifest.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-onapplytemplate-method-microsoft-web-media-smoothstreaming_1.md">OnApplyTemplate</a></td>
<td>Disconnects and connects event handlers and key properties during a template change. (Overrides <a href="https://msdn.microsoft.com/en-us/library/ms598234(v=vs.95)">FrameworkElement.OnApplyTemplate()</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms598925(v=vs.95)">OnCreateAutomationPeer</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/gg986890(v=vs.95)">OnDoubleTap</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ee653027(v=vs.95)">OnDragEnter</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ee652571(v=vs.95)">OnDragLeave</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ee652766(v=vs.95)">OnDragOver</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ee652958(v=vs.95)">OnDrop</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/cc838373(v=vs.95)">OnGotFocus</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/gg986887(v=vs.95)">OnHold</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/cc838780(v=vs.95)">OnKeyDown</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/cc838298(v=vs.95)">OnKeyUp</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/cc838359(v=vs.95)">OnLostFocus</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/dd833781(v=vs.95)">OnLostMouseCapture</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ff400412(v=vs.95)">OnManipulationCompleted</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ff400380(v=vs.95)">OnManipulationDelta</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ff400475(v=vs.95)">OnManipulationStarted</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/cc838748(v=vs.95)">OnMouseEnter</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/cc838717(v=vs.95)">OnMouseLeave</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/cc838744(v=vs.95)">OnMouseLeftButtonDown</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/cc838783(v=vs.95)">OnMouseLeftButtonUp</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/cc838704(v=vs.95)">OnMouseMove</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ee652650(v=vs.95)">OnMouseRightButtonDown</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ee653024(v=vs.95)">OnMouseRightButtonUp</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/dd699479(v=vs.95)">OnMouseWheel</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/gg986865(v=vs.95)">OnTap</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ee478107(v=vs.95)">OnTextInput</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ee652929(v=vs.95)">OnTextInputStart</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ee652881(v=vs.95)">OnTextInputUpdate</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="smoothstreamingmediaelement-parseexternalmanifest-method-microsoft-web-media-smoothstreaming_1.md">ParseExternalManifest</a></td>
<td>Downloads, parses, and returns an object that represents the specified external manifest.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-pause-method-microsoft-web-media-smoothstreaming_1.md">Pause</a></td>
<td>Pauses playing of audio or video media.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-play-method-microsoft-web-media-smoothstreaming_1.md">Play</a></td>
<td>Starts playing audio or video media.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms597472(v=vs.95)">ReadLocalValue</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms589309(v=vs.95)">DependencyObject</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms599321(v=vs.95)">ReleaseMouseCapture</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms599323(v=vs.95)">RemoveHandler</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-requestlog-method-microsoft-web-media-smoothstreaming_1.md">RequestLog</a></td>
<td>Sends a request to generate a log that will be raised by the System.Windows.Controls.MediaElement.LogReady event.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="smoothstreamingmediaelement-scheduleclip-method-clipinformation-clipcontext-object-microsoft-web-media-smoothstreaming_1.md">ScheduleClip(ClipInformation, ClipContext, Object)</a></td>
<td>Schedules playing of a media clip.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="smoothstreamingmediaelement-scheduleclip-method-clipinformation-boolean-object-microsoft-web-media-smoothstreaming_1.md">ScheduleClip(ClipInformation, Boolean, Object)</a></td>
<td>Schedules playing of a media clip.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="smoothstreamingmediaelement-scheduleclip-method-clipinformation-boolean-timespan-object-microsoft-web-media-smoothstreaming_1.md">ScheduleClip(ClipInformation, Boolean, TimeSpan, Object)</a></td>
<td>Schedules playing of a media clip.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="smoothstreamingmediaelement-scheduleclip-method-clipinformation-timespan-boolean-object-microsoft-web-media-smoothstreaming_1.md">ScheduleClip(ClipInformation, TimeSpan, Boolean, Object)</a></td>
<td>Schedules playing of a media clip.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="smoothstreamingmediaelement-schedulelinearclip-method-microsoft-web-media-smoothstreaming.md">ScheduleLinearClip</a></td>
<td>Schedules play of a linear media clip.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/cc189874(v=vs.95)">SetBinding</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="smoothstreamingmediaelement-setplaybackrangeasync-method-microsoft-web-media-smoothstreaming.md">SetPlaybackRangeAsync</a></td>
<td>Specifies a start position for playing media content.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-setplaybackrate-method-microsoft-web-media-smoothstreaming_1.md">SetPlaybackRate</a></td>
<td>Sets the playback rate of media stream.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-setsource-method-microsoft-web-media-smoothstreaming_1.md">SetSource</a></td>
<td>Sets the source of the SmoothStreamingMediaElement object.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms597473(v=vs.95)">SetValue</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms589309(v=vs.95)">DependencyObject</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-startseektolive-method-microsoft-web-media-smoothstreaming_1.md">StartSeekToLive</a></td>
<td>Starts a seek to a live media stream.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-stop-method-microsoft-web-media-smoothstreaming_1.md">Stop</a></td>
<td>Stops playing by the SmoothStreamingMediaElement object.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.95)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/cc189872(v=vs.95)">TransformToVisual</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms599327(v=vs.95)">UpdateLayout</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
</tbody>
</table>


Top

## Events

<table>
<thead>
<tr class="header">
<th> </th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/cc626450(v=vs.95)">BindingValidationError</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-bufferingprogresschanged-event-microsoft-web-media-smoothstreaming_1.md">BufferingProgressChanged</a></td>
<td>Occurs when the <a href="smoothstreamingmediaelement-bufferingprogress-property-microsoft-web-media-smoothstreaming_1.md">BufferingProgress</a> property changes.</td>
</tr>
<tr class="odd">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /></td>
<td><a href="smoothstreamingmediaelement-chunkdownloadfailed-event-microsoft-web-media-smoothstreaming.md">ChunkDownloadFailed</a></td>
<td>Occurs when the chunk download associated with an audio or video stream fails.</td>
</tr>
<tr class="even">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /></td>
<td><a href="smoothstreamingmediaelement-clipclickthrough-event-microsoft-web-media-smoothstreaming_1.md">ClipClickThrough</a></td>
<td>Occurs when a user clicks the media display.</td>
</tr>
<tr class="odd">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /></td>
<td><a href="smoothstreamingmediaelement-cliperror-event-microsoft-web-media-smoothstreaming_1.md">ClipError</a></td>
<td>Occurs when an error is raised while audio or video media is playing.</td>
</tr>
<tr class="even">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /></td>
<td><a href="smoothstreamingmediaelement-clipprogressupdate-event-microsoft-web-media-smoothstreaming_1.md">ClipProgressUpdate</a></td>
<td>Occurs when media reaches a marker.</td>
</tr>
<tr class="odd">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /></td>
<td><a href="smoothstreamingmediaelement-clipstatechanged-event-microsoft-web-media-smoothstreaming_1.md">ClipStateChanged</a></td>
<td>Occurs when a media clip state changes.</td>
</tr>
<tr class="even">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-currentstatechanged-event-microsoft-web-media-smoothstreaming_1.md">CurrentStateChanged</a></td>
<td>Occurs when the current state of media element changes.</td>
</tr>
<tr class="odd">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms596556(v=vs.95)">DataContextChanged</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/gg986869(v=vs.95)">DoubleTap</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-downloadprogresschanged-event-microsoft-web-media-smoothstreaming_1.md">DownloadProgressChanged</a></td>
<td>Occurs when the <a href="smoothstreamingmediaelement-downloadprogress-property-microsoft-web-media-smoothstreaming_1.md">DownloadProgress</a> property changes.</td>
</tr>
<tr class="even">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-downloadtrackchanged-event-microsoft-web-media-smoothstreaming_1.md">DownloadTrackChanged</a></td>
<td>Occurs when the track selected for download differs from the previously selected track.</td>
</tr>
<tr class="odd">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms596639(v=vs.95)">DragEnter</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms596640(v=vs.95)">DragLeave</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms596641(v=vs.95)">DragOver</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /></td>
<td><a href="smoothstreamingmediaelement-drmsetupdecryptorcompleted-event-microsoft-web-media-smoothstreaming.md">DrmSetupDecryptorCompleted</a></td>
<td>Occurs when the digital rights managment (DRM) decryptor setup has completed.</td>
</tr>
<tr class="odd">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms596642(v=vs.95)">Drop</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms596645(v=vs.95)">GotFocus</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/gg986877(v=vs.95)">Hold</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/cc838340(v=vs.95)">IsEnabledChanged</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms609826(v=vs.95)">Control</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms596670(v=vs.95)">KeyDown</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms596671(v=vs.95)">KeyUp</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/cc190381(v=vs.95)">LayoutUpdated</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /></td>
<td><a href="smoothstreamingmediaelement-linearclipchanged-event-microsoft-web-media-smoothstreaming.md">LinearClipChanged</a></td>
<td>Occurs when a media stream transitions in and out of a linear clip between two linear ads.</td>
</tr>
<tr class="odd">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-liveeventcompleted-event-microsoft-web-media-smoothstreaming_1.md">LiveEventCompleted</a></td>
<td>Occurs when a live media stream ends.</td>
</tr>
<tr class="even">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms596558(v=vs.95)">Loaded</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-logready-event-microsoft-web-media-smoothstreaming_1.md">LogReady</a></td>
<td>Occurs when the log generated by the <a href="smoothstreamingmediaelement-requestlog-method-microsoft-web-media-smoothstreaming_1.md">RequestLog</a> method is ready.</td>
</tr>
<tr class="even">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms596673(v=vs.95)">LostFocus</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms596675(v=vs.95)">LostMouseCapture</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /></td>
<td><a href="smoothstreamingmediaelement-manifestmerge-event-microsoft-web-media-smoothstreaming_1.md">ManifestMerge</a></td>
<td>Occurs when the main manifest has been parsed.</td>
</tr>
<tr class="odd">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-manifestready-event-microsoft-web-media-smoothstreaming_1.md">ManifestReady</a></td>
<td>Occurs when the manifest for the Smooth Streaming content is available for track selection.</td>
</tr>
<tr class="even">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/dd403080(v=vs.95)">ManipulationCompleted</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/dd403301(v=vs.95)">ManipulationDelta</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/dd403503(v=vs.95)">ManipulationStarted</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /></td>
<td><a href="smoothstreamingmediaelement-markerreached-event-microsoft-web-media-smoothstreaming_1.md">MarkerReached</a></td>
<td>Occurs when media playback reaches a timeline marker.</td>
</tr>
<tr class="even">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/hh341969(v=vs.95)">MediaCommand</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-mediaended-event-microsoft-web-media-smoothstreaming_1.md">MediaEnded</a></td>
<td>Occurs when media playback reaches the end.</td>
</tr>
<tr class="even">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-mediafailed-event-microsoft-web-media-smoothstreaming_1.md">MediaFailed</a></td>
<td>Occurs when there is an error associated with the media source.</td>
</tr>
<tr class="odd">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-mediaopened-event-microsoft-web-media-smoothstreaming_1.md">MediaOpened</a></td>
<td>Occurs when the media stream has been validated and opened and the file headers have been read.</td>
</tr>
<tr class="even">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms596678(v=vs.95)">MouseEnter</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms596679(v=vs.95)">MouseLeave</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms596680(v=vs.95)">MouseLeftButtonDown</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms596681(v=vs.95)">MouseLeftButtonUp</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms596682(v=vs.95)">MouseMove</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms596683(v=vs.95)">MouseRightButtonDown</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms596684(v=vs.95)">MouseRightButtonUp</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms596686(v=vs.95)">MouseWheel</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-playbacktrackchanged-event-microsoft-web-media-smoothstreaming_1.md">PlaybackTrackChanged</a></td>
<td>Occurs when the currently playing track changes.</td>
</tr>
<tr class="odd">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-seekcompleted-event-microsoft-web-media-smoothstreaming_1.md">SeekCompleted</a></td>
<td>Occurs when a seek operation completes.</td>
</tr>
<tr class="even">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /></td>
<td><a href="smoothstreamingmediaelement-setplaybackrangecompleted-event-microsoft-web-media-smoothstreaming.md">SetPlaybackRangeCompleted</a></td>
<td>Occurs when a SetPlaybackRangeAsync operation has completed.</td>
</tr>
<tr class="odd">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms596560(v=vs.95)">SizeChanged</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-smoothstreamingerroroccurred-event-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingErrorOccurred</a></td>
<td>Occurs when an error is raised during playback of Smooth Streaming content.</td>
</tr>
<tr class="odd">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/gg986879(v=vs.95)">Tap</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms596795(v=vs.95)">TextInput</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ee652569(v=vs.95)">TextInputStart</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ee652690(v=vs.95)">TextInputUpdate</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms590078(v=vs.95)">UIElement</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ms596565(v=vs.95)">Unloaded</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/ms602714(v=vs.95)">FrameworkElement</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-videohighestplayabletrackchanged-event-microsoft-web-media-smoothstreaming_1.md">VideoHighestPlayableTrackChanged</a></td>
<td>Occurs when the playback rate changes to the highest available rate.</td>
</tr>
</tbody>
</table>


Top

## Fields

<table>
<thead>
<tr class="header">
<th> </th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-attributesproperty-field-microsoft-web-media-smoothstreaming_1.md">AttributesProperty</a></td>
<td>Represents a dependency property that specifies the <a href="smoothstreamingmediaelement-attributes-property-microsoft-web-media-smoothstreaming_1.md">Attributes</a> property dictionary object.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-audiostreamcountproperty-field-microsoft-web-media-smoothstreaming_1.md">AudioStreamCountProperty</a></td>
<td>Represents a dependency property that specifies the <a href="smoothstreamingmediaelement-audiostreamcount-property-microsoft-web-media-smoothstreaming_1.md">AudioStreamCount</a> property.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-audiostreamindexproperty-field-microsoft-web-media-smoothstreaming_1.md">AudioStreamIndexProperty</a></td>
<td>Represents a dependency property that specifies the <a href="smoothstreamingmediaelement-audiostreamindex-property-microsoft-web-media-smoothstreaming_1.md">AudioStreamIndex</a> property.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-autoplayproperty-field-microsoft-web-media-smoothstreaming_1.md">AutoPlayProperty</a></td>
<td>Represents a dependency property that specifies the <a href="smoothstreamingmediaelement-autoplay-property-microsoft-web-media-smoothstreaming_1.md">AutoPlay</a> property.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-balanceproperty-field-microsoft-web-media-smoothstreaming_1.md">BalanceProperty</a></td>
<td>Represents a dependency property that specifies the <a href="smoothstreamingmediaelement-balance-property-microsoft-web-media-smoothstreaming_1.md">Balance</a> property.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-bufferingprogressproperty-field-microsoft-web-media-smoothstreaming_1.md">BufferingProgressProperty</a></td>
<td>Represents a dependency property that specifies the <a href="smoothstreamingmediaelement-bufferingprogress-property-microsoft-web-media-smoothstreaming_1.md">BufferingProgress</a> property.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-bufferingtimeproperty-field-microsoft-web-media-smoothstreaming_1.md">BufferingTimeProperty</a></td>
<td>Represents a dependency property that specifies the <a href="smoothstreamingmediaelement-bufferingtime-property-microsoft-web-media-smoothstreaming_1.md">BufferingTime</a> property.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-canpauseproperty-field-microsoft-web-media-smoothstreaming_1.md">CanPauseProperty</a></td>
<td>Represents a dependency property that specifies the <a href="smoothstreamingmediaelement-canpause-property-microsoft-web-media-smoothstreaming_1.md">CanPause</a> property.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-canseekproperty-field-microsoft-web-media-smoothstreaming_1.md">CanSeekProperty</a></td>
<td>Represents a dependency property that specifies the <a href="smoothstreamingmediaelement-canseek-property-microsoft-web-media-smoothstreaming_1.md">CanSeek</a> property.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="smoothstreamingmediaelement-clipmediaelementstyleproperty-field-microsoft-web-media-smoothstreaming_1.md">ClipMediaElementStyleProperty</a></td>
<td>Represents a dependency property that specifies the <a href="smoothstreamingmediaelement-clipmediaelementstyle-property-microsoft-web-media-smoothstreaming_1.md">ClipMediaElementStyle</a> property.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="smoothstreamingmediaelement-clippositionproperty-field-microsoft-web-media-smoothstreaming_1.md">ClipPositionProperty</a></td>
<td>Represents a dependency property that specifies the <a href="smoothstreamingmediaelement-clipposition-property-microsoft-web-media-smoothstreaming_1.md">ClipPosition</a> property.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-configpathproperty-field-microsoft-web-media-smoothstreaming_1.md">ConfigPathProperty</a></td>
<td>Represents a dependency property that specifies the <a href="smoothstreamingmediaelement-configpath-property-microsoft-web-media-smoothstreaming_1.md">ConfigPath</a> property.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-currentsegmentindexproperty-field-microsoft-web-media-smoothstreaming_1.md">CurrentSegmentIndexProperty</a></td>
<td>Represents a dependency property that represents the <a href="smoothstreamingmediaelement-currentsegmentindex-property-microsoft-web-media-smoothstreaming_1.md">CurrentSegmentIndex</a> property.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-currentstateproperty-field-microsoft-web-media-smoothstreaming_1.md">CurrentStateProperty</a></td>
<td>Represents a dependency property that specifies the <a href="smoothstreamingmediaelement-currentstate-property-microsoft-web-media-smoothstreaming_1.md">CurrentState</a> property.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-downloadprogressoffsetproperty-field-microsoft-web-media-smoothstreaming_1.md">DownloadProgressOffsetProperty</a></td>
<td>Represents a dependency property that specifies the <a href="smoothstreamingmediaelement-downloadprogressoffset-property-microsoft-web-media-smoothstreaming_1.md">DownloadProgressOffset</a> property.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-downloadprogressproperty-field-microsoft-web-media-smoothstreaming_1.md">DownloadProgressProperty</a></td>
<td>Represents a dependency property that specifies the <a href="smoothstreamingmediaelement-downloadprogress-property-microsoft-web-media-smoothstreaming_1.md">DownloadProgress</a> property.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-enablegpuaccelerationproperty-field-microsoft-web-media-smoothstreaming_1.md">EnableGPUAccelerationProperty</a></td>
<td>Represents a dependency property that specifies the <a href="smoothstreamingmediaelement-enablegpuacceleration-property-microsoft-web-media-smoothstreaming_1.md">EnableGPUAcceleration</a> property.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="smoothstreamingmediaelement-isdecodingongpuproperty-field-microsoft-web-media-smoothstreaming.md">IsDecodingOnGPUProperty</a></td>
<td>Represents a dependency property that specifies the <a href="smoothstreamingmediaelement-isdecodingongpu-property-microsoft-web-media-smoothstreaming.md">IsDecodingOnGPU</a> property.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-ismutedproperty-field-microsoft-web-media-smoothstreaming_1.md">IsMutedProperty</a></td>
<td>Represents a dependency property that specifies the <a href="smoothstreamingmediaelement-ismuted-property-microsoft-web-media-smoothstreaming_1.md">IsMuted</a> property.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="smoothstreamingmediaelement-livebackoffproperty-field-microsoft-web-media-smoothstreaming_1.md">LiveBackOffProperty</a></td>
<td>Represents a dependency property that specifies the <a href="smoothstreamingmediaelement-livebackoff-property-microsoft-web-media-smoothstreaming_1.md">LiveBackOff</a> property.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="smoothstreamingmediaelement-liveplaybackoffsetproperty-field-microsoft-web-media-smoothstreaming_1.md">LivePlaybackOffsetProperty</a></td>
<td>Represents a dependency property that specifies the <a href="smoothstreamingmediaelement-liveplaybackoffset-property-microsoft-web-media-smoothstreaming_1.md">LivePlaybackOffset</a> property.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-liveplaybackstartpositionproperty-field-microsoft-web-media-smoothstreaming_1.md">LivePlaybackStartPositionProperty</a></td>
<td>Represents a dependency property that specifies the <a href="smoothstreamingmediaelement-liveplaybackstartposition-property-microsoft-web-media-smoothstreaming_1.md">LivePlaybackStartPosition</a> property.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-naturaldurationproperty-field-microsoft-web-media-smoothstreaming_1.md">NaturalDurationProperty</a></td>
<td>Represents a dependency property that specifies the <a href="smoothstreamingmediaelement-naturalduration-property-microsoft-web-media-smoothstreaming_1.md">NaturalDuration</a> property.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-naturalvideoheightproperty-field-microsoft-web-media-smoothstreaming_1.md">NaturalVideoHeightProperty</a></td>
<td>Represents a dependency property that specifies the <a href="smoothstreamingmediaelement-naturalvideoheight-property-microsoft-web-media-smoothstreaming_1.md">NaturalVideoHeight</a> property.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-naturalvideowidthproperty-field-microsoft-web-media-smoothstreaming_1.md">NaturalVideoWidthProperty</a></td>
<td>Represents a dependency property that specifies the <a href="smoothstreamingmediaelement-naturalvideowidth-property-microsoft-web-media-smoothstreaming_1.md">NaturalVideoWidth</a> property.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="smoothstreamingmediaelement-pipmodeproperty-field-microsoft-web-media-smoothstreaming_1.md">PipModeProperty</a></td>
<td>Represents a dependency property that specifies the <a href="smoothstreamingmediaelement-pipmode-property-microsoft-web-media-smoothstreaming_1.md">PipMode</a> property.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-playbackrateproperty-field-microsoft-web-media-smoothstreaming_1.md">PlaybackRateProperty</a></td>
<td>Represents a dependency property that represents the <a href="smoothstreamingmediaelement-playbackrate-property-microsoft-web-media-smoothstreaming_1.md">PlaybackRate</a> property.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-positionproperty-field-microsoft-web-media-smoothstreaming_1.md">PositionProperty</a></td>
<td>Represents a dependency property that specifies the <a href="smoothstreamingmediaelement-position-property-microsoft-web-media-smoothstreaming_1.md">Position</a> property.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-smoothstreamingcacheproperty-field-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingCacheProperty</a></td>
<td>Represents a dependency property that represents the <a href="smoothstreamingmediaelement-smoothstreamingcache-property-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingCache</a> property.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-smoothstreamingplaybackmodeproperty-field-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingPlaybackModeProperty</a></td>
<td>Represents a dependency property that represents the <a href="smoothstreamingmediaelement-smoothstreamingplaybackmode-property-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingPlaybackMode</a> property.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-smoothstreamingsourceproperty-field-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingSourceProperty</a></td>
<td>Represents a dependency property that specifies the <a href="smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingSource</a> property.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-sourceproperty-field-microsoft-web-media-smoothstreaming_1.md">SourceProperty</a></td>
<td>Represents a dependency property that specifies the <a href="smoothstreamingmediaelement-source-property-microsoft-web-media-smoothstreaming_1.md">Source</a> property.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-stretchproperty-field-microsoft-web-media-smoothstreaming_1.md">StretchProperty</a></td>
<td>Represents a dependency property that specifies the <a href="smoothstreamingmediaelement-stretch-property-microsoft-web-media-smoothstreaming_1.md">Stretch</a> property.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-videodownloadtrackproperty-field-microsoft-web-media-smoothstreaming_1.md">VideoDownloadTrackProperty</a></td>
<td>Represents a dependency property that represents the <a href="smoothstreamingmediaelement-videodownloadtrack-property-microsoft-web-media-smoothstreaming_1.md">VideoDownloadTrack</a> property.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-videohighestplayabletrackproperty-field-microsoft-web-media-smoothstreaming_1.md">VideoHighestPlayableTrackProperty</a></td>
<td>Represents a dependency property that represents the <a href="smoothstreamingmediaelement-videohighestplayabletrack-property-microsoft-web-media-smoothstreaming_1.md">VideoHighestPlayableTrack</a> property.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-videoplaybacktrackproperty-field-microsoft-web-media-smoothstreaming_1.md">VideoPlaybackTrackProperty</a></td>
<td>Represents a dependency property that specifies the <a href="smoothstreamingmediaelement-videoplaybacktrack-property-microsoft-web-media-smoothstreaming_1.md">VideoPlaybackTrack</a> property.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="smoothstreamingmediaelement-volumeproperty-field-microsoft-web-media-smoothstreaming_1.md">VolumeProperty</a></td>
<td>Represents a dependency property that specifies the <a href="smoothstreamingmediaelement-volume-property-microsoft-web-media-smoothstreaming_1.md">Volume</a> property.</td>
</tr>
</tbody>
</table>


Top

## Remarks

The [MediaElement](https://msdn.microsoft.com/en-us/library/ms611595\(v=vs.95\)) object is rendered as a rectangular region that can display video or play audio without video display. The SmoothStreamingMediaElement class supports the features of System.UIElement and [MediaElement](https://msdn.microsoft.com/en-us/library/ms611595\(v=vs.95\)) operations such as mouse and keyboard events and the ability to capture focus.

You can specify the height and width of the media display surface by using the height and width properties in XAML. However, for best performance, avoid explicitly setting the height and width. Instead, leave the values unset; this lets the media resource display at its encoded size, and the Silverlight application will calibrate the size of the display. If you have to change the media-display size, it is best to re-encode the media to the target size by using a media-encoding tool.

## Examples

For more information and implementation examples, see [Microsoft Smooth Streaming Client 2.0](microsoft-smooth-streaming-client-2-0.md).

## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

