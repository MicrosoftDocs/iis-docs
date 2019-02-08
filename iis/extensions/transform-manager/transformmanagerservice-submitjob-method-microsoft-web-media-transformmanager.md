---
title: TransformManagerService.SubmitJob Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: SubmitJob Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.TransformManagerService.SubmitJob(System.String,System.String,System.Xml.Linq.XElement)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.transformmanagerservice.submitjob(v=VS.90)
ms:contentKeyID: 36868648
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TransformManagerService.SubmitJob
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.TransformManagerService.SubmitJob
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
<PrincipalPermissionAttribute(SecurityAction.Demand, Role := "Administrators")> _
Public Sub SubmitJob ( _
    jobDefinitionId As String, _
    instanceFileName As String, _
    smilManifest As XElement _
)
'Usage

  Dim instance As TransformManagerService
Dim jobDefinitionId As String
Dim instanceFileName As String
Dim smilManifest As XElement

instance.SubmitJob(jobDefinitionId, instanceFileName, _
    smilManifest)
```

``` csharp
[PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")]
public void SubmitJob(
    string jobDefinitionId,
    string instanceFileName,
    XElement smilManifest
)
```

``` c++
[PrincipalPermissionAttribute(SecurityAction::Demand, Role = L"Administrators")]
public:
virtual void SubmitJob(
    String^ jobDefinitionId, 
    String^ instanceFileName, 
    XElement^ smilManifest
) sealed
```

``` fsharp
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
abstract SubmitJob : 
        jobDefinitionId:string * 
        instanceFileName:string * 
        smilManifest:XElement -> unit 
[<PrincipalPermissionAttribute(SecurityAction.Demand, Role = "Administrators")>]
override SubmitJob : 
        jobDefinitionId:string * 
        instanceFileName:string * 
        smilManifest:XElement -> unit 
```

``` jscript
  public final function SubmitJob(
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
    The content of an SMIL 2.0-compliant manifest.  

#### Implements

[IManagementService. . :: . .SubmitJob(String, String, XElement)](imanagementservice-submitjob-method-microsoft-web-media-transformmanager.md)  

## Exceptions

|Exception|Condition|
|--- |--- |
|[IOException](https://msdn.microsoft.com/en-us/library/hccy4eyd(v=vs.90))|The manifest file already exists.|

## See Also

#### Reference

[TransformManagerService Class](transformmanagerservice-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

