---
title: JobDetails.Progress Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Progress Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDetails.Progress
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdetails.progress(v=VS.90)
ms:contentKeyID: 35520799
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.set_Progress
- Microsoft.Web.Media.TransformManager.JobDetails.get_Progress
- Microsoft.Web.Media.TransformManager.JobDetails.Progress
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.get_Progress
- Microsoft.Web.Media.TransformManager.JobDetails.Progress
- Microsoft.Web.Media.TransformManager.JobDetails.set_Progress
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# Progress Property

Gets or sets the percentage complete of the job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property Progress As Integer
    Get
    Set
'Usage

  Dim instance As JobDetails
Dim value As Integer

value = instance.Progress

instance.Progress = value
```

```csharp
[DataMemberAttribute]
public int Progress { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property int Progress {
    int get ();
    void set (int value);
}
```

``` fsharp
[<DataMemberAttribute>]
member Progress : int with get, set
```

```jscript
  function get Progress () : int
function set Progress (value : int)
```

### Property Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
The percentage complete.  

## See Also

### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

