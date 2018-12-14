---
title: InstallManager.Save Method () (Microsoft.Web.PlatformInstaller)
TOCTitle: Save Method ()
ms:assetid: M:Microsoft.Web.PlatformInstaller.InstallManager.Save(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installmanager.save(v=VS.90)
ms:contentKeyID: 22049741
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
- Microsoft.Web.PlatformInstaller.InstallManager.Save
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Save Method ()

Saves the current installation configuration in the specified location.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicSubSave ( _
    fileLocationAsString _
)
'Usage
DiminstanceAsInstallManagerDimfileLocationAsString

instance.Save(fileLocation)
```

``` csharp
publicvoidSave(
    stringfileLocation
)
```

``` c++
public:
voidSave(
    String^ fileLocation
)
```

``` jscript
publicfunctionSave(
    fileLocation : String
)
```

#### Parameters

  - fileLocation  
    Type: String  
    The location to save the file that contains the current installer cofniguration.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[InstallManager Class](installmanager-class-microsoft-web-platforminstaller.md)

[InstallManager Members](installmanager-members-microsoft-web-platforminstaller.md)

[Save Overload](installmanager-save-method-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

