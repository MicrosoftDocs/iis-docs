---
title: InstallerContext.InstallStateDetails Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: InstallStateDetails Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.InstallerContext.InstallStateDetails
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installercontext.installstatedetails(v=VS.90)
ms:contentKeyID: 22049702
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.InstallerContext.InstallStateDetails
- Microsoft.Web.PlatformInstaller.InstallerContext.get_InstallStateDetails
- Microsoft.Web.PlatformInstaller.InstallerContext.set_InstallStateDetails
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.InstallerContext.get_InstallStateDetails
- Microsoft.Web.PlatformInstaller.InstallerContext.InstallStateDetails
- Microsoft.Web.PlatformInstaller.InstallerContext.set_InstallStateDetails
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# InstallStateDetails Property

Gets or sets a string that provides details about the current installation state.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicPropertyInstallStateDetailsAsStringGetFriendSet
'Usage
DiminstanceAsInstallerContextDimvalueAsStringvalue = instance.InstallStateDetails
```

``` csharp
publicstringInstallStateDetails { get; internalset; }
```

``` c++
public:
propertyString^ InstallStateDetails {
    String^ get ();
    internal: voidset (String^ value);
}
```

``` jscript
function getInstallStateDetails () : Stringinternalfunction setInstallStateDetails (value : String)
```

#### Property Value

Type: String  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[InstallerContext Class](installercontext-class-microsoft-web-platforminstaller.md)

[InstallerContext Members](installercontext-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

