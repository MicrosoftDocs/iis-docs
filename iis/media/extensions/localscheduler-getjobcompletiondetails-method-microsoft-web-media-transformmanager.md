---
title: LocalScheduler.GetJobCompletionDetails Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetJobCompletionDetails Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.LocalScheduler.GetJobCompletionDetails(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.localscheduler.getjobcompletiondetails(v=VS.90)
ms:contentKeyID: 35520656
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.LocalScheduler.GetJobCompletionDetails
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.LocalScheduler.GetJobCompletionDetails
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetJobCompletionDetails Method

Returns a report about the specified job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicOverridesFunctionGetJobCompletionDetails ( _
    jobInstanceIdAsString _
) AsXElement
'Usage
DiminstanceAsLocalSchedulerDimjobInstanceIdAsStringDimreturnValueAsXElementreturnValue = instance.GetJobCompletionDetails(jobInstanceId)
```

``` csharp
publicoverrideXElementGetJobCompletionDetails(
    stringjobInstanceId
)
```

``` c++
public:
virtualXElement^ GetJobCompletionDetails(
    String^ jobInstanceId
) override
```

``` fsharp
abstractGetJobCompletionDetails : 
        jobInstanceId:string->XElementoverrideGetJobCompletionDetails : 
        jobInstanceId:string->XElement
```

``` jscript
publicoverridefunctionGetJobCompletionDetails(
    jobInstanceId : String
) : XElement
```

#### Parameters

  - jobInstanceId  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The ID of the job.  

#### Return Value

Type: [System.Xml.Linq. . :: . .XElement](https://msdn.microsoft.com/en-us/library/bb340098\(v=vs.90\))  
An XML element that contains a report about the job instance.  

## See Also

#### Reference

[LocalScheduler Class](localscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

