---
title: PillarTab.Name Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Name Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.PillarTab.Name
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.pillartab.name(v=VS.90)
ms:contentKeyID: 22049536
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.PillarTab.Name
- Microsoft.Web.PlatformInstaller.PillarTab.get_Name
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.PillarTab.get_Name
- Microsoft.Web.PlatformInstaller.PillarTab.Name
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Name Property

Gets a string that represents the name of the current pillar tab.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicOverridesReadOnlyPropertyNameAsStringGet
'Usage
DiminstanceAsPillarTabDimvalueAsStringvalue = instance.Name
```

``` csharp
publicoverridestringName { get; }
```

``` c++
public:
virtualpropertyString^ Name {
    String^ get () override;
}
```

``` jscript
overridefunction getName () : String
```

#### Property Value

Type: String  
A string that contains the name of the current pillar tab.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[PillarTab Class](pillartab-class-microsoft-web-platforminstaller.md)

[PillarTab Members](pillartab-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

