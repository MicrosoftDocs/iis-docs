---
title: StreamInfo.Subtype Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Subtype Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.StreamInfo.Subtype
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.streaminfo.subtype(v=VS.90)
ms:contentKeyID: 23961212
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.Subtype
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_Subtype
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.set_Subtype
dev_langs:
- "csharp"
- "jscript"
- "vb"
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_Subtype
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.set_Subtype
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.Subtype
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# Subtype Property

Gets or sets the Subtype property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property Subtype As String
'Usage

  Dim instance As StreamInfo
Dim value As String

value = instance.Subtype
```

```csharp
  public string Subtype { get; internal set; }
```

```cpp
  public:
property String^ Subtype {
    String^ get ();
    internal: void set (String^ value);
}
```

```jscript
  function get Subtype () : String
internal function set Subtype (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
A string value that specifies the subtype.  

## Remarks

For more information and an example that parses [StreamInfo](streaminfo-class-microsoft-web-media-smoothstreaming_1.md) objects, see [Timeline Markers and Events (IIS Smooth Streaming)](timeline-markers-and-events.md) under the heading "Extract Timeline Events and Assign Markers."

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[StreamInfo Class](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

