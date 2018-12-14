---
title: JobDefinition.NodeTaskCodePathX64 Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: NodeTaskCodePathX64 Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.NodeTaskCodePathX64
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.nodetaskcodepathx64(v=VS.90)
ms:contentKeyID: 35521084
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.NodeTaskCodePathX64
- Microsoft.Web.Media.TransformManager.JobDefinition.get_NodeTaskCodePathX64
- Microsoft.Web.Media.TransformManager.JobDefinition.set_NodeTaskCodePathX64
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_NodeTaskCodePathX64
- Microsoft.Web.Media.TransformManager.JobDefinition.set_NodeTaskCodePathX64
- Microsoft.Web.Media.TransformManager.JobDefinition.NodeTaskCodePathX64
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# NodeTaskCodePathX64 Property

Gets or sets a location for x64 binary files.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyNodeTaskCodePathX64AsStringGetSet
'Usage
DiminstanceAsJobDefinitionDimvalueAsStringvalue = instance.NodeTaskCodePathX64

instance.NodeTaskCodePathX64 = value
```

``` csharp
[DataMemberAttribute]
publicstringNodeTaskCodePathX64 { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ NodeTaskCodePathX64 {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberNodeTaskCodePathX64 : stringwithget, set
```

``` jscript
function getNodeTaskCodePathX64 () : Stringfunction setNodeTaskCodePathX64 (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The location.  

## Remarks

The NodeTaskCodePathX64 property supports advanced distributed server topologies.

## See Also

#### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

