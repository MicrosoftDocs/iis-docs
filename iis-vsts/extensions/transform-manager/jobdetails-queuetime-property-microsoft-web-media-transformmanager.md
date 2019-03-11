---
title: JobDetails.QueueTime Property (Microsoft.Web.Media.TransformManager)
TOCTitle: QueueTime Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDetails.QueueTime
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdetails.queuetime(v=VS.90)
ms:contentKeyID: 35520722
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.set_QueueTime
- Microsoft.Web.Media.TransformManager.JobDetails.QueueTime
- Microsoft.Web.Media.TransformManager.JobDetails.get_QueueTime
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.get_QueueTime
- Microsoft.Web.Media.TransformManager.JobDetails.QueueTime
- Microsoft.Web.Media.TransformManager.JobDetails.set_QueueTime
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# QueueTime Property

Gets or sets the date and time when the job was added to the work queue.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property QueueTime As DateTime
    Get
    Set
'Usage

  Dim instance As JobDetails
Dim value As DateTime

value = instance.QueueTime

instance.QueueTime = value
```

```csharp
[DataMemberAttribute]
public DateTime QueueTime { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property DateTime QueueTime {
    DateTime get ();
    void set (DateTime value);
}
```

``` fsharp
[<DataMemberAttribute>]
member QueueTime : DateTime with get, set
```

```jscript
  function get QueueTime () : DateTime
function set QueueTime (value : DateTime)
```

### Property Value

Type: [System.DateTime](https://msdn.microsoft.com/library/03ybds8y)  
The date and time when the job was added to the work queue.  

## See Also

### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

