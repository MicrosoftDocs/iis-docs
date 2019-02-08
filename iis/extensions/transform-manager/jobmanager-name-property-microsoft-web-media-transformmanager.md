---
title: JobManager.Name Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: Name Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManager.Name
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanager.name(v=VS.90)
ms:contentKeyID: 35520807
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManager.get_Name
- Microsoft.Web.Media.TransformManager.JobManager.Name
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManager.get_Name
- Microsoft.Web.Media.TransformManager.JobManager.Name
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Name Property

Gets the XML element name of the IIS Transform Manager configuration.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

``` vb
'Declaration

  Public ReadOnly Property Name As String
    Get
'Usage

  Dim instance As JobManager
Dim value As String

value = instance.Name
```

``` csharp
  public string Name { get; }
```

``` c++
  public:
property String^ Name {
    String^ get ();
}
```

``` fsharp
  member Name : string
```

``` jscript
  function get Name () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The XML element name of the IIS Transform Manager configuration.  

## See Also

#### Reference

[JobManager Class](jobmanager-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

