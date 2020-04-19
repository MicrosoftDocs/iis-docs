---
title: Tracing.ReadTraceConfig Method (XmlReader) (Microsoft.Web.Media.Diagnostics)
TOCTitle: ReadTraceConfig Method (XmlReader)
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.ReadTraceConfig(System.Xml.XmlReader)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.diagnostics.tracing.readtraceconfig(v=VS.95)
ms:contentKeyID: 46307632
ms.date: 05/31/2012
mtps_version: v=VS.95
dev_langs:
- vb
- csharp
- "cpp"
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.Tracing.ReadTraceConfig
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Tracing.ReadTraceConfig Method (XmlReader)

Reads trace configuration settings from XML data returned by the xmlReader that is specified by the parameter.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Shared Sub ReadTraceConfig ( _
    xmlReader As XmlReader _
)
'Usage

Dim xmlReader As XmlReader

Tracing.ReadTraceConfig(xmlReader)
```

```csharp
public static void ReadTraceConfig(
    XmlReader xmlReader
)
```

```cpp
public:
static void ReadTraceConfig(
    XmlReader^ xmlReader
)
```

``` fsharp
static member ReadTraceConfig : 
        xmlReader:XmlReader -> unit 
```

```jscript
public static function ReadTraceConfig(
    xmlReader : XmlReader
)
```

### Parameters

  - xmlReader  
    Type: [System.Xml.XmlReader](https://msdn.microsoft.com/library/b8a5e1s5\(v=vs.95\))  
    A [XmlReader](https://msdn.microsoft.com/library/b8a5e1s5\(v=vs.95\)) object.

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
