---
title: JobDefinition Constructor (FileInfo, XElement) (Microsoft.Web.Media.TransformManager)
TOCTitle: JobDefinition Constructor (FileInfo, XElement)
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobDefinition.#ctor(System.IO.FileInfo,System.Xml.Linq.XElement)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.jobdefinition(v=VS.90)
ms:contentKeyID: 35520668
ms.date: 06/14/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- "cpp"
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# JobDefinition Constructor (FileInfo, XElement)

Initializes a new instance of the [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) class using the specified file and job definition information.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Sub New ( _
    fileInfo As FileInfo, _
    jobDefinitionElement As XElement _
)
'Usage

  Dim fileInfo As FileInfo
Dim jobDefinitionElement As XElement

Dim instance As New JobDefinition(fileInfo, _
    jobDefinitionElement)
```

```csharp
  public JobDefinition(
    FileInfo fileInfo,
    XElement jobDefinitionElement
)
```

```cpp
  public:
JobDefinition(
    FileInfo^ fileInfo, 
    XElement^ jobDefinitionElement
)
```

``` fsharp
  new : 
        fileInfo:FileInfo * 
        jobDefinitionElement:XElement -> JobDefinition
```

```jscript
  public function JobDefinition(
    fileInfo : FileInfo, 
    jobDefinitionElement : XElement
)
```

### Parameters

  - fileInfo  
    Type: [System.IO.FileInfo](https://msdn.microsoft.com/library/akth6b1k)  
    An object that provides properties and instance methods for creating, copying, deleting, moving, and opening files.  

<!-- end list -->

  - jobDefinitionElement  
    Type: [System.Xml.Linq.XElement](https://msdn.microsoft.com/library/bb340098)  
    An XML object that represents the [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object.  

## Exceptions

|Exception|Condition|
|--- |--- |
|[ArgumentNullException](https://msdn.microsoft.com/library/27426hcy)|jobDefinitionElement is equivalent to null Nothing nullptr unit a null reference (Nothing in Visual Basic) .|


## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[JobDefinition Overload](jobdefinition-constructor-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

