---
title: JobDetails.JobTemplateName Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: JobTemplateName Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDetails.JobTemplateName
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdetails.jobtemplatename(v=VS.90)
ms:contentKeyID: 35520640
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.get_JobTemplateName
- Microsoft.Web.Media.TransformManager.JobDetails.set_JobTemplateName
- Microsoft.Web.Media.TransformManager.JobDetails.JobTemplateName
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.get_JobTemplateName
- Microsoft.Web.Media.TransformManager.JobDetails.JobTemplateName
- Microsoft.Web.Media.TransformManager.JobDetails.set_JobTemplateName
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# JobTemplateName Property

Gets or sets the name of the job template that defines the tasks for this job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyJobTemplateNameAsStringGetSet
'Usage
DiminstanceAsJobDetailsDimvalueAsStringvalue = instance.JobTemplateName

instance.JobTemplateName = value
```

``` csharp
[DataMemberAttribute]
publicstringJobTemplateName { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ JobTemplateName {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberJobTemplateName : stringwithget, set
```

``` jscript
function getJobTemplateName () : Stringfunction setJobTemplateName (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The name of the job template that defines the tasks for this job.  

## See Also

#### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

