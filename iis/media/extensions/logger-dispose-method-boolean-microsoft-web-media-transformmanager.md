---
title: Logger.Dispose Method (Boolean) (Microsoft.Web.Media.TransformManager)
TOCTitle: Dispose Method (Boolean)
ms:assetid: M:Microsoft.Web.Media.TransformManager.Logger.Dispose(System.Boolean)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.logger.dispose(v=VS.90)
ms:contentKeyID: 35520991
ms.date: 06/14/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- c++
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Logger.Dispose
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Dispose Method (Boolean)

Disposes logging resources and optionally releases the managed resources.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
ProtectedOverridableSubDispose ( _
    disposingAsBoolean _
)
'Usage
DimdisposingAsBooleanMe.Dispose(disposing)
```

``` csharp
protectedvirtualvoidDispose(
    booldisposing
)
```

``` c++
protected:
virtualvoidDispose(
    booldisposing
)
```

``` fsharp
abstractDispose : 
        disposing:bool->unitoverrideDispose : 
        disposing:bool->unit
```

``` jscript
protectedfunctionDispose(
    disposing : boolean
)
```

#### Parameters

  - disposing  
    Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
    true to release both managed and unmanaged resources; false to release only unmanaged resources.  

## Remarks

The Dispose(Boolean) method executes in two scenarios. If the disposing parameter is true, the method has been called directly or indirectly using code. Managed and unmanaged resources can be disposed. If the disposing parameter is false, the method has been called internally by the runtime. In that case, other objects should not be referenced. Only unmanaged resources can be disposed.

## See Also

#### Reference

[Logger Class](logger-class-microsoft-web-media-transformmanager.md)

[Dispose Overload](logger-dispose-method-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

