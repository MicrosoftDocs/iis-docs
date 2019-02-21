---
title: JobDefinition.WorkFolder Property (Microsoft.Web.Media.TransformManager)
TOCTitle: WorkFolder Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.WorkFolder
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.workfolder(v=VS.90)
ms:contentKeyID: 46408745
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_WorkFolder
- Microsoft.Web.Media.TransformManager.JobDefinition.set_WorkFolder
- Microsoft.Web.Media.TransformManager.JobDefinition.WorkFolder
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.WorkFolder
- Microsoft.Web.Media.TransformManager.JobDefinition.set_WorkFolder
- Microsoft.Web.Media.TransformManager.JobDefinition.get_WorkFolder
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# WorkFolder Property

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property WorkFolder As String
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As String

value = instance.WorkFolder

instance.WorkFolder = value
```

```csharp
[DataMemberAttribute]
public string WorkFolder { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ WorkFolder {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member WorkFolder : string with get, set
```

```jscript
  function get WorkFolder () : String
function set WorkFolder (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

