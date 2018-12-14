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
- CSharp
- JScript
- VB
- FSharp
- c++
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
ROBOTS: INDEX,FOLLOW
---

# SubmitJob Method

Submits a job to the IIS Transform Manager service.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration
<OperationContractAttribute> _
SubSubmitJob ( _
    jobDefinitionIdAsString, _
    instanceFileNameAsString, _
    smilManifestAsXElement _
)
'Usage
DiminstanceAsIManagementServiceDimjobDefinitionIdAsStringDiminstanceFileNameAsStringDimsmilManifestAsXElement

instance.SubmitJob(jobDefinitionId, instanceFileName, _
    smilManifest)
```

``` csharp
[OperationContractAttribute]
voidSubmitJob(
    stringjobDefinitionId,
    stringinstanceFileName,
    XElementsmilManifest
)
```

``` c++
[OperationContractAttribute]
voidSubmitJob(
    String^ jobDefinitionId, 
    String^ instanceFileName, 
    XElement^ smilManifest
)
```

``` fsharp
[<OperationContractAttribute>]
abstractSubmitJob : 
        jobDefinitionId:string * 
        instanceFileName:string * 
        smilManifest:XElement->unit
```

``` jscript
functionSubmitJob(
    jobDefinitionId : String, 
    instanceFileName : String, 
    smilManifest : XElement
)
```

#### Parameters

  - jobDefinitionId  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The ID of the job definition to submit.  

<!-- end list -->

  - instanceFileName  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The SMIL 2.0 manifest file name.  

<!-- end list -->

  - smilManifest  
    Type: [System.Xml.Linq. . :: . .XElement](https://msdn.microsoft.com/en-us/library/bb340098\(v=vs.90\))  
    A SMIL 2.0-compliant manifest that specifies the files and parameters for a job.  

## Exceptions

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th>Exception</th>
<th>Condition</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><a href="https://msdn.microsoft.com/en-us/library/hccy4eyd(v=vs.90)">IOException</a></td>
<td><p>The file already exists.</p></td>
</tr>
</tbody>
</table>


## See Also

#### Reference

[IManagementService Interface](imanagementservice-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

