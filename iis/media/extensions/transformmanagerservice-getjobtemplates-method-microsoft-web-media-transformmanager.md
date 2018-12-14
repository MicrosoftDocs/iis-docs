---
title: TransformManagerService.GetJobTemplates Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetJobTemplates Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobTemplates
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.transformmanagerservice.getjobtemplates(v=VS.90)
ms:contentKeyID: 35521053
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobTemplates
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobTemplates
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
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
PublicFunctionGetJobTemplatesAsCollection(OfJobTemplate)
'Usage
DiminstanceAsTransformManagerServiceDimreturnValueAsCollection(OfJobTemplate)

returnValue = instance.GetJobTemplates()
```

``` csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
publicCollection<JobTemplate> GetJobTemplates()
```

``` c++
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtualCollection<JobTemplate^>^ GetJobTemplates() sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstractGetJobTemplates : unit->Collection<JobTemplate> 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
overrideGetJobTemplates : unit->Collection<JobTemplate> 
```

``` jscript
publicfinalfunctionGetJobTemplates() : Collection<JobTemplate>
```

#### Return Value

Type: [System.Collections.ObjectModel. . :: . .Collection](https://msdn.microsoft.com/en-us/library/ms132397\(v=vs.90\))\< (Of \< ( \<'[JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
A collection of [JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md) objects.  

#### Implements

[IManagementService. . :: . .GetJobTemplates() () () ()](imanagementservice-getjobtemplates-method-microsoft-web-media-transformmanager.md)  

## See Also

#### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

