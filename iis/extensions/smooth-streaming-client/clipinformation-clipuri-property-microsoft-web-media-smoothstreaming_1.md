---
title: ClipInformation.ClipUri Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ClipUri Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ClipInformation.ClipUri
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.clipinformation.clipuri(v=VS.95)
ms:contentKeyID: 46307782
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.ClipUri
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.get_ClipUri
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.set_ClipUri
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.ClipUri
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.set_ClipUri
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.get_ClipUri
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ClipInformation.ClipUri Property

Gets or sets a [Uri](https://msdn.microsoft.com/library/txt7706a\(v=vs.95\)) object that contains the clip source.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property ClipUri As Uri
    Get
    Private Set
'Usage

Dim instance As ClipInformation
Dim value As Uri

value = instance.ClipUri
```

```csharp
public Uri ClipUri { get; private set; }
```

```cpp
public:
property Uri^ ClipUri {
    Uri^ get ();
    private: void set (Uri^ value);
}
```

``` fsharp
member ClipUri : Uri with get, private set
```

```jscript
function get ClipUri () : Uri
private function set ClipUri (value : Uri)
```

### Property Value

Type: [System.Uri](https://msdn.microsoft.com/library/txt7706a\(v=vs.95\))  
A [Uri](https://msdn.microsoft.com/library/txt7706a\(v=vs.95\)) object that contains the clip source.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[ClipInformation Class](clipinformation-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

