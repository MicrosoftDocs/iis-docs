---
title: SmoothStreamingMediaElement.SmoothStreamingErrorOccurred Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SmoothStreamingErrorOccurred Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SmoothStreamingErrorOccurred
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.smoothstreamingerroroccurred(v=VS.90)
ms:contentKeyID: 23961268
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SmoothStreamingErrorOccurred
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_SmoothStreamingErrorOccurred
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_SmoothStreamingErrorOccurred
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SmoothStreamingErrorOccurred
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingErrorOccurred Event

Occurs when an error is raised during playback of Smooth Streaming content.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

  Public Event SmoothStreamingErrorOccurred As EventHandler(Of SmoothStreamingErrorEventArgs)
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim handler As EventHandler(Of SmoothStreamingErrorEventArgs)

AddHandler instance.SmoothStreamingErrorOccurred, handler
```

``` csharp
  public event EventHandler<SmoothStreamingErrorEventArgs> SmoothStreamingErrorOccurred
```

``` c++
  public:
 event EventHandler<SmoothStreamingErrorEventArgs^>^ SmoothStreamingErrorOccurred {
    void add (EventHandler<SmoothStreamingErrorEventArgs^>^ value);
    void remove (EventHandler<SmoothStreamingErrorEventArgs^>^ value);
}
```

``` jscript
  JScript does not support events.
```

## Remarks

For more information, see [Events (IIS Smooth Streaming)](events.md).

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

