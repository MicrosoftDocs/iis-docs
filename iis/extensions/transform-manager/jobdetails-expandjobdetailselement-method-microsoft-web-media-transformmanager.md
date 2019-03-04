---
title: JobDetails.ExpandJobDetailsElement Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: ExpandJobDetailsElement Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobDetails.ExpandJobDetailsElement
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdetails.expandjobdetailselement(v=VS.90)
ms:contentKeyID: 35521162
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.ExpandJobDetailsElement
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.ExpandJobDetailsElement
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ExpandJobDetailsElement Method

Creates an XML element from a [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object that defines a work item.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Function ExpandJobDetailsElement As XElement
'Usage

  Dim instance As JobDetails
Dim returnValue As XElement

returnValue = instance.ExpandJobDetailsElement()
```

```csharp
  public XElement ExpandJobDetailsElement()
```

```cpp
  public:
XElement^ ExpandJobDetailsElement()
```

``` fsharp
  member ExpandJobDetailsElement : unit -> XElement 
```

```jscript
  public function ExpandJobDetailsElement() : XElement
```

### Return Value

Type: [System.Xml.Linq.XElement](https://msdn.microsoft.com/library/bb340098)  
An XML element that defines a work item based on a [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object.  

## Remarks

This method takes a [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object and creates an XML element. The [JobDetails](jobdetails-class-microsoft-web-media-transformmanager.md) object has IDs for [JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md), [JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md), and JobDefinitionS objects. The method resolves the IDs to names.

## See Also

### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

