---
title: ClipInformation.ClickThroughUri Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ClickThroughUri Property
description: Describes the ClickThroughUri Property and provides the namespace, assembly, syntax, property value, and version information.
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ClipInformation.ClickThroughUri
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.clipinformation.clickthroughuri(v=VS.95)
ms:contentKeyID: 46307776
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.ClickThroughUri
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.get_ClickThroughUri
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.set_ClickThroughUri
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.ClickThroughUri
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.get_ClickThroughUri
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.set_ClickThroughUri
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ClipInformation.ClickThroughUri Property

Gets or sets a [Uri](https://msdn.microsoft.com/library/txt7706a\(v=vs.95\)) object that contains the Uri to additional information.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property ClickThroughUri As Uri
    Get
    Private Set
'Usage

Dim instance As ClipInformation
Dim value As Uri

value = instance.ClickThroughUri
```

```csharp
public Uri ClickThroughUri { get; private set; }
```

```cpp
public:
property Uri^ ClickThroughUri {
    Uri^ get ();
    private: void set (Uri^ value);
}
```

``` fsharp
member ClickThroughUri : Uri with get, private set
```

```jscript
function get ClickThroughUri () : Uri
private function set ClickThroughUri (value : Uri)
```

### Property Value

Type: [System.Uri](https://msdn.microsoft.com/library/txt7706a\(v=vs.95\))  

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[ClipInformation Class](clipinformation-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
