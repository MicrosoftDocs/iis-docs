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
- c++
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
ROBOTS: INDEX,FOLLOW
---

# ManifestProperty Constructor (String, String, String, Boolean)

Initializes a new instance of the [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md) class using the specified namespace, name, and value, and whether the property is required.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    nsAsString, _
    nameAsString, _
    valueAsString, _
    requiredAsBoolean _
)
'Usage
DimnsAsStringDimnameAsStringDimvalueAsStringDimrequiredAsBooleanDiminstanceAs NewManifestProperty(ns, name, _
    value, required)
```

``` csharp
publicManifestProperty(
    stringns,
    stringname,
    stringvalue,
    boolrequired
)
```

``` c++
public:
ManifestProperty(
    String^ ns, 
    String^ name, 
    String^ value, 
    boolrequired
)
```

``` fsharp
new : 
        ns:string * 
        name:string * 
        value:string * 
        required:bool->ManifestProperty
```

``` jscript
publicfunctionManifestProperty(
    ns : String, 
    name : String, 
    value : String, 
    required : boolean
)
```

#### Parameters

  - ns  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The namespace of the manifest property.  

<!-- end list -->

  - name  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name of the manifest property.  

<!-- end list -->

  - value  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The value of the manifest property.  

<!-- end list -->

  - required  
    Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
    true to specify that the manifest property is required; otherwise, false.  

## See Also

#### Reference

[ManifestProperty Class](manifestproperty-class-microsoft-web-media-transformmanager.md)

[ManifestProperty Overload](manifestproperty-constructor-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

