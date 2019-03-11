---
title: JobDetails.LogFolder Property (Microsoft.Web.Media.TransformManager)
TOCTitle: LogFolder Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDetails.LogFolder
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdetails.logfolder(v=VS.90)
ms:contentKeyID: 36868653
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.get_LogFolder
- Microsoft.Web.Media.TransformManager.JobDetails.LogFolder
- Microsoft.Web.Media.TransformManager.JobDetails.set_LogFolder
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.get_LogFolder
- Microsoft.Web.Media.TransformManager.JobDetails.LogFolder
- Microsoft.Web.Media.TransformManager.JobDetails.set_LogFolder
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# LogFolder Property

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property LogFolder As String
    Get
    Set
'Usage

  Dim instance As JobDetails
Dim value As String

value = instance.LogFolder

instance.LogFolder = value
```

```csharp
[DataMemberAttribute]
public string LogFolder { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ LogFolder {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member LogFolder : string with get, set
```

```jscript
  function get LogFolder () : String
function set LogFolder (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  

## See Also

### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

