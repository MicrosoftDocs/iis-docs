---
title: InstallCommand.ReplaceEnvironmentVariables Method  (Microsoft.Web.PlatformInstaller)
TOCTitle: ReplaceEnvironmentVariables Method
ms:assetid: M:Microsoft.Web.PlatformInstaller.InstallCommand.ReplaceEnvironmentVariables(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installcommand.replaceenvironmentvariables(v=VS.90)
ms:contentKeyID: 22049549
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.InstallCommand.ReplaceEnvironmentVariables
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.InstallCommand.ReplaceEnvironmentVariables
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ReplaceEnvironmentVariables Method

Returns the value of the given string with replaced and expanded environment variables from the current [InstallCommand](installcommand-class-microsoft-web-platforminstaller.md) instance.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
ProtectedFunctionReplaceEnvironmentVariables ( _
    nameAsString _
) AsString
'Usage
DimnameAsStringDimreturnValueAsStringreturnValue = Me.ReplaceEnvironmentVariables(name)
```

``` csharp
protectedstringReplaceEnvironmentVariables(
    stringname
)
```

``` c++
protected:
String^ ReplaceEnvironmentVariables(
    String^ name
)
```

``` jscript
protectedfunctionReplaceEnvironmentVariables(
    name : String
) : String
```

#### Parameters

  - name  
    Type: String  
    A string that contains environment variables to replace.  

#### Return Value

Type: String  
A string with the original environment variables replaced with their respective values.  

## Remarks

The name parameter may contain any number of environment variable tokens such as %path% or %InstallerFile%. This method replaces those tokens with their respective values from the [EnvironmentVariables](installcommand-environmentvariables-property-microsoft-web-platforminstaller.md) collection and returns the modified string.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[InstallCommand Class](installcommand-class-microsoft-web-platforminstaller.md)

[InstallCommand Members](installcommand-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

