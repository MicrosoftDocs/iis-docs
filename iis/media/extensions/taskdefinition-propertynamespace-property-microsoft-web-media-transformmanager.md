---
title: TaskDefinition.PropertyNamespace Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: PropertyNamespace Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.TaskDefinition.PropertyNamespace
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.taskdefinition.propertynamespace(v=VS.90)
ms:contentKeyID: 35520964
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskDefinition.PropertyNamespace
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_PropertyNamespace
- Microsoft.Web.Media.TransformManager.TaskDefinition.set_PropertyNamespace
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_PropertyNamespace
- Microsoft.Web.Media.TransformManager.TaskDefinition.set_PropertyNamespace
- Microsoft.Web.Media.TransformManager.TaskDefinition.PropertyNamespace
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# PropertyNamespace Property

Gets or sets a property namespace for the current task.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyPropertyNamespaceAsStringGetSet
'Usage
DiminstanceAsTaskDefinitionDimvalueAsStringvalue = instance.PropertyNamespace

instance.PropertyNamespace = value
```

``` csharp
[DataMemberAttribute]
publicstringPropertyNamespace { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ PropertyNamespace {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberPropertyNamespace : stringwithget, set
```

``` jscript
function getPropertyNamespace () : Stringfunction setPropertyNamespace (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The property namespace for the current task.  

## See Also

#### Reference

[TaskDefinition Class](taskdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

