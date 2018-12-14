---
title: InstallReturnCode.DetailedInformation Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: DetailedInformation Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.InstallReturnCode.DetailedInformation
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installreturncode.detailedinformation(v=VS.90)
ms:contentKeyID: 22049523
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.InstallReturnCode.DetailedInformation
- Microsoft.Web.PlatformInstaller.InstallReturnCode.get_DetailedInformation
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.InstallReturnCode.DetailedInformation
- Microsoft.Web.PlatformInstaller.InstallReturnCode.get_DetailedInformation
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DetailedInformation Property

Gets or sets the detailed information regarding the status of an installation action..

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyDetailedInformationAsStringGet
'Usage
DiminstanceAsInstallReturnCodeDimvalueAsStringvalue = instance.DetailedInformation
```

``` csharp
publicstringDetailedInformation { get; }
```

``` c++
public:
propertyString^ DetailedInformation {
    String^ get ();
}
```

``` jscript
function getDetailedInformation () : String
```

#### Property Value

Type: String  
A string that contains detailed information.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[InstallReturnCode Class](installreturncode-class-microsoft-web-platforminstaller.md)

[InstallReturnCode Members](installreturncode-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

