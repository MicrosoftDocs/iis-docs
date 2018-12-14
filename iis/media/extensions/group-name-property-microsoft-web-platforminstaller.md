---
title: Group.Name Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Name Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Group.Name
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.group.name(v=VS.90)
ms:contentKeyID: 22049514
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Group.Name
- Microsoft.Web.PlatformInstaller.Group.get_Name
- Microsoft.Web.PlatformInstaller.Group.set_Name
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Group.get_Name
- Microsoft.Web.PlatformInstaller.Group.Name
- Microsoft.Web.PlatformInstaller.Group.set_Name
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Name Property

Gets or sets the name of the group.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicPropertyNameAsStringGetFriendSet
'Usage
DiminstanceAsGroupDimvalueAsStringvalue = instance.Name
```

``` csharp
publicstringName { get; internalset; }
```

``` c++
public:
propertyString^ Name {
    String^ get ();
    internal: voidset (String^ value);
}
```

``` jscript
function getName () : Stringinternalfunction setName (value : String)
```

#### Property Value

Type: String  
A string that represents the name of the group.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Group Class](group-class-microsoft-web-platforminstaller.md)

[Group Members](group-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

