---
title: TraceEntry.MethodName Property (Microsoft.Web.Media.Diagnostics)
TOCTitle: MethodName Property
ms:assetid: P:Microsoft.Web.Media.Diagnostics.TraceEntry.MethodName
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.traceentry.methodname(v=VS.90)
ms:contentKeyID: 23960955
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.Diagnostics.TraceEntry.MethodName
- Microsoft.Web.Media.Diagnostics.TraceEntry.get_MethodName
- Microsoft.Web.Media.Diagnostics.TraceEntry.set_MethodName
dev_langs:
- csharp
- jscript
- vb
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.TraceEntry.get_MethodName
- Microsoft.Web.Media.Diagnostics.TraceEntry.MethodName
- Microsoft.Web.Media.Diagnostics.TraceEntry.set_MethodName
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# MethodName Property

Gets or sets the MethodName property.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property MethodName As String
'Usage

  Dim instance As TraceEntry
Dim value As String

value = instance.MethodName

instance.MethodName = value
```

```csharp
  public string MethodName { get; set; }
```

```cpp
  public:
property String^ MethodName {
    String^ get ();
    void set (String^ value);
}
```

```jscript
  function get MethodName () : String
function set MethodName (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
A string value that specifies the method name of the method that invoked the trace.  

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

