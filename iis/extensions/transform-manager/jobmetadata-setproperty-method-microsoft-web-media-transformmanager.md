---
title: JobMetadata.SetProperty Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: SetProperty Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobMetadata.SetProperty(Microsoft.Web.Media.TransformManager.IManifestProperty)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobmetadata.setproperty(v=VS.90)
ms:contentKeyID: 35520783
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobMetadata.SetProperty
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobMetadata.SetProperty
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SetProperty Method

Sets a property value in the task resource description framework (RDF) metadata section in the manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Sub SetProperty ( _
    manifestProperty As IManifestProperty _
)
'Usage

  Dim instance As JobMetadata
Dim manifestProperty As IManifestProperty

instance.SetProperty(manifestProperty)
```

```csharp
  public void SetProperty(
    IManifestProperty manifestProperty
)
```

```cpp
  public:
virtual void SetProperty(
    IManifestProperty^ manifestProperty
) sealed
```

``` fsharp
  abstract SetProperty : 
        manifestProperty:IManifestProperty -> unit 
override SetProperty : 
        manifestProperty:IManifestProperty -> unit 
```

```jscript
  public final function SetProperty(
    manifestProperty : IManifestProperty
)
```

### Parameters

  - manifestProperty  
    Type: [Microsoft.Web.Media.TransformManager.IManifestProperty](imanifestproperty-interface-microsoft-web-media-transformmanager.md)  
    An [IManifestProperty](imanifestproperty-interface-microsoft-web-media-transformmanager.md) object that contains the name and value of the property to set.  

### Implements

[IJobMetadata.SetProperty(IManifestProperty)](ijobmetadata-setproperty-method-microsoft-web-media-transformmanager.md)  

## See Also

### Reference

[JobMetadata Class](jobmetadata-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
