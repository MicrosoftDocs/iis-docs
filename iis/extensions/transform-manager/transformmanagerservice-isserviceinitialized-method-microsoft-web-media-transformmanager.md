---
title: TransformManagerService.IsServiceInitialized Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: IsServiceInitialized Method
description: "The TransformManagerService.IsServiceInitialized method determines whether the IIS Transform Manager service is initialized."
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.IsServiceInitialized
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.transformmanagerservice.isserviceinitialized(v=VS.90)
ms:contentKeyID: 35520652
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.IsServiceInitialized
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.IsServiceInitialized
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# IsServiceInitialized Method

Determines whether the IIS Transform Manager service is initialized.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
Public Function IsServiceInitialized As Boolean
'Usage

  Dim instance As TransformManagerService
Dim returnValue As Boolean

returnValue = instance.IsServiceInitialized()
```

```csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
public bool IsServiceInitialized()
```

```cpp
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtual bool IsServiceInitialized() sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstract IsServiceInitialized : unit -> bool 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
override IsServiceInitialized : unit -> bool 
```

```jscript
  public final function IsServiceInitialized() : boolean
```

### Return Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
true if the Transform Manager service is initialized; otherwise, false.  

### Implements

[IManagementService.IsServiceInitialized() () () ()](imanagementservice-isserviceinitialized-method-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
