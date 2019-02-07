---
title: TaskDefinition Constructor (FileInfo, XElement, XElement) (Microsoft.Web.Media.TransformManager)
TOCTitle: TaskDefinition Constructor (FileInfo, XElement, XElement)
ms:assetid: M:Microsoft.Web.Media.TransformManager.TaskDefinition.#ctor(System.IO.FileInfo,System.Xml.Linq.XElement,System.Xml.Linq.XElement)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.taskdefinition.taskdefinition(v=VS.90)
ms:contentKeyID: 35521038
ms.date: 06/14/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- c++
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskDefinition..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TaskDefinition Constructor (FileInfo, XElement, XElement)

Initializes a new instance of the [TaskDefinition](taskdefinition-class-microsoft-web-media-transformmanager.md) class by using the specified file information, task definition, and default task definition.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration

  Public Sub New ( _
    fileInfo As FileInfo, _
    taskDefinitionElement As XElement, _
    defaultTaskDefinitionElement As XElement _
)
'Usage

  Dim fileInfo As FileInfo
Dim taskDefinitionElement As XElement
Dim defaultTaskDefinitionElement As XElement

Dim instance As New TaskDefinition(fileInfo, _
    taskDefinitionElement, defaultTaskDefinitionElement)
```

``` csharp
  public TaskDefinition(
    FileInfo fileInfo,
    XElement taskDefinitionElement,
    XElement defaultTaskDefinitionElement
)
```

``` c++
  public:
TaskDefinition(
    FileInfo^ fileInfo, 
    XElement^ taskDefinitionElement, 
    XElement^ defaultTaskDefinitionElement
)
```

``` fsharp
  new : 
        fileInfo:FileInfo * 
        taskDefinitionElement:XElement * 
        defaultTaskDefinitionElement:XElement -> TaskDefinition
```

``` jscript
  public function TaskDefinition(
    fileInfo : FileInfo, 
    taskDefinitionElement : XElement, 
    defaultTaskDefinitionElement : XElement
)
```

#### Parameters

  - fileInfo  
    Type: [System.IO. . :: . .FileInfo](https://msdn.microsoft.com/en-us/library/akth6b1k\(v=vs.90\))  
    The name of the task definition XML file.  

<!-- end list -->

  - taskDefinitionElement  
    Type: [System.Xml.Linq. . :: . .XElement](https://msdn.microsoft.com/en-us/library/bb340098\(v=vs.90\))  
    An object that contains the task definition.  

<!-- end list -->

  - defaultTaskDefinitionElement  
    Type: [System.Xml.Linq. . :: . .XElement](https://msdn.microsoft.com/en-us/library/bb340098\(v=vs.90\))  
    An object that contains a default task definition.  

## See Also

#### Reference

[TaskDefinition Class](taskdefinition-class-microsoft-web-media-transformmanager.md)

[TaskDefinition Overload](taskdefinition-constructor-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

