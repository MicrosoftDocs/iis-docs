---
title: InstallManager.Load Method ((Installer)) (Microsoft.Web.PlatformInstaller)
TOCTitle: Load Method ((Installer))
ms:assetid: M:Microsoft.Web.PlatformInstaller.InstallManager.Load(System.Collections.Generic.IEnumerable{Microsoft.Web.PlatformInstaller.Installer})
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installmanager.load(v=VS.90)
ms:contentKeyID: 22049688
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
- Microsoft.Web.PlatformInstaller.InstallManager.Load
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Load Method ((Installer))

Loads a collection of installers from the given generic IEnumerable collection of [Installer](installer-class-microsoft-web-platforminstaller.md) objects.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicSubLoad ( _
    installersAsIEnumerable(OfInstaller) _
)
'Usage
DiminstanceAsInstallManagerDiminstallersAsIEnumerable(OfInstaller)

instance.Load(installers)
```

``` csharp
publicvoidLoad(
    IEnumerable<Installer> installers
)
```

``` c++
public:
voidLoad(
    IEnumerable<Installer^>^ installers
)
```

``` jscript
publicfunctionLoad(
    installers : IEnumerable<Installer>
)
```

#### Parameters

  - installers  
    Type: IEnumerable\< (Of \< ( \<'[Installer](installer-class-microsoft-web-platforminstaller.md)\> ) \> ) \>  
    An IEnumerable collection of [Installer](installer-class-microsoft-web-platforminstaller.md) objects.  

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
<td><p>The installers parameter is null Nothing nullptr unit a null reference (Nothing in Visual Basic) (Nothing in Visual Basic)</p></td>
</tr>
<tr class="even">
<td>[InvalidOperationException]</td>
<td><p>The per-installation install log folder was not null or empty. This indicates the <a href="installmanager-class-microsoft-web-platforminstaller.md">InstallManager</a> is being reused and has not been properly reinitialized.</p></td>
</tr>
</tbody>
</table>


## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[InstallManager Class](installmanager-class-microsoft-web-platforminstaller.md)

[InstallManager Members](installmanager-members-microsoft-web-platforminstaller.md)

[Load Overload](installmanager-load-method-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

