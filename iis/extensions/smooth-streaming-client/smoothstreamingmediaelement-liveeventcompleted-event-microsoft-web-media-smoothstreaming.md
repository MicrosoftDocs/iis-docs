---
title: SmoothStreamingMediaElement.LiveEventCompleted Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: LiveEventCompleted Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LiveEventCompleted
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.liveeventcompleted(v=VS.90)
ms:contentKeyID: 23961015
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LiveEventCompleted
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_LiveEventCompleted
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LiveEventCompleted
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_LiveEventCompleted
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# LiveEventCompleted Event

Occurs when a live media stream ends.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

  Public Event LiveEventCompleted As EventHandler
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim handler As EventHandler

AddHandler instance.LiveEventCompleted, handler
```

``` csharp
  public event EventHandler LiveEventCompleted
```

``` c++
  public:
 event EventHandler^ LiveEventCompleted {
    void add (EventHandler^ value);
    void remove (EventHandler^ value);
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

