---
title: ProductManager.LoadExternalFile Method  (Microsoft.Web.PlatformInstaller)
TOCTitle: LoadExternalFile Method
ms:assetid: M:Microsoft.Web.PlatformInstaller.ProductManager.LoadExternalFile(System.Uri)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.productmanager.loadexternalfile(v=VS.90)
ms:contentKeyID: 22049590
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.ProductManager.LoadExternalFile
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.ProductManager.LoadExternalFile
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# LoadExternalFile Method

Loads the specified file in the product manager after making sure it is valid.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicSubLoadExternalFile ( _
    uriAsUri _
)
'Usage
DiminstanceAsProductManagerDimuriAsUri

instance.LoadExternalFile(uri)
```

``` csharp
publicvoidLoadExternalFile(
    Uriuri
)
```

``` c++
public:
voidLoadExternalFile(
    Uri^ uri
)
```

``` jscript
publicfunctionLoadExternalFile(
    uri : Uri
)
```

#### Parameters

  - uri  
    Type: Uri  
    A Uri where the product file is located.  

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
<td>[ArgumentNullException]</td>
<td><p>uri is null Nothing nullptr unit a null reference (Nothing in Visual Basic) (Nothing in Visual Basic)</p></td>
</tr>
</tbody>
</table>


## Remarks

This method downloads the file and stores it in a cache location. The downloaded file is then merged with the results of the current [ProductManager](productmanager-class-microsoft-web-platforminstaller.md) products.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[ProductManager Class](productmanager-class-microsoft-web-platforminstaller.md)

[ProductManager Members](productmanager-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

