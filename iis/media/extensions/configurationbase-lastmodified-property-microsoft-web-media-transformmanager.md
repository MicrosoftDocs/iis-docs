---
title: ConfigurationBase.LastModified Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: LastModified Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ConfigurationBase.LastModified
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.configurationbase.lastmodified(v=VS.90)
ms:contentKeyID: 35520753
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.LastModified
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_LastModified
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_LastModified
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_LastModified
- Microsoft.Web.Media.TransformManager.ConfigurationBase.LastModified
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_LastModified
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# LastModified Property

Gets or sets the date and time when the IIS Transform Manager configuration was last modified.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyLastModifiedAsDateTimeGetSet
'Usage
DiminstanceAsConfigurationBaseDimvalueAsDateTimevalue = instance.LastModified

instance.LastModified = value
```

``` csharp
[DataMemberAttribute]
publicDateTimeLastModified { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyDateTimeLastModified {
    DateTimeget ();
    voidset (DateTimevalue);
}
```

``` fsharp
[<DataMemberAttribute>]
memberLastModified : DateTimewithget, set
```

``` jscript
function getLastModified () : DateTimefunction setLastModified (value : DateTime)
```

#### Property Value

Type: [System. . :: . .DateTime](https://msdn.microsoft.com/en-us/library/03ybds8y\(v=vs.90\))  
The date and time when the IIS Transform Manager configuration was last modified.  

## See Also

#### Reference

[ConfigurationBase Class](configurationbase-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

