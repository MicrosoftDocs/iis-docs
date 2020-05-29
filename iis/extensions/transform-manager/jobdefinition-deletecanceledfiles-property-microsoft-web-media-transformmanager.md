---
title: JobDefinition.DeleteCanceledFiles Property (Microsoft.Web.Media.TransformManager)
TOCTitle: DeleteCanceledFiles Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.DeleteCanceledFiles
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobdefinition.deletecanceledfiles(v=VS.90)
ms:contentKeyID: 35521083
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.set_DeleteCanceledFiles
- Microsoft.Web.Media.TransformManager.JobDefinition.get_DeleteCanceledFiles
- Microsoft.Web.Media.TransformManager.JobDefinition.DeleteCanceledFiles
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.DeleteCanceledFiles
- Microsoft.Web.Media.TransformManager.JobDefinition.get_DeleteCanceledFiles
- Microsoft.Web.Media.TransformManager.JobDefinition.set_DeleteCanceledFiles
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# DeleteCanceledFiles Property

Gets or sets a value that indicates whether asset files for canceled jobs should be deleted during the maintenance cycle.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property DeleteCanceledFiles As Boolean
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As Boolean

value = instance.DeleteCanceledFiles

instance.DeleteCanceledFiles = value
```

```csharp
[DataMemberAttribute]
public bool DeleteCanceledFiles { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property bool DeleteCanceledFiles {
    bool get ();
    void set (bool value);
}
```

``` fsharp
[<DataMemberAttribute>]
member DeleteCanceledFiles : bool with get, set
```

```jscript
  function get DeleteCanceledFiles () : boolean
function set DeleteCanceledFiles (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
true if the asset files for canceled jobs are deleted, or false if the asset files for canceled jobs are retained.  

## Remarks

The [AssetRetentionPeriodMinutes](jobdefinition-assetretentionperiodminutes-property-microsoft-web-media-transformmanager.md) property is used to determine when the asset files for canceled jobs should be deleted.

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
