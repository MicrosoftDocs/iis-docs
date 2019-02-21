---
title: JobDefinition.EnforceFileNameCase Property (Microsoft.Web.Media.TransformManager)
TOCTitle: EnforceFileNameCase Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.EnforceFileNameCase
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.enforcefilenamecase(v=VS.90)
ms:contentKeyID: 35520657
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.set_EnforceFileNameCase
- Microsoft.Web.Media.TransformManager.JobDefinition.get_EnforceFileNameCase
- Microsoft.Web.Media.TransformManager.JobDefinition.EnforceFileNameCase
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.EnforceFileNameCase
- Microsoft.Web.Media.TransformManager.JobDefinition.set_EnforceFileNameCase
- Microsoft.Web.Media.TransformManager.JobDefinition.get_EnforceFileNameCase
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# EnforceFileNameCase Property

Gets or sets a value that indicates whether the file names referenced in the manifest must match in case.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property EnforceFileNameCase As Boolean
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As Boolean

value = instance.EnforceFileNameCase

instance.EnforceFileNameCase = value
```

```csharp
[DataMemberAttribute]
public bool EnforceFileNameCase { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property bool EnforceFileNameCase {
    bool get ();
    void set (bool value);
}
```

``` fsharp
[<DataMemberAttribute>]
member EnforceFileNameCase : bool with get, set
```

```jscript
  function get EnforceFileNameCase () : boolean
function set EnforceFileNameCase (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
true if the file names named in the manifest must match in case; otherwise, false.  

## Remarks

If the input file that triggers job creation is a SMIL-compliant manifest, it contains a list of media files for a job. If the EnforceFileNameCase property is set to true and if the name of a file referenced in the manifest is written to the watch folder but does not match the case of the actual file name, a warning is written to the log file and the job is moved to a rejected job folder.

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

