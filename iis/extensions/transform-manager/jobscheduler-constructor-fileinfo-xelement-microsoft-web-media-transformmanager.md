---
title: JobScheduler Constructor (FileInfo, XElement) (Microsoft.Web.Media.TransformManager)
description: Describes the JobScheduler FileInfo and XElement constructor and provides the constructor's syntax, parameters, and exceptions.
TOCTitle: JobScheduler Constructor (FileInfo, XElement)
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobScheduler.#ctor(System.IO.FileInfo,System.Xml.Linq.XElement)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobscheduler.jobscheduler(v=VS.90)
ms:contentKeyID: 35520731
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
- Microsoft.Web.Media.TransformManager.JobScheduler..ctor
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# JobScheduler Constructor (FileInfo, XElement)

Initializes a new instance of the [JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md) class using the specified file information and job scheduler XML element.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Sub New ( _
    fileInfo As FileInfo, _
    jobSchedulerElement As XElement _
)
'Usage

  Dim fileInfo As FileInfo
Dim jobSchedulerElement As XElement

Dim instance As New JobScheduler(fileInfo, _
    jobSchedulerElement)
```

```csharp
  public JobScheduler(
    FileInfo fileInfo,
    XElement jobSchedulerElement
)
```

```cpp
  public:
JobScheduler(
    FileInfo^ fileInfo, 
    XElement^ jobSchedulerElement
)
```

``` fsharp
  new : 
        fileInfo:FileInfo * 
        jobSchedulerElement:XElement -> JobScheduler
```

```jscript
  public function JobScheduler(
    fileInfo : FileInfo, 
    jobSchedulerElement : XElement
)
```

### Parameters

  - fileInfo  
    Type: [System.IO.FileInfo](https://msdn.microsoft.com/library/akth6b1k)  
    A [FileInfo](https://msdn.microsoft.com/library/akth6b1k) object that is used to retrieve file details.  

<!-- end list -->

  - jobSchedulerElement  
    Type: [System.Xml.Linq.XElement](https://msdn.microsoft.com/library/bb340098)  
    The XML element that contains job scheduler details.  

## Exceptions

|Exception|Condition|
|--- |--- |
|[ArgumentNullException](https://msdn.microsoft.com/library/27426hcy)|jobSchedulerElement is null Nothing nullptr unit a null reference (Nothing in Visual Basic) .|

## See Also

### Reference

[JobScheduler Class](jobscheduler-class-microsoft-web-media-transformmanager.md)

[JobScheduler Overload](jobscheduler-constructor-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
