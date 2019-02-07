---
title: Tracing.RemoteServerUri Property  (Microsoft.Web.Media.Diagnostics)
TOCTitle: RemoteServerUri Property
ms:assetid: P:Microsoft.Web.Media.Diagnostics.Tracing.RemoteServerUri
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.tracing.remoteserveruri(v=VS.95)
ms:contentKeyID: 46307739
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.Diagnostics.Tracing.get_RemoteServerUri
- Microsoft.Web.Media.Diagnostics.Tracing.RemoteServerUri
- Microsoft.Web.Media.Diagnostics.Tracing.set_RemoteServerUri
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.Tracing.get_RemoteServerUri
- Microsoft.Web.Media.Diagnostics.Tracing.set_RemoteServerUri
- Microsoft.Web.Media.Diagnostics.Tracing.RemoteServerUri
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Tracing.RemoteServerUri Property

Gets or sets the [Uri](https://msdn.microsoft.com/en-us/library/txt7706a\(v=vs.95\)) of the remote server.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Shared Property RemoteServerUri As Uri
    Get
    Private Set
'Usage

Dim value As Uri

value = Tracing.RemoteServerUri
```

``` csharp
public static Uri RemoteServerUri { get; private set; }
```

``` c++
public:
static property Uri^ RemoteServerUri {
    Uri^ get ();
    private: void set (Uri^ value);
}
```

``` fsharp
static member RemoteServerUri : Uri with get, private set
```

``` jscript
static function get RemoteServerUri () : Uri
private static function set RemoteServerUri (value : Uri)
```

#### Property Value

Type: [System.Uri](https://msdn.microsoft.com/en-us/library/txt7706a\(v=vs.95\))  
A [Uri](https://msdn.microsoft.com/en-us/library/txt7706a\(v=vs.95\)) object.

## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[Tracing Class](tracing-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

