---
title: TransformManagerService.InitializeService Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: InitializeService Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.InitializeService(Microsoft.Web.Media.TransformManager.Credential)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.transformmanagerservice.initializeservice(v=VS.90)
ms:contentKeyID: 35520992
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.InitializeService
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.InitializeService
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# InitializeService Method

Initializes the IIS Transform Manager service using the specified service credential.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
Public Function InitializeService ( _
    serviceCredential As Credential _
) As Boolean
'Usage

  Dim instance As TransformManagerService
Dim serviceCredential As Credential
Dim returnValue As Boolean

returnValue = instance.InitializeService(serviceCredential)
```

```csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
public bool InitializeService(
    Credential serviceCredential
)
```

```cpp
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtual bool InitializeService(
    Credential^ serviceCredential
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstract InitializeService : 
        serviceCredential:Credential -> bool 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
override InitializeService : 
        serviceCredential:Credential -> bool 
```

```jscript
  public final function InitializeService(
    serviceCredential : Credential
) : boolean
```

### Parameters

  - serviceCredential  
    Type: [Microsoft.Web.Media.TransformManager.Credential](credential-class-microsoft-web-media-transformmanager.md)  
    The [Credential](credential-class-microsoft-web-media-transformmanager.md) object that will allow the service to start and run.  

### Return Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  

### Implements

[IManagementService.InitializeService(Credential)](imanagementservice-initializeservice-method-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

