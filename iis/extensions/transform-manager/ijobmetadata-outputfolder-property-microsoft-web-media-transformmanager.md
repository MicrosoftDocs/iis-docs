---
title: IJobMetadata.OutputFolder Property (Microsoft.Web.Media.TransformManager)
TOCTitle: OutputFolder Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.IJobMetadata.OutputFolder
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.ijobmetadata.outputfolder(v=VS.90)
ms:contentKeyID: 35520629
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IJobMetadata.get_OutputFolder
- Microsoft.Web.Media.TransformManager.IJobMetadata.OutputFolder
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.IJobMetadata.get_OutputFolder
- Microsoft.Web.Media.TransformManager.IJobMetadata.OutputFolder
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# OutputFolder Property

Gets the name of the output folder for completed jobs.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  ReadOnly Property OutputFolder As String
    Get
'Usage

  Dim instance As IJobMetadata
Dim value As String

value = instance.OutputFolder
```

```csharp
  string OutputFolder { get; }
```

```cpp
  property String^ OutputFolder {
    String^ get ();
}
```

``` fsharp
  abstract OutputFolder : string
```

```jscript
  function get OutputFolder () : String
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The output folder name.  

## See Also

### Reference

[IJobMetadata Interface](ijobmetadata-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

