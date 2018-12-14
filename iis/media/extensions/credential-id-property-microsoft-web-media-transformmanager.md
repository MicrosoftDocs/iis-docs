---
title: Credential.Id Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: Id Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.Credential.Id
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.credential.id(v=VS.90)
ms:contentKeyID: 35521167
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Credential.Id
- Microsoft.Web.Media.TransformManager.Credential.set_Id
- Microsoft.Web.Media.TransformManager.Credential.get_Id
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Credential.get_Id
- Microsoft.Web.Media.TransformManager.Credential.Id
- Microsoft.Web.Media.TransformManager.Credential.set_Id
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Id Property

Gets or sets an internal credential ID.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyIdAsStringGetSet
'Usage
DiminstanceAsCredentialDimvalueAsStringvalue = instance.Id

instance.Id = value
```

``` csharp
[DataMemberAttribute]
publicstringId { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ Id {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberId : stringwithget, set
```

``` jscript
function getId () : Stringfunction setId (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A credential ID.  

## See Also

#### Reference

[Credential Class](credential-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

