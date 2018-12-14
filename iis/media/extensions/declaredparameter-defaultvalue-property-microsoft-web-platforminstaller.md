---
title: DeclaredParameter.DefaultValue Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: DefaultValue Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.DeclaredParameter.DefaultValue
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.declaredparameter.defaultvalue(v=VS.90)
ms:contentKeyID: 22049663
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.DeclaredParameter.DefaultValue
- Microsoft.Web.PlatformInstaller.DeclaredParameter.get_DefaultValue
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.DeclaredParameter.DefaultValue
- Microsoft.Web.PlatformInstaller.DeclaredParameter.get_DefaultValue
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DefaultValue Property

Gets the default value of a parameter.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyDefaultValueAsStringGet
'Usage
DiminstanceAsDeclaredParameterDimvalueAsStringvalue = instance.DefaultValue
```

``` csharp
publicstringDefaultValue { get; }
```

``` c++
public:
propertyString^ DefaultValue {
    String^ get ();
}
```

``` jscript
function getDefaultValue () : String
```

#### Property Value

Type: String  
A string that represents the default value of the parameter.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[DeclaredParameter Class](declaredparameter-class-microsoft-web-platforminstaller.md)

[DeclaredParameter Members](declaredparameter-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

