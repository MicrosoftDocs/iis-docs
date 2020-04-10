---
title: SmoothStreamingMediaElement.CurrentStateChanged Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CurrentStateChanged Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CurrentStateChanged
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.currentstatechanged(v=VS.90)
ms:contentKeyID: 23960961
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CurrentStateChanged
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_CurrentStateChanged
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CurrentStateChanged
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_CurrentStateChanged
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# CurrentStateChanged Event

Occurs when the current state of media element changes.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Event CurrentStateChanged As RoutedEventHandler
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim handler As RoutedEventHandler

AddHandler instance.CurrentStateChanged, handler
```

```csharp
  public event RoutedEventHandler CurrentStateChanged
```

```cpp
  public:
 event RoutedEventHandler^ CurrentStateChanged {
    void add (RoutedEventHandler^ value);
    void remove (RoutedEventHandler^ value);
}
```

```jscript
  JScript does not support events.
```

## Remarks

For more information, see [Events (IIS Smooth Streaming)](events.md).

## Examples

The following examples shows a delegate that displays the new state using a text element.

``` 
    void SmoothPlayer_CurrentStateChanged(object sender, RoutedEventArgs e)
    {
        OutputText.Text = (sender as SmoothStreamingMediaElement).CurrentState.ToString();
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
