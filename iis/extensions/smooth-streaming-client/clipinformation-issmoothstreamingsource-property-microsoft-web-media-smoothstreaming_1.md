---
title: The ClipInformation.IsSmoothStreamingSource Property (Microsoft.Web.Media.SmoothStreaming)
description: Describes the ClipInformation.IsSmoothStreamingSource property and provides the property's syntax, remarks, and version information.
TOCTitle: IsSmoothStreamingSource Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ClipInformation.IsSmoothStreamingSource
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.clipinformation.issmoothstreamingsource(v=VS.95)
ms:contentKeyID: 46307783
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.IsSmoothStreamingSource
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.get_IsSmoothStreamingSource
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.set_IsSmoothStreamingSource
dev_langs:
- csharp
- jscript
- vb
- FSharp
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

# The ClipInformation.IsSmoothStreamingSource Property

Gets or sets a Boolean value that indicates whether the media clip is in Smooth Streaming format.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property IsSmoothStreamingSource As Boolean
    Get
    Private Set
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

``` fsharp
member IsSmoothStreamingSource : bool with get, private set
```

```jscript
function get IsSmoothStreamingSource () : boolean
private function set IsSmoothStreamingSource (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50\(v=vs.95\))  
A Boolean value, true if the media clip is in Smooth Streaming format, otherwise false.

## Remarks

For a complete example that uses the IsSmoothStreamingSource property, see [Scheduling Media Clips](scheduling-media-clips.md).

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[ClipInformation Class](clipinformation-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
