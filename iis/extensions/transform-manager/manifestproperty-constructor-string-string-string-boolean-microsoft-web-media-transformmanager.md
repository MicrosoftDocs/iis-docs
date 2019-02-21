---
title: ManifestProperty Constructor (String, String, String, Boolean) (Microsoft.Web.Media.TransformManager)
TOCTitle: ManifestProperty Constructor (String, String, String, Boolean)
ms:assetid: M:Microsoft.Web.Media.TransformManager.ManifestProperty.#ctor(System.String,System.String,System.String,System.Boolean)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.manifestproperty.manifestproperty(v=VS.90)
ms:contentKeyID: 35520564
ms.date: 06/14/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- "cpp"
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ManifestProperty..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# ManifestProperty Constructor (String, String, String, Boolean)

Initializes a new instance of the [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md) class using the specified namespace, name, and value, and whether the property is required.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  Public Sub New ( _
    ns As String, _
    name As String, _
    value As String, _
    required As Boolean _
)
'Usage

  Dim ns As String
Dim name As String
Dim value As String
Dim required As Boolean

Dim instance As New ManifestProperty(ns, name, _
    value, required)
```

```csharp
  public ManifestProperty(
    string ns,
    string name,
    string value,
    bool required
)
```

```cpp
  public:
ManifestProperty(
    String^ ns, 
    String^ name, 
    String^ value, 
    bool required
)
```

``` fsharp
  new : 
        ns:string * 
        name:string * 
        value:string * 
        required:bool -> ManifestProperty
```

```jscript
  public function ManifestProperty(
    ns : String, 
    name : String, 
    value : String, 
    required : boolean
)
```

### Parameters

  - ns  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The namespace of the manifest property.  

<!-- end list -->

  - name  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The name of the manifest property.  

<!-- end list -->

  - value  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The value of the manifest property.  

<!-- end list -->

  - required  
    Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
    true to specify that the manifest property is required; otherwise, false.  

## See Also

### Reference

[ManifestProperty Class](manifestproperty-class-microsoft-web-media-transformmanager.md)

[ManifestProperty Overload](manifestproperty-constructor-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

