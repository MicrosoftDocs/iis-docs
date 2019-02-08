---
title: SmoothStreamingMediaElement.SetPlaybackRangeCompletedEventHandler Delegate (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SmoothStreamingMediaElement.SetPlaybackRangeCompletedEventHandler Delegate
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SetPlaybackRangeCompletedEventHandler
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.setplaybackrangecompletedeventhandler(v=VS.95)
ms:contentKeyID: 46307961
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SetPlaybackRangeCompletedEventHandler
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SetPlaybackRangeCompletedEventHandler
- Microsoft.Web.Media.SmoothStreaming.SetPlaybackRangeCompletedEventHandler..ctor
- Microsoft.Web.Media.SmoothStreaming.SetPlaybackRangeCompletedEventHandler.BeginInvoke
- Microsoft.Web.Media.SmoothStreaming.SetPlaybackRangeCompletedEventHandler.Invoke
- Microsoft.Web.Media.SmoothStreaming.SetPlaybackRangeCompletedEventHandler.EndInvoke
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingMediaElement.SetPlaybackRangeCompletedEventHandler Delegate

Represents the event handler signature for a SetPlaybackRangeAsync operation.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Delegate Sub SetPlaybackRangeCompletedEventHandler ( _
    sender As Object, _
    args As AsyncCompletedEventArgs _
)
'Usage

Dim instance As New SetPlaybackRangeCompletedEventHandler(AddressOf HandlerMethod)
```

``` csharp
public delegate void SetPlaybackRangeCompletedEventHandler(
    Object sender,
    AsyncCompletedEventArgs args
)
```

``` c++
public delegate void SetPlaybackRangeCompletedEventHandler(
    Object^ sender, 
    AsyncCompletedEventArgs^ args
)
```

``` fsharp
type SetPlaybackRangeCompletedEventHandler = 
    delegate of 
        sender:Object * 
        args:AsyncCompletedEventArgs -> unit
```

``` jscript
JScript supports the use of delegates, but not the declaration of new ones.
```

#### Parameters

  - sender  
    Type: [System.Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.95\))  

<!-- end list -->

  - args  
    Type: [System.ComponentModel.AsyncCompletedEventArgs](https://msdn.microsoft.com/en-us/library/2tde67e9\(v=vs.95\))  

## Version Information

#### Silverlight

Supported in: 5  

## See Also

#### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

