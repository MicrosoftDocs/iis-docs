﻿---
title: MSDeployPackage.RemoveParameters Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: RemoveParameters Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.MSDeployPackage.RemoveParameters
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.msdeploypackage.removeparameters(v=VS.90)
ms:contentKeyID: 22049572
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.MSDeployPackage.RemoveParameters
- Microsoft.Web.PlatformInstaller.MSDeployPackage.get_RemoveParameters
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.MSDeployPackage.get_RemoveParameters
- Microsoft.Web.PlatformInstaller.MSDeployPackage.RemoveParameters
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# RemoveParameters Property

Gets a list of remove parameters.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyRemoveParametersAsIList(OfString)
    Get
'Usage
DiminstanceAsMSDeployPackageDimvalueAsIList(OfString)

value = instance.RemoveParameters
```

``` csharp
publicIList<string> RemoveParameters { get; }
```

``` c++
public:
propertyIList<String^>^ RemoveParameters {
    IList<String^>^ get ();
}
```

``` jscript
function getRemoveParameters () : IList<String>
```

#### Property Value

Type: IList\< (Of \< ( \<'String\> ) \> ) \>  
A generic IList of strings that represent parameters to remove.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[MSDeployPackage Class](msdeploypackage-class-microsoft-web-platforminstaller.md)

[MSDeployPackage Members](msdeploypackage-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)
