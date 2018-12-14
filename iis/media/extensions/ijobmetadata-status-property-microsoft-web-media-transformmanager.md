---
title: IJobMetadata.Status Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: Status Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.IJobMetadata.Status
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.ijobmetadata.status(v=VS.90)
ms:contentKeyID: 35520634
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IJobMetadata.Status
- Microsoft.Web.Media.TransformManager.IJobMetadata.set_Status
- Microsoft.Web.Media.TransformManager.IJobMetadata.get_Status
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.IJobMetadata.get_Status
- Microsoft.Web.Media.TransformManager.IJobMetadata.set_Status
- Microsoft.Web.Media.TransformManager.IJobMetadata.Status
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Status Property

Gets or sets the status of an ongoing transform.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

``` vb
'Declaration
PropertyStatusAsStringGetSet
'Usage
DiminstanceAsIJobMetadataDimvalueAsStringvalue = instance.Status

instance.Status = value
```

``` csharp
stringStatus { get; set; }
```

``` c++
propertyString^ Status {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
abstractStatus : stringwithget, set
```

``` jscript
function getStatus () : Stringfunction setStatus (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The transform status.  

## See Also

#### Reference

[IJobMetadata Interface](ijobmetadata-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

