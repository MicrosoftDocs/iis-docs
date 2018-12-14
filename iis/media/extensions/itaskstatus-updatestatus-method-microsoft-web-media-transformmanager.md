---
title: ITaskStatus.UpdateStatus Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: UpdateStatus Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.ITaskStatus.UpdateStatus(System.Int32,Microsoft.Web.Media.TransformManager.JobStatus,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.itaskstatus.updatestatus(v=VS.90)
ms:contentKeyID: 35521141
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ITaskStatus.UpdateStatus
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ITaskStatus.UpdateStatus
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# UpdateStatus Method

Updates the status of an ongoing task.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

``` vb
'Declaration
SubUpdateStatus ( _
    percentCompleteAsInteger, _
    statusAsJobStatus, _
    messageAsString _
)
'Usage
DiminstanceAsITaskStatusDimpercentCompleteAsIntegerDimstatusAsJobStatusDimmessageAsString

instance.UpdateStatus(percentComplete, _
    status, message)
```

``` csharp
voidUpdateStatus(
    intpercentComplete,
    JobStatusstatus,
    stringmessage
)
```

``` c++
voidUpdateStatus(
    intpercentComplete, 
    JobStatusstatus, 
    String^ message
)
```

``` fsharp
abstractUpdateStatus : 
        percentComplete:int * 
        status:JobStatus * 
        message:string->unit
```

``` jscript
functionUpdateStatus(
    percentComplete : int, 
    status : JobStatus, 
    message : String
)
```

#### Parameters

  - percentComplete  
    Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
    The percentage completed of the task.  

<!-- end list -->

  - status  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)  
    The task status.  

<!-- end list -->

  - message  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    A message to include in the status update.  

## See Also

#### Reference

[ITaskStatus Interface](itaskstatus-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

