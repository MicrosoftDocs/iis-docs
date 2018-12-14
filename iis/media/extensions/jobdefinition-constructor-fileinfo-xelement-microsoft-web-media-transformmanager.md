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
- c++
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
ROBOTS: INDEX,FOLLOW
---

# JobDefinition Constructor (FileInfo, XElement)

Initializes a new instance of the [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) class using the specified file and job definition information.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    fileInfoAsFileInfo, _
    jobDefinitionElementAsXElement _
)
'Usage
DimfileInfoAsFileInfoDimjobDefinitionElementAsXElementDiminstanceAs NewJobDefinition(fileInfo, _
    jobDefinitionElement)
```

``` csharp
publicJobDefinition(
    FileInfofileInfo,
    XElementjobDefinitionElement
)
```

``` c++
public:
JobDefinition(
    FileInfo^ fileInfo, 
    XElement^ jobDefinitionElement
)
```

``` fsharp
new : 
        fileInfo:FileInfo * 
        jobDefinitionElement:XElement->JobDefinition
```

``` jscript
publicfunctionJobDefinition(
    fileInfo : FileInfo, 
    jobDefinitionElement : XElement
)
```

#### Parameters

  - fileInfo  
    Type: [System.IO. . :: . .FileInfo](https://msdn.microsoft.com/en-us/library/akth6b1k\(v=vs.90\))  
    An object that provides properties and instance methods for creating, copying, deleting, moving, and opening files.  

<!-- end list -->

  - jobDefinitionElement  
    Type: [System.Xml.Linq. . :: . .XElement](https://msdn.microsoft.com/en-us/library/bb340098\(v=vs.90\))  
    An XML object that represents the [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object.  

## Exceptions

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th>Exception</th>
<th>Condition</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><a href="https://msdn.microsoft.com/en-us/library/27426hcy(v=vs.90)">ArgumentNullException</a></td>
<td><p>jobDefinitionElement is equivalent to null Nothing nullptr unit a null reference (Nothing in Visual Basic) .</p></td>
</tr>
</tbody>
</table>


## See Also

#### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[JobDefinition Overload](jobdefinition-constructor-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

