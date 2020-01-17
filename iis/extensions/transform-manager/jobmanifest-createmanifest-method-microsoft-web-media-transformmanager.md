---
title: JobManifest.CreateManifest Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: CreateManifest Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobManifest.CreateManifest(Microsoft.Web.Media.TransformManager.JobDefinition,System.String,Microsoft.Web.Media.TransformManager.SchedulerInfo,System.Xml.Linq.XElement,System.Collections.Generic.ICollection{System.Xml.Linq.XElement},System.String,System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobmanifest.createmanifest(v=VS.90)
ms:contentKeyID: 35520619
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.CreateManifest
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.CreateManifest
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# CreateManifest Method

Creates a [JobManifest](jobmanifest-class-microsoft-web-media-transformmanager.md) object by using the job definition, the root work folder name, scheduling information about a job, tasks that define a job, shared properties, the name of the file that is used to create the manifest, and the ID of the manifest instance.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Shared Function CreateManifest ( _
    jobDefinition As JobDefinition, _
    workQueueRoot As String, _
    schedulerInfo As SchedulerInfo, _
    template As XElement, _
    sharedProperties As ICollection(Of XElement), _
    inputFileName As String, _
    instanceId As String _
) As JobManifest
'Usage

  Dim jobDefinition As JobDefinition
Dim workQueueRoot As String
Dim schedulerInfo As SchedulerInfo
Dim template As XElement
Dim sharedProperties As ICollection(Of XElement)
Dim inputFileName As String
Dim instanceId As String
Dim returnValue As JobManifest

returnValue = JobManifest.CreateManifest(jobDefinition, _
    workQueueRoot, schedulerInfo, template, _
    sharedProperties, inputFileName, _
    instanceId)
```

```csharp
  public static JobManifest CreateManifest(
    JobDefinition jobDefinition,
    string workQueueRoot,
    SchedulerInfo schedulerInfo,
    XElement template,
    ICollection<XElement> sharedProperties,
    string inputFileName,
    string instanceId
)
```

```cpp
  public:
static JobManifest^ CreateManifest(
    JobDefinition^ jobDefinition, 
    String^ workQueueRoot, 
    SchedulerInfo^ schedulerInfo, 
    XElement^ template, 
    ICollection<XElement^>^ sharedProperties, 
    String^ inputFileName, 
    String^ instanceId
)
```

``` fsharp
  static member CreateManifest : 
        jobDefinition:JobDefinition * 
        workQueueRoot:string * 
        schedulerInfo:SchedulerInfo * 
        template:XElement * 
        sharedProperties:ICollection<XElement> * 
        inputFileName:string * 
        instanceId:string -> JobManifest 
```

```jscript
  public static function CreateManifest(
    jobDefinition : JobDefinition, 
    workQueueRoot : String, 
    schedulerInfo : SchedulerInfo, 
    template : XElement, 
    sharedProperties : ICollection<XElement>, 
    inputFileName : String, 
    instanceId : String
) : JobManifest
```

### Parameters

  - jobDefinition  
    Type: [Microsoft.Web.Media.TransformManager.JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md)  
    An object that defines how a job is created, scheduled, monitored, and maintained.  

<!-- end list -->

  - workQueueRoot  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    A value that specifies the root work folder name.  

<!-- end list -->

  - schedulerInfo  
    Type: [Microsoft.Web.Media.TransformManager.SchedulerInfo](schedulerinfo-class-microsoft-web-media-transformmanager.md)  
    An object that provides scheduling information about a job.  

<!-- end list -->

  - template  
    Type: [System.Xml.Linq.XElement](https://msdn.microsoft.com/library/bb340098)  
    An XML element that contains a set of sequential tasks that define a job.  

<!-- end list -->

  - sharedProperties  
    Type: [System.Collections.Generic.ICollection](https://msdn.microsoft.com/library/92t2ye13)\< (Of \< ( \<'[XElement](https://msdn.microsoft.com/library/bb340098)\> ) \> ) \>  
    A collection of shared properties that can be supplied for a job.  

<!-- end list -->

  - inputFileName  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The name of the input file that triggered the job.  

<!-- end list -->

  - instanceId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The ID of the manifest for the job instance.  

### Return Value

Type: [Microsoft.Web.Media.TransformManager.JobManifest](jobmanifest-class-microsoft-web-media-transformmanager.md)  
An object that contains job instance metadata.  

## See Also

### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

