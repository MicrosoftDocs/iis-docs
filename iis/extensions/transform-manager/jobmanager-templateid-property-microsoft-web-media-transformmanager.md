---
title: JobManager.TemplateId Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: TemplateId Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManager.TemplateId
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanager.templateid(v=VS.90)
ms:contentKeyID: 35521041
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManager.TemplateId
- Microsoft.Web.Media.TransformManager.JobManager.get_TemplateId
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManager.get_TemplateId
- Microsoft.Web.Media.TransformManager.JobManager.TemplateId
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TemplateId Property

Gets the ID of the job template that the [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object uses.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration

  Public ReadOnly Property TemplateId As String
    Get
'Usage

  Dim instance As JobManager
Dim value As String

value = instance.TemplateId
```

``` csharp
  public string TemplateId { get; }
```

``` c++
  public:
property String^ TemplateId {
    String^ get ();
}
```

``` fsharp
  member TemplateId : string
```

``` jscript
  function get TemplateId () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The ID of the job template that the [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object uses.  

## See Also

#### Reference

[JobManager Class](jobmanager-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

