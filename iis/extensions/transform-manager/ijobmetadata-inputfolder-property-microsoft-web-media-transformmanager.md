---
title: IJobMetadata.InputFolder Property (Microsoft.Web.Media.TransformManager)
TOCTitle: InputFolder Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.IJobMetadata.InputFolder
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.ijobmetadata.inputfolder(v=VS.90)
ms:contentKeyID: 35520916
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IJobMetadata.InputFolder
- Microsoft.Web.Media.TransformManager.IJobMetadata.get_InputFolder
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.IJobMetadata.get_InputFolder
- Microsoft.Web.Media.TransformManager.IJobMetadata.InputFolder
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# InputFolder Property

Gets the name of the input folder for the job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  ReadOnly Property InputFolder As String
    Get
'Usage

  Dim instance As IJobMetadata
Dim value As String

value = instance.InputFolder
```

```csharp
  string InputFolder { get; }
```

```cpp
  property String^ InputFolder {
    String^ get ();
}
```

``` fsharp
  abstract InputFolder : string
```

```jscript
  function get InputFolder () : String
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The input folder name.  

## See Also

### Reference

[IJobMetadata Interface](ijobmetadata-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

