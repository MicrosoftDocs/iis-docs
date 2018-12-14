---
title: JobDefinition.ProcessPriority Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: ProcessPriority Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.ProcessPriority
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.processpriority(v=VS.90)
ms:contentKeyID: 36868664
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_ProcessPriority
- Microsoft.Web.Media.TransformManager.JobDefinition.ProcessPriority
- Microsoft.Web.Media.TransformManager.JobDefinition.set_ProcessPriority
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_ProcessPriority
- Microsoft.Web.Media.TransformManager.JobDefinition.ProcessPriority
- Microsoft.Web.Media.TransformManager.JobDefinition.set_ProcessPriority
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ProcessPriority Property

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyProcessPriorityAsIntegerGetSet
'Usage
DiminstanceAsJobDefinitionDimvalueAsIntegervalue = instance.ProcessPriority

instance.ProcessPriority = value
```

``` csharp
[DataMemberAttribute]
publicintProcessPriority { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyintProcessPriority {
    intget ();
    voidset (intvalue);
}
```

``` fsharp
[<DataMemberAttribute>]
memberProcessPriority : intwithget, set
```

``` jscript
function getProcessPriority () : intfunction setProcessPriority (value : int)
```

#### Property Value

Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  

## See Also

#### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

