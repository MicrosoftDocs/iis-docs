---
title: PillarTab.Pillars Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Pillars Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.PillarTab.Pillars
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.pillartab.pillars(v=VS.90)
ms:contentKeyID: 22049705
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.PillarTab.Pillars
- Microsoft.Web.PlatformInstaller.PillarTab.get_Pillars
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.PillarTab.get_Pillars
- Microsoft.Web.PlatformInstaller.PillarTab.Pillars
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Pillars Property

Gets a read-only collection of pillars for the current tab.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyPillarsAsReadOnlyCollection(OfPillar)
    Get
'Usage
DiminstanceAsPillarTabDimvalueAsReadOnlyCollection(OfPillar)

value = instance.Pillars
```

``` csharp
publicReadOnlyCollection<Pillar> Pillars { get; }
```

``` c++
public:
propertyReadOnlyCollection<Pillar^>^ Pillars {
    ReadOnlyCollection<Pillar^>^ get ();
}
```

``` jscript
function getPillars () : ReadOnlyCollection<Pillar>
```

#### Property Value

Type: ReadOnlyCollection\< (Of \< ( \<'[Pillar](pillar-class-microsoft-web-platforminstaller.md)\> ) \> ) \>  
A generic ReadOnlyCollection of [Pillar](pillar-class-microsoft-web-platforminstaller.md) objects for the current tab.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[PillarTab Class](pillartab-class-microsoft-web-platforminstaller.md)

[PillarTab Members](pillartab-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

