---
title: JobDetails.CreateWorkItemFromXElement Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: CreateWorkItemFromXElement Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobDetails.CreateWorkItemFromXElement(System.Xml.Linq.XElement)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdetails.createworkitemfromxelement(v=VS.90)
ms:contentKeyID: 35520587
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.CreateWorkItemFromXElement
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.CreateWorkItemFromXElement
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# CreateWorkItemFromXElement Method

Creates a [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object that defines a work item using the specified XML element.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Shared Function CreateWorkItemFromXElement ( _
    element As XElement _
) As JobDetails
'Usage

  Dim element As XElement
Dim returnValue As JobDetails

returnValue = JobDetails.CreateWorkItemFromXElement(element)
```

```csharp
  public static JobDetails CreateWorkItemFromXElement(
    XElement element
)
```

```cpp
  public:
static JobDetails^ CreateWorkItemFromXElement(
    XElement^ element
)
```

``` fsharp
  static member CreateWorkItemFromXElement : 
        element:XElement -> JobDetails 
```

```jscript
  public static function CreateWorkItemFromXElement(
    element : XElement
) : JobDetails
```

### Parameters

  - element  
    Type: [System.Xml.Linq.XElement](https://msdn.microsoft.com/library/bb340098)  
    The XML element to use to create a [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object that defines a work item.  

### Return Value

Type: [Microsoft.Web.Media.TransformManager.JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md)  
A [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object that defines a work item.  

## See Also

### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

