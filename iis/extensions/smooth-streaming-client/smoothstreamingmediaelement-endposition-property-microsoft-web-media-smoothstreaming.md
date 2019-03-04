---
title: SmoothStreamingMediaElement.EndPosition Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: EndPosition Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.EndPosition
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.endposition(v=VS.90)
ms:contentKeyID: 23961120
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.EndPosition
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_EndPosition
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_EndPosition
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.EndPosition
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_EndPosition
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_EndPosition
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# EndPosition Property

Gets or sets the end position.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property EndPosition As TimeSpan
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

```jscript
  function get EndPosition () : TimeSpan
function set EndPosition (value : TimeSpan)
```

### Property Value

Type: [System.TimeSpan](https://msdn.microsoft.com/library/269ew577)  
The end position.  

## Remarks

For more information, see [Events (IIS Smooth Streaming)](events.md).

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

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

