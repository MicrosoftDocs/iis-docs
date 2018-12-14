---
title: ProductManager.WebPlatformInstallerUpdateAvailable Event (Microsoft.Web.PlatformInstaller)
TOCTitle: WebPlatformInstallerUpdateAvailable Event
ms:assetid: E:Microsoft.Web.PlatformInstaller.ProductManager.WebPlatformInstallerUpdateAvailable
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.productmanager.webplatforminstallerupdateavailable(v=VS.90)
ms:contentKeyID: 22049656
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.ProductManager.WebPlatformInstallerUpdateAvailable
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.ProductManager.add_WebPlatformInstallerUpdateAvailable
- Microsoft.Web.PlatformInstaller.ProductManager.remove_WebPlatformInstallerUpdateAvailable
- Microsoft.Web.PlatformInstaller.ProductManager.WebPlatformInstallerUpdateAvailable
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# WebPlatformInstallerUpdateAvailable Event

Event indicates that a new version of the Web Platform Installer executable is available.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
Public Event WebPlatformInstallerUpdateAvailableAsEventHandler(OfUpdateAvailableEventArgs)
'Usage
DiminstanceAsProductManagerDimhandlerAsEventHandler(OfUpdateAvailableEventArgs)

AddHandler instance.WebPlatformInstallerUpdateAvailable, handler
```

``` csharp
public event EventHandler<UpdateAvailableEventArgs> WebPlatformInstallerUpdateAvailable
```

``` c++
public:
 eventEventHandler<UpdateAvailableEventArgs^>^ WebPlatformInstallerUpdateAvailable {
    voidadd (EventHandler<UpdateAvailableEventArgs^>^ value);
    voidremove (EventHandler<UpdateAvailableEventArgs^>^ value);
}
```

``` jscript
JScript does not support events.
```

## Remarks

Event listeners may evaluate the [UpdateAvailableEventArgs](updateavailableeventargs-class-microsoft-web-platforminstaller.md) object provided by the event to receive the caption and text to display in the user interface dialog.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[ProductManager Class](productmanager-class-microsoft-web-platforminstaller.md)

[ProductManager Members](productmanager-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

