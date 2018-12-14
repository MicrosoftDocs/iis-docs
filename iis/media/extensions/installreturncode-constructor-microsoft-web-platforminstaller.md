---
title: InstallReturnCode Constructor  (Microsoft.Web.PlatformInstaller)
TOCTitle: InstallReturnCode Constructor
ms:assetid: M:Microsoft.Web.PlatformInstaller.InstallReturnCode.#ctor(Microsoft.Web.PlatformInstaller.InstallReturnCodeStatus,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installreturncode.installreturncode(v=VS.90)
ms:contentKeyID: 22187108
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.InstallReturnCode.InstallReturnCode
- Microsoft.Web.PlatformInstaller.InstallReturnCode.#ctor
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.InstallReturnCode..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# InstallReturnCode Constructor

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    statusAsInstallReturnCodeStatus, _
    detailedInformationAsString _
)
'Usage
DimstatusAsInstallReturnCodeStatusDimdetailedInformationAsStringDiminstanceAs NewInstallReturnCode(status, _
    detailedInformation)
```

``` csharp
publicInstallReturnCode(
    InstallReturnCodeStatusstatus,
    stringdetailedInformation
)
```

``` c++
public:
InstallReturnCode(
    InstallReturnCodeStatusstatus, 
    String^ detailedInformation
)
```

``` jscript
publicfunctionInstallReturnCode(
    status : InstallReturnCodeStatus, 
    detailedInformation : String
)
```

#### Parameters

  - status  
    Type: [Microsoft.Web.PlatformInstaller. . :: . .InstallReturnCodeStatus](installreturncodestatus-enumeration-microsoft-web-platforminstaller.md)  

<!-- end list -->

  - detailedInformation  
    Type: String  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[InstallReturnCode Class](installreturncode-class-microsoft-web-platforminstaller.md)

[InstallReturnCode Members](installreturncode-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

