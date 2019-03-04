---
title: HpcScheduler.TestConnection Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: TestConnection Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.HpcScheduler.TestConnection(System.Object)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.hpcscheduler.testconnection(v=VS.90)
ms:contentKeyID: 35521110
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.HpcScheduler.TestConnection
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.HpcScheduler.TestConnection
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TestConnection Method

Tests connectivity of the IIS Transform Manager service to the [HpcScheduler](hpcscheduler-class-microsoft-web-media-transformmanager.md) object.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Sub TestConnection ( _
    connectionObject As Object _
)
'Usage

  Dim instance As HpcScheduler
Dim connectionObject As Object

instance.TestConnection(connectionObject)
```

```csharp
  public void TestConnection(
    Object connectionObject
)
```

```cpp
  public:
void TestConnection(
    Object^ connectionObject
)
```

``` fsharp
  member TestConnection : 
        connectionObject:Object -> unit 
```

```jscript
  public function TestConnection(
    connectionObject : Object
)
```

### Parameters

  - connectionObject  
    Type: [System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
    An object that contains connection details.  

## See Also

### Reference

[HpcScheduler Class](hpcscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

