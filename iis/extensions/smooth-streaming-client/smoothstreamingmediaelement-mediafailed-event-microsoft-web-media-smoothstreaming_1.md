---
title: SmoothStreamingMediaElement.MediaFailed Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: MediaFailed Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.MediaFailed
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.mediafailed(v=VS.95)
ms:contentKeyID: 46307502
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.MediaFailed
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_MediaFailed
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.MediaFailed
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_MediaFailed
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# SmoothStreamingMediaElement.MediaFailed Event

Occurs when there is an error associated with the media source.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Event MediaFailed As EventHandler(Of ExceptionRoutedEventArgs)
'Usage

Dim instance As SmoothStreamingMediaElement
Dim handler As EventHandler(Of ExceptionRoutedEventArgs)

AddHandler instance.MediaFailed, handler
```

```csharp
public event EventHandler<ExceptionRoutedEventArgs> MediaFailed
```

```cpp
public:
 event EventHandler<ExceptionRoutedEventArgs^>^ MediaFailed {
    void add (EventHandler<ExceptionRoutedEventArgs^>^ value);
    void remove (EventHandler<ExceptionRoutedEventArgs^>^ value);
}
```

``` fsharp
member MediaFailed : <EventHandler<ExceptionRoutedEventArgs>,
    ExceptionRoutedEventArgs>
```

```jscript
JScript supports the use of events, but not the declaration of new ones.
```

## Remarks

For more information, see [Events](events.md).

## Examples

The following example shows a delegate that handles the media failed event.

``` 
    void SmoothPlayer_MediaFailed(object sender, ExceptionRoutedEventArgs e)
    {
        MessageBox.Show(e.ErrorException.Message + " Inner Exception: "
            + e.ErrorException.InnerException);
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

