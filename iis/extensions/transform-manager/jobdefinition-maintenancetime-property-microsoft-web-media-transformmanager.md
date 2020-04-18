---
title: JobDefinition.MaintenanceTime Property (Microsoft.Web.Media.TransformManager)
TOCTitle: MaintenanceTime Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.MaintenanceTime
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobdefinition.maintenancetime(v=VS.90)
ms:contentKeyID: 35520630
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_MaintenanceTime
- Microsoft.Web.Media.TransformManager.JobDefinition.MaintenanceTime
- Microsoft.Web.Media.TransformManager.JobDefinition.set_MaintenanceTime
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_MaintenanceTime
- Microsoft.Web.Media.TransformManager.JobDefinition.MaintenanceTime
- Microsoft.Web.Media.TransformManager.JobDefinition.set_MaintenanceTime
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# MaintenanceTime Property

Gets or sets a fixed time during the day to run maintenance.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property MaintenanceTime As DateTime
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As DateTime

value = instance.MaintenanceTime

instance.MaintenanceTime = value
```

```csharp
[DataMemberAttribute]
public DateTime MaintenanceTime { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property DateTime MaintenanceTime {
    DateTime get ();
    void set (DateTime value);
}
```

``` fsharp
[<DataMemberAttribute>]
member MaintenanceTime : DateTime with get, set
```

```jscript
  function get MaintenanceTime () : DateTime
function set MaintenanceTime (value : DateTime)
```

### Property Value

Type: [System.DateTime](https://msdn.microsoft.com/library/03ybds8y)  
A fixed time during the day to run maintenance.  

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
