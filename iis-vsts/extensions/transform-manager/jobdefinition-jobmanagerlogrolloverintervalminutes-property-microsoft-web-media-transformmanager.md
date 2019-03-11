---
title: JobDefinition.JobManagerLogRolloverIntervalMinutes Property (Microsoft.Web.Media.TransformManager)
TOCTitle: JobManagerLogRolloverIntervalMinutes Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.JobManagerLogRolloverIntervalMinutes
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.jobmanagerlogrolloverintervalminutes(v=VS.90)
ms:contentKeyID: 35568109
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_JobManagerLogRolloverIntervalMinutes
- Microsoft.Web.Media.TransformManager.JobDefinition.JobManagerLogRolloverIntervalMinutes
- Microsoft.Web.Media.TransformManager.JobDefinition.set_JobManagerLogRolloverIntervalMinutes
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_JobManagerLogRolloverIntervalMinutes
- Microsoft.Web.Media.TransformManager.JobDefinition.JobManagerLogRolloverIntervalMinutes
- Microsoft.Web.Media.TransformManager.JobDefinition.set_JobManagerLogRolloverIntervalMinutes
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# JobManagerLogRolloverIntervalMinutes Property

Gets or sets the number of minutes of log data to collect before a new log file is created.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property JobManagerLogRolloverIntervalMinutes As Integer
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As Integer

value = instance.JobManagerLogRolloverIntervalMinutes

instance.JobManagerLogRolloverIntervalMinutes = value
```

```csharp
[DataMemberAttribute]
public int JobManagerLogRolloverIntervalMinutes { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property int JobManagerLogRolloverIntervalMinutes {
    int get ();
    void set (int value);
}
```

``` fsharp
[<DataMemberAttribute>]
member JobManagerLogRolloverIntervalMinutes : int with get, set
```

```jscript
  function get JobManagerLogRolloverIntervalMinutes () : int
function set JobManagerLogRolloverIntervalMinutes (value : int)
```

### Property Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
The number of minutes of log data to collect before a new log file is created.  

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

