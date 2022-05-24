---
title: JobDetails.StartTime Property (Microsoft.Web.Media.TransformManager)
TOCTitle: StartTime Property
description: "The JobDetails.StartTime property gets or sets the date and time when the job was started by the scheduler."
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDetails.StartTime
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobdetails.starttime(v=VS.90)
ms:contentKeyID: 35520726
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.get_StartTime
- Microsoft.Web.Media.TransformManager.JobDetails.set_StartTime
- Microsoft.Web.Media.TransformManager.JobDetails.StartTime
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.get_StartTime
- Microsoft.Web.Media.TransformManager.JobDetails.set_StartTime
- Microsoft.Web.Media.TransformManager.JobDetails.StartTime
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# StartTime Property

Gets or sets the date and time when the job was started by the scheduler.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property StartTime As DateTime
    Get
    Set
'Usage

  Dim instance As JobDetails
Dim value As DateTime

value = instance.StartTime

instance.StartTime = value
```

```csharp
[DataMemberAttribute]
public DateTime StartTime { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property DateTime StartTime {
    DateTime get ();
    void set (DateTime value);
}
```

``` fsharp
[<DataMemberAttribute>]
member StartTime : DateTime with get, set
```

```jscript
  function get StartTime () : DateTime
function set StartTime (value : DateTime)
```

### Property Value

Type: [System.DateTime](https://msdn.microsoft.com/library/03ybds8y)  
The date and time when the job was started by the scheduler.  

## See Also

### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
