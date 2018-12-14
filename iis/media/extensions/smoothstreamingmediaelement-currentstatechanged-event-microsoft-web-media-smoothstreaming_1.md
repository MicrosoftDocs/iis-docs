---
title: SmoothStreamingMediaElement.CurrentStateChanged Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CurrentStateChanged Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CurrentStateChanged
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.currentstatechanged(v=VS.95)
ms:contentKeyID: 46307491
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CurrentStateChanged
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_CurrentStateChanged
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CurrentStateChanged
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_CurrentStateChanged
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingMediaElement.CurrentStateChanged Event

Occurs when the current state of media element changes.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Event CurrentStateChanged As RoutedEventHandler
'Usage

Dim instance As SmoothStreamingMediaElement
Dim handler As RoutedEventHandler

AddHandler instance.CurrentStateChanged, handler
```

``` csharp
public event RoutedEventHandler CurrentStateChanged
```

``` c++
public:
 event RoutedEventHandler^ CurrentStateChanged {
    void add (RoutedEventHandler^ value);
    void remove (RoutedEventHandler^ value);
}
```

``` fsharp
member CurrentStateChanged : <RoutedEventHandler,
    RoutedEventArgs>
```

``` jscript
JScript supports the use of events, but not the declaration of new ones.
```

## Remarks

For more information, see [Events](events.md).

## Examples

The following examples shows a delegate that displays the new state using a text element.

``` 
    void SmoothPlayer_CurrentStateChanged(object sender, RoutedEventArgs e)
    {
        OutputText.Text = (sender as SmoothStreamingMediaElement).CurrentState.ToString();
    }
```

## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

