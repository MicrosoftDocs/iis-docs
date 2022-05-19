---
title: Utilities.GetAssemblyInfo Method  (Microsoft.Web.Media.TransformManager)
description: Describes the Utilities.GetAssemblyInfo method and details the method's syntax, parameters, and return value.
TOCTitle: GetAssemblyInfo Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.Utilities.GetAssemblyInfo(System.String)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.utilities.getassemblyinfo(v=VS.90)
ms:contentKeyID: 35520777
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Utilities.GetAssemblyInfo
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Utilities.GetAssemblyInfo
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# GetAssemblyInfo Method

Returns assembly information from the manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Shared Function GetAssemblyInfo ( _
    type As String _
) As String
'Usage

  Dim type As String
Dim returnValue As String

returnValue = Utilities.GetAssemblyInfo(type)
```

```csharp
  public static string GetAssemblyInfo(
    string type
)
```

```cpp
  public:
static String^ GetAssemblyInfo(
    String^ type
)
```

``` fsharp
  static member GetAssemblyInfo : 
        type:string -> string 
```

```jscript
  public static function GetAssemblyInfo(
    type : String
) : String
```

### Parameters

  - type  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
    Job metadata that is contained in the taskCode node of the manifest.  

### Return Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
Assembly information that is contained in the type element of the taskCode node of the manifest.  

## See Also

### Reference

[Utilities Class](utilities-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
