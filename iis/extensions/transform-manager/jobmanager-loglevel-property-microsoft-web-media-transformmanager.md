---
title: JobManager.LogLevel Property (Microsoft.Web.Media.TransformManager)
TOCTitle: LogLevel Property
description: Describes the JobManager.LogLevel property and provides the field's namespace, assembly, syntax, and property value.
ms:assetid: P:Microsoft.Web.Media.TransformManager.JobManager.LogLevel
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobmanager.loglevel(v=VS.90)
ms:contentKeyID: 35521166
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobManager.get_LogLevel
- Microsoft.Web.Media.TransformManager.JobManager.LogLevel
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManager.get_LogLevel
- Microsoft.Web.Media.TransformManager.JobManager.LogLevel
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# LogLevel Property

Gets a log level value that is contained in the log level element of the IIS Transform Manager configuration.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property LogLevel As LogLevel
    Get
'Usage

  Dim instance As JobManager
Dim value As LogLevel

value = instance.LogLevel
```

```csharp
  public LogLevel LogLevel { get; }
```

```cpp
  public:
property LogLevel LogLevel {
    LogLevel get ();
}
```

``` fsharp
  member LogLevel : LogLevel
```

```jscript
  function get LogLevel () : LogLevel
```

### Property Value

Type: [Microsoft.Web.Media.TransformManager.LogLevel](loglevel-enumeration-microsoft-web-media-transformmanager.md)  
A log level value that is contained in the log level element of the IIS Transform Manager configuration.  

## See Also

### Reference

[JobManager Class](jobmanager-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
