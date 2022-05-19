---
title: JobDetails.CreateWorkItemElement Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: CreateWorkItemElement Method
description: "The CreateWorkItemElement method creates an XML element based on the specified JobDetails object that defines a work item."
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobDetails.CreateWorkItemElement(Microsoft.Web.Media.TransformManager.JobDetails)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobdetails.createworkitemelement(v=VS.90)
ms:contentKeyID: 35520925
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.CreateWorkItemElement
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.CreateWorkItemElement
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# CreateWorkItemElement Method

Creates an XML element based on the specified [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object that defines a work item.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Shared Function CreateWorkItemElement ( _
    workItem As JobDetails _
) As XElement
'Usage

  Dim workItem As JobDetails
Dim returnValue As XElement

returnValue = JobDetails.CreateWorkItemElement(workItem)
```

```csharp
  public static XElement CreateWorkItemElement(
    JobDetails workItem
)
```

```cpp
  public:
static XElement^ CreateWorkItemElement(
    JobDetails^ workItem
)
```

``` fsharp
  static member CreateWorkItemElement : 
        workItem:JobDetails -> XElement 
```

```jscript
  public static function CreateWorkItemElement(
    workItem : JobDetails
) : XElement
```

### Parameters

  - workItem  
    Type: [Microsoft.Web.Media.TransformManager.JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)  
    The [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object that defines the work item.  

### Return Value

Type: [System.Xml.Linq.XElement](https://msdn.microsoft.com/library/bb340098)  
An XML element that defines a work item based on a [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object.  

## See Also

### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
