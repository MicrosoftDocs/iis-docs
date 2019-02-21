---
title: JobDefinition.TemplateId Property (Microsoft.Web.Media.TransformManager)
TOCTitle: TemplateId Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.TemplateId
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.templateid(v=VS.90)
ms:contentKeyID: 35521096
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.TemplateId
- Microsoft.Web.Media.TransformManager.JobDefinition.get_TemplateId
- Microsoft.Web.Media.TransformManager.JobDefinition.set_TemplateId
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_TemplateId
- Microsoft.Web.Media.TransformManager.JobDefinition.set_TemplateId
- Microsoft.Web.Media.TransformManager.JobDefinition.TemplateId
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# TemplateId Property

Gets or sets the ID of the job template that the [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object uses.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property TemplateId As String
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As String

value = instance.TemplateId

instance.TemplateId = value
```

```csharp
[DataMemberAttribute]
public string TemplateId { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ TemplateId {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member TemplateId : string with get, set
```

```jscript
  function get TemplateId () : String
function set TemplateId (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The ID of the job template that the [JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md) object uses.  

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

