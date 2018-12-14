---
title: ProductManager.GetTab Method  (Microsoft.Web.PlatformInstaller)
TOCTitle: GetTab Method
ms:assetid: M:Microsoft.Web.PlatformInstaller.ProductManager.GetTab(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.productmanager.gettab(v=VS.90)
ms:contentKeyID: 46408529
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.ProductManager.GetTab
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.ProductManager.GetTab
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetTab Method

Gets a tab from its identifier.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicFunctionGetTab ( _
    tabIdAsString _
) AsTab
'Usage
DiminstanceAsProductManagerDimtabIdAsStringDimreturnValueAsTabreturnValue = instance.GetTab(tabId)
```

``` csharp
publicTabGetTab(
    stringtabId
)
```

``` c++
public:
Tab^ GetTab(
    String^ tabId
)
```

``` jscript
publicfunctionGetTab(
    tabId : String
) : Tab
```

#### Parameters

  - tabId  
    Type: String  
    A string value that specifies the tab Id.  

#### Return Value

Type: [Microsoft.Web.PlatformInstaller. . :: . .Tab](tab-class-microsoft-web-platforminstaller.md)  
A [Tab](tab-class-microsoft-web-platforminstaller.md) object.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[ProductManager Class](productmanager-class-microsoft-web-platforminstaller.md)

[ProductManager Members](productmanager-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

