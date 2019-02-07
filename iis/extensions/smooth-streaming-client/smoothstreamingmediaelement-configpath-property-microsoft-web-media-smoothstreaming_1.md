---
title: SmoothStreamingMediaElement.ConfigPath Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ConfigPath Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ConfigPath
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.configpath(v=VS.95)
ms:contentKeyID: 46307812
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ConfigPath
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_ConfigPath
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_ConfigPath
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ConfigPath
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_ConfigPath
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_ConfigPath
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingMediaElement.ConfigPath Property

Gets or sets the path of the configuration file.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Property ConfigPath As String
    Get
    Set
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As String

value = instance.ConfigPath

instance.ConfigPath = value
```

``` csharp
public string ConfigPath { get; set; }
```

``` c++
public:
property String^ ConfigPath {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
member ConfigPath : string with get, set
```

``` jscript
function get ConfigPath () : String
function set ConfigPath (value : String)
```

#### Property Value

Type: [System.String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.95\))  
The path of the configuration file.

## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

