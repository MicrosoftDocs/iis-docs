---
title: JobDetails.CreateWorkItemElement Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: CreateWorkItemElement Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobDetails.CreateWorkItemElement(Microsoft.Web.Media.TransformManager.JobDetails)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdetails.createworkitemelement(v=VS.90)
ms:contentKeyID: 35520925
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.CreateWorkItemElement
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.CreateWorkItemElement
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CreateWorkItemElement Method

Creates an XML element based on the specified [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object that defines a work item.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicSharedFunctionCreateWorkItemElement ( _
    workItemAsJobDetails _
) AsXElement
'Usage
DimworkItemAsJobDetailsDimreturnValueAsXElementreturnValue = JobDetails.CreateWorkItemElement(workItem)
```

``` csharp
publicstaticXElementCreateWorkItemElement(
    JobDetailsworkItem
)
```

``` c++
public:
staticXElement^ CreateWorkItemElement(
    JobDetails^ workItem
)
```

``` fsharp
staticmemberCreateWorkItemElement : 
        workItem:JobDetails->XElement
```

``` jscript
publicstaticfunctionCreateWorkItemElement(
    workItem : JobDetails
) : XElement
```

#### Parameters

  - workItem  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)  
    The [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object that defines the work item.  

#### Return Value

Type: [System.Xml.Linq. . :: . .XElement](https://msdn.microsoft.com/en-us/library/bb340098\(v=vs.90\))  
An XML element that defines a work item based on a [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object.  

## See Also

#### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

