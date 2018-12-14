---
title: JobScheduler.JobSchedulerElement Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: JobSchedulerElement Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobScheduler.JobSchedulerElement
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobscheduler.jobschedulerelement(v=VS.90)
ms:contentKeyID: 35520864
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobScheduler.JobSchedulerElement
- Microsoft.Web.Media.TransformManager.JobScheduler.get_JobSchedulerElement
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobScheduler.get_JobSchedulerElement
- Microsoft.Web.Media.TransformManager.JobScheduler.JobSchedulerElement
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# JobSchedulerElement Property

Gets the XML element that contains the scheduler definition.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyJobSchedulerElementAsXElementGet
'Usage
DiminstanceAsJobSchedulerDimvalueAsXElementvalue = instance.JobSchedulerElement
```

``` csharp
publicXElementJobSchedulerElement { get; }
```

``` c++
public:
propertyXElement^ JobSchedulerElement {
    XElement^ get ();
}
```

``` fsharp
memberJobSchedulerElement : XElement
```

``` jscript
function getJobSchedulerElement () : XElement
```

#### Property Value

Type: [System.Xml.Linq. . :: . .XElement](https://msdn.microsoft.com/en-us/library/bb340098\(v=vs.90\))  
The XML element that contains the scheduler definition.  

## See Also

#### Reference

[JobScheduler Class](jobscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

