---
title: Utilities.IsLocalMachineX64 Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: IsLocalMachineX64 Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.Utilities.IsLocalMachineX64
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.utilities.islocalmachinex64(v=VS.90)
ms:contentKeyID: 35521128
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Utilities.IsLocalMachineX64
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Utilities.IsLocalMachineX64
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# IsLocalMachineX64 Method

Returns a value that indicates whether the local computer is a 64-bit computer.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Shared Function IsLocalMachineX64 As Boolean
'Usage

  Dim returnValue As Boolean

returnValue = Utilities.IsLocalMachineX64()
```

```csharp
  public static bool IsLocalMachineX64()
```

```cpp
  public:
static bool IsLocalMachineX64()
```

``` fsharp
  static member IsLocalMachineX64 : unit -> bool 
```

```jscript
  public static function IsLocalMachineX64() : boolean
```

### Return Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
true if the local computer is a 64-bit computer; otherwise, false.  

## See Also

### Reference

[Utilities Class](utilities-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

