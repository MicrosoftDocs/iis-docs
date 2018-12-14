---
title: JobDefinition.MaintenanceIntervalMinutes Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: MaintenanceIntervalMinutes Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.MaintenanceIntervalMinutes
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.maintenanceintervalminutes(v=VS.90)
ms:contentKeyID: 35520597
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_MaintenanceIntervalMinutes
- Microsoft.Web.Media.TransformManager.JobDefinition.MaintenanceIntervalMinutes
- Microsoft.Web.Media.TransformManager.JobDefinition.set_MaintenanceIntervalMinutes
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_MaintenanceIntervalMinutes
- Microsoft.Web.Media.TransformManager.JobDefinition.set_MaintenanceIntervalMinutes
- Microsoft.Web.Media.TransformManager.JobDefinition.MaintenanceIntervalMinutes
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# MaintenanceIntervalMinutes Property

Gets or sets the number of minutes between maintenance-processing activities.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyMaintenanceIntervalMinutesAsIntegerGetSet
'Usage
DiminstanceAsJobDefinitionDimvalueAsIntegervalue = instance.MaintenanceIntervalMinutes

instance.MaintenanceIntervalMinutes = value
```

``` csharp
[DataMemberAttribute]
publicintMaintenanceIntervalMinutes { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyintMaintenanceIntervalMinutes {
    intget ();
    voidset (intvalue);
}
```

``` fsharp
[<DataMemberAttribute>]
memberMaintenanceIntervalMinutes : intwithget, set
```

``` jscript
function getMaintenanceIntervalMinutes () : intfunction setMaintenanceIntervalMinutes (value : int)
```

#### Property Value

Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
The number of minutes.  

## See Also

#### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

