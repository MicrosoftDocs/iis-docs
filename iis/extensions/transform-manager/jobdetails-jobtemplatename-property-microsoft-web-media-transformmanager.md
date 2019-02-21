---
title: JobDetails.JobTemplateName Property (Microsoft.Web.Media.TransformManager)
TOCTitle: JobTemplateName Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDetails.JobTemplateName
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdetails.jobtemplatename(v=VS.90)
ms:contentKeyID: 35520640
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDetails.get_JobTemplateName
- Microsoft.Web.Media.TransformManager.JobDetails.set_JobTemplateName
- Microsoft.Web.Media.TransformManager.JobDetails.JobTemplateName
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDetails.get_JobTemplateName
- Microsoft.Web.Media.TransformManager.JobDetails.JobTemplateName
- Microsoft.Web.Media.TransformManager.JobDetails.set_JobTemplateName
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# JobTemplateName Property

Gets or sets the name of the job template that defines the tasks for this job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property JobTemplateName As String
    Get
    Set
'Usage

  Dim instance As JobDetails
Dim value As String

value = instance.JobTemplateName

instance.JobTemplateName = value
```

```csharp
[DataMemberAttribute]
public string JobTemplateName { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ JobTemplateName {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member JobTemplateName : string with get, set
```

```jscript
  function get JobTemplateName () : String
function set JobTemplateName (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The name of the job template that defines the tasks for this job.  

## See Also

### Reference

[JobDetails Class](jobdetails-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

