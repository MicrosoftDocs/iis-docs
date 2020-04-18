---
title: Tracing.ReadTraceConfig Method (XmlReader) (Microsoft.Web.Media.Diagnostics)
TOCTitle: ReadTraceConfig Method (XmlReader)
ms:assetid: M:Microsoft.Web.Media.Diagnostics.Tracing.ReadTraceConfig(System.Xml.XmlReader)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.diagnostics.tracing.readtraceconfig(v=VS.90)
ms:contentKeyID: 23961165
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- "cpp"
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

# ReadTraceConfig Method (XmlReader)

Reads trace configuration settings from XML data returned by the xmlReader that is specified by the parameter.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

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

```jscript
  public static function ReadTraceConfig(
    xmlReader : XmlReader
)
```

### Parameters

  - xmlReader  
    Type: [System.Xml.XmlReader](https://msdn.microsoft.com/library/b8a5e1s5)  
    A [XmlReader](https://msdn.microsoft.com/library/b8a5e1s5) object.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[Tracing Class](tracing-class-microsoft-web-media-diagnostics_1.md)

[ReadTraceConfig Overload](tracing-readtraceconfig-method-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)
