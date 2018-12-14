---
title: Utilities.GetAssemblyInfo Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetAssemblyInfo Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.Utilities.GetAssemblyInfo(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.utilities.getassemblyinfo(v=VS.90)
ms:contentKeyID: 35520777
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Utilities.GetAssemblyInfo
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Utilities.GetAssemblyInfo
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetAssemblyInfo Method

Returns assembly information from the manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicSharedFunctionGetAssemblyInfo ( _
    typeAsString _
) AsString
'Usage
DimtypeAsStringDimreturnValueAsStringreturnValue = Utilities.GetAssemblyInfo(type)
```

``` csharp
publicstaticstringGetAssemblyInfo(
    stringtype
)
```

``` c++
public:
staticString^ GetAssemblyInfo(
    String^ type
)
```

``` fsharp
staticmemberGetAssemblyInfo : 
        type:string->string
```

``` jscript
publicstaticfunctionGetAssemblyInfo(
    type : String
) : String
```

#### Parameters

  - type  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    Job metadata that is contained in the taskCode node of the manifest.  

#### Return Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
Assembly information that is contained in the type element of the taskCode node of the manifest.  

## See Also

#### Reference

[Utilities Class](utilities-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

