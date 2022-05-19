---
title: ClipContext.ClipInformation Property (Microsoft.Web.Media.SmoothStreaming)
description: "This article shows the ClipContext.ClipInformation Property syntax, which gets or sets the ClipInformation Property for Microsoft.Web.Media.SmoothStreaming."
TOCTitle: ClipInformation Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ClipContext.ClipInformation
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.clipcontext.clipinformation(v=VS.95)
ms:contentKeyID: 46307764
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipContext.ClipInformation
- Microsoft.Web.Media.SmoothStreaming.ClipContext.get_ClipInformation
- Microsoft.Web.Media.SmoothStreaming.ClipContext.set_ClipInformation
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipContext.ClipInformation
- Microsoft.Web.Media.SmoothStreaming.ClipContext.get_ClipInformation
- Microsoft.Web.Media.SmoothStreaming.ClipContext.set_ClipInformation
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ClipContext.ClipInformation Property

Gets or sets the ClipInformation property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property ClipInformation As ClipInformation
    Get
    Private Set
'Usage

Dim instance As ClipContext
Dim value As ClipInformation

value = instance.ClipInformation
```

```csharp
public ClipInformation ClipInformation { get; private set; }
```

```cpp
public:
property ClipInformation^ ClipInformation {
    ClipInformation^ get ();
    private: void set (ClipInformation^ value);
}
```

``` fsharp
member ClipInformation : ClipInformation with get, private set
```

```jscript
function get ClipInformation () : ClipInformation
private function set ClipInformation (value : ClipInformation)
```

### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.ClipInformation](clipinformation-class-microsoft-web-media-smoothstreaming_1.md)  
A [ClipInformation](clipinformation-class-microsoft-web-media-smoothstreaming_1.md) object.

## Remarks

Clip information associated with the context. For more information, see [Scheduling Media Clips](scheduling-media-clips.md).

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[ClipContext Class](clipcontext-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
