---
title: TaskDefinition.TaskDefinitionElement Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: TaskDefinitionElement Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.TaskDefinition.TaskDefinitionElement
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.taskdefinition.taskdefinitionelement(v=VS.90)
ms:contentKeyID: 35520906
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskDefinition.set_TaskDefinitionElement
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_TaskDefinitionElement
- Microsoft.Web.Media.TransformManager.TaskDefinition.TaskDefinitionElement
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_TaskDefinitionElement
- Microsoft.Web.Media.TransformManager.TaskDefinition.set_TaskDefinitionElement
- Microsoft.Web.Media.TransformManager.TaskDefinition.TaskDefinitionElement
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TaskDefinitionElement Property

Gets or sets the [XElement](https://msdn.microsoft.com/en-us/library/bb340098\(v=vs.90\)) object container of the template file.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration

  Public Property TaskDefinitionElement As XElement
    Get
    Set
'Usage

  Dim instance As TaskDefinition
Dim value As XElement

value = instance.TaskDefinitionElement

instance.TaskDefinitionElement = value
```

``` csharp
  public XElement TaskDefinitionElement { get; set; }
```

``` c++
  public:
property XElement^ TaskDefinitionElement {
    XElement^ get ();
    void set (XElement^ value);
}
```

``` fsharp
  member TaskDefinitionElement : XElement with get, set
```

``` jscript
  function get TaskDefinitionElement () : XElement
function set TaskDefinitionElement (value : XElement)
```

#### Property Value

Type: [System.Xml.Linq. . :: . .XElement](https://msdn.microsoft.com/en-us/library/bb340098\(v=vs.90\))  
The object container of the template file.  

## See Also

#### Reference

[TaskDefinition Class](taskdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

