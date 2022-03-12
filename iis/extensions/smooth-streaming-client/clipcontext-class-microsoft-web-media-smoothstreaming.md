---
title: ClipContext Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ClipContext Class
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.ClipContext
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.clipcontext(v=VS.90)
ms:contentKeyID: 23960991
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipContext
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipContext
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ClipContext Class

Context information for a Smooth Streaming media clip. This information is Read-only and specific to clip.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  Microsoft.Web.Media.SmoothStreaming..::..ClipContext  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Class ClipContext
'Usage

  Dim instance As ClipContext
```

```csharp
  public class ClipContext
```

```cpp
  public ref class ClipContext
```

```jscript
  public class ClipContext
```

The ClipContext type exposes the following members.

## Properties

|Property Type|Name|Description|
|--- |--- |--- |
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[ClipInformation](clipcontext-clipinformation-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the [ClipInformation](clipcontext-clipinformation-property-microsoft-web-media-smoothstreaming_1.md) property.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[CurrentClipState](clipcontext-currentclipstate-property-microsoft-web-media-smoothstreaming_1.md)|Gets the [CurrentClipState](clipcontext-currentclipstate-property-microsoft-web-media-smoothstreaming_1.md) property.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[Data](clipcontext-data-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the [Data](clipcontext-data-property-microsoft-web-media-smoothstreaming_1.md) property.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[HasQuartileEvents](clipcontext-hasquartileevents-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the [HasQuartileEvents](clipcontext-hasquartileevents-property-microsoft-web-media-smoothstreaming_1.md) property. This value specifies whether the clip context has inserted quartile event markers into the clip.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[NaturalDuration](clipcontext-naturalduration-property-microsoft-web-media-smoothstreaming_1.md)|Gets the natural duration for the clip.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[PlaybackDuration](clipcontext-playbackduration-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the playback duration.|

## Methods

|Method Type|Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|

## Remarks

This class provides information about the clip to be played. You do not have to track the values of the properties of this class because they are available with each event. For more information, see [Scheduling Media Clips (IIS Smooth Streaming)](scheduling-media-clips.md).

## Examples

If the user clicks on the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) surface while an inserted clip is playing, the delegate method that handles the event can access the ClipContext()()()() from the [ClipEventArgs](clipeventargs-class-microsoft-web-media-smoothstreaming_1.md). The [ClipInformation](clipcontext-clipinformation-property-microsoft-web-media-smoothstreaming_1.md) property contains the ClickThroughUrl()()()() that was assigned when the [ClipInformation](clipinformation-class-microsoft-web-media-smoothstreaming_1.md) object was initialized.

The following delegate opens a new browser window for the ClickThroughUrl()()()().

```csharp
void SmoothPlayer_ClipClickThrough(object sender, ClipEventArgs e)
{
    System.Windows.Browser.HtmlPage.Window.Navigate(e.Context.ClipInformation.ClickThroughUrl, "_newWindow");
}
```

## Version Information

### Silverlight

Supported in: 4  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
