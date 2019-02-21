---
title: SmoothStreamingMediaElement.Position Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Position Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Position
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.position(v=VS.90)
ms:contentKeyID: 23961236
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Position
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_Position
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_Position
dev_langs:
- "csharp"
- "jscript"
- "vb"
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_Position
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Position
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_Position
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# Position Property

Gets or sets the position in the current stream.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property Position As TimeSpan
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim value As TimeSpan

value = instance.Position

instance.Position = value
```

```csharp
  public TimeSpan Position { get; set; }
```

```cpp
  public:
property TimeSpan Position {
    TimeSpan get ();
    void set (TimeSpan value);
}
```

```jscript
  function get Position () : TimeSpan
function set Position (value : TimeSpan)
```

### Property Value

Type: [System.TimeSpan](https://msdn.microsoft.com/library/269ew577)  
The position in the current stream.  

## Remarks

For more information and for examples, see [Position in Stream (IIS Smooth Streaming)](position-in-stream.md) and [Events (IIS Smooth Streaming)](events.md).

## Examples

The following example shows a delegate that assigns the Position property. Each time the user clicks the SeekButton element, the event handler adds a five-second interval to the position property until the current position plus five seconds is greater than the length of the media stream as specified by the [EndPosition](smoothstreamingmediaelement-endposition-property-microsoft-web-media-smoothstreaming_1.md) property.

``` 
        // Button seek interval.
        TimeSpan spanAdd = new TimeSpan(0, 0, 5);
        private void SeekButton_Click(object sender, RoutedEventArgs e)
        {
            if ((SmoothPlayer.Position + spanAdd) < SmoothPlayer.EndPosition)
            {
                SmoothPlayer.Position += spanAdd;
            }
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

