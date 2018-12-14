---
title: JobDefinition.JobManagerLogLevel Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: JobManagerLogLevel Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.JobManagerLogLevel
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.jobmanagerloglevel(v=VS.90)
ms:contentKeyID: 35521115
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.JobManagerLogLevel
- Microsoft.Web.Media.TransformManager.JobDefinition.get_JobManagerLogLevel
- Microsoft.Web.Media.TransformManager.JobDefinition.set_JobManagerLogLevel
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_JobManagerLogLevel
- Microsoft.Web.Media.TransformManager.JobDefinition.JobManagerLogLevel
- Microsoft.Web.Media.TransformManager.JobDefinition.set_JobManagerLogLevel
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# JobManagerLogLevel Property

Gets or sets the threshold value of log entries that are written to the job manager log.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyJobManagerLogLevelAsLogLevelGetSet
'Usage
DiminstanceAsJobDefinitionDimvalueAsLogLevelvalue = instance.JobManagerLogLevel

instance.JobManagerLogLevel = value
```

``` csharp
[DataMemberAttribute]
publicLogLevelJobManagerLogLevel { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyLogLevelJobManagerLogLevel {
    LogLevelget ();
    voidset (LogLevelvalue);
}
```

``` fsharp
[<DataMemberAttribute>]
memberJobManagerLogLevel : LogLevelwithget, set
```

``` jscript
function getJobManagerLogLevel () : LogLevelfunction setJobManagerLogLevel (value : LogLevel)
```

#### Property Value

Type: [Microsoft.Web.Media.TransformManager. . :: . .LogLevel](loglevel-enumeration-microsoft-web-media-transformmanager.md)  
A [LogLevel](loglevel-enumeration-microsoft-web-media-transformmanager.md) object that includes a threshold value.  

## See Also

#### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

