---
title: IManagementService.GetJobTemplates Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetJobTemplates Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IManagementService.GetJobTemplates
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.imanagementservice.getjobtemplates(v=VS.90)
ms:contentKeyID: 35520935
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IManagementService.GetJobTemplates
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IManagementService.GetJobTemplates
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetJobTemplates Method

Returns all [JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md) objects from IIS Transform Manager.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<OperationContractAttribute> _
FunctionGetJobTemplatesAsCollection(OfJobTemplate)
'Usage
DiminstanceAsIManagementServiceDimreturnValueAsCollection(OfJobTemplate)

returnValue = instance.GetJobTemplates()
```

``` csharp
[OperationContractAttribute]
Collection<JobTemplate> GetJobTemplates()
```

``` c++
[OperationContractAttribute]
Collection<JobTemplate^>^ GetJobTemplates()
```

``` fsharp
[<OperationContractAttribute>]
abstractGetJobTemplates : unit->Collection<JobTemplate> 
```

``` jscript
functionGetJobTemplates() : Collection<JobTemplate>
```

#### Return Value

Type: [System.Collections.ObjectModel. . :: . .Collection](https://msdn.microsoft.com/en-us/library/ms132397\(v=vs.90\))\< (Of \< ( \<'[JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
A collection of [JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md) objects.  

## Remarks

A [JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md) object contains two parts, an aggregate RDF metadata section that is injected into the manifest, and the sequence of task definitions.

## See Also

#### Reference

[IManagementService Interface](imanagementservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

