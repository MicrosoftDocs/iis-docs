---
title: JobDefinition.Notifications Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Notifications Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.Notifications
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.notifications(v=VS.90)
ms:contentKeyID: 35520586
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.Notifications
- Microsoft.Web.Media.TransformManager.JobDefinition.get_Notifications
- Microsoft.Web.Media.TransformManager.JobDefinition.set_Notifications
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_Notifications
- Microsoft.Web.Media.TransformManager.JobDefinition.Notifications
- Microsoft.Web.Media.TransformManager.JobDefinition.set_Notifications
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# Notifications Property

Gets or sets a collection of the job notifications that trigger a notification POST request.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property Notifications As JobStatus()
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As JobStatus()

value = instance.Notifications

instance.Notifications = value
```

```csharp
[DataMemberAttribute]
public JobStatus[] Notifications { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property array<JobStatus>^ Notifications {
    array<JobStatus>^ get ();
    void set (array<JobStatus>^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member Notifications : JobStatus[] with get, set
```

```jscript
  function get Notifications () : JobStatus[]
function set Notifications (value : JobStatus[])
```

### Property Value

Type: array\<[Microsoft.Web.Media.TransformManager.JobStatus](jobstatus-enumeration-microsoft-web-media-transformmanager.md)\> \[\] () \[\] \[\]  
A collection of the job notifications that trigger a notification POST request.  

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

