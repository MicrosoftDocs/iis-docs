---
title: JobDefinition.NodeTaskCodePathX86 Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: NodeTaskCodePathX86 Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.NodeTaskCodePathX86
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.nodetaskcodepathx86(v=VS.90)
ms:contentKeyID: 35520566
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_NodeTaskCodePathX86
- Microsoft.Web.Media.TransformManager.JobDefinition.NodeTaskCodePathX86
- Microsoft.Web.Media.TransformManager.JobDefinition.set_NodeTaskCodePathX86
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_NodeTaskCodePathX86
- Microsoft.Web.Media.TransformManager.JobDefinition.set_NodeTaskCodePathX86
- Microsoft.Web.Media.TransformManager.JobDefinition.NodeTaskCodePathX86
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# NodeTaskCodePathX86 Property

Gets or sets a location for x86 binary files.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyNodeTaskCodePathX86AsStringGetSet
'Usage
DiminstanceAsJobDefinitionDimvalueAsStringvalue = instance.NodeTaskCodePathX86

instance.NodeTaskCodePathX86 = value
```

``` csharp
[DataMemberAttribute]
publicstringNodeTaskCodePathX86 { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ NodeTaskCodePathX86 {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberNodeTaskCodePathX86 : stringwithget, set
```

``` jscript
function getNodeTaskCodePathX86 () : Stringfunction setNodeTaskCodePathX86 (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The location.  

## Remarks

The NodeTaskCodePathX86 property supports advanced distributed server topologies.

## See Also

#### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

