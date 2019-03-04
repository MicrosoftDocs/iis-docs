---
title: Tracing.ReadTraceConfig Method (Uri) (Microsoft.Web.Media.Diagnostics)
TOCTitle: ReadTraceConfig Method (Uri)
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.ReadTraceConfig(System.Uri)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.tracing.readtraceconfig(v=VS.95)
ms:contentKeyID: 46307624
ms.date: 05/31/2012
mtps_version: v=VS.95
dev_langs:
- vb
- csharp
- cpp
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

# Tracing.ReadTraceConfig Method (Uri)

Reads trace configuration settings from XML data returned by the uri that is specified by the parameter.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Shared Sub ReadTraceConfig ( _
    uri As Uri _
)
'Usage

Dim uri As Uri

Tracing.ReadTraceConfig(uri)
```

```csharp
public static void ReadTraceConfig(
    Uri uri
)
```

```cpp
public:
static void ReadTraceConfig(
    Uri^ uri
)
```

``` fsharp
static member ReadTraceConfig : 
        uri:Uri -> unit 
```

```jscript
public static function ReadTraceConfig(
    uri : Uri
)
```

### Parameters

  - uri  
    Type: [System.Uri](https://msdn.microsoft.com/library/txt7706a\(v=vs.95\))  
    A [Uri](https://msdn.microsoft.com/library/txt7706a\(v=vs.95\)) object that returns XML trace configuration data.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[Tracing Class](tracing-class-microsoft-web-media-diagnostics_1.md)

[ReadTraceConfig Overload](tracing-readtraceconfig-method-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

