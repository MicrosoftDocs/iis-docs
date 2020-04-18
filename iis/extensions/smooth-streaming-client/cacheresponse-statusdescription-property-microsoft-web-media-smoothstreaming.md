---
title: CacheResponse.StatusDescription Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: StatusDescription Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.CacheResponse.StatusDescription
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.cacheresponse.statusdescription(v=VS.90)
ms:contentKeyID: 31469164
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.get_StatusDescription
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.set_StatusDescription
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.StatusDescription
dev_langs:
- csharp
- jscript
- vb
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

# StatusDescription Property

A string that contains the status description.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property StatusDescription As String
'Usage

  Dim instance As CacheResponse
Dim value As String

value = instance.StatusDescription
```

```csharp
  public string StatusDescription { get; private set; }
```

```cpp
  public:
property String^ StatusDescription {
    String^ get ();
    private: void set (String^ value);
}
```

```jscript
  function get StatusDescription () : String
private function set StatusDescription (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
A string object that contains the status description.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[CacheResponse Class](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
