---
title: ConfigurationMessage.ObjectType Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: ObjectType Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ConfigurationMessage.ObjectType
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.configurationmessage.objecttype(v=VS.90)
ms:contentKeyID: 35520825
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.ObjectType
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.get_ObjectType
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.set_ObjectType
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.get_ObjectType
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.ObjectType
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.set_ObjectType
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ObjectType Property

Gets or set the type of the configuration object.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyObjectTypeAsStringGetSet
'Usage
DiminstanceAsConfigurationMessageDimvalueAsStringvalue = instance.ObjectType

instance.ObjectType = value
```

``` csharp
[DataMemberAttribute]
publicstringObjectType { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ ObjectType {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberObjectType : stringwithget, set
```

``` jscript
function getObjectType () : Stringfunction setObjectType (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The type of the configuration object.  

## See Also

#### Reference

[ConfigurationMessage Class](configurationmessage-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

