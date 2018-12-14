---
title: JobMetadata.SetProperty Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: SetProperty Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobMetadata.SetProperty(Microsoft.Web.Media.TransformManager.IManifestProperty)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmetadata.setproperty(v=VS.90)
ms:contentKeyID: 35520783
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobMetadata.SetProperty
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobMetadata.SetProperty
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
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicSubSetProperty ( _
    manifestPropertyAsIManifestProperty _
)
'Usage
DiminstanceAsJobMetadataDimmanifestPropertyAsIManifestProperty

instance.SetProperty(manifestProperty)
```

``` csharp
publicvoidSetProperty(
    IManifestPropertymanifestProperty
)
```

``` c++
public:
virtualvoidSetProperty(
    IManifestProperty^ manifestProperty
) sealed
```

``` fsharp
abstractSetProperty : 
        manifestProperty:IManifestProperty->unitoverrideSetProperty : 
        manifestProperty:IManifestProperty->unit
```

``` jscript
publicfinalfunctionSetProperty(
    manifestProperty : IManifestProperty
)
```

#### Parameters

  - manifestProperty  
    Type: [Microsoft.Web.Media.TransformManager. . :: . .IManifestProperty](imanifestproperty-interface-microsoft-web-media-transformmanager.md)  
    An [IManifestProperty](imanifestproperty-interface-microsoft-web-media-transformmanager.md) object that contains the name and value of the property to set.  

#### Implements

[IJobMetadata. . :: . .SetProperty(IManifestProperty)](ijobmetadata-setproperty-method-microsoft-web-media-transformmanager.md)  

## See Also

#### Reference

[JobMetadata Class](jobmetadata-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

