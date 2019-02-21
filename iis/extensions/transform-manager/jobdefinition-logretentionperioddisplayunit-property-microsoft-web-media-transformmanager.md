---
title: JobDefinition.LogRetentionPeriodDisplayUnit Property (Microsoft.Web.Media.TransformManager)
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
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition.get_LogRetentionPeriodDisplayUnit
- Microsoft.Web.Media.TransformManager.JobDefinition.LogRetentionPeriodDisplayUnit
- Microsoft.Web.Media.TransformManager.JobDefinition.set_LogRetentionPeriodDisplayUnit
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# LogRetentionPeriodDisplayUnit Property

Gets or sets the unit of time that is used with the [LogRetentionPeriodMinutes](jobdefinition-logretentionperiodminutes-property-microsoft-web-media-transformmanager.md) property to indicate how long the log file that is associated with a job is retained.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property LogRetentionPeriodDisplayUnit As String
    Get
    Set
'Usage

  Dim instance As JobDefinition
Dim value As String

value = instance.LogRetentionPeriodDisplayUnit

instance.LogRetentionPeriodDisplayUnit = value
```

```csharp
[DataMemberAttribute]
public string LogRetentionPeriodDisplayUnit { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property String^ LogRetentionPeriodDisplayUnit {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
[<DataMemberAttribute>]
member LogRetentionPeriodDisplayUnit : string with get, set
```

```jscript
  function get LogRetentionPeriodDisplayUnit () : String
function set LogRetentionPeriodDisplayUnit (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
A unit of time.  

## Remarks

The LogRetentionPeriodDisplayUnit property modifies the [LogRetentionPeriodMinutes](jobdefinition-logretentionperiodminutes-property-microsoft-web-media-transformmanager.md) property. The LogRetentionPeriodDisplayUnit property can be set to "days", "hours", or "minutes".

## See Also

### Reference

[JobDefinition Class](jobdefinition-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

