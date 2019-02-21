---
title: TaskDetails.ChildProcessId Property (Microsoft.Web.Media.TransformManager)
TOCTitle: ChildProcessId Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.TaskDetails.ChildProcessId
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.taskdetails.childprocessid(v=VS.90)
ms:contentKeyID: 35521048
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskDetails.get_ChildProcessId
- Microsoft.Web.Media.TransformManager.TaskDetails.set_ChildProcessId
- Microsoft.Web.Media.TransformManager.TaskDetails.ChildProcessId
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskDetails.ChildProcessId
- Microsoft.Web.Media.TransformManager.TaskDetails.get_ChildProcessId
- Microsoft.Web.Media.TransformManager.TaskDetails.set_ChildProcessId
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# ChildProcessId Property

Gets or sets the ID of a child process.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Property ChildProcessId As Integer
    Get
    Set
'Usage

  Dim instance As TaskDetails
Dim value As Integer

value = instance.ChildProcessId

instance.ChildProcessId = value
```

```csharp
  public int ChildProcessId { get; set; }
```

```cpp
  public:
property int ChildProcessId {
    int get ();
    void set (int value);
}
```

``` fsharp
  member ChildProcessId : int with get, set
```

```jscript
  function get ChildProcessId () : int
function set ChildProcessId (value : int)
```

### Property Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
The ID of a child process.  

## See Also

### Reference

[TaskDetails Structure](taskdetails-structure-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

