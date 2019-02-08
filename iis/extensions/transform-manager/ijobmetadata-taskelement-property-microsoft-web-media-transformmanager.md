---
title: IJobMetadata.TaskElement Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: TaskElement Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.IJobMetadata.TaskElement
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.ijobmetadata.taskelement(v=VS.90)
ms:contentKeyID: 35521148
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.IJobMetadata.get_TaskElement
- Microsoft.Web.Media.TransformManager.IJobMetadata.TaskElement
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.IJobMetadata.get_TaskElement
- Microsoft.Web.Media.TransformManager.IJobMetadata.TaskElement
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TaskElement Property

Gets the task element from the manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

``` vb
'Declaration

  ReadOnly Property TaskElement As XElement
    Get
'Usage

  Dim instance As IJobMetadata
Dim value As XElement

value = instance.TaskElement
```

``` csharp
  XElement TaskElement { get; }
```

``` c++
  property XElement^ TaskElement {
    XElement^ get ();
}
```

``` fsharp
  abstract TaskElement : XElement
```

``` jscript
  function get TaskElement () : XElement
```

#### Property Value

Type: [System.Xml.Linq. . :: . .XElement](https://msdn.microsoft.com/en-us/library/bb340098\(v=vs.90\))  
The task element.  

## See Also

#### Reference

[IJobMetadata Interface](ijobmetadata-interface-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

