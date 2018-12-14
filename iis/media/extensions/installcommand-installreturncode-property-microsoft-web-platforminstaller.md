---
title: InstallCommand.InstallReturnCode Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: InstallReturnCode Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.InstallCommand.InstallReturnCode
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installcommand.installreturncode(v=VS.90)
ms:contentKeyID: 22049569
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.InstallCommand.InstallReturnCode
- Microsoft.Web.PlatformInstaller.InstallCommand.get_InstallReturnCode
- Microsoft.Web.PlatformInstaller.InstallCommand.set_InstallReturnCode
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.InstallCommand.get_InstallReturnCode
- Microsoft.Web.PlatformInstaller.InstallCommand.InstallReturnCode
- Microsoft.Web.PlatformInstaller.InstallCommand.set_InstallReturnCode
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# InstallReturnCode Property

Gets or sets the [InstallReturnCode](installreturncode-class-microsoft-web-platforminstaller.md) that indicates the status of the installer command upon completion.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
ProtectedPropertyInstallReturnCodeAsInstallReturnCodeGetSet
'Usage
DimvalueAsInstallReturnCodevalue = Me.InstallReturnCodeMe.InstallReturnCode = value
```

``` csharp
protectedInstallReturnCodeInstallReturnCode { get; set; }
```

``` c++
protected:
propertyInstallReturnCode^ InstallReturnCode {
    InstallReturnCode^ get ();
    voidset (InstallReturnCode^ value);
}
```

``` jscript
function getInstallReturnCode () : InstallReturnCodefunction setInstallReturnCode (value : InstallReturnCode)
```

#### Property Value

Type: [Microsoft.Web.PlatformInstaller. . :: . .InstallReturnCode](installreturncode-class-microsoft-web-platforminstaller.md)  
An [InstallReturnCode](installreturncode-class-microsoft-web-platforminstaller.md) instance that contains detailed information about the status of the [InstallCommand](installcommand-class-microsoft-web-platforminstaller.md) upon completion.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[InstallCommand Class](installcommand-class-microsoft-web-platforminstaller.md)

[InstallCommand Members](installcommand-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

