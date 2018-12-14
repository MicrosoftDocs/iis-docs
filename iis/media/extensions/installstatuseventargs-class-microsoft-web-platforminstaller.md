---
title: InstallStatusEventArgs Class (Microsoft.Web.PlatformInstaller)
TOCTitle: InstallStatusEventArgs Class
ms:assetid: T:Microsoft.Web.PlatformInstaller.InstallStatusEventArgs
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installstatuseventargs(v=VS.90)
ms:contentKeyID: 22049776
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.InstallStatusEventArgs
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.InstallStatusEventArgs
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# InstallStatusEventArgs Class

Represents an event argument provided when an installation status event is fired.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicClassInstallStatusEventArgs _
    InheritsEventArgs
'Usage
DiminstanceAsInstallStatusEventArgs
```

``` csharp
publicclassInstallStatusEventArgs : EventArgs
```

``` c++
publicref classInstallStatusEventArgs : publicEventArgs
```

``` jscript
publicclass InstallStatusEventArgs extendsEventArgs
```

## Remarks

This event argument is provided when the [InstallerStatusUpdated](installmanager-installerstatusupdated-event-microsoft-web-platforminstaller.md) event of the [InstallManager](installmanager-class-microsoft-web-platforminstaller.md) class is fired.

## Inheritance Hierarchy

Object  
  EventArgs  
    Microsoft.Web.PlatformInstaller..::..InstallStatusEventArgs  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[InstallStatusEventArgs Members](installstatuseventargs-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

