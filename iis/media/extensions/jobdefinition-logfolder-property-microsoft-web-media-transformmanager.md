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
PublicPropertyLogFolderAsStringGetSet
'Usage
DiminstanceAsJobDefinitionDimvalueAsStringvalue = instance.LogFolder

instance.LogFolder = value
```

``` csharp
[DataMemberAttribute]
publicstringLogFolder { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ LogFolder {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberLogFolder : stringwithget, set
```

``` jscript
function getLogFolder () : Stringfunction setLogFolder (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

## See Also

#### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

