---
title: JobDefinition.AssetRetentionPeriodMinutes Property (Microsoft.Web.Media.TransformManager)
TOCTitle: AssetRetentionPeriodMinutes Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.AssetRetentionPeriodMinutes
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.assetretentionperiodminutes(v=VS.90)
ms:contentKeyID: 35520839
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.set_AssetRetentionPeriodMinutes
- Microsoft.Web.Media.TransformManager.JobDefinition.AssetRetentionPeriodMinutes
- Microsoft.Web.Media.TransformManager.JobDefinition.get_AssetRetentionPeriodMinutes
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.AssetRetentionPeriodMinutes
- Microsoft.Web.Media.TransformManager.JobDefinition.get_AssetRetentionPeriodMinutes
- Microsoft.Web.Media.TransformManager.JobDefinition.set_AssetRetentionPeriodMinutes
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# AssetRetentionPeriodMinutes Property

Gets or sets the number of minutes that the asset files that are associated with a job are retained after they are selected for deletion during maintenance.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property AssetRetentionPeriodMinutes As Integer
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As Integer

value = instance.AssetRetentionPeriodMinutes

instance.AssetRetentionPeriodMinutes = value
```

```csharp
[DataMemberAttribute]
public int AssetRetentionPeriodMinutes { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property int AssetRetentionPeriodMinutes {
    int get ();
    void set (int value);
}
```

``` fsharp
[<DataMemberAttribute>]
member AssetRetentionPeriodMinutes : int with get, set
```

```jscript
  function get AssetRetentionPeriodMinutes () : int
function set AssetRetentionPeriodMinutes (value : int)
```

### Property Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
The number of minutes to keep asset files.  

## Remarks

Assets for canceled, failed, and finished jobs are controlled independently by the [DeleteCanceledFiles](jobdefinition-deletecanceledfiles-property-microsoft-web-media-transformmanager.md), [DeleteFailedFiles](jobdefinition-deletefailedfiles-property-microsoft-web-media-transformmanager.md), and [DeleteFinishedFiles](jobdefinition-deletefinishedfiles-property-microsoft-web-media-transformmanager.md) properties.

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

