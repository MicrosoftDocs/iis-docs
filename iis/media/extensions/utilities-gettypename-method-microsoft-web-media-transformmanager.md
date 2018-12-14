---
title: Utilities.GetTypeName Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: GetTypeName Method
ms:assetid: M:Microsoft.Web.Media.TransformManager.Utilities.GetTypeName(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.utilities.gettypename(v=VS.90)
ms:contentKeyID: 35521117
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.Utilities.GetTypeName
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.Utilities.GetTypeName
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetTypeName Method

Returns the type name from the manifest.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicSharedFunctionGetTypeName ( _
    typeAsString _
) AsString
'Usage
DimtypeAsStringDimreturnValueAsStringreturnValue = Utilities.GetTypeName(type)
```

``` csharp
publicstaticstringGetTypeName(
    stringtype
)
```

``` c++
public:
staticString^ GetTypeName(
    String^ type
)
```

``` fsharp
staticmemberGetTypeName : 
        type:string->string
```

``` jscript
publicstaticfunctionGetTypeName(
    type : String
) : String
```

#### Parameters

  - type  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    Job metadata that is contained in the taskCode node of the manifest.  

#### Return Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The type name.  

## Remarks

The type name is contained in the type element of the taskCode node of the manifest.

## See Also

#### Reference

[Utilities Class](utilities-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

