---
title: Pillar.Groups Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Groups Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Pillar.Groups
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.pillar.groups(v=VS.90)
ms:contentKeyID: 22049783
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Pillar.Groups
- Microsoft.Web.PlatformInstaller.Pillar.get_Groups
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Pillar.get_Groups
- Microsoft.Web.PlatformInstaller.Pillar.Groups
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Groups Property

Gets a read-only collection of groups associated to the pillar.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyGroupsAsReadOnlyCollection(OfGroup)
    Get
'Usage
DiminstanceAsPillarDimvalueAsReadOnlyCollection(OfGroup)

value = instance.Groups
```

``` csharp
publicReadOnlyCollection<Group> Groups { get; }
```

``` c++
public:
propertyReadOnlyCollection<Group^>^ Groups {
    ReadOnlyCollection<Group^>^ get ();
}
```

``` jscript
function getGroups () : ReadOnlyCollection<Group>
```

#### Property Value

Type: ReadOnlyCollection\< (Of \< ( \<'[Group](group-class-microsoft-web-platforminstaller.md)\> ) \> ) \>  
A generic ReadOnlyCollection of [Group](group-class-microsoft-web-platforminstaller.md) objects associated with the current pillar.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Pillar Class](pillar-class-microsoft-web-platforminstaller.md)

[Pillar Members](pillar-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

