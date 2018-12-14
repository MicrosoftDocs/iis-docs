---
title: DeclaredParameter.Tags Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Tags Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.DeclaredParameter.Tags
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.declaredparameter.tags(v=VS.90)
ms:contentKeyID: 22049557
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.DeclaredParameter.Tags
- Microsoft.Web.PlatformInstaller.DeclaredParameter.get_Tags
- Microsoft.Web.PlatformInstaller.DeclaredParameter.set_Tags
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.DeclaredParameter.get_Tags
- Microsoft.Web.PlatformInstaller.DeclaredParameter.set_Tags
- Microsoft.Web.PlatformInstaller.DeclaredParameter.Tags
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Tags Property

Gets or sets a DeploymentWellKnownTag value that indicates the type of value this parameter represents.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicPropertyTagsAsDeploymentWellKnownTagGetSet
'Usage
DiminstanceAsDeclaredParameterDimvalueAsDeploymentWellKnownTagvalue = instance.Tags

instance.Tags = value
```

``` csharp
publicDeploymentWellKnownTagTags { get; set; }
```

``` c++
public:
propertyDeploymentWellKnownTagTags {
    DeploymentWellKnownTagget ();
    voidset (DeploymentWellKnownTagvalue);
}
```

``` jscript
function getTags () : DeploymentWellKnownTagfunction setTags (value : DeploymentWellKnownTag)
```

#### Property Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentWellKnownTag](deploymentwellknowntag-enumeration-microsoft-web-deployment.md)  
A value of one or more DeploymentWellKnownTag that indicate the type of value this parameter represents.  

## Remarks

DeploymentWellKnownTag is decorated with the Flags attribute. Therefore, this property may represent zero or more values from the enumeration. Use the bitwise AND operator to determine if the value of this property represents a value in the DeploymentWellKnownTag enumeration. Use the bitwise OR operator to flag this property with the enumeration value you wish to set.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[DeclaredParameter Class](declaredparameter-class-microsoft-web-platforminstaller.md)

[DeclaredParameter Members](declaredparameter-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

