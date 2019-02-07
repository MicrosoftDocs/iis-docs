---
title: SmoothStreamingMediaElement.ConfigPath Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ConfigPath Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ConfigPath
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.configpath(v=VS.90)
ms:contentKeyID: 23961055
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ConfigPath
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_ConfigPath
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_ConfigPath
dev_langs:
- CSharp
- JScript
- VB
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

# ConfigPath Property

Gets or sets the path of the configuration file.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

  Public Property ConfigPath As String
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

``` jscript
  function get ConfigPath () : String
function set ConfigPath (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The path of the configuration file.  

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

