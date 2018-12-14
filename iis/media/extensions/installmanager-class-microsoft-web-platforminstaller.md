---
title: InstallManager Class (Microsoft.Web.PlatformInstaller)
TOCTitle: InstallManager Class
ms:assetid: T:Microsoft.Web.PlatformInstaller.InstallManager
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installmanager(v=VS.90)
ms:contentKeyID: 22049731
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.InstallManager
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.InstallManager
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# InstallManager Class

Manages the installation configuration and installation process.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicNotInheritableClassInstallManager _
    ImplementsIDisposable
'Usage
DiminstanceAsInstallManager
```

``` csharp
publicsealedclassInstallManager : IDisposable
```

``` c++
publicref classInstallManagersealed : IDisposable
```

``` jscript
publicfinalclass InstallManager implementsIDisposable
```

## Remarks

This class provides methods to start and stop installation as well as perform cleanup duties associated with the post-installations or cancellations.

## Inheritance Hierarchy

Object  
  Microsoft.Web.PlatformInstaller..::..InstallManager  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[InstallManager Members](installmanager-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

