---
title: JobDefinition.MaintenanceIntervalMinutes Property (Microsoft.Web.Media.TransformManager)
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
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_MaintenanceIntervalMinutes
- Microsoft.Web.Media.TransformManager.JobDefinition.set_MaintenanceIntervalMinutes
- Microsoft.Web.Media.TransformManager.JobDefinition.MaintenanceIntervalMinutes
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# MaintenanceIntervalMinutes Property

Gets or sets the number of minutes between maintenance-processing activities.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property MaintenanceIntervalMinutes As Integer
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As Integer

value = instance.MaintenanceIntervalMinutes

instance.MaintenanceIntervalMinutes = value
```

```csharp
[DataMemberAttribute]
public int MaintenanceIntervalMinutes { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property int MaintenanceIntervalMinutes {
    int get ();
    void set (int value);
}
```

``` fsharp
[<DataMemberAttribute>]
member MaintenanceIntervalMinutes : int with get, set
```

```jscript
  function get MaintenanceIntervalMinutes () : int
function set MaintenanceIntervalMinutes (value : int)
```

### Property Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
The number of minutes.  

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

