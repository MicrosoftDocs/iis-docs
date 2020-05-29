---
title: JobTemplate Constructor (FileInfo, XElement) (Microsoft.Web.Media.TransformManager)
TOCTitle: JobTemplate Constructor (FileInfo, XElement)
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobTemplate.#ctor(System.IO.FileInfo,System.Xml.Linq.XElement)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobtemplate.jobtemplate(v=VS.90)
ms:contentKeyID: 35520672
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
- Microsoft.Web.Media.TransformManager.JobTemplate..ctor
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# JobTemplate Constructor (FileInfo, XElement)

Initializes a new instance of the [JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md) class using the specified file information and job template.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Sub New ( _
    fileInfo As FileInfo, _
    jobTemplateElement As XElement _
)
'Usage

  Dim fileInfo As FileInfo
Dim jobTemplateElement As XElement

Dim instance As New JobTemplate(fileInfo, _
    jobTemplateElement)
```

```csharp
  public JobTemplate(
    FileInfo fileInfo,
    XElement jobTemplateElement
)
```

```cpp
  public:
JobTemplate(
    FileInfo^ fileInfo, 
    XElement^ jobTemplateElement
)
```

``` fsharp
  new : 
        fileInfo:FileInfo * 
        jobTemplateElement:XElement -> JobTemplate
```

```jscript
  public function JobTemplate(
    fileInfo : FileInfo, 
    jobTemplateElement : XElement
)
```

### Parameters

  - fileInfo  
    Type: [System.IO.FileInfo](https://msdn.microsoft.com/library/akth6b1k)  
    The file information of the job template XML file.  

<!-- end list -->

  - jobTemplateElement  
    Type: [System.Xml.Linq.XElement](https://msdn.microsoft.com/library/bb340098)  
    An object that contains the job template.  

## See Also

### Reference

[JobTemplate Class](jobtemplate-class-microsoft-web-media-transformmanager.md)

[JobTemplate Overload](jobtemplate-constructor-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
