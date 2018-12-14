---
title: InstallReturnCode.Status Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Status Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.InstallReturnCode.Status
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installreturncode.status(v=VS.90)
ms:contentKeyID: 22049745
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.InstallReturnCode.Status
- Microsoft.Web.PlatformInstaller.InstallReturnCode.get_Status
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.InstallReturnCode.get_Status
- Microsoft.Web.PlatformInstaller.InstallReturnCode.Status
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Status Property

Gets or sets the status of an installation action.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyStatusAsInstallReturnCodeStatusGet
'Usage
DiminstanceAsInstallReturnCodeDimvalueAsInstallReturnCodeStatusvalue = instance.Status
```

``` csharp
publicInstallReturnCodeStatusStatus { get; }
```

``` c++
public:
propertyInstallReturnCodeStatusStatus {
    InstallReturnCodeStatusget ();
}
```

``` jscript
function getStatus () : InstallReturnCodeStatus
```

#### Property Value

Type: [Microsoft.Web.PlatformInstaller. . :: . .InstallReturnCodeStatus](installreturncodestatus-enumeration-microsoft-web-platforminstaller.md)  
A valid value from the [InstallReturnCodeStatus](installreturncodestatus-enumeration-microsoft-web-platforminstaller.md) enumeration.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[InstallReturnCode Class](installreturncode-class-microsoft-web-platforminstaller.md)

[InstallReturnCode Members](installreturncode-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

