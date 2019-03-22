---
title: TaskDefinition.SuccessCodes Property (Microsoft.Web.Media.TransformManager)
TOCTitle: SuccessCodes Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.TaskDefinition.SuccessCodes
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.taskdefinition.successcodes(v=VS.90)
ms:contentKeyID: 35520786
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskDefinition.SuccessCodes
- Microsoft.Web.Media.TransformManager.TaskDefinition.set_SuccessCodes
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_SuccessCodes
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskDefinition.get_SuccessCodes
- Microsoft.Web.Media.TransformManager.TaskDefinition.set_SuccessCodes
- Microsoft.Web.Media.TransformManager.TaskDefinition.SuccessCodes
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SuccessCodes Property

Gets or sets a set of codes that indicate whether the task completed successfully.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property SuccessCodes As String
    Get
    Set
'Usage

  Dim instance As TaskDefinition
Dim value As String

value = instance.SuccessCodes

instance.SuccessCodes = value
```

```csharp
[DataMemberAttribute]
public string SuccessCodes { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ SuccessCodes {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member SuccessCodes : string with get, set
```

```jscript
  function get SuccessCodes () : String
function set SuccessCodes (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
A set of codes that indicate whether the task completed successfully.  

## Remarks

The SuccessCodes property provides a way to define a set of success return codes. These return codes are contained in a comma-separated list. For example, a command line executable might return 0 when it has successfully completed a task. Therefore, 0 should be included as a success return code.

## See Also

### Reference

[TaskDefinition Class](taskdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

