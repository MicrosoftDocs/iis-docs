﻿---
title: TaskDefinition.Properties Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: Properties Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.TaskDefinition.Properties
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.taskdefinition.properties(v=VS.90)
ms:contentKeyID: 35521144
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskDefinition.Properties
- Microsoft.Web.Media.TransformManager.TaskDefinition.set_Properties
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_Properties
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_Properties
- Microsoft.Web.Media.TransformManager.TaskDefinition.Properties
- Microsoft.Web.Media.TransformManager.TaskDefinition.set_Properties
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Properties Property

Gets or sets a collection of the properties that are defined for the current task.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyPropertiesAsManifestPropertiesDictionaryGetSet
'Usage
DiminstanceAsTaskDefinitionDimvalueAsManifestPropertiesDictionaryvalue = instance.Properties

instance.Properties = value
```

``` csharp
[DataMemberAttribute]
publicManifestPropertiesDictionaryProperties { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyManifestPropertiesDictionary^ Properties {
    ManifestPropertiesDictionary^ get ();
    voidset (ManifestPropertiesDictionary^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberProperties : ManifestPropertiesDictionarywithget, set
```

``` jscript
function getProperties () : ManifestPropertiesDictionaryfunction setProperties (value : ManifestPropertiesDictionary)
```

#### Property Value

Type: [Microsoft.Web.Media.TransformManager. . :: . .ManifestPropertiesDictionary](manifestpropertiesdictionary-class-microsoft-web-media-transformmanager.md)  
The collection of task properties.  

## See Also

#### Reference

[TaskDefinition Class](taskdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
