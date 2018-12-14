---
title: JobManifest.Folder Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: Folder Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManifest.Folder
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanifest.folder(v=VS.90)
ms:contentKeyID: 35520589
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.get_Folder
- Microsoft.Web.Media.TransformManager.JobManifest.set_Folder
- Microsoft.Web.Media.TransformManager.JobManifest.Folder
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.Folder
- Microsoft.Web.Media.TransformManager.JobManifest.get_Folder
- Microsoft.Web.Media.TransformManager.JobManifest.set_Folder
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Folder Property

Gets or sets the folder name of the manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicPropertyFolderAsStringGetSet
'Usage
DiminstanceAsJobManifestDimvalueAsStringvalue = instance.Folder

instance.Folder = value
```

``` csharp
publicstringFolder { get; set; }
```

``` c++
public:
propertyString^ Folder {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
memberFolder : stringwithget, set
```

``` jscript
function getFolder () : Stringfunction setFolder (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The folder name of the manifest.  

## See Also

#### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

