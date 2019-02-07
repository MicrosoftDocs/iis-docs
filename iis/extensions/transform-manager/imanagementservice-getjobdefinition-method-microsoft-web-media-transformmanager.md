---
title: IManagementService.GetJobDefinition Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetJobDefinition Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IManagementService.GetJobDefinition(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.imanagementservice.getjobdefinition(v=VS.90)
ms:contentKeyID: 35520829
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IManagementService.GetJobDefinition
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IManagementService.GetJobDefinition
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetJobDefinition Method

Returns a [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object that defines how IIS Transform Manager monitors, creates, schedules, and maintains jobs.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<OperationContractAttribute> _
Function GetJobDefinition ( _
    jobDefinitionId As String _
) As JobDefinition
'Usage

  Dim instance As IManagementService
Dim jobDefinitionId As String
Dim returnValue As JobDefinition

returnValue = instance.GetJobDefinition(jobDefinitionId)
```

``` csharp
[OperationContractAttribute]
JobDefinition GetJobDefinition(
    string jobDefinitionId
)
```

``` c++
[OperationContractAttribute]
JobDefinition^ GetJobDefinition(
    String^ jobDefinitionId
)
```

``` fsharp
[<OperationContractAttribute>]
abstract GetJobDefinition : 
        jobDefinitionId:string -> JobDefinition 
```

``` jscript
  function GetJobDefinition(
    jobDefinitionId : String
) : JobDefinition
```

#### Parameters

  - jobDefinitionId  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The ID of the [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object to get.  

#### Return Value

Type: [Microsoft.Web.Media.TransformManager. . :: . .JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md)  
The [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object.  

## See Also

#### Reference

[IManagementService Interface](imanagementservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

