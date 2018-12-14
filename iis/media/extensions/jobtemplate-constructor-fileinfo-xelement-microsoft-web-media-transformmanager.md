---
title: JobTemplate Constructor (FileInfo, XElement) (Microsoft.Web.Media.TransformManager)
TOCTitle: JobTemplate Constructor (FileInfo, XElement)
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobTemplate.#ctor(System.IO.FileInfo,System.Xml.Linq.XElement)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobtemplate.jobtemplate(v=VS.90)
ms:contentKeyID: 35520672
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
- Microsoft.Web.Media.TransformManager.JobTemplate..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# JobTemplate Constructor (FileInfo, XElement)

Initializes a new instance of the [JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md) class using the specified file information and job template.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    fileInfoAsFileInfo, _
    jobTemplateElementAsXElement _
)
'Usage
DimfileInfoAsFileInfoDimjobTemplateElementAsXElementDiminstanceAs NewJobTemplate(fileInfo, _
    jobTemplateElement)
```

``` csharp
publicJobTemplate(
    FileInfofileInfo,
    XElementjobTemplateElement
)
```

``` c++
public:
JobTemplate(
    FileInfo^ fileInfo, 
    XElement^ jobTemplateElement
)
```

``` fsharp
new : 
        fileInfo:FileInfo * 
        jobTemplateElement:XElement->JobTemplate
```

``` jscript
publicfunctionJobTemplate(
    fileInfo : FileInfo, 
    jobTemplateElement : XElement
)
```

#### Parameters

  - fileInfo  
    Type: [System.IO. . :: . .FileInfo](https://msdn.microsoft.com/en-us/library/akth6b1k\(v=vs.90\))  
    The file information of the job template XML file.  

<!-- end list -->

  - jobTemplateElement  
    Type: [System.Xml.Linq. . :: . .XElement](https://msdn.microsoft.com/en-us/library/bb340098\(v=vs.90\))  
    An object that contains the job template.  

## See Also

#### Reference

[JobTemplate Class](jobtemplate-class-microsoft-web-media-transformmanager.md)

[JobTemplate Overload](jobtemplate-constructor-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

