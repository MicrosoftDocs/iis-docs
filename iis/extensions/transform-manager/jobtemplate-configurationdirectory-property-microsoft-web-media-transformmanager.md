---
title: JobTemplate.ConfigurationDirectory Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: ConfigurationDirectory Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobTemplate.ConfigurationDirectory
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobtemplate.configurationdirectory(v=VS.90)
ms:contentKeyID: 35520685
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobTemplate.get_ConfigurationDirectory
- Microsoft.Web.Media.TransformManager.JobTemplate.ConfigurationDirectory
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobTemplate.ConfigurationDirectory
- Microsoft.Web.Media.TransformManager.JobTemplate.get_ConfigurationDirectory
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ConfigurationDirectory Property

Gets the path of this configuration file.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration

  Public ReadOnly Property ConfigurationDirectory As String
    Get
'Usage

  Dim instance As JobTemplate
Dim value As String

value = instance.ConfigurationDirectory
```

``` csharp
  public string ConfigurationDirectory { get; }
```

``` c++
  public:
property String^ ConfigurationDirectory {
    String^ get ();
}
```

``` fsharp
  member ConfigurationDirectory : string
```

``` jscript
  function get ConfigurationDirectory () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The path.  

## See Also

#### Reference

[JobTemplate Class](jobtemplate-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

