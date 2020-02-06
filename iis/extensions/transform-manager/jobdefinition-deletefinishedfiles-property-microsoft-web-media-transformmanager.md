---
title: JobDefinition.DeleteFinishedFiles Property (Microsoft.Web.Media.TransformManager)
TOCTitle: DeleteFinishedFiles Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.DeleteFinishedFiles
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobdefinition.deletefinishedfiles(v=VS.90)
ms:contentKeyID: 35521069
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.DeleteFinishedFiles
- Microsoft.Web.Media.TransformManager.JobDefinition.set_DeleteFinishedFiles
- Microsoft.Web.Media.TransformManager.JobDefinition.get_DeleteFinishedFiles
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.DeleteFinishedFiles
- Microsoft.Web.Media.TransformManager.JobDefinition.get_DeleteFinishedFiles
- Microsoft.Web.Media.TransformManager.JobDefinition.set_DeleteFinishedFiles
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# DeleteFinishedFiles Property

Gets or sets a value that indicates whether asset files for finished jobs should be deleted during the maintenance cycle.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property DeleteFinishedFiles As Boolean
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As Boolean

value = instance.DeleteFinishedFiles

instance.DeleteFinishedFiles = value
```

```csharp
[DataMemberAttribute]
public bool DeleteFinishedFiles { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property bool DeleteFinishedFiles {
    bool get ();
    void set (bool value);
}
```

``` fsharp
[<DataMemberAttribute>]
member DeleteFinishedFiles : bool with get, set
```

```jscript
  function get DeleteFinishedFiles () : boolean
function set DeleteFinishedFiles (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
true if the asset files for finished jobs are deleted, or false if the asset files for finished jobs are retained.  

## Remarks

The [AssetRetentionPeriodMinutes](jobdefinition-assetretentionperiodminutes-property-microsoft-web-media-transformmanager.md) property is used to determine when the asset files for finished jobs should be deleted.

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

