---
title: JobManifest.InputFileNames Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: InputFileNames Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManifest.InputFileNames
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanifest.inputfilenames(v=VS.90)
ms:contentKeyID: 35520801
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.get_InputFileNames
- Microsoft.Web.Media.TransformManager.JobManifest.InputFileNames
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.get_InputFileNames
- Microsoft.Web.Media.TransformManager.JobManifest.InputFileNames
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# InputFileNames Property

Gets a collection of input file names for a job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyInputFileNamesAsICollection(OfString)
    Get
'Usage
DiminstanceAsJobManifestDimvalueAsICollection(OfString)

value = instance.InputFileNames
```

``` csharp
publicICollection<string> InputFileNames { get; }
```

``` c++
public:
propertyICollection<String^>^ InputFileNames {
    ICollection<String^>^ get ();
}
```

``` fsharp
memberInputFileNames : ICollection<string>
```

``` jscript
function getInputFileNames () : ICollection<String>
```

#### Property Value

Type: [System.Collections.Generic. . :: . .ICollection](https://msdn.microsoft.com/en-us/library/92t2ye13\(v=vs.90\))\< (Of \< ( \<'[String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))\> ) \> ) \>  
A collection of input file names for a job.  

## See Also

#### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

