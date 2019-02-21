---
title: IJobMetadata.SetProperty Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: SetProperty Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IJobMetadata.SetProperty(Microsoft.Web.Media.TransformManager.IManifestProperty)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.ijobmetadata.setproperty(v=VS.90)
ms:contentKeyID: 35520752
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IJobMetadata.SetProperty
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.IJobMetadata.SetProperty
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SetProperty Method

Sets a property value in the task resource description framework (RDF) metadata section in the manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  Sub SetProperty ( _
    manifestProperty As IManifestProperty _
)
'Usage

  Dim instance As IJobMetadata
Dim manifestProperty As IManifestProperty

instance.SetProperty(manifestProperty)
```

```csharp
  void SetProperty(
    IManifestProperty manifestProperty
)
```

```cpp
  void SetProperty(
    IManifestProperty^ manifestProperty
)
```

``` fsharp
  abstract SetProperty : 
        manifestProperty:IManifestProperty -> unit 
```

```jscript
  function SetProperty(
    manifestProperty : IManifestProperty
)
```

### Parameters

  - manifestProperty  
    Type: [Microsoft.Web.Media.TransformManager.IManifestProperty](imanifestproperty-interface-microsoft-web-media-transformmanager.md)  
    An [IManifestProperty](imanifestproperty-interface-microsoft-web-media-transformmanager.md) object that has name and value members.  

## See Also

### Reference

[IJobMetadata Interface](ijobmetadata-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

