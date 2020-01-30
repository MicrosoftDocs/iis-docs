---
title: JobDefinition.NodeTaskCodePathX64 Property (Microsoft.Web.Media.TransformManager)
TOCTitle: NodeTaskCodePathX64 Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.NodeTaskCodePathX64
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobdefinition.nodetaskcodepathx64(v=VS.90)
ms:contentKeyID: 35521084
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.NodeTaskCodePathX64
- Microsoft.Web.Media.TransformManager.JobDefinition.get_NodeTaskCodePathX64
- Microsoft.Web.Media.TransformManager.JobDefinition.set_NodeTaskCodePathX64
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_NodeTaskCodePathX64
- Microsoft.Web.Media.TransformManager.JobDefinition.set_NodeTaskCodePathX64
- Microsoft.Web.Media.TransformManager.JobDefinition.NodeTaskCodePathX64
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# NodeTaskCodePathX64 Property

Gets or sets a location for x64 binary files.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property NodeTaskCodePathX64 As String
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As String

value = instance.NodeTaskCodePathX64

instance.NodeTaskCodePathX64 = value
```

```csharp
[DataMemberAttribute]
public string NodeTaskCodePathX64 { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ NodeTaskCodePathX64 {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member NodeTaskCodePathX64 : string with get, set
```

```jscript
  function get NodeTaskCodePathX64 () : String
function set NodeTaskCodePathX64 (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The location.  

## Remarks

The NodeTaskCodePathX64 property supports advanced distributed server topologies.

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

