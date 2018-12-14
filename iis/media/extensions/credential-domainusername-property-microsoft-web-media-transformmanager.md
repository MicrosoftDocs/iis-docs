---
title: Credential.DomainUserName Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: DomainUserName Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.Credential.DomainUserName
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.credential.domainusername(v=VS.90)
ms:contentKeyID: 35521186
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Credential.DomainUserName
- Microsoft.Web.Media.TransformManager.Credential.get_DomainUserName
- Microsoft.Web.Media.TransformManager.Credential.set_DomainUserName
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Credential.DomainUserName
- Microsoft.Web.Media.TransformManager.Credential.get_DomainUserName
- Microsoft.Web.Media.TransformManager.Credential.set_DomainUserName
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DomainUserName Property

Gets or sets the credential domain that uses the credential user name.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyDomainUserNameAsStringGetSet
'Usage
DiminstanceAsCredentialDimvalueAsStringvalue = instance.DomainUserName

instance.DomainUserName = value
```

``` csharp
[DataMemberAttribute]
publicstringDomainUserName { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ DomainUserName {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberDomainUserName : stringwithget, set
```

``` jscript
function getDomainUserName () : Stringfunction setDomainUserName (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The credential domain that uses the credential user name.  

## See Also

#### Reference

[Credential Class](credential-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

