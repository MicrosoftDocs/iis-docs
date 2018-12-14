---
title: MSDeployPackage.GetDBConnectionErrorString Method  (Microsoft.Web.PlatformInstaller)
TOCTitle: GetDBConnectionErrorString Method
ms:assetid: M:Microsoft.Web.PlatformInstaller.MSDeployPackage.GetDBConnectionErrorString(Microsoft.Web.PlatformInstaller.DatabaseProvider)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.msdeploypackage.getdbconnectionerrorstring(v=VS.90)
ms:contentKeyID: 22187114
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.MSDeployPackage.GetDBConnectionErrorString
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.MSDeployPackage.GetDBConnectionErrorString
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetDBConnectionErrorString Method

Gets the exception thrown by a failed database connection.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicFunctionGetDBConnectionErrorString ( _
    providerAsDatabaseProvider _
) AsString
'Usage
DiminstanceAsMSDeployPackageDimproviderAsDatabaseProviderDimreturnValueAsStringreturnValue = instance.GetDBConnectionErrorString(provider)
```

``` csharp
publicstringGetDBConnectionErrorString(
    DatabaseProviderprovider
)
```

``` c++
public:
String^ GetDBConnectionErrorString(
    DatabaseProviderprovider
)
```

``` jscript
publicfunctionGetDBConnectionErrorString(
    provider : DatabaseProvider
) : String
```

#### Parameters

  - provider  
    Type: [Microsoft.Web.PlatformInstaller. . :: . .DatabaseProvider](databaseprovider-enumeration-microsoft-web-platforminstaller.md)  
    A [DatabaseProvider](databaseprovider-enumeration-microsoft-web-platforminstaller.md) instance.  

#### Return Value

Type: String  
A string value that contains the database connection error.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[MSDeployPackage Class](msdeploypackage-class-microsoft-web-platforminstaller.md)

[MSDeployPackage Members](msdeploypackage-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

