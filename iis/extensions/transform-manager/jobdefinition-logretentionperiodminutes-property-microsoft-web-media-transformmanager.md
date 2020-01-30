---
title: JobDefinition.LogRetentionPeriodMinutes Property (Microsoft.Web.Media.TransformManager)
TOCTitle: LogRetentionPeriodMinutes Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.LogRetentionPeriodMinutes
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobdefinition.logretentionperiodminutes(v=VS.90)
ms:contentKeyID: 35521008
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.set_LogRetentionPeriodMinutes
- Microsoft.Web.Media.TransformManager.JobDefinition.get_LogRetentionPeriodMinutes
- Microsoft.Web.Media.TransformManager.JobDefinition.LogRetentionPeriodMinutes
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_LogRetentionPeriodMinutes
- Microsoft.Web.Media.TransformManager.JobDefinition.LogRetentionPeriodMinutes
- Microsoft.Web.Media.TransformManager.JobDefinition.set_LogRetentionPeriodMinutes
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# LogRetentionPeriodMinutes Property

Gets or sets the number of minutes that the log that is associated with a job is retained before being deleted during maintenance.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property LogRetentionPeriodMinutes As Integer
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As Integer

value = instance.LogRetentionPeriodMinutes

instance.LogRetentionPeriodMinutes = value
```

```csharp
[DataMemberAttribute]
public int LogRetentionPeriodMinutes { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property int LogRetentionPeriodMinutes {
    int get ();
    void set (int value);
}
```

``` fsharp
[<DataMemberAttribute>]
member LogRetentionPeriodMinutes : int with get, set
```

```jscript
  function get LogRetentionPeriodMinutes () : int
function set LogRetentionPeriodMinutes (value : int)
```

### Property Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
The number of minutes that the log that is associated with a job is retained.  

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

