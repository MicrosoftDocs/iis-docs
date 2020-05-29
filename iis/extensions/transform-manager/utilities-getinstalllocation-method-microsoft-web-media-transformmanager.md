---
title: Utilities.GetInstallLocation Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetInstallLocation Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.Utilities.GetInstallLocation
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.utilities.getinstalllocation(v=VS.90)
ms:contentKeyID: 35521059
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Utilities.GetInstallLocation
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Utilities.GetInstallLocation
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# GetInstallLocation Method

Returns the installation location of IIS Transform Manager from the local computer.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Shared Function GetInstallLocation As String
'Usage

  Dim returnValue As String

returnValue = Utilities.GetInstallLocation()
```

```csharp
  public static string GetInstallLocation()
```

```cpp
  public:
static String^ GetInstallLocation()
```

``` fsharp
  static member GetInstallLocation : unit -> string 
```

```jscript
  public static function GetInstallLocation() : String
```

### Return Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The installation location of IIS Transform Manager from the local computer.  

## See Also

### Reference

[Utilities Class](utilities-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
