---
title: SchedulerInfo.Id Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Id Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.SchedulerInfo.Id
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.schedulerinfo.id(v=VS.90)
ms:contentKeyID: 35520948
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.SchedulerInfo.Id
- Microsoft.Web.Media.TransformManager.SchedulerInfo.get_Id
- Microsoft.Web.Media.TransformManager.SchedulerInfo.set_Id
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.SchedulerInfo.get_Id
- Microsoft.Web.Media.TransformManager.SchedulerInfo.Id
- Microsoft.Web.Media.TransformManager.SchedulerInfo.set_Id
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# Id Property

Gets or sets the ID of the [SchedulerInfo](schedulerinfo-class-microsoft-web-media-transformmanager.md) object.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Property Id As String
    Get
    Set
'Usage

  Dim instance As SchedulerInfo
Dim value As String

value = instance.Id

instance.Id = value
```

```csharp
  public string Id { get; set; }
```

```cpp
  public:
property String^ Id {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
  member Id : string with get, set
```

```jscript
  function get Id () : String
function set Id (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The ID of the [SchedulerInfo](schedulerinfo-class-microsoft-web-media-transformmanager.md) object.  

## See Also

### Reference

[SchedulerInfo Class](schedulerinfo-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

