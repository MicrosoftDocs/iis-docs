---
title: JobDetails.JobDefinitionId Property (Microsoft.Web.Media.TransformManager)
TOCTitle: JobDefinitionId Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDetails.JobDefinitionId
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdetails.jobdefinitionid(v=VS.90)
ms:contentKeyID: 35521089
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.get_JobDefinitionId
- Microsoft.Web.Media.TransformManager.JobDetails.set_JobDefinitionId
- Microsoft.Web.Media.TransformManager.JobDetails.JobDefinitionId
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.get_JobDefinitionId
- Microsoft.Web.Media.TransformManager.JobDetails.JobDefinitionId
- Microsoft.Web.Media.TransformManager.JobDetails.set_JobDefinitionId
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# JobDefinitionId Property

Gets or sets the ID of the [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object that created this job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property JobDefinitionId As String
    Get
    Set
'Usage

  Dim instance As JobDetails
Dim value As String

value = instance.JobDefinitionId

instance.JobDefinitionId = value
```

```csharp
[DataMemberAttribute]
public string JobDefinitionId { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ JobDefinitionId {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member JobDefinitionId : string with get, set
```

```jscript
  function get JobDefinitionId () : String
function set JobDefinitionId (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The ID of the job definition that created this job.  

## See Also

### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

