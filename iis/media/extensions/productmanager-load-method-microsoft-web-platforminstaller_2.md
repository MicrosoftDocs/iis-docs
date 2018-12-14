---
title: ProductManager.Load Method (, ) (Microsoft.Web.PlatformInstaller)
TOCTitle: Load Method (, )
ms:assetid: M:Microsoft.Web.PlatformInstaller.ProductManager.Load(System.Uri,System.Boolean)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.productmanager.load(v=VS.90)
ms:contentKeyID: 22049541
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- c++
- jscript
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.ProductManager.Load
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Load Method (, )

Loads product data specific to the current processor architecture and operating system from the specified productFileUrl.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicSubLoad ( _
    productFileUrlAsUri, _
    filterByArchitectureAndOSAsBoolean _
)
'Usage
DiminstanceAsProductManagerDimproductFileUrlAsUriDimfilterByArchitectureAndOSAsBoolean

instance.Load(productFileUrl, filterByArchitectureAndOS)
```

``` csharp
publicvoidLoad(
    UriproductFileUrl,
    boolfilterByArchitectureAndOS
)
```

``` c++
public:
voidLoad(
    Uri^ productFileUrl, 
    boolfilterByArchitectureAndOS
)
```

``` jscript
publicfunctionLoad(
    productFileUrl : Uri, 
    filterByArchitectureAndOS : boolean
)
```

#### Parameters

  - productFileUrl  
    Type: Uri  
    A Uri where the product file is located.  

<!-- end list -->

  - filterByArchitectureAndOS  
    Type: Boolean  
    Determines whether the product file should be filtered to include only those products available for the current processor architecture and operating system. true if the file should be filtered, otherwise false.  

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
<td><p>productFileUrl is null Nothing nullptr unit a null reference (Nothing in Visual Basic) (Nothing in Visual Basic).</p></td>
</tr>
</tbody>
</table>


## Remarks


> [!NOTE]
> <P>Processor architecture is determined by evaluating the <STRONG>PROCESSOR_ARCHITECTURE</STRONG> key found in <STRONG>System\CurrentControlSet\Control\Session Manager\Environment</STRONG>.</P>



## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[ProductManager Class](productmanager-class-microsoft-web-platforminstaller.md)

[ProductManager Members](productmanager-members-microsoft-web-platforminstaller.md)

[Load Overload](productmanager-load-method-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

