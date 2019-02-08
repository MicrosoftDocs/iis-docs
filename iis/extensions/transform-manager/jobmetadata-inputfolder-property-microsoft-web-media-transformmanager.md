---
title: JobMetadata.InputFolder Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: InputFolder Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobMetadata.InputFolder
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobmetadata.inputfolder(v=VS.90)
ms:contentKeyID: 35520562
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobMetadata.InputFolder
- Microsoft.Web.Media.TransformManager.JobMetadata.get_InputFolder
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobMetadata.get_InputFolder
- Microsoft.Web.Media.TransformManager.JobMetadata.InputFolder
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# InputFolder Property

Gets the name of the input folder for the job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration

  Public ReadOnly Property InputFolder As String
    Get
'Usage

  Dim instance As JobMetadata
Dim value As String

value = instance.InputFolder
```

``` csharp
  public string InputFolder { get; }
```

``` c++
  public:
virtual property String^ InputFolder {
    String^ get () sealed;
}
```

``` fsharp
  abstract InputFolder : string
override InputFolder : string
```

``` jscript
  final function get InputFolder () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The input folder name.  

#### Implements

[IJobMetadata. . :: . .InputFolder](ijobmetadata-inputfolder-property-microsoft-web-media-transformmanager.md)  

## See Also

#### Reference

[JobMetadata Class](jobmetadata-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

