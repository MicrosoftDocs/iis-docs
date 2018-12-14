---
title: ITaskStatus.PercentComplete Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: PercentComplete Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ITaskStatus.PercentComplete
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.itaskstatus.percentcomplete(v=VS.90)
ms:contentKeyID: 35520974
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ITaskStatus.PercentComplete
- Microsoft.Web.Media.TransformManager.ITaskStatus.get_PercentComplete
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ITaskStatus.get_PercentComplete
- Microsoft.Web.Media.TransformManager.ITaskStatus.PercentComplete
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# PercentComplete Property

Gets the percentage of task completion.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

``` vb
'Declaration
ReadOnlyPropertyPercentCompleteAsIntegerGet
'Usage
DiminstanceAsITaskStatusDimvalueAsIntegervalue = instance.PercentComplete
```

``` csharp
intPercentComplete { get; }
```

``` c++
propertyintPercentComplete {
    intget ();
}
```

``` fsharp
abstractPercentComplete : int
```

``` jscript
function getPercentComplete () : int
```

#### Property Value

Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
The percentage completed.  

## Remarks

The percentage can be used to report progress in the UI.

## See Also

#### Reference

[ITaskStatus Interface](itaskstatus-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

