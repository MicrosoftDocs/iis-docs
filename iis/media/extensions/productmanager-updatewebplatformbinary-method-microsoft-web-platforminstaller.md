---
title: ProductManager.UpdateWebPlatformBinary Method  (Microsoft.Web.PlatformInstaller)
TOCTitle: UpdateWebPlatformBinary Method
ms:assetid: M:Microsoft.Web.PlatformInstaller.ProductManager.UpdateWebPlatformBinary
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.productmanager.updatewebplatformbinary(v=VS.90)
ms:contentKeyID: 22049660
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.ProductManager.UpdateWebPlatformBinary
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.ProductManager.UpdateWebPlatformBinary
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# UpdateWebPlatformBinary Method

Downloads and updates the Web Platform Installer executable binary.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicSharedSubUpdateWebPlatformBinary
'Usage
ProductManager.UpdateWebPlatformBinary()
```

``` csharp
publicstaticvoidUpdateWebPlatformBinary()
```

``` c++
public:
staticvoidUpdateWebPlatformBinary()
```

``` jscript
publicstaticfunctionUpdateWebPlatformBinary()
```

## Remarks

This method downloads the Web Platform Installer executable and replaces it. A new process is then launched with the new executable and the current executable environment is unloaded.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[ProductManager Class](productmanager-class-microsoft-web-platforminstaller.md)

[ProductManager Members](productmanager-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

