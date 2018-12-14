﻿---
title: JobDefinition.Enabled Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: Enabled Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.Enabled
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.enabled(v=VS.90)
ms:contentKeyID: 35520918
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_Enabled
- Microsoft.Web.Media.TransformManager.JobDefinition.set_Enabled
- Microsoft.Web.Media.TransformManager.JobDefinition.Enabled
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.Enabled
- Microsoft.Web.Media.TransformManager.JobDefinition.get_Enabled
- Microsoft.Web.Media.TransformManager.JobDefinition.set_Enabled
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Enabled Property

Gets or sets a value that indicates whether the job manager that is associated with this job definition can be started.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyEnabledAsBooleanGetSet
'Usage
DiminstanceAsJobDefinitionDimvalueAsBooleanvalue = instance.Enabled

instance.Enabled = value
```

``` csharp
[DataMemberAttribute]
publicboolEnabled { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyboolEnabled {
    boolget ();
    voidset (boolvalue);
}
```

``` fsharp
[<DataMemberAttribute>]
memberEnabled : boolwithget, set
```

``` jscript
function getEnabled () : booleanfunction setEnabled (value : boolean)
```

#### Property Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
true if the job manager that is associated with this job definition can be started; otherwise, false.  

## See Also

#### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
