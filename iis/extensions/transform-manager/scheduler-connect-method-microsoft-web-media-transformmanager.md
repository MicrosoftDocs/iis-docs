---
title: Scheduler.Connect Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: Connect Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.Scheduler.Connect(System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.scheduler.connect(v=VS.90)
ms:contentKeyID: 35520843
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Scheduler.Connect
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Scheduler.Connect
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Connect Method

Connects to the scheduler.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public MustOverride Sub Connect ( _
    connectionString As String _
)
'Usage

  Dim instance As Scheduler
Dim connectionString As String

instance.Connect(connectionString)
```

```csharp
  public abstract void Connect(
    string connectionString
)
```

```cpp
  public:
virtual void Connect(
    String^ connectionString
) abstract
```

``` fsharp
  abstract Connect : 
        connectionString:string -> unit 
```

```jscript
  public abstract function Connect(
    connectionString : String
)
```

### Parameters

  - connectionString  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The connection string that is used to connect to the scheduler.  

## See Also

### Reference

[Scheduler Class](scheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

