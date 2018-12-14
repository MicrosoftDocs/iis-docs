---
title: JobMetadata.OutputFolder Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: OutputFolder Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobMetadata.OutputFolder
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmetadata.outputfolder(v=VS.90)
ms:contentKeyID: 35521200
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobMetadata.OutputFolder
- Microsoft.Web.Media.TransformManager.JobMetadata.get_OutputFolder
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobMetadata.get_OutputFolder
- Microsoft.Web.Media.TransformManager.JobMetadata.OutputFolder
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# OutputFolder Property

Gets the name of the output folder for completed jobs.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyOutputFolderAsStringGet
'Usage
DiminstanceAsJobMetadataDimvalueAsStringvalue = instance.OutputFolder
```

``` csharp
publicstringOutputFolder { get; }
```

``` c++
public:
virtualpropertyString^ OutputFolder {
    String^ get () sealed;
}
```

``` fsharp
abstractOutputFolder : stringoverrideOutputFolder : string
```

``` jscript
finalfunction getOutputFolder () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The output folder name.  

#### Implements

[IJobMetadata. . :: . .OutputFolder](ijobmetadata-outputfolder-property-microsoft-web-media-transformmanager.md)  

## See Also

#### Reference

[JobMetadata Class](jobmetadata-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

