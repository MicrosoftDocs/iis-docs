---
title: JobDefinition.LogFolder Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: LogFolder Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.LogFolder
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.logfolder(v=VS.90)
ms:contentKeyID: 36868654
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_LogFolder
- Microsoft.Web.Media.TransformManager.JobDefinition.LogFolder
- Microsoft.Web.Media.TransformManager.JobDefinition.set_LogFolder
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_LogFolder
- Microsoft.Web.Media.TransformManager.JobDefinition.LogFolder
- Microsoft.Web.Media.TransformManager.JobDefinition.set_LogFolder
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# LogFolder Property

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
Public Property LogFolder As String
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As String

value = instance.LogFolder

instance.LogFolder = value
```

``` csharp
[DataMemberAttribute]
public string LogFolder { get; set; }
```

``` c++
[DataMemberAttribute]
public:
property String^ LogFolder {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member LogFolder : string with get, set
```

``` jscript
  function get LogFolder () : String
function set LogFolder (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

## See Also

#### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

