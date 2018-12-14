---
title: Credential.Password Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: Password Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.Credential.Password
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.credential.password(v=VS.90)
ms:contentKeyID: 35521012
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Credential.get_Password
- Microsoft.Web.Media.TransformManager.Credential.set_Password
- Microsoft.Web.Media.TransformManager.Credential.Password
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Credential.get_Password
- Microsoft.Web.Media.TransformManager.Credential.Password
- Microsoft.Web.Media.TransformManager.Credential.set_Password
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Password Property

Gets or sets an internal credential password.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyPasswordAsStringGetSet
'Usage
DiminstanceAsCredentialDimvalueAsStringvalue = instance.Password

instance.Password = value
```

``` csharp
[DataMemberAttribute]
publicstringPassword { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ Password {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberPassword : stringwithget, set
```

``` jscript
function getPassword () : Stringfunction setPassword (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A credential password.  

## See Also

#### Reference

[Credential Class](credential-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

