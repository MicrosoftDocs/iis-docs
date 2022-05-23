---
title: JobDefinition.MaintenanceUseInterval Property (Microsoft.Web.Media.TransformManager)
description: Describes the JobDefinition.MaintenanceUseInterval property and details its namespace, assembly, syntax, and property value.
TOCTitle: MaintenanceUseInterval Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.MaintenanceUseInterval
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobdefinition.maintenanceuseinterval(v=VS.90)
ms:contentKeyID: 35520578
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.MaintenanceUseInterval
- Microsoft.Web.Media.TransformManager.JobDefinition.set_MaintenanceUseInterval
- Microsoft.Web.Media.TransformManager.JobDefinition.get_MaintenanceUseInterval
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_MaintenanceUseInterval
- Microsoft.Web.Media.TransformManager.JobDefinition.set_MaintenanceUseInterval
- Microsoft.Web.Media.TransformManager.JobDefinition.MaintenanceUseInterval
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# MaintenanceUseInterval Property

Gets or sets a value that indicates that maintenance should be run at a specified interval instead of at a fixed time.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property MaintenanceUseInterval As Boolean
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As Boolean

value = instance.MaintenanceUseInterval

instance.MaintenanceUseInterval = value
```

```csharp
[DataMemberAttribute]
public bool MaintenanceUseInterval { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property bool MaintenanceUseInterval {
    bool get ();
    void set (bool value);
}
```

``` fsharp
[<DataMemberAttribute>]
member MaintenanceUseInterval : bool with get, set
```

```jscript
  function get MaintenanceUseInterval () : boolean
function set MaintenanceUseInterval (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
true if maintenance should be run at a specified interval, or false if maintenance should be run at a fixed time.  

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
