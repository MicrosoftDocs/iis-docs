---
title: JobDefinition.InputIsManifest Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: InputIsManifest Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.InputIsManifest
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.inputismanifest(v=VS.90)
ms:contentKeyID: 35520903
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.set_InputIsManifest
- Microsoft.Web.Media.TransformManager.JobDefinition.get_InputIsManifest
- Microsoft.Web.Media.TransformManager.JobDefinition.InputIsManifest
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_InputIsManifest
- Microsoft.Web.Media.TransformManager.JobDefinition.InputIsManifest
- Microsoft.Web.Media.TransformManager.JobDefinition.set_InputIsManifest
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# InputIsManifest Property

Gets or sets a value that indicates whether the file that initiates job creation is a SMIL 2.0-compliant manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyInputIsManifestAsBooleanGetSet
'Usage
DiminstanceAsJobDefinitionDimvalueAsBooleanvalue = instance.InputIsManifest

instance.InputIsManifest = value
```

``` csharp
[DataMemberAttribute]
publicboolInputIsManifest { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyboolInputIsManifest {
    boolget ();
    voidset (boolvalue);
}
```

``` fsharp
[<DataMemberAttribute>]
memberInputIsManifest : boolwithget, set
```

``` jscript
function getInputIsManifest () : booleanfunction setInputIsManifest (value : boolean)
```

#### Property Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
true if the file that initiates job creation is a SMIL 2.0-compliant manifest; otherwise, false.  

## See Also

#### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

