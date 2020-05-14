---
title: TaskDefinition Constructor (FileInfo, XElement) (Microsoft.Web.Media.TransformManager)
TOCTitle: TaskDefinition Constructor (FileInfo, XElement)
ms:assetid: M:Microsoft.Web.Media.TransformManager.TaskDefinition.#ctor(System.IO.FileInfo,System.Xml.Linq.XElement)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.taskdefinition.taskdefinition(v=VS.90)
ms:contentKeyID: 35520583
ms.date: 06/14/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- cpp
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskDefinition..ctor
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# TaskDefinition Constructor (FileInfo, XElement)

Initializes a new instance of the [TaskDefinition](taskdefinition-class-microsoft-web-media-transformmanager.md) class by using the specified file information and task definition.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Sub New ( _
    fileInfo As FileInfo, _
    taskDefinitionElement As XElement _
)
'Usage

  Dim fileInfo As FileInfo
Dim taskDefinitionElement As XElement

Dim instance As New TaskDefinition(fileInfo, _
    taskDefinitionElement)
```

```csharp
  public TaskDefinition(
    FileInfo fileInfo,
    XElement taskDefinitionElement
)
```

```cpp
  public:
TaskDefinition(
    FileInfo^ fileInfo,
    XElement^ taskDefinitionElement
)
```

``` fsharp
  new :
        fileInfo:FileInfo *
        taskDefinitionElement:XElement -> TaskDefinition
```

```jscript
  public function TaskDefinition(
    fileInfo : FileInfo,
    taskDefinitionElement : XElement
)
```

### Parameters

  - fileInfo  
    Type: [System.IO.FileInfo](https://msdn.microsoft.com/library/akth6b1k)  
    The name of the task definition XML file.  

<!-- end list -->

  - taskDefinitionElement  
    Type: [System.Xml.Linq.XElement](https://msdn.microsoft.com/library/bb340098)  
    An object that contains the task definition.  

## See Also

### Reference

[TaskDefinition Class](taskdefinition-class-microsoft-web-media-transformmanager.md)

[TaskDefinition Overload](taskdefinition-constructor-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
