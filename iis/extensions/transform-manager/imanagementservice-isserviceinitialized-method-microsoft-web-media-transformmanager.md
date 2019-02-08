---
title: IManagementService.IsServiceInitialized Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: IsServiceInitialized Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IManagementService.IsServiceInitialized
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.imanagementservice.isserviceinitialized(v=VS.90)
ms:contentKeyID: 35520803
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IManagementService.IsServiceInitialized
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IManagementService.IsServiceInitialized
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
<OperationContractAttribute> _
Function IsServiceInitialized As Boolean
'Usage

  Dim instance As IManagementService
Dim returnValue As Boolean

returnValue = instance.IsServiceInitialized()
```

``` csharp
[OperationContractAttribute]
bool IsServiceInitialized()
```

``` c++
[OperationContractAttribute]
bool IsServiceInitialized()
```

``` fsharp
[<OperationContractAttribute>]
abstract IsServiceInitialized : unit -> bool 
```

``` jscript
  function IsServiceInitialized() : boolean
```

#### Return Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
true if the Transform Manager service is initialized; otherwise, false.  

## See Also

#### Reference

[IManagementService Interface](imanagementservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

