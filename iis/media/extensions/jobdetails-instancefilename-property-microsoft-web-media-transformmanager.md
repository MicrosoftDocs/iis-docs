---
title: JobDetails.InstanceFileName Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: InstanceFileName Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDetails.InstanceFileName
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdetails.instancefilename(v=VS.90)
ms:contentKeyID: 35520557
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.InstanceFileName
- Microsoft.Web.Media.TransformManager.JobDetails.get_InstanceFileName
- Microsoft.Web.Media.TransformManager.JobDetails.set_InstanceFileName
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.get_InstanceFileName
- Microsoft.Web.Media.TransformManager.JobDetails.InstanceFileName
- Microsoft.Web.Media.TransformManager.JobDetails.set_InstanceFileName
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# InstanceFileName Property

Gets or sets the name of the file that matched the file watcher filter and that instantiated the job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyInstanceFileNameAsStringGetSet
'Usage
DiminstanceAsJobDetailsDimvalueAsStringvalue = instance.InstanceFileName

instance.InstanceFileName = value
```

``` csharp
[DataMemberAttribute]
publicstringInstanceFileName { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ InstanceFileName {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberInstanceFileName : stringwithget, set
```

``` jscript
function getInstanceFileName () : Stringfunction setInstanceFileName (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The name of the file that matched the file watcher filter and instantiated the job.  

## See Also

#### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

