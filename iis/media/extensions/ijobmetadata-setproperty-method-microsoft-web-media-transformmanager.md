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
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.IJobMetadata.SetProperty
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SetProperty Method

Sets a property value in the task resource description framework (RDF) metadata section in the manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

``` vb
'Declaration
SubSetProperty ( _
    manifestPropertyAsIManifestProperty _
)
'Usage
DiminstanceAsIJobMetadataDimmanifestPropertyAsIManifestProperty

instance.SetProperty(manifestProperty)
```

``` csharp
voidSetProperty(
    IManifestPropertymanifestProperty
)
```

``` c++
voidSetProperty(
    IManifestProperty^ manifestProperty
)
```

``` fsharp
abstractSetProperty : 
        manifestProperty:IManifestProperty->unit
```

``` jscript
functionSetProperty(
    manifestProperty : IManifestProperty
)
```

#### Parameters

  - manifestProperty  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .IManifestProperty](imanifestproperty-interface-microsoft-web-media-transformmanager.md)  
    An [IManifestProperty](imanifestproperty-interface-microsoft-web-media-transformmanager.md) object that has name and value members.  

## See Also

#### Reference

[IJobMetadata Interface](ijobmetadata-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

