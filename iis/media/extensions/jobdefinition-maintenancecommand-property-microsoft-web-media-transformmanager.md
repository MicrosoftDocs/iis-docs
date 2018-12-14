---
title: JobDefinition.MaintenanceCommand Property  (Microsoft.Web.Media.TransformManager)
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
- CSharp
- JScript
- VB
- FSharp
- c++
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
ROBOTS: INDEX,FOLLOW
---

# MaintenanceCommand Property

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyMaintenanceCommandAsStringGetSet
'Usage
DiminstanceAsJobDefinitionDimvalueAsStringvalue = instance.MaintenanceCommand

instance.MaintenanceCommand = value
```

``` csharp
[DataMemberAttribute]
publicstringMaintenanceCommand { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ MaintenanceCommand {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberMaintenanceCommand : stringwithget, set
```

``` jscript
function getMaintenanceCommand () : Stringfunction setMaintenanceCommand (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

## See Also

#### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

