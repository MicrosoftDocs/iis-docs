---
title: JobTemplate.JobTemplateElement Property (Microsoft.Web.Media.TransformManager)
TOCTitle: JobTemplateElement Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobTemplate.JobTemplateElement
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobtemplate.jobtemplateelement(v=VS.90)
ms:contentKeyID: 35520568
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobTemplate.set_JobTemplateElement
- Microsoft.Web.Media.TransformManager.JobTemplate.JobTemplateElement
- Microsoft.Web.Media.TransformManager.JobTemplate.get_JobTemplateElement
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobTemplate.get_JobTemplateElement
- Microsoft.Web.Media.TransformManager.JobTemplate.JobTemplateElement
- Microsoft.Web.Media.TransformManager.JobTemplate.set_JobTemplateElement
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# JobTemplateElement Property

Gets or sets the [XElement](https://msdn.microsoft.com/library/bb340098) container of the template file.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Property JobTemplateElement As XElement
    Get
    Set
'Usage

  Dim instance As JobTemplate
Dim value As XElement

value = instance.JobTemplateElement

instance.JobTemplateElement = value
```

```csharp
  public XElement JobTemplateElement { get; set; }
```

```cpp
  public:
property XElement^ JobTemplateElement {
    XElement^ get ();
    void set (XElement^ value);
}
```

``` fsharp
  member JobTemplateElement : XElement with get, set
```

```jscript
  function get JobTemplateElement () : XElement
function set JobTemplateElement (value : XElement)
```

### Property Value

Type: [System.Xml.Linq.XElement](https://msdn.microsoft.com/library/bb340098)  
The [XElement](https://msdn.microsoft.com/library/bb340098) container of the template file.  

## See Also

### Reference

[JobTemplate Class](jobtemplate-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

