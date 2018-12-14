---
title: JobDefinition.LogRetentionPeriodDisplayUnit Property  (Microsoft.Web.Media.TransformManager)
TOCTitle: LogRetentionPeriodDisplayUnit Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobDefinition.LogRetentionPeriodDisplayUnit
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition.logretentionperioddisplayunit(v=VS.90)
ms:contentKeyID: 35520761
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_LogRetentionPeriodDisplayUnit
- Microsoft.Web.Media.TransformManager.JobDefinition.set_LogRetentionPeriodDisplayUnit
- Microsoft.Web.Media.TransformManager.JobDefinition.LogRetentionPeriodDisplayUnit
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_LogRetentionPeriodDisplayUnit
- Microsoft.Web.Media.TransformManager.JobDefinition.LogRetentionPeriodDisplayUnit
- Microsoft.Web.Media.TransformManager.JobDefinition.set_LogRetentionPeriodDisplayUnit
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# LogRetentionPeriodDisplayUnit Property

Gets or sets the unit of time that is used with the [LogRetentionPeriodMinutes](jobdefinition-logretentionperiodminutes-property-microsoft-web-media-transformmanager.md) property to indicate how long the log file that is associated with a job is retained.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataMemberAttribute> _
PublicPropertyLogRetentionPeriodDisplayUnitAsStringGetSet
'Usage
DiminstanceAsJobDefinitionDimvalueAsStringvalue = instance.LogRetentionPeriodDisplayUnit

instance.LogRetentionPeriodDisplayUnit = value
```

``` csharp
[DataMemberAttribute]
publicstringLogRetentionPeriodDisplayUnit { get; set; }
```

``` c++
[DataMemberAttribute]
public:
propertyString^ LogRetentionPeriodDisplayUnit {
    String^ get ();
    voidset (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
memberLogRetentionPeriodDisplayUnit : stringwithget, set
```

``` jscript
function getLogRetentionPeriodDisplayUnit () : Stringfunction setLogRetentionPeriodDisplayUnit (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A unit of time.  

## Remarks

The LogRetentionPeriodDisplayUnit property modifies the [LogRetentionPeriodMinutes](jobdefinition-logretentionperiodminutes-property-microsoft-web-media-transformmanager.md) property. The LogRetentionPeriodDisplayUnit property can be set to "days", "hours", or "minutes".

## See Also

#### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

