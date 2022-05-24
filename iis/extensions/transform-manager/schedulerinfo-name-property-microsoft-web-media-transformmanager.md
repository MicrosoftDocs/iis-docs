---
title: SchedulerInfo.Name Property (Microsoft.Web.Media.TransformManager)
description: Describes the SchedulerInfo.Name property and details its namespace, assembly, syntax, and property value.
TOCTitle: Name Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.SchedulerInfo.Name
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.schedulerinfo.name(v=VS.90)
ms:contentKeyID: 35521150
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.SchedulerInfo.set_Name
- Microsoft.Web.Media.TransformManager.SchedulerInfo.get_Name
- Microsoft.Web.Media.TransformManager.SchedulerInfo.Name
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.SchedulerInfo.get_Name
- Microsoft.Web.Media.TransformManager.SchedulerInfo.Name
- Microsoft.Web.Media.TransformManager.SchedulerInfo.set_Name
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Name Property

Gets or sets the name of the [SchedulerInfo](schedulerinfo-class-microsoft-web-media-transformmanager.md) object.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Property Name As String
    Get
    Set
'Usage

  Dim instance As SchedulerInfo
Dim value As String

value = instance.Name

instance.Name = value
```

```csharp
  public string Name { get; set; }
```

```cpp
  public:
property String^ Name {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
  member Name : string with get, set
```

```jscript
  function get Name () : String
function set Name (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The name of the [SchedulerInfo](schedulerinfo-class-microsoft-web-media-transformmanager.md) object.  

## See Also

### Reference

[SchedulerInfo Class](schedulerinfo-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
