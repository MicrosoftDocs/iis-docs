---
title: IJobMetadata.GetProperty Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetProperty Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.IJobMetadata.GetProperty(System.Xml.Linq.XName)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.ijobmetadata.getproperty(v=VS.90)
ms:contentKeyID: 35521090
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IJobMetadata.GetProperty
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.IJobMetadata.GetProperty
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# GetProperty Method

Returns the value of the specified property from the task resource description framework (RDF) metadata section in the manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

```vb
'Declaration

  Function GetProperty ( _
    predicate As XName _
) As IManifestProperty
'Usage

  Dim instance As IJobMetadata
Dim predicate As XName
Dim returnValue As IManifestProperty

returnValue = instance.GetProperty(predicate)
```

```csharp
  IManifestProperty GetProperty(
    XName predicate
)
```

```cpp
  IManifestProperty^ GetProperty(
    XName^ predicate
)
```

``` fsharp
  abstract GetProperty : 
        predicate:XName -> IManifestProperty 
```

```jscript
  function GetProperty(
    predicate : XName
) : IManifestProperty
```

### Parameters

  - predicate  
    Type: [System.Xml.Linq.XName](https://msdn.microsoft.com/library/bb347810)  
    The name of the property to get.  

### Return Value

Type: [Microsoft.Web.Media.TransformManager.IManifestProperty](imanifestproperty-interface-microsoft-web-media-transformmanager.md)  
The property value.  

## See Also

### Reference

[IJobMetadata Interface](ijobmetadata-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

