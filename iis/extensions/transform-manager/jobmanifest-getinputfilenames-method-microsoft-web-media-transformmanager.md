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
- csharp
- jscript
- vb
- FSharp
- cpp
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

```vb
'Declaration

  Public Shared Function GetInputFileNames ( _
    smilManifest As XContainer _
) As ICollection(Of String)
'Usage

  Dim smilManifest As XContainer
Dim returnValue As ICollection(Of String)

returnValue = JobManifest.GetInputFileNames(smilManifest)
```

```csharp
  public static ICollection<string> GetInputFileNames(
    XContainer smilManifest
)
```

```cpp
  public:
static ICollection<String^>^ GetInputFileNames(
    XContainer^ smilManifest
)
```

``` fsharp
  static member GetInputFileNames : 
        smilManifest:XContainer -> ICollection<string> 
```

```jscript
  public static function GetInputFileNames(
    smilManifest : XContainer
) : ICollection<String>
```

### Parameters

  - smilManifest  
    Type: [System.Xml.Linq.XContainer](https://msdn.microsoft.com/library/bb353736)  
    An XML element that contains the manifest.  

### Return Value

Type: [System.Collections.Generic.ICollection](https://msdn.microsoft.com/library/92t2ye13)\< (Of \< ( \<'[String](https://msdn.microsoft.com/library/s1wwdcbf)\> ) \> ) \>  
The collection of input file names.  

## See Also

### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

