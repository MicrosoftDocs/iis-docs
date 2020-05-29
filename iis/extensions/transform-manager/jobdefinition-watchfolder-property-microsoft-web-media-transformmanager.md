---
title: JobDefinition.WatchFolder Property (Microsoft.Web.Media.TransformManager)
TOCTitle: WatchFolder Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.WatchFolder
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobdefinition.watchfolder(v=VS.90)
ms:contentKeyID: 35520886
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.WatchFolder
- Microsoft.Web.Media.TransformManager.JobDefinition.set_WatchFolder
- Microsoft.Web.Media.TransformManager.JobDefinition.get_WatchFolder
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_WatchFolder
- Microsoft.Web.Media.TransformManager.JobDefinition.set_WatchFolder
- Microsoft.Web.Media.TransformManager.JobDefinition.WatchFolder
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# WatchFolder Property

Gets or sets a file system folder that will be watched for files that will instantiate jobs.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property WatchFolder As String
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As String

value = instance.WatchFolder

instance.WatchFolder = value
```

```csharp
[DataMemberAttribute]
public string WatchFolder { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ WatchFolder {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member WatchFolder : string with get, set
```

```jscript
  function get WatchFolder () : String
function set WatchFolder (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The folder.  

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
