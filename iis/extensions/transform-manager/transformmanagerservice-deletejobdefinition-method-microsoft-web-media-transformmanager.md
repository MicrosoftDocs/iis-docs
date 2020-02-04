---
title: TransformManagerService.DeleteJobDefinition Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: DeleteJobDefinition Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.DeleteJobDefinition(System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.transformmanagerservice.deletejobdefinition(v=VS.90)
ms:contentKeyID: 35521158
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.DeleteJobDefinition
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.DeleteJobDefinition
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# DeleteJobDefinition Method

Deletes a [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object from IIS Transform Manager.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
Public Sub DeleteJobDefinition ( _
    jobDefinitionId As String _
)
'Usage

  Dim instance As TransformManagerService
Dim jobDefinitionId As String

instance.DeleteJobDefinition(jobDefinitionId)
```

```csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
public void DeleteJobDefinition(
    string jobDefinitionId
)
```

```cpp
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtual void DeleteJobDefinition(
    String^ jobDefinitionId
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstract DeleteJobDefinition : 
        jobDefinitionId:string -> unit 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
override DeleteJobDefinition : 
        jobDefinitionId:string -> unit 
```

```jscript
  public final function DeleteJobDefinition(
    jobDefinitionId : String
)
```

### Parameters

  - jobDefinitionId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The ID of the [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object to delete.  

### Implements

[IManagementService.DeleteJobDefinition(String)](imanagementservice-deletejobdefinition-method-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

