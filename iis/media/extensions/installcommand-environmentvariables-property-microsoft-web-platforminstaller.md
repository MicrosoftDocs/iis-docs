---
title: InstallCommand.EnvironmentVariables Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: EnvironmentVariables Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.InstallCommand.EnvironmentVariables
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installcommand.environmentvariables(v=VS.90)
ms:contentKeyID: 22049576
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.InstallCommand.EnvironmentVariables
- Microsoft.Web.PlatformInstaller.InstallCommand.get_EnvironmentVariables
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.InstallCommand.EnvironmentVariables
- Microsoft.Web.PlatformInstaller.InstallCommand.get_EnvironmentVariables
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# EnvironmentVariables Property

Gets a dictionary of environment variables for this [InstallCommand](installcommand-class-microsoft-web-platforminstaller.md) instance.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyEnvironmentVariablesAsIDictionary(OfString, String)
    Get
'Usage
DiminstanceAsInstallCommandDimvalueAsIDictionary(OfString, String)

value = instance.EnvironmentVariables
```

``` csharp
publicIDictionary<string, string> EnvironmentVariables { get; }
```

``` c++
public:
propertyIDictionary<String^, String^>^ EnvironmentVariables {
    IDictionary<String^, String^>^ get ();
}
```

``` jscript
function getEnvironmentVariables () : IDictionary<String, String>
```

#### Property Value

Type: IDictionary\< (Of \< ( \<'String, String\> ) \> ) \>  
A generic IDictionary reference.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[InstallCommand Class](installcommand-class-microsoft-web-platforminstaller.md)

[InstallCommand Members](installcommand-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

