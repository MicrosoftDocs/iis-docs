---
title: JobDefinition.SchedulerProperties Property (Microsoft.Web.Media.TransformManager)
TOCTitle: SchedulerProperties Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.SchedulerProperties
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.schedulerproperties(v=VS.90)
ms:contentKeyID: 35521073
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.SchedulerProperties
- Microsoft.Web.Media.TransformManager.JobDefinition.get_SchedulerProperties
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_SchedulerProperties
- Microsoft.Web.Media.TransformManager.JobDefinition.SchedulerProperties
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# SchedulerProperties Property

Gets a list of additional scheduler properties.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property SchedulerProperties As Dictionary(Of String, String)
    Get
'Usage

  Dim instance As JobDefinition
Dim value As Dictionary(Of String, String)

value = instance.SchedulerProperties
```

```csharp
  public Dictionary<string, string> SchedulerProperties { get; }
```

```cpp
  public:
property Dictionary<String^, String^>^ SchedulerProperties {
    Dictionary<String^, String^>^ get ();
}
```

``` fsharp
  member SchedulerProperties : Dictionary<string, string>
```

```jscript
  function get SchedulerProperties () : Dictionary<String, String>
```

### Property Value

Type: [System.Collections.Generic.Dictionary](https://msdn.microsoft.com/library/xfhwa508)\< (Of \< ( \<'[String](https://msdn.microsoft.com/library/s1wwdcbf), [String](https://msdn.microsoft.com/library/s1wwdcbf)\> ) \> ) \>  
A list of scheduler properties.  

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

