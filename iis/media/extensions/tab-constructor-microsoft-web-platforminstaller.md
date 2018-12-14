---
title: Tab Constructor  (Microsoft.Web.PlatformInstaller)
TOCTitle: Tab Constructor
ms:assetid: M:Microsoft.Web.PlatformInstaller.Tab.#ctor(Microsoft.Web.PlatformInstaller.ProductManager)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.tab.tab(v=VS.90)
ms:contentKeyID: 22049684
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Tab.Tab
- Microsoft.Web.PlatformInstaller.Tab.#ctor
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Tab..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Tab Constructor

Creates an instance of a Tab object.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
ProtectedSubNew ( _
    productManagerAsProductManager _
)
'Usage
DimproductManagerAsProductManagerDiminstanceAs NewTab(productManager)
```

``` csharp
protectedTab(
    ProductManagerproductManager
)
```

``` c++
protected:
Tab(
    ProductManager^ productManager
)
```

``` jscript
protectedfunctionTab(
    productManager : ProductManager
)
```

#### Parameters

  - productManager  
    Type: [Microsoft.Web.PlatformInstaller. . :: . .ProductManager](productmanager-class-microsoft-web-platforminstaller.md)  
    The [ProductManager](productmanager-class-microsoft-web-platforminstaller.md) object this tab is related to.  

## Remarks

This constructor is protected and should be called by the constructor of inheriting classes.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Tab Class](tab-class-microsoft-web-platforminstaller.md)

[Tab Members](tab-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

