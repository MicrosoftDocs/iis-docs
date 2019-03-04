---
title: SchedulerInfo.ConnectionString Property (Microsoft.Web.Media.TransformManager)
TOCTitle: ConnectionString Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.SchedulerInfo.ConnectionString
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.schedulerinfo.connectionstring(v=VS.90)
ms:contentKeyID: 35520838
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.SchedulerInfo.set_ConnectionString
- Microsoft.Web.Media.TransformManager.SchedulerInfo.ConnectionString
- Microsoft.Web.Media.TransformManager.SchedulerInfo.get_ConnectionString
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.SchedulerInfo.ConnectionString
- Microsoft.Web.Media.TransformManager.SchedulerInfo.get_ConnectionString
- Microsoft.Web.Media.TransformManager.SchedulerInfo.set_ConnectionString
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ConnectionString Property

Gets or sets the connection string that is used by this scheduler.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Property ConnectionString As String
    Get
    Set
'Usage

  Dim instance As SchedulerInfo
Dim value As String

value = instance.ConnectionString

instance.ConnectionString = value
```

```csharp
  public string ConnectionString { get; set; }
```

```cpp
  public:
property String^ ConnectionString {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
  member ConnectionString : string with get, set
```

```jscript
  function get ConnectionString () : String
function set ConnectionString (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The connection string that is used by this scheduler.  

## See Also

### Reference

[SchedulerInfo Class](schedulerinfo-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

