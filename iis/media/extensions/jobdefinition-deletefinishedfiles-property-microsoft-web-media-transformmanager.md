---
title: JobDefinition.DeleteFinishedFiles Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: DeleteFinishedFiles Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.DeleteFinishedFiles
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.deletefinishedfiles(v=VS.90)
ms:contentKeyID: 35521069
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.DeleteFinishedFiles
- Microsoft.Web.Media.TransformManager.JobDefinition.set_DeleteFinishedFiles
- Microsoft.Web.Media.TransformManager.JobDefinition.get_DeleteFinishedFiles
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.DeleteFinishedFiles
- Microsoft.Web.Media.TransformManager.JobDefinition.get_DeleteFinishedFiles
- Microsoft.Web.Media.TransformManager.JobDefinition.set_DeleteFinishedFiles
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeleteFinishedFiles Property

Gets or sets a value that indicates whether asset files for finished jobs should be deleted during the maintenance cycle.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyDeleteFinishedFilesAsBooleanGetSet
'Usage
DiminstanceAsJobDefinitionDimvalueAsBooleanvalue = instance.DeleteFinishedFiles

instance.DeleteFinishedFiles = value
```

``` csharp
[DataMemberAttribute]
publicboolDeleteFinishedFiles { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyboolDeleteFinishedFiles {
    boolget ();
    voidset (boolvalue);
}
```

``` fsharp
[<DataMemberAttribute>]
memberDeleteFinishedFiles : boolwithget, set
```

``` jscript
function getDeleteFinishedFiles () : booleanfunction setDeleteFinishedFiles (value : boolean)
```

#### Property Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
true if the asset files for finished jobs are deleted, or false if the asset files for finished jobs are retained.  

## Remarks

The [AssetRetentionPeriodMinutes](jobdefinition-assetretentionperiodminutes-property-microsoft-web-media-transformmanager.md) property is used to determine when the asset files for finished jobs should be deleted.

## See Also

#### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

