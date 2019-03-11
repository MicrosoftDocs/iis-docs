---
title: JobDetails.EndTime Property (Microsoft.Web.Media.TransformManager)
TOCTitle: EndTime Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDetails.EndTime
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdetails.endtime(v=VS.90)
ms:contentKeyID: 35521093
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.get_EndTime
- Microsoft.Web.Media.TransformManager.JobDetails.EndTime
- Microsoft.Web.Media.TransformManager.JobDetails.set_EndTime
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.EndTime
- Microsoft.Web.Media.TransformManager.JobDetails.get_EndTime
- Microsoft.Web.Media.TransformManager.JobDetails.set_EndTime
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# EndTime Property

Gets or sets the time when the job ended.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property EndTime As DateTime
    Get
    Set
'Usage

  Dim instance As JobDetails
Dim value As DateTime

value = instance.EndTime

instance.EndTime = value
```

```csharp
[DataMemberAttribute]
public DateTime EndTime { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property DateTime EndTime {
    DateTime get ();
    void set (DateTime value);
}
```

``` fsharp
[<DataMemberAttribute>]
member EndTime : DateTime with get, set
```

```jscript
  function get EndTime () : DateTime
function set EndTime (value : DateTime)
```

### Property Value

Type: [System.DateTime](https://msdn.microsoft.com/library/03ybds8y)  
The time when the job ended.  

## See Also

### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

