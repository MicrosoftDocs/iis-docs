---
title: TraceEntry.TraceLevel Property (Microsoft.Web.Media.Diagnostics)
TOCTitle: TraceLevel Property
ms:assetid: P:Microsoft.Web.Media.Diagnostics.TraceEntry.TraceLevel
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.traceentry.tracelevel(v=VS.90)
ms:contentKeyID: 23960969
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.Diagnostics.TraceEntry.TraceLevel
- Microsoft.Web.Media.Diagnostics.TraceEntry.get_TraceLevel
- Microsoft.Web.Media.Diagnostics.TraceEntry.set_TraceLevel
dev_langs:
- "csharp"
- "jscript"
- "vb"
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.TraceEntry.get_TraceLevel
- Microsoft.Web.Media.Diagnostics.TraceEntry.set_TraceLevel
- Microsoft.Web.Media.Diagnostics.TraceEntry.TraceLevel
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# TraceLevel Property

Gets or sets the TraceLevel property.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property TraceLevel As TraceLevel
'Usage

  Dim instance As TraceEntry
Dim value As TraceLevel

value = instance.TraceLevel

instance.TraceLevel = value
```

```csharp
  public TraceLevel TraceLevel { get; set; }
```

```cpp
  public:
property TraceLevel TraceLevel {
    TraceLevel get ();
    void set (TraceLevel value);
}
```

```jscript
  function get TraceLevel () : TraceLevel
function set TraceLevel (value : TraceLevel)
```

### Property Value

Type: [Microsoft.Web.Media.Diagnostics.TraceLevel](tracelevel-enumeration-microsoft-web-media-diagnostics_1.md)  
A [TraceLevel](tracelevel-enumeration-microsoft-web-media-diagnostics_1.md) enumeration object.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[TraceEntry Class](traceentry-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

