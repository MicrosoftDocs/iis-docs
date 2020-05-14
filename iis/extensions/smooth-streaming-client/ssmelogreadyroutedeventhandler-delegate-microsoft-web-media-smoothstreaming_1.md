---
title: SSMELogReadyRoutedEventHandler Delegate (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SSMELogReadyRoutedEventHandler Delegate
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventHandler
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.ssmelogreadyroutedeventhandler(v=VS.95)
ms:contentKeyID: 46307950
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventHandler
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventHandler
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventHandler.EndInvoke
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventHandler..ctor
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventHandler.Invoke
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventHandler.BeginInvoke
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SSMELogReadyRoutedEventHandler Delegate

The event handler for the [LogReady](smoothstreamingmediaelement-logready-event-microsoft-web-media-smoothstreaming_1.md) event.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Delegate Sub SSMELogReadyRoutedEventHandler ( _
    sender As Object, _
    e As SSMELogReadyRoutedEventArgs _
)
'Usage

Dim instance As New SSMELogReadyRoutedEventHandler(AddressOf HandlerMethod)
```

```csharp
public delegate void SSMELogReadyRoutedEventHandler(
    Object sender,
    SSMELogReadyRoutedEventArgs e
)
```

```cpp
public delegate void SSMELogReadyRoutedEventHandler(
    Object^ sender,
    SSMELogReadyRoutedEventArgs^ e
)
```

``` fsharp
type SSMELogReadyRoutedEventHandler =
    delegate of
        sender:Object *
        e:SSMELogReadyRoutedEventArgs -> unit
```

```jscript
JScript supports the use of delegates, but not the declaration of new ones.
```

### Parameters

  - sender  
    Type: [System.Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\))  
    The [Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\)) sender.

<!-- end list -->

  - e  
    Type: [Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs](ssmelogreadyroutedeventargs-class-microsoft-web-media-smoothstreaming_1.md)  
    A SSMELogReadyRoutedEventArgs object.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
