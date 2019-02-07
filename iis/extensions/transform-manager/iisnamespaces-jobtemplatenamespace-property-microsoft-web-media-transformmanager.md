---
title: IisNamespaces.JobTemplateNamespace Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: JobTemplateNamespace Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.IisNamespaces.JobTemplateNamespace
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.iisnamespaces.jobtemplatenamespace(v=VS.90)
ms:contentKeyID: 35520971
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IisNamespaces.JobTemplateNamespace
- Microsoft.Web.Media.TransformManager.IisNamespaces.get_JobTemplateNamespace
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.IisNamespaces.get_JobTemplateNamespace
- Microsoft.Web.Media.TransformManager.IisNamespaces.JobTemplateNamespace
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# JobTemplateNamespace Property

Gets the URI of a media services schema document that is related to job templates.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

``` vb
'Declaration

  Public Shared ReadOnly Property JobTemplateNamespace As XNamespace
    Get
'Usage

  Dim value As XNamespace

value = IisNamespaces.JobTemplateNamespace
```

``` csharp
  public static XNamespace JobTemplateNamespace { get; }
```

``` c++
  public:
static property XNamespace^ JobTemplateNamespace {
    XNamespace^ get ();
}
```

``` fsharp
  static member JobTemplateNamespace : XNamespace
```

``` jscript
  static function get JobTemplateNamespace () : XNamespace
```

#### Property Value

Type: [System.Xml.Linq. . :: . .XNamespace](https://msdn.microsoft.com/en-us/library/bb291898\(v=vs.90\))  
The XML namespace value "http://schemas.microsoft.com/iis/media/v4/TM/JobTemplate\#".  

## See Also

#### Reference

[IisNamespaces Class](iisnamespaces-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

