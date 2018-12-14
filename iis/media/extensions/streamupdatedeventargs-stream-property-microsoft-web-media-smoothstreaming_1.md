---
title: StreamUpdatedEventArgs.Stream Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Stream Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.Stream
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.streamupdatedeventargs.stream(v=VS.95)
ms:contentKeyID: 46307872
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.get_Stream
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.set_Stream
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.Stream
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.get_Stream
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.set_Stream
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.Stream
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# StreamUpdatedEventArgs.Stream Property

The stream that has been updated.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Property Stream As StreamInfo
    Get
    Private Set
'Usage

Dim instance As StreamUpdatedEventArgs
Dim value As StreamInfo

value = instance.Stream
```

``` csharp
public StreamInfo Stream { get; private set; }
```

``` c++
public:
property StreamInfo^ Stream {
    StreamInfo^ get ();
    private: void set (StreamInfo^ value);
}
```

``` fsharp
member Stream : StreamInfo with get, private set
```

``` jscript
function get Stream () : StreamInfo
private function set Stream (value : StreamInfo)
```

#### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)  
A [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) object.

## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[StreamUpdatedEventArgs Class](streamupdatedeventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

