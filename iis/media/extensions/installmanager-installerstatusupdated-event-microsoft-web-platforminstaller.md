---
title: InstallManager.InstallerStatusUpdated Event (Microsoft.Web.PlatformInstaller)
TOCTitle: InstallerStatusUpdated Event
ms:assetid: E:Microsoft.Web.PlatformInstaller.InstallManager.InstallerStatusUpdated
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installmanager.installerstatusupdated(v=VS.90)
ms:contentKeyID: 22049648
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.InstallManager.InstallerStatusUpdated
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.InstallManager.add_InstallerStatusUpdated
- Microsoft.Web.PlatformInstaller.InstallManager.InstallerStatusUpdated
- Microsoft.Web.PlatformInstaller.InstallManager.remove_InstallerStatusUpdated
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# InstallerStatusUpdated Event

Event that indicates the the installation status is updated.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
Public Event InstallerStatusUpdatedAsEventHandler(OfInstallStatusEventArgs)
'Usage
DiminstanceAsInstallManagerDimhandlerAsEventHandler(OfInstallStatusEventArgs)

AddHandler instance.InstallerStatusUpdated, handler
```

``` csharp
public event EventHandler<InstallStatusEventArgs> InstallerStatusUpdated
```

``` c++
public:
 eventEventHandler<InstallStatusEventArgs^>^ InstallerStatusUpdated {
    voidadd (EventHandler<InstallStatusEventArgs^>^ value);
    voidremove (EventHandler<InstallStatusEventArgs^>^ value);
}
```

``` jscript
JScript does not support events.
```

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[InstallManager Class](installmanager-class-microsoft-web-platforminstaller.md)

[InstallManager Members](installmanager-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

