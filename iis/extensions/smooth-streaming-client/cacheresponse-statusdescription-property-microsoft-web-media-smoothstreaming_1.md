---
title: CacheResponse.StatusDescription Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: StatusDescription Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.CacheResponse.StatusDescription
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.cacheresponse.statusdescription(v=VS.95)
ms:contentKeyID: 46307748
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.get_StatusDescription
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.set_StatusDescription
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.StatusDescription
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.get_StatusDescription
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.set_StatusDescription
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.StatusDescription
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# CacheResponse.StatusDescription Property

A string that contains the status description.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property StatusDescription As String
    Get
    Set
'Usage

Dim instance As CacheResponse
Dim value As String

value = instance.StatusDescription

instance.StatusDescription = value
```

```csharp
public string StatusDescription { get; set; }
```

```cpp
public:
property String^ StatusDescription {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
member StatusDescription : string with get, set
```

```jscript
function get StatusDescription () : String
function set StatusDescription (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\))  
A string object that contains the status description.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[CacheResponse Class](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

