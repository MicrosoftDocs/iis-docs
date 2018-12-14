---
title: Pillar Class (Microsoft.Web.PlatformInstaller)
TOCTitle: Pillar Class
ms:assetid: T:Microsoft.Web.PlatformInstaller.Pillar
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.pillar(v=VS.90)
ms:contentKeyID: 22049692
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Pillar
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Pillar
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Pillar Class

Represents a top-level product with one or more associated or otherwise recommended products to install.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicClassPillar
'Usage
DiminstanceAsPillar
```

``` csharp
publicclassPillar
```

``` c++
publicref classPillar
```

``` jscript
publicclass Pillar
```

## Remarks

A "pillar" represents a product with associated or recommended child products. The associated [PillarTab](pillartab-class-microsoft-web-platforminstaller.md) allows a user to select the core product, and then configure the associated products from a dialog resembling a [GroupTab](grouptab-class-microsoft-web-platforminstaller.md).

## Inheritance Hierarchy

Object  
  Microsoft.Web.PlatformInstaller..::..Pillar  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Pillar Members](pillar-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

[PillarTab](pillartab-class-microsoft-web-platforminstaller.md)

[GroupTab](grouptab-class-microsoft-web-platforminstaller.md)

