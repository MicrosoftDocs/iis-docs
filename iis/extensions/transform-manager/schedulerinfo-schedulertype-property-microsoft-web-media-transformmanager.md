---
title: SchedulerInfo.SchedulerType Property (Microsoft.Web.Media.TransformManager)
TOCTitle: SchedulerType Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.SchedulerInfo.SchedulerType
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.schedulerinfo.schedulertype(v=VS.90)
ms:contentKeyID: 35520705
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.SchedulerInfo.set_SchedulerType
- Microsoft.Web.Media.TransformManager.SchedulerInfo.SchedulerType
- Microsoft.Web.Media.TransformManager.SchedulerInfo.get_SchedulerType
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.SchedulerInfo.get_SchedulerType
- Microsoft.Web.Media.TransformManager.SchedulerInfo.SchedulerType
- Microsoft.Web.Media.TransformManager.SchedulerInfo.set_SchedulerType
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SchedulerType Property

Gets or sets the scheduler type.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Property SchedulerType As String
    Get
    Set
'Usage

  Dim instance As SchedulerInfo
Dim value As String

value = instance.SchedulerType

instance.SchedulerType = value
```

```csharp
  public string SchedulerType { get; set; }
```

```cpp
  public:
property String^ SchedulerType {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
  member SchedulerType : string with get, set
```

```jscript
  function get SchedulerType () : String
function set SchedulerType (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The string that represents the scheduler type.  

## See Also

### Reference

[SchedulerInfo Class](schedulerinfo-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
