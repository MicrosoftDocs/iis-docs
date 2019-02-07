---
title: TransformManagerService.DeleteJobTemplate Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: DeleteJobTemplate Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.DeleteJobTemplate(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.transformmanagerservice.deletejobtemplate(v=VS.90)
ms:contentKeyID: 35520936
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.DeleteJobTemplate
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.DeleteJobTemplate
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeleteJobTemplate Method

Deletes a [JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md) object from IIS Transform Manager.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
Public Sub DeleteJobTemplate ( _
    jobTemplateId As String _
)
'Usage

  Dim instance As TransformManagerService
Dim jobTemplateId As String

instance.DeleteJobTemplate(jobTemplateId)
```

``` csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
public void DeleteJobTemplate(
    string jobTemplateId
)
```

``` c++
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtual void DeleteJobTemplate(
    String^ jobTemplateId
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstract DeleteJobTemplate : 
        jobTemplateId:string -> unit 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
override DeleteJobTemplate : 
        jobTemplateId:string -> unit 
```

``` jscript
  public final function DeleteJobTemplate(
    jobTemplateId : String
)
```

#### Parameters

  - jobTemplateId  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The ID of the [JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md) object to delete.  

#### Implements

[IManagementService. . :: . .DeleteJobTemplate(String)](imanagementservice-deletejobtemplate-method-microsoft-web-media-transformmanager.md)  

## Exceptions

|Exception|Condition|
|--- |--- |
|[InvalidOperationException](https://msdn.microsoft.com/en-us/library/2asft85a(v=vs.90))|The job template is in use and cannot be deleted.|

## See Also

#### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

