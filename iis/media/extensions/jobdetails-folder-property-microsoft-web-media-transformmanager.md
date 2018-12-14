---
title: JobDetails.Folder Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: Folder Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDetails.Folder
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdetails.folder(v=VS.90)
ms:contentKeyID: 35520717
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.set_Folder
- Microsoft.Web.Media.TransformManager.JobDetails.Folder
- Microsoft.Web.Media.TransformManager.JobDetails.get_Folder
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.Folder
- Microsoft.Web.Media.TransformManager.JobDetails.get_Folder
- Microsoft.Web.Media.TransformManager.JobDetails.set_Folder
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Folder Property

Gets or sets the root folder of the [JobManager](jobmanager-class-microsoft-web-media-transformmanager.md) object that is processing the job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyFolderAsStringGetSet
'Usage
DiminstanceAsJobDetailsDimvalueAsStringvalue = instance.Folder

instance.Folder = value
```

``` csharp
[DataMemberAttribute]
publicstringFolder { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ Folder {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberFolder : stringwithget, set
```

``` jscript
function getFolder () : Stringfunction setFolder (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The root folder of the job manager that is processing the job.  

## See Also

#### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

