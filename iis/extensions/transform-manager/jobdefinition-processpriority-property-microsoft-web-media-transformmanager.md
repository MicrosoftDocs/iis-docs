---
title: JobDefinition.ProcessPriority Property (Microsoft.Web.Media.TransformManager)
TOCTitle: ProcessPriority Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.ProcessPriority
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobdefinition.processpriority(v=VS.90)
ms:contentKeyID: 36868664
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_ProcessPriority
- Microsoft.Web.Media.TransformManager.JobDefinition.ProcessPriority
- Microsoft.Web.Media.TransformManager.JobDefinition.set_ProcessPriority
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_ProcessPriority
- Microsoft.Web.Media.TransformManager.JobDefinition.ProcessPriority
- Microsoft.Web.Media.TransformManager.JobDefinition.set_ProcessPriority
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ProcessPriority Property

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property ProcessPriority As Integer
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As Integer

value = instance.ProcessPriority

instance.ProcessPriority = value
```

```csharp
[DataMemberAttribute]
public int ProcessPriority { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property int ProcessPriority {
    int get ();
    void set (int value);
}
```

``` fsharp
[<DataMemberAttribute>]
member ProcessPriority : int with get, set
```

```jscript
  function get ProcessPriority () : int
function set ProcessPriority (value : int)
```

### Property Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
