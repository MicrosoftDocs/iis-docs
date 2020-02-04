---
title: JobDefinition.NotificationIncludeLogForFailedJob Property (Microsoft.Web.Media.TransformManager)
TOCTitle: NotificationIncludeLogForFailedJob Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.NotificationIncludeLogForFailedJob
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobdefinition.notificationincludelogforfailedjob(v=VS.90)
ms:contentKeyID: 35520800
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.NotificationIncludeLogForFailedJob
- Microsoft.Web.Media.TransformManager.JobDefinition.get_NotificationIncludeLogForFailedJob
- Microsoft.Web.Media.TransformManager.JobDefinition.set_NotificationIncludeLogForFailedJob
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_NotificationIncludeLogForFailedJob
- Microsoft.Web.Media.TransformManager.JobDefinition.NotificationIncludeLogForFailedJob
- Microsoft.Web.Media.TransformManager.JobDefinition.set_NotificationIncludeLogForFailedJob
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# NotificationIncludeLogForFailedJob Property

Gets or sets a value that specifies that the log that is associated with a failed job will be included in a failure notification POST request.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property NotificationIncludeLogForFailedJob As Boolean
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As Boolean

value = instance.NotificationIncludeLogForFailedJob

instance.NotificationIncludeLogForFailedJob = value
```

```csharp
[DataMemberAttribute]
public bool NotificationIncludeLogForFailedJob { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property bool NotificationIncludeLogForFailedJob {
    bool get ();
    void set (bool value);
}
```

``` fsharp
[<DataMemberAttribute>]
member NotificationIncludeLogForFailedJob : bool with get, set
```

```jscript
  function get NotificationIncludeLogForFailedJob () : boolean
function set NotificationIncludeLogForFailedJob (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
true if the log that is associated with a failed job will be included in a failure notification POST request; otherwise, false.  

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

