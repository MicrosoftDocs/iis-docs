---
title: JobDefinition.DeleteFailedFiles Property (Microsoft.Web.Media.TransformManager)
TOCTitle: DeleteFailedFiles Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.DeleteFailedFiles
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.deletefailedfiles(v=VS.90)
ms:contentKeyID: 35520592
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.set_DeleteFailedFiles
- Microsoft.Web.Media.TransformManager.JobDefinition.get_DeleteFailedFiles
- Microsoft.Web.Media.TransformManager.JobDefinition.DeleteFailedFiles
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.DeleteFailedFiles
- Microsoft.Web.Media.TransformManager.JobDefinition.set_DeleteFailedFiles
- Microsoft.Web.Media.TransformManager.JobDefinition.get_DeleteFailedFiles
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeleteFailedFiles Property

Gets or sets a value that indicates whether asset files for failed jobs should be deleted during the maintenance cycle.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property DeleteFailedFiles As Boolean
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As Boolean

value = instance.DeleteFailedFiles

instance.DeleteFailedFiles = value
```

```csharp
[DataMemberAttribute]
public bool DeleteFailedFiles { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property bool DeleteFailedFiles {
    bool get ();
    void set (bool value);
}
```

``` fsharp
[<DataMemberAttribute>]
member DeleteFailedFiles : bool with get, set
```

```jscript
  function get DeleteFailedFiles () : boolean
function set DeleteFailedFiles (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
true if the asset files for failed jobs are deleted, or false if the asset files for failed jobs are retained.  

## Remarks

The [AssetRetentionPeriodMinutes](jobdefinition-assetretentionperiodminutes-property-microsoft-web-media-transformmanager.md) property is used to determine when the asset files for failed jobs should be deleted.

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

