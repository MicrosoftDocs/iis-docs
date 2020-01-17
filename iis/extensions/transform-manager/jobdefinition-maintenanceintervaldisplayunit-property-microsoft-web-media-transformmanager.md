---
title: JobDefinition.MaintenanceIntervalDisplayUnit Property (Microsoft.Web.Media.TransformManager)
TOCTitle: MaintenanceIntervalDisplayUnit Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.MaintenanceIntervalDisplayUnit
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobdefinition.maintenanceintervaldisplayunit(v=VS.90)
ms:contentKeyID: 35520713
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.set_MaintenanceIntervalDisplayUnit
- Microsoft.Web.Media.TransformManager.JobDefinition.get_MaintenanceIntervalDisplayUnit
- Microsoft.Web.Media.TransformManager.JobDefinition.MaintenanceIntervalDisplayUnit
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_MaintenanceIntervalDisplayUnit
- Microsoft.Web.Media.TransformManager.JobDefinition.MaintenanceIntervalDisplayUnit
- Microsoft.Web.Media.TransformManager.JobDefinition.set_MaintenanceIntervalDisplayUnit
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# MaintenanceIntervalDisplayUnit Property

Gets or sets the unit of time that is used with the [MaintenanceIntervalMinutes](jobdefinition-maintenanceintervalminutes-property-microsoft-web-media-transformmanager.md) property to indicate how often maintenance is run.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property MaintenanceIntervalDisplayUnit As String
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As String

value = instance.MaintenanceIntervalDisplayUnit

instance.MaintenanceIntervalDisplayUnit = value
```

```csharp
[DataMemberAttribute]
public string MaintenanceIntervalDisplayUnit { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ MaintenanceIntervalDisplayUnit {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member MaintenanceIntervalDisplayUnit : string with get, set
```

```jscript
  function get MaintenanceIntervalDisplayUnit () : String
function set MaintenanceIntervalDisplayUnit (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The unit of time.  

## Remarks

The MaintenanceIntervalDisplayUnit property modifies the [MaintenanceIntervalMinutes](jobdefinition-maintenanceintervalminutes-property-microsoft-web-media-transformmanager.md) property. The MaintenanceIntervalDisplayUnit property can be set to "days", "hours", or "minutes".

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

