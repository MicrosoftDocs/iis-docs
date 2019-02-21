---
title: JobMetadata.OutputFolder Property (Microsoft.Web.Media.TransformManager)
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
- csharp
- jscript
- vb
- FSharp
- cpp
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
---

# OutputFolder Property

Gets the name of the output folder for completed jobs.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property OutputFolder As String
    Get
'Usage

  Dim instance As JobMetadata
Dim value As String

value = instance.OutputFolder
```

```csharp
  public string OutputFolder { get; }
```

```cpp
  public:
virtual property String^ OutputFolder {
    String^ get () sealed;
}
```

``` fsharp
  abstract OutputFolder : string
override OutputFolder : string
```

```jscript
  final function get OutputFolder () : String
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The output folder name.  

### Implements

[IJobMetadata.OutputFolder](ijobmetadata-outputfolder-property-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[JobMetadata Class](jobmetadata-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

