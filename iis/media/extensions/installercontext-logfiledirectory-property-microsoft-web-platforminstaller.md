---
title: InstallerContext.LogFileDirectory Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: LogFileDirectory Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.InstallerContext.LogFileDirectory
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installercontext.logfiledirectory(v=VS.90)
ms:contentKeyID: 22049598
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.InstallerContext.LogFileDirectory
- Microsoft.Web.PlatformInstaller.InstallerContext.get_LogFileDirectory
- Microsoft.Web.PlatformInstaller.InstallerContext.set_LogFileDirectory
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.InstallerContext.get_LogFileDirectory
- Microsoft.Web.PlatformInstaller.InstallerContext.LogFileDirectory
- Microsoft.Web.PlatformInstaller.InstallerContext.set_LogFileDirectory
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# LogFileDirectory Property

Gets or sets a string that contains the physical log file directory path.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicPropertyLogFileDirectoryAsStringGetSet
'Usage
DiminstanceAsInstallerContextDimvalueAsStringvalue = instance.LogFileDirectory

instance.LogFileDirectory = value
```

``` csharp
publicstringLogFileDirectory { get; set; }
```

``` c++
public:
propertyString^ LogFileDirectory {
    String^ get ();
    voidset (String^ value);
}
```

``` jscript
function getLogFileDirectory () : Stringfunction setLogFileDirectory (value : String)
```

#### Property Value

Type: String  
A string that contains the physical log file directory path.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[InstallerContext Class](installercontext-class-microsoft-web-platforminstaller.md)

[InstallerContext Members](installercontext-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

