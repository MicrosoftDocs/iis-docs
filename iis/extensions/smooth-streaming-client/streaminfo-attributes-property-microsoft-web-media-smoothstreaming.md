---
title: StreamInfo.Attributes Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Attributes Property
description: "The Attributes property gets or sets attributes for this stream. This article describes its syntax, examples, and version information."
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.StreamInfo.Attributes
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.streaminfo.attributes(v=VS.90)
ms:contentKeyID: 31469151
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.Attributes
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_Attributes
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.set_Attributes
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.Attributes
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_Attributes
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.set_Attributes
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Attributes Property

Gets or sets attributes for this stream.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property Attributes As IDictionary(Of String, String)
'Usage

  Dim instance As StreamInfo
Dim value As IDictionary(Of String, String)

value = instance.Attributes
```

```csharp
  public IDictionary<string, string> Attributes { get; internal set; }
```

```cpp
  public:
property IDictionary<String^, String^>^ Attributes {
    IDictionary<String^, String^>^ get ();
    internal: void set (IDictionary<String^, String^>^ value);
}
```

```jscript
  function get Attributes () : IDictionary<String, String>
internal function set Attributes (value : IDictionary<String, String>)
```

### Property Value

Type: [System.Collections.Generic.IDictionary](https://msdn.microsoft.com/library/s4ys34ea)\< (Of \< ( \<'[String](https://msdn.microsoft.com/library/s1wwdcbf), [String](https://msdn.microsoft.com/library/s1wwdcbf)\> ) \> ) \>  
An IDictionary object of name/value attribute pairs.  

## Examples

The following example shows the use of attributes to identify streams for selection. For more information, see the examples in [Timeline Markers and Events (IIS Smooth Streaming)](timeline-markers-and-events.md).

``` 
    if (streamInfo.Type == System.Windows.Media.MediaStreamType.Script)
    {
        if (streamInfo.Attributes["Name"] == "ClosedCaptions" ||
                                streamInfo.Attributes["Name"] == "MARKERS")
        {
            selectStreams.Add(streamInfo);
            segmentInfo.SelectStreamsAsync(selectStreams);
        }
    }
```

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
