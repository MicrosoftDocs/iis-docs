---
title: SmoothStreamingMediaElement.Position Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Position Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Position
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.position(v=VS.95)
ms:contentKeyID: 46307842
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Position
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_Position
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_Position
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_Position
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Position
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_Position
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElement.Position Property

Gets or sets the position in the current stream.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property Position As TimeSpan
    Get
    Set
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

``` fsharp
member Position : TimeSpan with get, set
```

```jscript
function get Position () : TimeSpan
function set Position (value : TimeSpan)
```

### Property Value

Type: [System.TimeSpan](https://msdn.microsoft.com/library/269ew577\(v=vs.95\))  
The position in the current stream.

## Remarks

For more information and for examples, see [Position in Stream](position-in-stream.md) and [Events](events.md).

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

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

