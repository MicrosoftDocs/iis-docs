---
title: JobDefinition.WatchFolder Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: WatchFolder Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.WatchFolder
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.watchfolder(v=VS.90)
ms:contentKeyID: 35520886
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.WatchFolder
- Microsoft.Web.Media.TransformManager.JobDefinition.set_WatchFolder
- Microsoft.Web.Media.TransformManager.JobDefinition.get_WatchFolder
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_WatchFolder
- Microsoft.Web.Media.TransformManager.JobDefinition.set_WatchFolder
- Microsoft.Web.Media.TransformManager.JobDefinition.WatchFolder
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# WatchFolder Property

Gets or sets a file system folder that will be watched for files that will instantiate jobs.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyWatchFolderAsStringGetSet
'Usage
DiminstanceAsJobDefinitionDimvalueAsStringvalue = instance.WatchFolder

instance.WatchFolder = value
```

``` csharp
[DataMemberAttribute]
publicstringWatchFolder { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ WatchFolder {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberWatchFolder : stringwithget, set
```

``` jscript
function getWatchFolder () : Stringfunction setWatchFolder (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The folder.  

## See Also

#### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

