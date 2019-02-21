---
title: JobTemplate.Properties Property (Microsoft.Web.Media.TransformManager)
TOCTitle: Properties Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobTemplate.Properties
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobtemplate.properties(v=VS.90)
ms:contentKeyID: 35520929
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobTemplate.get_Properties
- Microsoft.Web.Media.TransformManager.JobTemplate.Properties
- Microsoft.Web.Media.TransformManager.JobTemplate.set_Properties
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobTemplate.get_Properties
- Microsoft.Web.Media.TransformManager.JobTemplate.Properties
- Microsoft.Web.Media.TransformManager.JobTemplate.set_Properties
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# Properties Property

Gets or sets a collection of properties that are defined for the tasks.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property Properties As ManifestPropertiesDictionary
    Get
    Set
'Usage

  Dim instance As JobTemplate
Dim value As ManifestPropertiesDictionary

value = instance.Properties

instance.Properties = value
```

```csharp
[DataMemberAttribute]
public ManifestPropertiesDictionary Properties { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property ManifestPropertiesDictionary^ Properties {
    ManifestPropertiesDictionary^ get ();
    void set (ManifestPropertiesDictionary^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member Properties : ManifestPropertiesDictionary with get, set
```

```jscript
  function get Properties () : ManifestPropertiesDictionary
function set Properties (value : ManifestPropertiesDictionary)
```

### Property Value

Type: [Microsoft.Web.Media.TransformManager.ManifestPropertiesDictionary](manifestpropertiesdictionary-class-microsoft-web-media-transformmanager.md)  
A collection of properties that are defined for the tasks.  

## See Also

### Reference

[JobTemplate Class](jobtemplate-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

