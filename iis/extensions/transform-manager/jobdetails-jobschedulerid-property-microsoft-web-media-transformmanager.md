---
title: JobDetails.JobSchedulerId Property (Microsoft.Web.Media.TransformManager)
TOCTitle: JobSchedulerId Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDetails.JobSchedulerId
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdetails.jobschedulerid(v=VS.90)
ms:contentKeyID: 35521043
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.set_JobSchedulerId
- Microsoft.Web.Media.TransformManager.JobDetails.get_JobSchedulerId
- Microsoft.Web.Media.TransformManager.JobDetails.JobSchedulerId
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.get_JobSchedulerId
- Microsoft.Web.Media.TransformManager.JobDetails.JobSchedulerId
- Microsoft.Web.Media.TransformManager.JobDetails.set_JobSchedulerId
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# JobSchedulerId Property

Gets or sets the ID of the [JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md) object that runs this job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property JobSchedulerId As String
    Get
    Set
'Usage

  Dim instance As JobDetails
Dim value As String

value = instance.JobSchedulerId

instance.JobSchedulerId = value
```

```csharp
[DataMemberAttribute]
public string JobSchedulerId { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ JobSchedulerId {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member JobSchedulerId : string with get, set
```

```jscript
  function get JobSchedulerId () : String
function set JobSchedulerId (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The ID of the job scheduler that runs this job.  

## See Also

### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

