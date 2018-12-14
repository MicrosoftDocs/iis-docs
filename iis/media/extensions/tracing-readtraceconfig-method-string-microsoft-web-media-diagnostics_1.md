---
title: Tracing.ReadTraceConfig Method (String) (Microsoft.Web.Media.Diagnostics)
TOCTitle: ReadTraceConfig Method (String)
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.ReadTraceConfig(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.tracing.readtraceconfig(v=VS.95)
ms:contentKeyID: 46307631
ms.date: 05/31/2012
mtps_version: v=VS.95
dev_langs:
- vb
- csharp
- c++
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.Tracing.ReadTraceConfig
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Tracing.ReadTraceConfig Method (String)

Reads trace configuration settings from the XML data that is specified by xmlConfig.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Shared Sub ReadTraceConfig ( _
    xmlConfig As String _
)
'Usage

Dim xmlConfig As String

Tracing.ReadTraceConfig(xmlConfig)
```

``` csharp
public static void ReadTraceConfig(
    string xmlConfig
)
```

``` c++
public:
static void ReadTraceConfig(
    String^ xmlConfig
)
```

``` fsharp
static member ReadTraceConfig : 
        xmlConfig:string -> unit 
```

``` jscript
public static function ReadTraceConfig(
    xmlConfig : String
)
```

#### Parameters

  - xmlConfig  
    Type: [System.String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.95\))  
    A string value that contains an XML configuration.

## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[Tracing Class](tracing-class-microsoft-web-media-diagnostics_1.md)

[ReadTraceConfig Overload](tracing-readtraceconfig-method-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

