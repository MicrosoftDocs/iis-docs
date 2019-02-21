---
title: ClipInformation.ClickThroughUri Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ClickThroughUri Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ClipInformation.ClickThroughUri
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.clipinformation.clickthroughuri(v=VS.90)
ms:contentKeyID: 31469170
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.ClickThroughUri
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.get_ClickThroughUri
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.set_ClickThroughUri
dev_langs:
- csharp
- jscript
- vb
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

# ClickThroughUri Property

Gets or sets a [Uri](https://msdn.microsoft.com/library/txt7706a) object that contains the Uri to additional information.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property ClickThroughUri As Uri
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

```jscript
  function get ClickThroughUri () : Uri
private function set ClickThroughUri (value : Uri)
```

### Property Value

Type: [System.Uri](https://msdn.microsoft.com/library/txt7706a)  

## Version Information

### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[ClipInformation Class](clipinformation-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

