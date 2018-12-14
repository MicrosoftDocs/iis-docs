---
title: ProductManager.SetResourceLanguage Method  (Microsoft.Web.PlatformInstaller)
TOCTitle: SetResourceLanguage Method
ms:assetid: M:Microsoft.Web.PlatformInstaller.ProductManager.SetResourceLanguage(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.productmanager.setresourcelanguage(v=VS.90)
ms:contentKeyID: 22049548
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.ProductManager.SetResourceLanguage
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.ProductManager.SetResourceLanguage
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SetResourceLanguage Method

Sets the current resource language.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicSubSetResourceLanguage ( _
    resourceLanguageAsString _
)
'Usage
DiminstanceAsProductManagerDimresourceLanguageAsString

instance.SetResourceLanguage(resourceLanguage)
```

``` csharp
publicvoidSetResourceLanguage(
    stringresourceLanguage
)
```

``` c++
public:
voidSetResourceLanguage(
    String^ resourceLanguage
)
```

``` jscript
publicfunctionSetResourceLanguage(
    resourceLanguage : String
)
```

#### Parameters

  - resourceLanguage  
    Type: String  
    The resource language to set for the current [ProductManager](productmanager-class-microsoft-web-platforminstaller.md) instance.  

## Exceptions

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th>Exception</th>
<th>Condition</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>[InvalidOperationException]</td>
<td><p>The resource file for the specified resourceLanguage was not found.</p></td>
</tr>
</tbody>
</table>


## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[ProductManager Class](productmanager-class-microsoft-web-platforminstaller.md)

[ProductManager Members](productmanager-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

