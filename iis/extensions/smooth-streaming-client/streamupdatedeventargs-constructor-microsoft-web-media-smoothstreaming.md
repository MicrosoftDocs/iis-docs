---
title: StreamUpdatedEventArgs Constructor  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: StreamUpdatedEventArgs Constructor
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.#ctor(Microsoft.Web.Media.SmoothStreaming.StreamInfo,Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.StreamUpdatedAction,System.Nullable{System.TimeSpan})
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.streamupdatedeventargs.streamupdatedeventargs(v=VS.90)
ms:contentKeyID: 31469317
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.#ctor
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.StreamUpdatedEventArgs
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# StreamUpdatedEventArgs Constructor

Initializes a new instance of the [StreamUpdatedEventArgs](streamupdatedeventargs-class-microsoft-web-media-smoothstreaming_1.md) class.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

  Public Sub New ( _
    stream As StreamInfo, _
    action As StreamUpdatedEventArgs..::..StreamUpdatedAction, _
    timestamp As Nullable(Of TimeSpan) _
)
'Usage

  Dim stream As StreamInfo
Dim action As StreamUpdatedEventArgs..::..StreamUpdatedAction
Dim timestamp As Nullable(Of TimeSpan)

Dim instance As New StreamUpdatedEventArgs(stream, _
    action, timestamp)
```

``` csharp
  public StreamUpdatedEventArgs(
    StreamInfo stream,
    StreamUpdatedEventArgs..::..StreamUpdatedAction action,
    Nullable<TimeSpan> timestamp
)
```

``` c++
  public:
StreamUpdatedEventArgs(
    StreamInfo^ stream, 
    StreamUpdatedEventArgs..::..StreamUpdatedAction action, 
    Nullable<TimeSpan> timestamp
)
```

``` jscript
  public function StreamUpdatedEventArgs(
    stream : StreamInfo, 
    action : StreamUpdatedEventArgs..::..StreamUpdatedAction, 
    timestamp : Nullable<TimeSpan>
)
```

#### Parameters

  - stream  
    Type: [Microsoft.Web.Media.SmoothStreaming. . :: . .StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)  
    A [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) object.  

<!-- end list -->

  - action  
    Type: [Microsoft.Web.Media.SmoothStreaming. . :: . .StreamUpdatedEventArgs. . :: . .StreamUpdatedAction](streamupdatedeventargs-streamupdatedaction-enumeration-microsoft-web-media-smoothstreaming_1.md)  
    A [StreamUpdatedEventArgs..::..StreamUpdatedAction](streamupdatedeventargs-streamupdatedaction-enumeration-microsoft-web-media-smoothstreaming_1.md) object.  

<!-- end list -->

  - timestamp  
    Type: [System. . :: . .Nullable](https://msdn.microsoft.com/en-us/library/b3h38hb0\(v=vs.90\))\< (Of \< ( \<'[TimeSpan](https://msdn.microsoft.com/en-us/library/269ew577\(v=vs.90\))\> ) \> ) \>  
    A [TimeSpan](https://msdn.microsoft.com/en-us/library/269ew577\(v=vs.90\)) object.  

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[StreamUpdatedEventArgs Class](streamupdatedeventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

