---
title: Credential.UserName Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: UserName Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.Credential.UserName
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.credential.username(v=VS.90)
ms:contentKeyID: 35520664
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Credential.set_UserName
- Microsoft.Web.Media.TransformManager.Credential.get_UserName
- Microsoft.Web.Media.TransformManager.Credential.UserName
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Credential.get_UserName
- Microsoft.Web.Media.TransformManager.Credential.set_UserName
- Microsoft.Web.Media.TransformManager.Credential.UserName
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# UserName Property

Gets or sets a credential user name.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyUserNameAsStringGetSet
'Usage
DiminstanceAsCredentialDimvalueAsStringvalue = instance.UserName

instance.UserName = value
```

``` csharp
[DataMemberAttribute]
publicstringUserName { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ UserName {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberUserName : stringwithget, set
```

``` jscript
function getUserName () : Stringfunction setUserName (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A credential user name.  

## See Also

#### Reference

[Credential Class](credential-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

