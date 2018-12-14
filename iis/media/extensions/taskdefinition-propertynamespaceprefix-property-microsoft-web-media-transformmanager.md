---
title: TaskDefinition.PropertyNamespacePrefix Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: PropertyNamespacePrefix Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.TaskDefinition.PropertyNamespacePrefix
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.taskdefinition.propertynamespaceprefix(v=VS.90)
ms:contentKeyID: 35520773
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskDefinition.PropertyNamespacePrefix
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_PropertyNamespacePrefix
- Microsoft.Web.Media.TransformManager.TaskDefinition.set_PropertyNamespacePrefix
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_PropertyNamespacePrefix
- Microsoft.Web.Media.TransformManager.TaskDefinition.PropertyNamespacePrefix
- Microsoft.Web.Media.TransformManager.TaskDefinition.set_PropertyNamespacePrefix
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# PropertyNamespacePrefix Property

Gets or sets a prefix for the property namespace of the current task.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyPropertyNamespacePrefixAsStringGetSet
'Usage
DiminstanceAsTaskDefinitionDimvalueAsStringvalue = instance.PropertyNamespacePrefix

instance.PropertyNamespacePrefix = value
```

``` csharp
[DataMemberAttribute]
publicstringPropertyNamespacePrefix { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ PropertyNamespacePrefix {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberPropertyNamespacePrefix : stringwithget, set
```

``` jscript
function getPropertyNamespacePrefix () : Stringfunction setPropertyNamespacePrefix (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The prefix for the property namespace of the current task.  

## See Also

#### Reference

[TaskDefinition Class](taskdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

