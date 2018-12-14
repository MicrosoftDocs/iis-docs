---
title: InstallerContext.ReturnCode Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: ReturnCode Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.InstallerContext.ReturnCode
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installercontext.returncode(v=VS.90)
ms:contentKeyID: 22049672
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.InstallerContext.ReturnCode
- Microsoft.Web.PlatformInstaller.InstallerContext.get_ReturnCode
- Microsoft.Web.PlatformInstaller.InstallerContext.set_ReturnCode
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.InstallerContext.get_ReturnCode
- Microsoft.Web.PlatformInstaller.InstallerContext.ReturnCode
- Microsoft.Web.PlatformInstaller.InstallerContext.set_ReturnCode
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ReturnCode Property

Gets or sets the install return code associated with the current installer context.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicPropertyReturnCodeAsInstallReturnCodeGetSet
'Usage
DiminstanceAsInstallerContextDimvalueAsInstallReturnCodevalue = instance.ReturnCode

instance.ReturnCode = value
```

``` csharp
publicInstallReturnCodeReturnCode { get; set; }
```

``` c++
public:
propertyInstallReturnCode^ ReturnCode {
    InstallReturnCode^ get ();
    voidset (InstallReturnCode^ value);
}
```

``` jscript
function getReturnCode () : InstallReturnCodefunction setReturnCode (value : InstallReturnCode)
```

#### Property Value

Type: [Microsoft.Web.PlatformInstaller. . :: . .InstallReturnCode](installreturncode-class-microsoft-web-platforminstaller.md)  
An [InstallReturnCode](installreturncode-class-microsoft-web-platforminstaller.md) instance.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[InstallerContext Class](installercontext-class-microsoft-web-platforminstaller.md)

[InstallerContext Members](installercontext-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

