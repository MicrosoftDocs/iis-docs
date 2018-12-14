---
title: SmoothStreamingMediaElement.MediaFailed Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: MediaFailed Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.MediaFailed
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.mediafailed(v=VS.90)
ms:contentKeyID: 23961163
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.MediaFailed
dev_langs:
- CSharp
- JScript
- VB
- c++
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
ROBOTS: INDEX,FOLLOW
---

# MediaFailed Event

Occurs when there is an error associated with the media source.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
Public Event MediaFailedAsEventHandler(OfExceptionRoutedEventArgs)
'Usage
DiminstanceAsSmoothStreamingMediaElementDimhandlerAsEventHandler(OfExceptionRoutedEventArgs)

AddHandler instance.MediaFailed, handler
```

``` csharp
public event EventHandler<ExceptionRoutedEventArgs> MediaFailed
```

``` c++
public:
 eventEventHandler<ExceptionRoutedEventArgs^>^ MediaFailed {
    voidadd (EventHandler<ExceptionRoutedEventArgs^>^ value);
    voidremove (EventHandler<ExceptionRoutedEventArgs^>^ value);
}
```

``` jscript
JScript does not support events.
```

## Remarks

For more information, see [Events (IIS Smooth Streaming)](events.md).

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

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

