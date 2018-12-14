---
title: ProductManager.Load Method (, , , , ) (Microsoft.Web.PlatformInstaller)
TOCTitle: Load Method (, , , , )
ms:assetid: M:Microsoft.Web.PlatformInstaller.ProductManager.Load(System.Uri,System.Boolean,System.Boolean,System.Boolean,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.productmanager.load(v=VS.90)
ms:contentKeyID: 22049635
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

# Load Method (, , , , )

Loads product data specific to the current processor architecture and operating system from the specified productFileUrl. Optionally may load external file enclosures and use a cached file.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicSubLoad ( _
    productFileUrlAsUri, _
    filterByArchitectureAndOSAsBoolean, _
    loadEnclosuresAsBoolean, _
    useCachedVersionAsBoolean, _
    cacheDirectoryAsString _
)
'Usage
DiminstanceAsProductManagerDimproductFileUrlAsUriDimfilterByArchitectureAndOSAsBooleanDimloadEnclosuresAsBooleanDimuseCachedVersionAsBooleanDimcacheDirectoryAsString

instance.Load(productFileUrl, filterByArchitectureAndOS, _
    loadEnclosures, useCachedVersion, _
    cacheDirectory)
```

``` csharp
publicvoidLoad(
    UriproductFileUrl,
    boolfilterByArchitectureAndOS,
    boolloadEnclosures,
    booluseCachedVersion,
    stringcacheDirectory
)
```

``` c++
public:
voidLoad(
    Uri^ productFileUrl, 
    boolfilterByArchitectureAndOS, 
    boolloadEnclosures, 
    booluseCachedVersion, 
    String^ cacheDirectory
)
```

``` jscript
publicfunctionLoad(
    productFileUrl : Uri, 
    filterByArchitectureAndOS : boolean, 
    loadEnclosures : boolean, 
    useCachedVersion : boolean, 
    cacheDirectory : String
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

<!-- end list -->

  - loadEnclosures  
    Type: Boolean  
    Determines if the method should attempt to load external files specified in enclosures in the file represented by productFileUrl. true if the method should attempt to load external enclosures, otherwise false.  

<!-- end list -->

  - useCachedVersion  
    Type: Boolean  
    Determines if cached data should be used or the file should be downloaded again. true if the method should use the cached version from a previous attempt, otherwise false.  

<!-- end list -->

  - cacheDirectory  
    Type: String  
    The directory where the cached data is located.  

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
<td><p>productFileUrl or cacheDirectory are null Nothing nullptr unit a null reference (Nothing in Visual Basic) (Nothing in Visual Basic).</p></td>
</tr>
</tbody>
</table>


## Remarks

An enclosure in the XML file tasks the form of:

\<link rel='enclosure' href='\<uri\>'/\>


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

