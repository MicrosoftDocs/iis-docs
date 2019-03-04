---
title: SmoothStreamingMediaElement.Balance Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Balance Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Balance
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.balance(v=VS.95)
ms:contentKeyID: 46307803
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Balance
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_Balance
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_Balance
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Balance
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_Balance
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_Balance
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingMediaElement.Balance Property

Gets or sets the audio balance.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property Balance As Double
    Get
    Set
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

``` fsharp
member Balance : float with get, set
```

```jscript
function get Balance () : double
function set Balance (value : double)
```

### Property Value

Type: [System.Double](https://msdn.microsoft.com/library/643eft0t\(v=vs.95\))  
A value that indicates the balance.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

