---
title: InstallManager.InstallCompleted Event (Microsoft.Web.PlatformInstaller)
TOCTitle: InstallCompleted Event
ms:assetid: E:Microsoft.Web.PlatformInstaller.InstallManager.InstallCompleted
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installmanager.installcompleted(v=VS.90)
ms:contentKeyID: 22049746
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.InstallManager.InstallCompleted
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.InstallManager.add_InstallCompleted
- Microsoft.Web.PlatformInstaller.InstallManager.InstallCompleted
- Microsoft.Web.PlatformInstaller.InstallManager.remove_InstallCompleted
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# InstallCompleted Event

Event that indicates the installation has completed.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
Public Event InstallCompletedAsEventHandler(OfEventArgs)
'Usage
DiminstanceAsInstallManagerDimhandlerAsEventHandler(OfEventArgs)

AddHandler instance.InstallCompleted, handler
```

``` csharp
public event EventHandler<EventArgs> InstallCompleted
```

``` c++
public:
 eventEventHandler<EventArgs^>^ InstallCompleted {
    voidadd (EventHandler<EventArgs^>^ value);
    voidremove (EventHandler<EventArgs^>^ value);
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

