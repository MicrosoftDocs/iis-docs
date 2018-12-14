---
title: Tab.Id Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Id Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Tab.Id
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.tab.id(v=VS.90)
ms:contentKeyID: 22049538
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Tab.Id
- Microsoft.Web.PlatformInstaller.Tab.get_Id
- Microsoft.Web.PlatformInstaller.Tab.set_Id
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Tab.get_Id
- Microsoft.Web.PlatformInstaller.Tab.Id
- Microsoft.Web.PlatformInstaller.Tab.set_Id
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Id Property

Gets the string identifier of the current tab.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicPropertyIdAsStringGetProtectedSet
'Usage
DiminstanceAsTabDimvalueAsStringvalue = instance.Id

instance.Id = value
```

``` csharp
publicstringId { get; protectedset; }
```

``` c++
public:
propertyString^ Id {
    String^ get ();
    protected: voidset (String^ value);
}
```

``` jscript
function getId () : Stringprotectedfunction setId (value : String)
```

#### Property Value

Type: String  
A string that contains the unique identifier of the current tab.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Tab Class](tab-class-microsoft-web-platforminstaller.md)

[Tab Members](tab-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

