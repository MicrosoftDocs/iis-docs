---
title: JobManifest.InstanceFileName Property (Microsoft.Web.Media.TransformManager)
TOCTitle: InstanceFileName Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManifest.InstanceFileName
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobmanifest.instancefilename(v=VS.90)
ms:contentKeyID: 35520982
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManifest.set_InstanceFileName
- Microsoft.Web.Media.TransformManager.JobManifest.InstanceFileName
- Microsoft.Web.Media.TransformManager.JobManifest.get_InstanceFileName
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManifest.get_InstanceFileName
- Microsoft.Web.Media.TransformManager.JobManifest.InstanceFileName
- Microsoft.Web.Media.TransformManager.JobManifest.set_InstanceFileName
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# InstanceFileName Property

Gets or sets the file name of the manifest instance.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Property InstanceFileName As String
    Get
    Set
'Usage

  Dim instance As JobManifest
Dim value As String

value = instance.InstanceFileName

instance.InstanceFileName = value
```

```csharp
  public string InstanceFileName { get; set; }
```

```cpp
  public:
property String^ InstanceFileName {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
  member InstanceFileName : string with get, set
```

```jscript
  function get InstanceFileName () : String
function set InstanceFileName (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The file name of the manifest instance.  

## Remarks

The InstanceFileName is the name of the file that was added into the watch folder and that matched the watch folder filter and caused a job to be created.

## See Also

### Reference

[JobManifest Class](jobmanifest-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

