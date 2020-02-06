---
title: JobDefinition.IsJobManagerRunning Property (Microsoft.Web.Media.TransformManager)
TOCTitle: IsJobManagerRunning Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.IsJobManagerRunning
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobdefinition.isjobmanagerrunning(v=VS.90)
ms:contentKeyID: 35520781
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.set_IsJobManagerRunning
- Microsoft.Web.Media.TransformManager.JobDefinition.get_IsJobManagerRunning
- Microsoft.Web.Media.TransformManager.JobDefinition.IsJobManagerRunning
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_IsJobManagerRunning
- Microsoft.Web.Media.TransformManager.JobDefinition.set_IsJobManagerRunning
- Microsoft.Web.Media.TransformManager.JobDefinition.IsJobManagerRunning
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# IsJobManagerRunning Property

Gets or sets a value that indicates whether the job manager that is associated with this job definition is running.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property IsJobManagerRunning As Boolean
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As Boolean

value = instance.IsJobManagerRunning

instance.IsJobManagerRunning = value
```

```csharp
[DataMemberAttribute]
public bool IsJobManagerRunning { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property bool IsJobManagerRunning {
    bool get ();
    void set (bool value);
}
```

``` fsharp
[<DataMemberAttribute>]
member IsJobManagerRunning : bool with get, set
```

```jscript
  function get IsJobManagerRunning () : boolean
function set IsJobManagerRunning (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
true if the job manager that is associated with this job definition is running; otherwise, false.  

## Remarks

This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code. If you set this property, it will have no effect.

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

