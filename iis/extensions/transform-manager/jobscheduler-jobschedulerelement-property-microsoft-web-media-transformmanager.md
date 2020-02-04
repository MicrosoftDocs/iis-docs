---
title: JobScheduler.JobSchedulerElement Property (Microsoft.Web.Media.TransformManager)
TOCTitle: JobSchedulerElement Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobScheduler.JobSchedulerElement
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobscheduler.jobschedulerelement(v=VS.90)
ms:contentKeyID: 35520864
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobScheduler.JobSchedulerElement
- Microsoft.Web.Media.TransformManager.JobScheduler.get_JobSchedulerElement
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobScheduler.get_JobSchedulerElement
- Microsoft.Web.Media.TransformManager.JobScheduler.JobSchedulerElement
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# JobSchedulerElement Property

Gets the XML element that contains the scheduler definition.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property JobSchedulerElement As XElement
    Get
'Usage

  Dim instance As JobScheduler
Dim value As XElement

value = instance.JobSchedulerElement
```

```csharp
  public XElement JobSchedulerElement { get; }
```

```cpp
  public:
property XElement^ JobSchedulerElement {
    XElement^ get ();
}
```

``` fsharp
  member JobSchedulerElement : XElement
```

```jscript
  function get JobSchedulerElement () : XElement
```

### Property Value

Type: [System.Xml.Linq.XElement](https://msdn.microsoft.com/library/bb340098)  
The XML element that contains the scheduler definition.  

## See Also

### Reference

[JobScheduler Class](jobscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

