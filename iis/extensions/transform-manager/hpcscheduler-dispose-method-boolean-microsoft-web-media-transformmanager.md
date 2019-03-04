---
title: HpcScheduler.Dispose Method (Boolean) (Microsoft.Web.Media.TransformManager)
TOCTitle: Dispose Method (Boolean)
ms:assetid: M:Microsoft.Web.Media.TransformManager.HpcScheduler.Dispose(System.Boolean)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.hpcscheduler.dispose(v=VS.90)
ms:contentKeyID: 35520863
ms.date: 06/14/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- cpp
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.HpcScheduler.Dispose
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Dispose Method (Boolean)

Releases all resources used by the HPC scheduler and optionally releases the managed resources.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

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

## Remarks

If disposing is true, the method has been called using code and managed and unmanaged resources can be disposed. If disposing is false, the method has been called internally by the runtime. In that case, other objects should not be referenced.

Only unmanaged resources can be disposed.

## See Also

### Reference

[HpcScheduler Class](hpcscheduler-class-microsoft-web-media-transformmanager.md)

[Dispose Overload](hpcscheduler-dispose-method-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

