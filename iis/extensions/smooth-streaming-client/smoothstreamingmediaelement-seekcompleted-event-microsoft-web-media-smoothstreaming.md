---
title: SmoothStreamingMediaElement.SeekCompleted Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SeekCompleted Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SeekCompleted
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.seekcompleted(v=VS.90)
ms:contentKeyID: 23960954
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SeekCompleted
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_SeekCompleted
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_SeekCompleted
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SeekCompleted
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SeekCompleted Event

Occurs when a seek operation completes.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Event SeekCompleted As EventHandler(Of SeekCompletedEventArgs)
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim handler As EventHandler(Of SeekCompletedEventArgs)

AddHandler instance.SeekCompleted, handler
```

```csharp
  public event EventHandler<SeekCompletedEventArgs> SeekCompleted
```

```cpp
  public:
 event EventHandler<SeekCompletedEventArgs^>^ SeekCompleted {
    void add (EventHandler<SeekCompletedEventArgs^>^ value);
    void remove (EventHandler<SeekCompletedEventArgs^>^ value);
}
```

```jscript
  JScript does not support events.
```

## Remarks

For more information, see [Events (IIS Smooth Streaming)](events.md).

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

