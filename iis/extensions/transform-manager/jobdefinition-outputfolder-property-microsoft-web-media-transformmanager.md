---
title: JobDefinition.OutputFolder Property (Microsoft.Web.Media.TransformManager)
TOCTitle: OutputFolder Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.OutputFolder
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobdefinition.outputfolder(v=VS.90)
ms:contentKeyID: 35520569
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.OutputFolder
- Microsoft.Web.Media.TransformManager.JobDefinition.set_OutputFolder
- Microsoft.Web.Media.TransformManager.JobDefinition.get_OutputFolder
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_OutputFolder
- Microsoft.Web.Media.TransformManager.JobDefinition.set_OutputFolder
- Microsoft.Web.Media.TransformManager.JobDefinition.OutputFolder
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# OutputFolder Property

Gets or sets the output folder for a job. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property OutputFolder As String
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As String

value = instance.OutputFolder

instance.OutputFolder = value
```

```csharp
[DataMemberAttribute]
public string OutputFolder { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ OutputFolder {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member OutputFolder : string with get, set
```

```jscript
  function get OutputFolder () : String
function set OutputFolder (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The output folder for a job.  

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
