---
title: JobDefinition.TemplateName Property (Microsoft.Web.Media.TransformManager)
TOCTitle: TemplateName Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.TemplateName
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobdefinition.templatename(v=VS.90)
ms:contentKeyID: 35520927
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.TemplateName
- Microsoft.Web.Media.TransformManager.JobDefinition.get_TemplateName
- Microsoft.Web.Media.TransformManager.JobDefinition.set_TemplateName
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_TemplateName
- Microsoft.Web.Media.TransformManager.JobDefinition.TemplateName
- Microsoft.Web.Media.TransformManager.JobDefinition.set_TemplateName
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# TemplateName Property

Gets or sets the name of the job template that the current [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object uses.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property TemplateName As String
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As String

value = instance.TemplateName

instance.TemplateName = value
```

```csharp
[DataMemberAttribute]
public string TemplateName { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ TemplateName {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member TemplateName : string with get, set
```

```jscript
  function get TemplateName () : String
function set TemplateName (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The name of the job template.  

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

