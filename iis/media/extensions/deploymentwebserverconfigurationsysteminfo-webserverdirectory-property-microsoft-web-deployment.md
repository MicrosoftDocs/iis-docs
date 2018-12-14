---
title: DeploymentWebServerConfigurationSystemInfo.WebServerDirectory Property  (Microsoft.Web.Deployment)
TOCTitle: WebServerDirectory Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.WebServerDirectory
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentwebserverconfigurationsysteminfo.webserverdirectory(v=VS.90)
ms:contentKeyID: 22753944
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.WebServerDirectory
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.get_WebServerDirectory
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.set_WebServerDirectory
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.get_WebServerDirectory
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.set_WebServerDirectory
- Microsoft.Web.Deployment.DeploymentWebServerConfigurationSystemInfo.WebServerDirectory
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# WebServerDirectory Property

Gets or sets the path to the directory that contains the service-related files for IIS.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicPropertyWebServerDirectoryAsString
'Usage
DiminstanceAsDeploymentWebServerConfigurationSystemInfoDimvalueAsStringvalue = instance.WebServerDirectory

instance.WebServerDirectory = value
```

``` csharp
publicstringWebServerDirectory { get; set; }
```

``` c++
public:
propertyString^ WebServerDirectory {
    String^ get ();
    voidset (String^ value);
}
```

``` jscript
function getWebServerDirectory () : Stringfunction setWebServerDirectory (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
Contains the path to the directory that contains the service-related files for IIS.  

## Remarks

For IIS 7 the default directory for the service-related files is %SystemDrive%\\windows\\system32\\inetsrv.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentWebServerConfigurationSystemInfo Class](deploymentwebserverconfigurationsysteminfo-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

