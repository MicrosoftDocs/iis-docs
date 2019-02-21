---
title: IManagementService.SubmitJob Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: SubmitJob Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IManagementService.SubmitJob(System.String,System.String,System.Xml.Linq.XElement)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.imanagementservice.submitjob(v=VS.90)
ms:contentKeyID: 36868657
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IManagementService.SubmitJob
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.IManagementService.SubmitJob
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# SubmitJob Method

Submits a job to the IIS Transform Manager service.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration
<OperationContractAttribute> _
Sub SubmitJob ( _
    jobDefinitionId As String, _
    instanceFileName As String, _
    smilManifest As XElement _
)
'Usage

  Dim instance As IManagementService
Dim jobDefinitionId As String
Dim instanceFileName As String
Dim smilManifest As XElement

instance.SubmitJob(jobDefinitionId, instanceFileName, _
    smilManifest)
```

```csharp
[OperationContractAttribute]
void SubmitJob(
    string jobDefinitionId,
    string instanceFileName,
    XElement smilManifest
)
```

```cpp
[OperationContractAttribute]
void SubmitJob(
    String^ jobDefinitionId, 
    String^ instanceFileName, 
    XElement^ smilManifest
)
```

``` fsharp
[<OperationContractAttribute>]
abstract SubmitJob : 
        jobDefinitionId:string * 
        instanceFileName:string * 
        smilManifest:XElement -> unit 
```

```jscript
  function SubmitJob(
    jobDefinitionId : String, 
    instanceFileName : String, 
    smilManifest : XElement
)
```

### Parameters

  - jobDefinitionId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The ID of the job definition to submit.  

<!-- end list -->

  - instanceFileName  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The SMIL 2.0 manifest file name.  

<!-- end list -->

  - smilManifest  
    Type: [System.Xml.Linq.XElement](https://msdn.microsoft.com/library/bb340098)  
    A SMIL 2.0-compliant manifest that specifies the files and parameters for a job.  

## Exceptions

|Exception|Condition|
|--- |--- |
|[IOException](https://msdn.microsoft.com/library/hccy4eyd)|The file already exists.|


## See Also

### Reference

[IManagementService Interface](imanagementservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

