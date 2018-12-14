---
title: JobDetails.JobDefinitionId Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: JobDefinitionId Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDetails.JobDefinitionId
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdetails.jobdefinitionid(v=VS.90)
ms:contentKeyID: 35521089
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.get_JobDefinitionId
- Microsoft.Web.Media.TransformManager.JobDetails.set_JobDefinitionId
- Microsoft.Web.Media.TransformManager.JobDetails.JobDefinitionId
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.get_JobDefinitionId
- Microsoft.Web.Media.TransformManager.JobDetails.JobDefinitionId
- Microsoft.Web.Media.TransformManager.JobDetails.set_JobDefinitionId
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# JobDefinitionId Property

Gets or sets the ID of the [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object that created this job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyJobDefinitionIdAsStringGetSet
'Usage
DiminstanceAsJobDetailsDimvalueAsStringvalue = instance.JobDefinitionId

instance.JobDefinitionId = value
```

``` csharp
[DataMemberAttribute]
publicstringJobDefinitionId { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ JobDefinitionId {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberJobDefinitionId : stringwithget, set
```

``` jscript
function getJobDefinitionId () : Stringfunction setJobDefinitionId (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The ID of the job definition that created this job.  

## See Also

#### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

