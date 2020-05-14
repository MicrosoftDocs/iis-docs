---
title: JobManager.Dispose Method (Boolean) (Microsoft.Web.Media.TransformManager)
TOCTitle: Dispose Method (Boolean)
ms:assetid: M:Microsoft.Web.Media.TransformManager.JobManager.Dispose(System.Boolean)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobmanager.dispose(v=VS.90)
ms:contentKeyID: 35520822
ms.date: 06/14/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- cpp
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.TransformManager.ServiceLibrary.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobManager.Dispose
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Dispose Method (Boolean)

Releases unmanaged resources and optionally releases managed resources.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.ServiceLibrary (in Microsoft.Web.Media.TransformManager.ServiceLibrary.dll)

## Syntax

```vb
'Declaration

  Protected Overridable Sub Dispose ( _
    disposing As Boolean _
)
'Usage

  Dim disposing As Boolean

Me.Dispose(disposing)
```

```csharp
  protected virtual void Dispose(
    bool disposing
)
```

```cpp
  protected:
virtual void Dispose(
    bool disposing
)
```

``` fsharp
  abstract Dispose :
        disposing:bool -> unit
override Dispose :
        disposing:bool -> unit
```

```jscript
  protected function Dispose(
    disposing : boolean
)
```

### Parameters

  - disposing  
    Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
    true to release both managed and unmanaged resources; false to release only unmanaged resources.  

## See Also

### Reference

[JobManager Class](jobmanager-class-microsoft-web-media-transformmanager.md)

[Dispose Overload](jobmanager-dispose-method-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
