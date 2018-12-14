---
title: JobDefinition.SetJobTemplates Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: SetJobTemplates Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobDefinition.SetJobTemplates(System.Collections.ObjectModel.Collection{Microsoft.Web.Media.TransformManager.JobTemplate})
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.setjobtemplates(v=VS.90)
ms:contentKeyID: 35520739
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.SetJobTemplates
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.SetJobTemplates
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SetJobTemplates Method

Sets or refreshes the job template collection. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicSharedSubSetJobTemplates ( _
    jobTemplatesAsCollection(OfJobTemplate) _
)
'Usage
DimjobTemplatesAsCollection(OfJobTemplate)

JobDefinition.SetJobTemplates(jobTemplates)
```

``` csharp
publicstaticvoidSetJobTemplates(
    Collection<JobTemplate> jobTemplates
)
```

``` c++
public:
staticvoidSetJobTemplates(
    Collection<JobTemplate^>^ jobTemplates
)
```

``` fsharp
staticmemberSetJobTemplates : 
        jobTemplates:Collection<JobTemplate> ->unit
```

``` jscript
publicstaticfunctionSetJobTemplates(
    jobTemplates : Collection<JobTemplate>
)
```

#### Parameters

  - jobTemplates  
    Type: [System.Collections.ObjectModel. . :: . .Collection](https://msdn.microsoft.com/en-us/library/ms132397\(v=vs.90\))\< (Of \< ( \<'[JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
    A collection of job templates.  

## See Also

#### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

