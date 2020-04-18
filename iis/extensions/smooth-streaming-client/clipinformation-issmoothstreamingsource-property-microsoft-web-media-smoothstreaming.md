---
title: ClipInformation.IsSmoothStreamingSource Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: IsSmoothStreamingSource Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ClipInformation.IsSmoothStreamingSource
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.clipinformation.issmoothstreamingsource(v=VS.90)
ms:contentKeyID: 23961127
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.IsSmoothStreamingSource
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.get_IsSmoothStreamingSource
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.set_IsSmoothStreamingSource
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.get_IsSmoothStreamingSource
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.IsSmoothStreamingSource
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.set_IsSmoothStreamingSource
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# IsSmoothStreamingSource Property

Gets or sets a Boolean value that indicates whether the media clip is in Smooth Streaming format.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property IsSmoothStreamingSource As Boolean
'Usage

  Dim instance As ClipInformation
Dim value As Boolean

value = instance.IsSmoothStreamingSource
```

```csharp
  public bool IsSmoothStreamingSource { get; private set; }
```

```cpp
  public:
property bool IsSmoothStreamingSource {
    bool get ();
    private: void set (bool value);
}
```

```jscript
  function get IsSmoothStreamingSource () : boolean
private function set IsSmoothStreamingSource (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
A Boolean value, true if the media clip is in Smooth Streaming format, otherwise false.  

## Remarks

For a complete example that uses the IsSmoothStreamingSource property, see [Scheduling Media Clips (IIS Smooth Streaming)](scheduling-media-clips.md).

## Version Information

### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[ClipInformation Class](clipinformation-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
