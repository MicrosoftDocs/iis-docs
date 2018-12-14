---
title: DeploymentWebServerConfigurationSystemInfo.SchemaDirectory Property  (Microsoft.Web.Deployment)
TOCTitle: SchemaDirectory Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.SchemaDirectory
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentwebserverconfigurationsysteminfo.schemadirectory(v=VS.90)
ms:contentKeyID: 22754025
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.SchemaDirectory
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.get_SchemaDirectory
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.get_SchemaDirectory
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.SchemaDirectory
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SchemaDirectory Property

Gets or sets the path to the Web server’s schema directory.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertySchemaDirectoryAsString
'Usage
DiminstanceAsDeploymentWebServerConfigurationSystemInfoDimvalueAsStringvalue = instance.SchemaDirectory
```

``` csharp
publicstringSchemaDirectory { get; }
```

``` c++
public:
propertyString^ SchemaDirectory {
    String^ get ();
}
```

``` jscript
function getSchemaDirectory () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
Contains the path to the Web server’s schema directory.  

## Remarks

The schema directory for IIS 7 contains the schema files that define all of the settings and default values for IIS 7’s configuration.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentWebServerConfigurationSystemInfo Class](deploymentwebserverconfigurationsysteminfo-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

