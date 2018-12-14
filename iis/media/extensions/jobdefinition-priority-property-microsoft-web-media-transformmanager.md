---
title: JobDefinition.Priority Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: Priority Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.Priority
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.priority(v=VS.90)
ms:contentKeyID: 35520853
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_Priority
- Microsoft.Web.Media.TransformManager.JobDefinition.Priority
- Microsoft.Web.Media.TransformManager.JobDefinition.set_Priority
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_Priority
- Microsoft.Web.Media.TransformManager.JobDefinition.set_Priority
- Microsoft.Web.Media.TransformManager.JobDefinition.Priority
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Priority Property

Gets or sets the priority of a job.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyPriorityAsIntegerGetSet
'Usage
DiminstanceAsJobDefinitionDimvalueAsIntegervalue = instance.Priority

instance.Priority = value
```

``` csharp
[DataMemberAttribute]
publicintPriority { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyintPriority {
    intget ();
    voidset (intvalue);
}
```

``` fsharp
[<DataMemberAttribute>]
memberPriority : intwithget, set
```

``` jscript
function getPriority () : intfunction setPriority (value : int)
```

#### Property Value

Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
The priority value.  

## Remarks

The Priority property is used by the scheduler when it chooses between multiple job managers that all have work to complete.

## See Also

#### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

