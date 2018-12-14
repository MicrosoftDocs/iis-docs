---
title: Installer.LogFiles Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: LogFiles Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Installer.LogFiles
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installer.logfiles(v=VS.90)
ms:contentKeyID: 22049647
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Installer.LogFiles
- Microsoft.Web.PlatformInstaller.Installer.get_LogFiles
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Installer.get_LogFiles
- Microsoft.Web.PlatformInstaller.Installer.LogFiles
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# LogFiles Property

Gets a read-only collection of strings that point to log files associated with the current installer.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyLogFilesAsReadOnlyCollection(OfString)
    Get
'Usage
DiminstanceAsInstallerDimvalueAsReadOnlyCollection(OfString)

value = instance.LogFiles
```

``` csharp
publicReadOnlyCollection<string> LogFiles { get; }
```

``` c++
public:
propertyReadOnlyCollection<String^>^ LogFiles {
    ReadOnlyCollection<String^>^ get ();
}
```

``` jscript
function getLogFiles () : ReadOnlyCollection<String>
```

#### Property Value

Type: ReadOnlyCollection\< (Of \< ( \<'String\> ) \> ) \>  
A generic ReadOnlyCollection of strings.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Installer Class](installer-class-microsoft-web-platforminstaller.md)

[Installer Members](installer-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

