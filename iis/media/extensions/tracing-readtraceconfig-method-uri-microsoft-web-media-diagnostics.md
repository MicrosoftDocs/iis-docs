---
title: Tracing.ReadTraceConfig Method (Uri) (Microsoft.Web.Media.Diagnostics)
TOCTitle: ReadTraceConfig Method (Uri)
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.ReadTraceConfig(System.Uri)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.tracing.readtraceconfig(v=VS.90)
ms:contentKeyID: 23961107
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

# ReadTraceConfig Method (Uri)

Reads trace configuration settings from XML data returned by the uri that is specified by the parameter.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicSharedSubReadTraceConfig ( _
    uriAsUri _
)
'Usage
DimuriAsUriTracing.ReadTraceConfig(uri)
```

``` csharp
publicstaticvoidReadTraceConfig(
    Uriuri
)
```

``` c++
public:
staticvoidReadTraceConfig(
    Uri^ uri
)
```

``` jscript
publicstaticfunctionReadTraceConfig(
    uri : Uri
)
```

#### Parameters

  - uri  
    Type: [System. . :: . .Uri](https://msdn.microsoft.com/en-us/library/txt7706a\(v=vs.90\))  
    A [Uri](https://msdn.microsoft.com/en-us/library/txt7706a\(v=vs.90\)) object that returns XML trace configuration data.  

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

