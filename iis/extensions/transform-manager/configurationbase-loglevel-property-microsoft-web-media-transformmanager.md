---
title: ConfigurationBase.LogLevel Property (Microsoft.Web.Media.TransformManager)
description: The LogLevel property gets or sets a value that represents the level of log detail that is contained in the log level element of the IIS Transform Manager configuration.
TOCTitle: LogLevel Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.ConfigurationBase.LogLevel
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.configurationbase.loglevel(v=VS.90)
ms:contentKeyID: 35520794
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_LogLevel
- Microsoft.Web.Media.TransformManager.ConfigurationBase.LogLevel
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_LogLevel
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.get_LogLevel
- Microsoft.Web.Media.TransformManager.ConfigurationBase.LogLevel
- Microsoft.Web.Media.TransformManager.ConfigurationBase.set_LogLevel
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# LogLevel Property

Gets or sets a value that represents the level of detail for a log that is contained in the log level element of the IIS Transform Manager configuration.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataMemberAttribute> _
Public Property LogLevel As LogLevel
    Get
    Set
'Usage

  Dim instance As ConfigurationBase
Dim value As LogLevel

value = instance.LogLevel

instance.LogLevel = value
```

```csharp
[DataMemberAttribute]
public LogLevel LogLevel { get; set; }
```

```cpp
[DataMemberAttribute]
public:
property LogLevel LogLevel {
    LogLevel get ();
    void set (LogLevel value);
}
```

``` fsharp
[<DataMemberAttribute>]
member LogLevel : LogLevel with get, set
```

```jscript
  function get LogLevel () : LogLevel
function set LogLevel (value : LogLevel)
```

### Property Value

Type: [Microsoft.Web.Media.TransformManager.LogLevel](loglevel-enumeration-microsoft-web-media-transformmanager.md)  
The level of detail for a log.  

## Remarks

Configuration is a composite model. Job definitions contain scheduler objects and job templates. Job templates in turn contain task definitions. The logging subsystem enables the log level for an object to be set, but also lets that value be overridden by objects higher in the hierarchy. If the log level is not set at the job definition level, the value that is defined in the job template will be used. If the log level is not set in the job template, the value that is defined in the task definition is used.

## See Also

### Reference

[ConfigurationBase Class](configurationbase-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
