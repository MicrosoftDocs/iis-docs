---
title: LocalScheduler.Connect Method  (Microsoft.Web.Media.TransformManager)
Description: Understand how the Connect method connects to the local scheduler.
TOCTitle: Connect Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.LocalScheduler.Connect(System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.localscheduler.connect(v=VS.90)
ms:contentKeyID: 35520892
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.LocalScheduler.Connect
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.LocalScheduler.Connect
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Connect Method

Connects to the local scheduler.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Overrides Sub Connect ( _
    connectionString As String _
)
'Usage

  Dim instance As LocalScheduler
Dim connectionString As String

instance.Connect(connectionString)
```

```csharp
  public override void Connect(
    string connectionString
)
```

```cpp
  public:
virtual void Connect(
    String^ connectionString
) override
```

``` fsharp
  abstract Connect : 
        connectionString:string -> unit 
override Connect : 
        connectionString:string -> unit 
```

```jscript
  public override function Connect(
    connectionString : String
)
```

### Parameters

  - connectionString  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    The connection string that is used to connect to the scheduler.  

## Exceptions

|Exception|Condition|
|--- |--- |
|[FileLoadException](https://msdn.microsoft.com/library/99akez90)|The method was unable to load a file that was created by the task scheduler when a job was submitted.|
|[COMException](https://msdn.microsoft.com/library/02hkayhc)|The method was unable to complete the transaction that was originated by the task scheduler.|

## See Also

### Reference

[LocalScheduler Class](localscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
