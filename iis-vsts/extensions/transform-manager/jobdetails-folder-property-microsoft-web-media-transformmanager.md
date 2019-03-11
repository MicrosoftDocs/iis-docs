---
title: JobDetails.Folder Property (Microsoft.Web.Media.TransformManager)
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
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.Folder
- Microsoft.Web.Media.TransformManager.JobDetails.get_Folder
- Microsoft.Web.Media.TransformManager.JobDetails.set_Folder
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Folder Property

Gets or sets the root folder of the [JobManager](jobmanager-class-microsoft-web-media-transformmanager.md) object that is processing the job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property Folder As String
    Get
    Set
'Usage

  Dim instance As JobDetails
Dim value As String

value = instance.Folder

instance.Folder = value
```

```csharp
[DataMemberAttribute]
public string Folder { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ Folder {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member Folder : string with get, set
```

```jscript
  function get Folder () : String
function set Folder (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The root folder of the job manager that is processing the job.  

## See Also

### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

