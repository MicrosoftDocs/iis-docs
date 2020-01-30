---
title: JobDefinition.SetJobTemplates Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: SetJobTemplates Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobDefinition.SetJobTemplates(System.Collections.ObjectModel.Collection{Microsoft.Web.Media.TransformManager.JobTemplate})
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobdefinition.setjobtemplates(v=VS.90)
ms:contentKeyID: 35520739
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.SetJobTemplates
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.SetJobTemplates
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SetJobTemplates Method

Sets or refreshes the job template collection. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Shared Sub SetJobTemplates ( _
    jobTemplates As Collection(Of JobTemplate) _
)
'Usage

  Dim jobTemplates As Collection(Of JobTemplate)

JobDefinition.SetJobTemplates(jobTemplates)
```

```csharp
  public static void SetJobTemplates(
    Collection<JobTemplate> jobTemplates
)
```

```cpp
  public:
static void SetJobTemplates(
    Collection<JobTemplate^>^ jobTemplates
)
```

``` fsharp
  static member SetJobTemplates : 
        jobTemplates:Collection<JobTemplate> -> unit 
```

```jscript
  public static function SetJobTemplates(
    jobTemplates : Collection<JobTemplate>
)
```

### Parameters

  - jobTemplates  
    Type: [System.Collections.ObjectModel.Collection](https://msdn.microsoft.com/library/ms132397)\< (Of \< ( \<'[JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
    A collection of job templates.  

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

