---
title: MSDeployPackage.DeclaredParameters Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: DeclaredParameters Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.MSDeployPackage.DeclaredParameters
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.msdeploypackage.declaredparameters(v=VS.90)
ms:contentKeyID: 22049650
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.MSDeployPackage.DeclaredParameters
- Microsoft.Web.PlatformInstaller.MSDeployPackage.get_DeclaredParameters
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.MSDeployPackage.DeclaredParameters
- Microsoft.Web.PlatformInstaller.MSDeployPackage.get_DeclaredParameters
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeclaredParameters Property

Gets a list of declared parameters.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyDeclaredParametersAsIList(OfDeclaredParameter)
    Get
'Usage
DiminstanceAsMSDeployPackageDimvalueAsIList(OfDeclaredParameter)

value = instance.DeclaredParameters
```

``` csharp
publicIList<DeclaredParameter> DeclaredParameters { get; }
```

``` c++
public:
propertyIList<DeclaredParameter^>^ DeclaredParameters {
    IList<DeclaredParameter^>^ get ();
}
```

``` jscript
function getDeclaredParameters () : IList<DeclaredParameter>
```

#### Property Value

Type: IList\< (Of \< ( \<'[DeclaredParameter](declaredparameter-class-microsoft-web-platforminstaller.md)\> ) \> ) \>  
A generic IList of [DeclaredParameter](declaredparameter-class-microsoft-web-platforminstaller.md) objects.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[MSDeployPackage Class](msdeploypackage-class-microsoft-web-platforminstaller.md)

[MSDeployPackage Members](msdeploypackage-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

