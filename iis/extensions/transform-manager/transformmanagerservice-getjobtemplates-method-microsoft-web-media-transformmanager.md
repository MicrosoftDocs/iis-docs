---
title: TransformManagerService.GetJobTemplates Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetJobTemplates Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobTemplates
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.transformmanagerservice.getjobtemplates(v=VS.90)
ms:contentKeyID: 35521053
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobTemplates
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.GetJobTemplates
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# GetJobTemplates Method

Returns all [JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md) objects from IIS Transform Manager.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
Public Function GetJobTemplates As Collection(Of JobTemplate)
'Usage

  Dim instance As TransformManagerService
Dim returnValue As Collection(Of JobTemplate)

returnValue = instance.GetJobTemplates()
```

```csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
public Collection<JobTemplate> GetJobTemplates()
```

```cpp
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtual Collection<JobTemplate^>^ GetJobTemplates() sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstract GetJobTemplates : unit -> Collection<JobTemplate> 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
override GetJobTemplates : unit -> Collection<JobTemplate> 
```

```jscript
  public final function GetJobTemplates() : Collection<JobTemplate>
```

### Return Value

Type: [System.Collections.ObjectModel.Collection](https://msdn.microsoft.com/library/ms132397)\< (Of \< ( \<'[JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
A collection of [JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md) objects.  

### Implements

[IManagementService.GetJobTemplates() () () ()](imanagementservice-getjobtemplates-method-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
