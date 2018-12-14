---
title: MSDeployPackage.ShouldShowOverwriteWarning Method  (Microsoft.Web.PlatformInstaller)
TOCTitle: ShouldShowOverwriteWarning Method
ms:assetid: M:Microsoft.Web.PlatformInstaller.MSDeployPackage.ShouldShowOverwriteWarning
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.msdeploypackage.shouldshowoverwritewarning(v=VS.90)
ms:contentKeyID: 22049652
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.MSDeployPackage.ShouldShowOverwriteWarning
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.MSDeployPackage.ShouldShowOverwriteWarning
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ShouldShowOverwriteWarning Method

Gets a value that indicates whether a user should be presented with an overwrite warning before executing the package.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicFunctionShouldShowOverwriteWarningAsBoolean
'Usage
DiminstanceAsMSDeployPackageDimreturnValueAsBooleanreturnValue = instance.ShouldShowOverwriteWarning()
```

``` csharp
publicboolShouldShowOverwriteWarning()
```

``` c++
public:
boolShouldShowOverwriteWarning()
```

``` jscript
publicfunctionShouldShowOverwriteWarning() : boolean
```

#### Return Value

Type: Boolean  
true if the user should get an overwrite warning, otherwise false.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[MSDeployPackage Class](msdeploypackage-class-microsoft-web-platforminstaller.md)

[MSDeployPackage Members](msdeploypackage-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

