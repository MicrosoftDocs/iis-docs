---
title: SSMELogReadyRoutedEventHandler Delegate (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SSMELogReadyRoutedEventHandler Delegate
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventHandler
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.ssmelogreadyroutedeventhandler(v=VS.90)
ms:contentKeyID: 31469167
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventHandler
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventHandler
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventHandler.EndInvoke
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventHandler..ctor
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventHandler.Invoke
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventHandler.BeginInvoke
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SSMELogReadyRoutedEventHandler Delegate

The event handler for the [LogReady](smoothstreamingmediaelement-logready-event-microsoft-web-media-smoothstreaming_1.md) event.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicDelegateSubSSMELogReadyRoutedEventHandler ( _
    senderAsObject, _
    eAsSSMELogReadyRoutedEventArgs _
)
'Usage
DiminstanceAsNewSSMELogReadyRoutedEventHandler(AddressOf HandlerMethod)
```

``` csharp
publicdelegatevoidSSMELogReadyRoutedEventHandler(
    Objectsender,
    SSMELogReadyRoutedEventArgse
)
```

``` c++
publicdelegatevoidSSMELogReadyRoutedEventHandler(
    Object^ sender, 
    SSMELogReadyRoutedEventArgs^ e
)
```

``` jscript
JScript does not support delegates.
```

#### Parameters

  - sender  
    Type: [System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
    The [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\)) sender.  

<!-- end list -->

  - e  
    Type: [Microsoft.Web.Media.SmoothStreaming. . :: . .SSMELogReadyRoutedEventArgs](ssmelogreadyroutedeventargs-class-microsoft-web-media-smoothstreaming_1.md)  
    A SSMELogReadyRoutedEventArgs object.  

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## See Also

#### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

