---
title: JobTemplate.JobTemplateElement Property  (Microsoft.Web.Media.TransformManager)
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
- CSharp
- JScript
- VB
- FSharp
- c++
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
ROBOTS: INDEX,FOLLOW
---

# JobTemplateElement Property

Gets or sets the [XElement](https://msdn.microsoft.com/en-us/library/bb340098\(v=vs.90\)) container of the template file.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicPropertyJobTemplateElementAsXElementGetSet
'Usage
DiminstanceAsJobTemplateDimvalueAsXElementvalue = instance.JobTemplateElement

instance.JobTemplateElement = value
```

``` csharp
publicXElementJobTemplateElement { get; set; }
```

``` c++
public:
propertyXElement^ JobTemplateElement {
    XElement^ get ();
    voidset (XElement^ value);
}
```

``` fsharp
memberJobTemplateElement : XElementwithget, set
```

``` jscript
function getJobTemplateElement () : XElementfunction setJobTemplateElement (value : XElement)
```

#### Property Value

Type: [System.Xml.Linq. . :: . .XElement](https://msdn.microsoft.com/en-us/library/bb340098\(v=vs.90\))  
The [XElement](https://msdn.microsoft.com/en-us/library/bb340098\(v=vs.90\)) container of the template file.  

## See Also

#### Reference

[JobTemplate Class](jobtemplate-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

