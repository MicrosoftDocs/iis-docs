---
title: JobScheduler Constructor (FileInfo, XElement) (Microsoft.Web.Media.TransformManager)
TOCTitle: JobScheduler Constructor (FileInfo, XElement)
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobScheduler.#ctor(System.IO.FileInfo,System.Xml.Linq.XElement)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobscheduler.jobscheduler(v=VS.90)
ms:contentKeyID: 35520731
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
- Microsoft.Web.Media.TransformManager.JobScheduler..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# JobScheduler Constructor (FileInfo, XElement)

Initializes a new instance of the [JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md) class using the specified file information and job scheduler XML element.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    fileInfoAsFileInfo, _
    jobSchedulerElementAsXElement _
)
'Usage
DimfileInfoAsFileInfoDimjobSchedulerElementAsXElementDiminstanceAs NewJobScheduler(fileInfo, _
    jobSchedulerElement)
```

``` csharp
publicJobScheduler(
    FileInfofileInfo,
    XElementjobSchedulerElement
)
```

``` c++
public:
JobScheduler(
    FileInfo^ fileInfo, 
    XElement^ jobSchedulerElement
)
```

``` fsharp
new : 
        fileInfo:FileInfo * 
        jobSchedulerElement:XElement->JobScheduler
```

``` jscript
publicfunctionJobScheduler(
    fileInfo : FileInfo, 
    jobSchedulerElement : XElement
)
```

#### Parameters

  - fileInfo  
    Type: [System.IO. . :: . .FileInfo](https://msdn.microsoft.com/en-us/library/akth6b1k\(v=vs.90\))  
    A [FileInfo](https://msdn.microsoft.com/en-us/library/akth6b1k\(v=vs.90\)) object that is used to retrieve file details.  

<!-- end list -->

  - jobSchedulerElement  
    Type: [System.Xml.Linq. . :: . .XElement](https://msdn.microsoft.com/en-us/library/bb340098\(v=vs.90\))  
    The XML element that contains job scheduler details.  

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
<td><p>jobSchedulerElement is null Nothing nullptr unit a null reference (Nothing in Visual Basic) .</p></td>
</tr>
</tbody>
</table>


## See Also

#### Reference

[JobScheduler Class](jobscheduler-class-microsoft-web-media-transformmanager.md)

[JobScheduler Overload](jobscheduler-constructor-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

