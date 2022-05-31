---
title: SmoothStreamingMediaElement.Balance Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Balance Property
description: Gets or sets the audio balance.
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Balance
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.balance(v=VS.90)
ms:contentKeyID: 23960952
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Balance
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_Balance
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_Balance
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Balance
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_Balance
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_Balance
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Balance Property

Gets or sets the audio balance.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property Balance As Double
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim value As Double

value = instance.Balance

instance.Balance = value
```

```csharp
  public double Balance { get; set; }
```

```cpp
  public:
property double Balance {
    double get ();
    void set (double value);
}
```

```jscript
  function get Balance () : double
function set Balance (value : double)
```

### Property Value

Type: [System.Double](https://msdn.microsoft.com/library/643eft0t)  
A value that indicates the balance.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
