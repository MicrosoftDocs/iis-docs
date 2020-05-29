---
title: JobDetails.JobDefinitionName Property (Microsoft.Web.Media.TransformManager)
TOCTitle: JobDefinitionName Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDetails.JobDefinitionName
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobdetails.jobdefinitionname(v=VS.90)
ms:contentKeyID: 35520610
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.JobDefinitionName
- Microsoft.Web.Media.TransformManager.JobDetails.set_JobDefinitionName
- Microsoft.Web.Media.TransformManager.JobDetails.get_JobDefinitionName
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.get_JobDefinitionName
- Microsoft.Web.Media.TransformManager.JobDetails.JobDefinitionName
- Microsoft.Web.Media.TransformManager.JobDetails.set_JobDefinitionName
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# JobDefinitionName Property

Gets or sets the name of the [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object that created this job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property JobDefinitionName As String
    Get
    Set
'Usage

  Dim instance As JobDetails
Dim value As String

value = instance.JobDefinitionName

instance.JobDefinitionName = value
```

```csharp
[DataMemberAttribute]
public string JobDefinitionName { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ JobDefinitionName {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member JobDefinitionName : string with get, set
```

```jscript
  function get JobDefinitionName () : String
function set JobDefinitionName (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The name of the job definition that created this job.  

## See Also

### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
