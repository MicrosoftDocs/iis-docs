---
title: ConfigurationMessage.RegKeyFound Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: RegKeyFound Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ConfigurationMessage.RegKeyFound
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.configurationmessage.regkeyfound(v=VS.90)
ms:contentKeyID: 35521134
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.get_RegKeyFound
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.RegKeyFound
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.set_RegKeyFound
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.get_RegKeyFound
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.RegKeyFound
- Microsoft.Web.Media.TransformManager.ConfigurationMessage.set_RegKeyFound
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# RegKeyFound Property

Gets or sets a message to post when the registration key value is found.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyRegKeyFoundAsStringGetSet
'Usage
DiminstanceAsConfigurationMessageDimvalueAsStringvalue = instance.RegKeyFound

instance.RegKeyFound = value
```

``` csharp
[DataMemberAttribute]
publicstringRegKeyFound { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ RegKeyFound {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberRegKeyFound : stringwithget, set
```

``` jscript
function getRegKeyFound () : Stringfunction setRegKeyFound (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The message that is posted when the registration key is found.  

## See Also

#### Reference

[ConfigurationMessage Class](configurationmessage-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

