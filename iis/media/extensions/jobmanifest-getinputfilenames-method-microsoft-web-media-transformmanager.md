---
title: JobManifest.GetInputFileNames Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetInputFileNames Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobManifest.GetInputFileNames(System.Xml.Linq.XContainer)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmanifest.getinputfilenames(v=VS.90)
ms:contentKeyID: 35521026
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.GetInputFileNames
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.GetInputFileNames
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetInputFileNames Method

Returns a collection of input file names.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicSharedFunctionGetInputFileNames ( _
    smilManifestAsXContainer _
) AsICollection(OfString)
'Usage
DimsmilManifestAsXContainerDimreturnValueAsICollection(OfString)

returnValue = JobManifest.GetInputFileNames(smilManifest)
```

``` csharp
publicstaticICollection<string> GetInputFileNames(
    XContainersmilManifest
)
```

``` c++
public:
staticICollection<String^>^ GetInputFileNames(
    XContainer^ smilManifest
)
```

``` fsharp
staticmemberGetInputFileNames : 
        smilManifest:XContainer->ICollection<string> 
```

``` jscript
publicstaticfunctionGetInputFileNames(
    smilManifest : XContainer
) : ICollection<String>
```

#### Parameters

  - smilManifest  
    Type: [System.Xml.Linq. . :: . .XContainer](https://msdn.microsoft.com/en-us/library/bb353736\(v=vs.90\))  
    An XML element that contains the manifest.  

#### Return Value

Type: [System.Collections.Generic. . :: . .ICollection](https://msdn.microsoft.com/en-us/library/92t2ye13\(v=vs.90\))\< (Of \< ( \<'[String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))\> ) \> ) \>  
The collection of input file names.  

## See Also

#### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

