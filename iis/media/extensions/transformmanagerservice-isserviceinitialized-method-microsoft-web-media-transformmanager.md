---
title: TransformManagerService.IsServiceInitialized Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: IsServiceInitialized Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.IsServiceInitialized
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.transformmanagerservice.isserviceinitialized(v=VS.90)
ms:contentKeyID: 35520652
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.IsServiceInitialized
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.IsServiceInitialized
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# IsServiceInitialized Method

Determines whether the IIS Transform Manager service is initialized.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
PublicFunctionIsServiceInitializedAsBoolean
'Usage
DiminstanceAsTransformManagerServiceDimreturnValueAsBooleanreturnValue = instance.IsServiceInitialized()
```

``` csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
publicboolIsServiceInitialized()
```

``` c++
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtualboolIsServiceInitialized() sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstractIsServiceInitialized : unit->bool 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
overrideIsServiceInitialized : unit->bool
```

``` jscript
publicfinalfunctionIsServiceInitialized() : boolean
```

#### Return Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
true if the Transform Manager service is initialized; otherwise, false.  

#### Implements

[IManagementService. . :: . .IsServiceInitialized() () () ()](imanagementservice-isserviceinitialized-method-microsoft-web-media-transformmanager.md)  

## See Also

#### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

