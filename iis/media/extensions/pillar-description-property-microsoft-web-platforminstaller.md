---
title: Pillar.Description Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Description Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Pillar.Description
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.pillar.description(v=VS.90)
ms:contentKeyID: 22049637
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Pillar.Description
- Microsoft.Web.PlatformInstaller.Pillar.get_Description
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Pillar.Description
- Microsoft.Web.PlatformInstaller.Pillar.get_Description
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Description Property

Gets a string that contains the description of the pillar.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyDescriptionAsStringGet
'Usage
DiminstanceAsPillarDimvalueAsStringvalue = instance.Description
```

``` csharp
publicstringDescription { get; }
```

``` c++
public:
propertyString^ Description {
    String^ get ();
}
```

``` jscript
function getDescription () : String
```

#### Property Value

Type: String  
A string that contains the description of the pillar.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Pillar Class](pillar-class-microsoft-web-platforminstaller.md)

[Pillar Members](pillar-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

