---
title: JobDefinition.LocalFileWatcherFilter Property (Microsoft.Web.Media.TransformManager)
TOCTitle: LocalFileWatcherFilter Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.LocalFileWatcherFilter
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.localfilewatcherfilter(v=VS.90)
ms:contentKeyID: 35521116
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.set_LocalFileWatcherFilter
- Microsoft.Web.Media.TransformManager.JobDefinition.LocalFileWatcherFilter
- Microsoft.Web.Media.TransformManager.JobDefinition.get_LocalFileWatcherFilter
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_LocalFileWatcherFilter
- Microsoft.Web.Media.TransformManager.JobDefinition.LocalFileWatcherFilter
- Microsoft.Web.Media.TransformManager.JobDefinition.set_LocalFileWatcherFilter
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# LocalFileWatcherFilter Property

Gets or sets a file filter value that is used to initiate job creation.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property LocalFileWatcherFilter As String
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As String

value = instance.LocalFileWatcherFilter

instance.LocalFileWatcherFilter = value
```

```csharp
[DataMemberAttribute]
public string LocalFileWatcherFilter { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ LocalFileWatcherFilter {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member LocalFileWatcherFilter : string with get, set
```

```jscript
  function get LocalFileWatcherFilter () : String
function set LocalFileWatcherFilter (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
A file filter value that is used to initiate job creation.  

## Remarks

Filters can be for simple file types or for SMIL 2.0-compliant manifests. If the [InputIsManifest](jobdefinition-inputismanifest-property-microsoft-web-media-transformmanager.md) property is true, files that match the filter are opened and searched for the seq or switch elements that have child elements that in turn have the src attribute. The src attribute contains the name of the input files. When all of the input files have arrived, the job is created.

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

