---
title: JobDefinition.SchedulerId Property (Microsoft.Web.Media.TransformManager)
TOCTitle: SchedulerId Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.SchedulerId
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.schedulerid(v=VS.90)
ms:contentKeyID: 35520981
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.SchedulerId
- Microsoft.Web.Media.TransformManager.JobDefinition.set_SchedulerId
- Microsoft.Web.Media.TransformManager.JobDefinition.get_SchedulerId
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_SchedulerId
- Microsoft.Web.Media.TransformManager.JobDefinition.set_SchedulerId
- Microsoft.Web.Media.TransformManager.JobDefinition.SchedulerId
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# SchedulerId Property

Gets or sets the ID of the scheduler that is associated with this job definition.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property SchedulerId As String
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As String

value = instance.SchedulerId

instance.SchedulerId = value
```

```csharp
[DataMemberAttribute]
public string SchedulerId { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ SchedulerId {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member SchedulerId : string with get, set
```

```jscript
  function get SchedulerId () : String
function set SchedulerId (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The ID of the scheduler.  

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

