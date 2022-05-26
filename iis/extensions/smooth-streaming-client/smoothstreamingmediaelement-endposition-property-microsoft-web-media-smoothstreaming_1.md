---
title: SmoothStreamingMediaElement.EndPosition Property (Microsoft.Web.Media.SmoothStreaming)
description: This article has syntax, property value, and version information for the SmoothStreamingMediaElement.EndPosition property.
TOCTitle: EndPosition Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.EndPosition
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.endposition(v=VS.95)
ms:contentKeyID: 46307823
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.EndPosition
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_EndPosition
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_EndPosition
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.EndPosition
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_EndPosition
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_EndPosition
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElement.EndPosition Property

Gets or sets the end position.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property EndPosition As TimeSpan
    Get
    Set
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As TimeSpan

value = instance.EndPosition

instance.EndPosition = value
```

```csharp
public TimeSpan EndPosition { get; set; }
```

```cpp
public:
property TimeSpan EndPosition {
    TimeSpan get ();
    void set (TimeSpan value);
}
```

``` fsharp
member EndPosition : TimeSpan with get, set
```

```jscript
function get EndPosition () : TimeSpan
function set EndPosition (value : TimeSpan)
```

### Property Value

Type: [System.TimeSpan](https://msdn.microsoft.com/library/269ew577\(v=vs.95\))  
The end position.

## Remarks

For more information, see [Events](events.md).

## Examples

The following example shows a delegate that calculates a new position value from the slider input and the EndPosition property. It reassigns the [Position](smoothstreamingmediaelement-position-property-microsoft-web-media-smoothstreaming_1.md) property so that the media stream will resume playing at a new position.

``` 
    private void SeekBar_ValueChanged(object sender,
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

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
