---
title: IManagementService.UpdateJobTemplate Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: UpdateJobTemplate Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IManagementService.UpdateJobTemplate(Microsoft.Web.Media.TransformManager.JobTemplate)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.imanagementservice.updatejobtemplate(v=VS.90)
ms:contentKeyID: 35520674
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IManagementService.UpdateJobTemplate
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IManagementService.UpdateJobTemplate
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# UpdateJobTemplate Method

Adds or replaces a [JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md) object.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<OperationContractAttribute> _
Sub UpdateJobTemplate ( _
    jobTemplate As JobTemplate _
)
'Usage

  Dim instance As IManagementService
Dim jobTemplate As JobTemplate

instance.UpdateJobTemplate(jobTemplate)
```

```csharp
[OperationContractAttribute]
void UpdateJobTemplate(
    JobTemplate jobTemplate
)
```

```cpp
[OperationContractAttribute]
void UpdateJobTemplate(
    JobTemplate^ jobTemplate
)
```

``` fsharp
[<OperationContractAttribute>]
abstract UpdateJobTemplate : 
        jobTemplate:JobTemplate -> unit 
```

```jscript
  function UpdateJobTemplate(
    jobTemplate : JobTemplate
)
```

### Parameters

  - jobTemplate  
    Type: [Microsoft.Web.Media.TransformManager.JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md)  
    A [JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md) object.  

## Remarks

A [JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md) object contains a set of sequential tasks that are used during the transform process.

## See Also

### Reference

[IManagementService Interface](imanagementservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
