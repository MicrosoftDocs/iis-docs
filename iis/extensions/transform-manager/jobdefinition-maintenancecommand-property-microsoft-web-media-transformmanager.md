---
title: JobDefinition.MaintenanceCommand Property (Microsoft.Web.Media.TransformManager)
TOCTitle: MaintenanceCommand Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.MaintenanceCommand
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.maintenancecommand(v=VS.90)
ms:contentKeyID: 46408523
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_MaintenanceCommand
- Microsoft.Web.Media.TransformManager.JobDefinition.MaintenanceCommand
- Microsoft.Web.Media.TransformManager.JobDefinition.set_MaintenanceCommand
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_MaintenanceCommand
- Microsoft.Web.Media.TransformManager.JobDefinition.MaintenanceCommand
- Microsoft.Web.Media.TransformManager.JobDefinition.set_MaintenanceCommand
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# MaintenanceCommand Property

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property MaintenanceCommand As String
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As String

value = instance.MaintenanceCommand

instance.MaintenanceCommand = value
```

```csharp
[DataMemberAttribute]
public string MaintenanceCommand { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ MaintenanceCommand {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member MaintenanceCommand : string with get, set
```

```jscript
  function get MaintenanceCommand () : String
function set MaintenanceCommand (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

