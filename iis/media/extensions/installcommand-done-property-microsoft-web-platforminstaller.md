---
title: InstallCommand.Done Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Done Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.InstallCommand.Done
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installcommand.done(v=VS.90)
ms:contentKeyID: 22049640
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.InstallCommand.Done
- Microsoft.Web.PlatformInstaller.InstallCommand.get_Done
- Microsoft.Web.PlatformInstaller.InstallCommand.set_Done
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.InstallCommand.Done
- Microsoft.Web.PlatformInstaller.InstallCommand.get_Done
- Microsoft.Web.PlatformInstaller.InstallCommand.set_Done
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Done Property

Gets or sets a value indicating the command that this object represents has completed.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicPropertyDoneAsBooleanGetProtected FriendSet
'Usage
DiminstanceAsInstallCommandDimvalueAsBooleanvalue = instance.Done

instance.Done = value
```

``` csharp
publicboolDone { get; protected internalset; }
```

``` c++
public:
propertyboolDone {
    boolget ();
    protected public: voidset (boolvalue);
}
```

``` jscript
function getDone () : booleanfunction setDone (value : boolean)
```

#### Property Value

Type: Boolean  
true if the [InstallCommand](installcommand-class-microsoft-web-platforminstaller.md) is completed, otherwise false.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[InstallCommand Class](installcommand-class-microsoft-web-platforminstaller.md)

[InstallCommand Members](installcommand-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

