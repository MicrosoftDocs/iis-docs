---
title: IManagementService.GetJobDefinitions Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetJobDefinitions Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IManagementService.GetJobDefinitions
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.imanagementservice.getjobdefinitions(v=VS.90)
ms:contentKeyID: 35520986
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IManagementService.GetJobDefinitions
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IManagementService.GetJobDefinitions
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# GetJobDefinitions Method

Returns all [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) objects from IIS Transform Manager.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<OperationContractAttribute> _
Function GetJobDefinitions As Collection(Of JobDefinition)
'Usage

  Dim instance As IManagementService
Dim returnValue As Collection(Of JobDefinition)

returnValue = instance.GetJobDefinitions()
```

```csharp
[OperationContractAttribute]
Collection<JobDefinition> GetJobDefinitions()
```

```cpp
[OperationContractAttribute]
Collection<JobDefinition^>^ GetJobDefinitions()
```

``` fsharp
[<OperationContractAttribute>]
abstract GetJobDefinitions : unit -> Collection<JobDefinition> 
```

```jscript
  function GetJobDefinitions() : Collection<JobDefinition>
```

### Return Value

Type: [System.Collections.ObjectModel.Collection](https://msdn.microsoft.com/library/ms132397)\< (Of \< ( \<'[JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
A collection of [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) objects.  

## See Also

### Reference

[IManagementService Interface](imanagementservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

