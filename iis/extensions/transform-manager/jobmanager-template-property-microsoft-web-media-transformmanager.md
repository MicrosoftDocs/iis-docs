---
title: JobManager.Template Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: Template Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManager.Template
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanager.template(v=VS.90)
ms:contentKeyID: 35520949
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManager.Template
- Microsoft.Web.Media.TransformManager.JobManager.get_Template
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManager.get_Template
- Microsoft.Web.Media.TransformManager.JobManager.Template
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Template Property

Gets the job template that defines the tasks for this job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration

  Public ReadOnly Property Template As XElement
    Get
'Usage

  Dim instance As JobManager
Dim value As XElement

value = instance.Template
```

``` csharp
  public XElement Template { get; }
```

``` c++
  public:
property XElement^ Template {
    XElement^ get ();
}
```

``` fsharp
  member Template : XElement
```

``` jscript
  function get Template () : XElement
```

#### Property Value

Type: [System.Xml.Linq. . :: . .XElement](https://msdn.microsoft.com/en-us/library/bb340098\(v=vs.90\))  
The job template that defines the tasks for this job.  

## See Also

#### Reference

[JobManager Class](jobmanager-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

