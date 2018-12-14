---
title: GroupTab.Groups Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Groups Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.GroupTab.Groups
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.grouptab.groups(v=VS.90)
ms:contentKeyID: 22049522
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.GroupTab.Groups
- Microsoft.Web.PlatformInstaller.GroupTab.get_Groups
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.GroupTab.get_Groups
- Microsoft.Web.PlatformInstaller.GroupTab.Groups
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Groups Property

Gets the groups that this tab represents.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyGroupsAsReadOnlyCollection(OfGroup)
    Get
'Usage
DiminstanceAsGroupTabDimvalueAsReadOnlyCollection(OfGroup)

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
A ReadOnlyCOllection of [Group](group-class-microsoft-web-platforminstaller.md) objects.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[GroupTab Class](grouptab-class-microsoft-web-platforminstaller.md)

[GroupTab Members](grouptab-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

