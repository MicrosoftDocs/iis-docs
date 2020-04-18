---
title: JobDetails.JobName Property (Microsoft.Web.Media.TransformManager)
TOCTitle: JobName Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDetails.JobName
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobdetails.jobname(v=VS.90)
ms:contentKeyID: 35521195
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.get_JobName
- Microsoft.Web.Media.TransformManager.JobDetails.set_JobName
- Microsoft.Web.Media.TransformManager.JobDetails.JobName
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.get_JobName
- Microsoft.Web.Media.TransformManager.JobDetails.JobName
- Microsoft.Web.Media.TransformManager.JobDetails.set_JobName
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# JobName Property

Gets or set the name of this job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property JobName As String
    Get
    Set
'Usage

  Dim instance As JobDetails
Dim value As String

value = instance.JobName

instance.JobName = value
```

```csharp
[DataMemberAttribute]
public string JobName { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ JobName {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member JobName : string with get, set
```

```jscript
  function get JobName () : String
function set JobName (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The name of this job.  

## See Also

### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
