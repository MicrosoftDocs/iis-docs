---
title: JobDefinition.AssetRetentionPeriodDisplayUnit Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: AssetRetentionPeriodDisplayUnit Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.AssetRetentionPeriodDisplayUnit
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.assetretentionperioddisplayunit(v=VS.90)
ms:contentKeyID: 35521131
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_AssetRetentionPeriodDisplayUnit
- Microsoft.Web.Media.TransformManager.JobDefinition.set_AssetRetentionPeriodDisplayUnit
- Microsoft.Web.Media.TransformManager.JobDefinition.AssetRetentionPeriodDisplayUnit
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.AssetRetentionPeriodDisplayUnit
- Microsoft.Web.Media.TransformManager.JobDefinition.get_AssetRetentionPeriodDisplayUnit
- Microsoft.Web.Media.TransformManager.JobDefinition.set_AssetRetentionPeriodDisplayUnit
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# AssetRetentionPeriodDisplayUnit Property

Gets or sets a value that indicates how long the assets that are associated with a job are retained.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
Public Property AssetRetentionPeriodDisplayUnit As String
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As String

value = instance.AssetRetentionPeriodDisplayUnit

instance.AssetRetentionPeriodDisplayUnit = value
```

``` csharp
[DataMemberAttribute]
public string AssetRetentionPeriodDisplayUnit { get; set; }
```

``` c++
[DataMemberAttribute]
public:
property String^ AssetRetentionPeriodDisplayUnit {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member AssetRetentionPeriodDisplayUnit : string with get, set
```

``` jscript
  function get AssetRetentionPeriodDisplayUnit () : String
function set AssetRetentionPeriodDisplayUnit (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The unit of time.  

## Remarks

The unit of time is used with the [AssetRetentionPeriodMinutes](jobdefinition-assetretentionperiodminutes-property-microsoft-web-media-transformmanager.md) property to indicate how long the assets that are associated with a job are retained. The AssetRetentionPeriodDisplayUnit property can be set to "days", "hours", or "minutes".

## See Also

#### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

