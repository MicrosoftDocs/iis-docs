---
title: Tracing.ReadTraceConfig Method (String) (Microsoft.Web.Media.Diagnostics)
TOCTitle: ReadTraceConfig Method (String)
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.ReadTraceConfig(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.tracing.readtraceconfig(v=VS.90)
ms:contentKeyID: 23961038
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- c++
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

# ReadTraceConfig Method (String)

Reads trace configuration settings from the XML data that is specified by xmlConfig.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicSharedSubReadTraceConfig ( _
    xmlConfigAsString _
)
'Usage
DimxmlConfigAsStringTracing.ReadTraceConfig(xmlConfig)
```

``` csharp
publicstaticvoidReadTraceConfig(
    stringxmlConfig
)
```

``` c++
public:
staticvoidReadTraceConfig(
    String^ xmlConfig
)
```

``` jscript
publicstaticfunctionReadTraceConfig(
    xmlConfig : String
)
```

#### Parameters

  - xmlConfig  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    A string value that contains an XML configuration.  

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[Tracing Class](tracing-class-microsoft-web-media-diagnostics_1.md)

[ReadTraceConfig Overload](tracing-readtraceconfig-method-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

