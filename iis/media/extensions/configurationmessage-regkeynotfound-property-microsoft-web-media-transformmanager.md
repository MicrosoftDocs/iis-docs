---
title: ConfigurationMessage.RegKeyNotFound Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: RegKeyNotFound Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ConfigurationMessage.RegKeyNotFound
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.configurationmessage.regkeynotfound(v=VS.90)
ms:contentKeyID: 35520682
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.set_RegKeyNotFound
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.RegKeyNotFound
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.get_RegKeyNotFound
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.get_RegKeyNotFound
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.RegKeyNotFound
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.set_RegKeyNotFound
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# RegKeyNotFound Property

Gets or sets a message to post when the registration key is not found.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyRegKeyNotFoundAsStringGetSet
'Usage
DiminstanceAsConfigurationMessageDimvalueAsStringvalue = instance.RegKeyNotFound

instance.RegKeyNotFound = value
```

``` csharp
[DataMemberAttribute]
publicstringRegKeyNotFound { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ RegKeyNotFound {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberRegKeyNotFound : stringwithget, set
```

``` jscript
function getRegKeyNotFound () : Stringfunction setRegKeyNotFound (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The message that is posted when the registration key is not found.  

## See Also

#### Reference

[ConfigurationMessage Class](configurationmessage-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

