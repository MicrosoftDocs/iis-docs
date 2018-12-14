---
title: DeclaredParameter.FriendlyName Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: FriendlyName Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.DeclaredParameter.FriendlyName
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.declaredparameter.friendlyname(v=VS.90)
ms:contentKeyID: 22187111
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.DeclaredParameter.FriendlyName
- Microsoft.Web.PlatformInstaller.DeclaredParameter.get_FriendlyName
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.DeclaredParameter.FriendlyName
- Microsoft.Web.PlatformInstaller.DeclaredParameter.get_FriendlyName
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# FriendlyName Property

Gets a string that contains the localized name of the declared parameter.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyFriendlyNameAsStringGet
'Usage
DiminstanceAsDeclaredParameterDimvalueAsStringvalue = instance.FriendlyName
```

``` csharp
publicstringFriendlyName { get; }
```

``` c++
public:
propertyString^ FriendlyName {
    String^ get ();
}
```

``` jscript
function getFriendlyName () : String
```

#### Property Value

Type: String  
A string that contains the localized name of the declared parameter.  

## Remarks


> [!NOTE]
> <P>The FriendlyName is displayed in the user interface.</P>



## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[DeclaredParameter Class](declaredparameter-class-microsoft-web-platforminstaller.md)

[DeclaredParameter Members](declaredparameter-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

