---
title: Credential.Domain Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: Domain Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.Credential.Domain
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.credential.domain(v=VS.90)
ms:contentKeyID: 35520701
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Credential.get_Domain
- Microsoft.Web.Media.TransformManager.Credential.Domain
- Microsoft.Web.Media.TransformManager.Credential.set_Domain
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Credential.Domain
- Microsoft.Web.Media.TransformManager.Credential.get_Domain
- Microsoft.Web.Media.TransformManager.Credential.set_Domain
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Domain Property

Gets or sets the credential domain.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyDomainAsStringGetSet
'Usage
DiminstanceAsCredentialDimvalueAsStringvalue = instance.Domain

instance.Domain = value
```

``` csharp
[DataMemberAttribute]
publicstringDomain { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ Domain {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberDomain : stringwithget, set
```

``` jscript
function getDomain () : Stringfunction setDomain (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The credential domain.  

## See Also

#### Reference

[Credential Class](credential-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

