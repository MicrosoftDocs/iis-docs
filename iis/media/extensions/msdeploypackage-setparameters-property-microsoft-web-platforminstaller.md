---
title: MSDeployPackage.SetParameters Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: SetParameters Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.MSDeployPackage.SetParameters
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.msdeploypackage.setparameters(v=VS.90)
ms:contentKeyID: 22049673
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.MSDeployPackage.SetParameters
- Microsoft.Web.PlatformInstaller.MSDeployPackage.get_SetParameters
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.MSDeployPackage.get_SetParameters
- Microsoft.Web.PlatformInstaller.MSDeployPackage.SetParameters
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SetParameters Property

Gets a generic string to string dictionary that contains parameters to set.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertySetParametersAsDictionary(OfString, String)
    Get
'Usage
DiminstanceAsMSDeployPackageDimvalueAsDictionary(OfString, String)

value = instance.SetParameters
```

``` csharp
publicDictionary<string, string> SetParameters { get; }
```

``` c++
public:
propertyDictionary<String^, String^>^ SetParameters {
    Dictionary<String^, String^>^ get ();
}
```

``` jscript
function getSetParameters () : Dictionary<String, String>
```

#### Property Value

Type: Dictionary\< (Of \< ( \<'String, String\> ) \> ) \>  
A generic Dictionary of string keys and string values to set.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[MSDeployPackage Class](msdeploypackage-class-microsoft-web-platforminstaller.md)

[MSDeployPackage Members](msdeploypackage-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

