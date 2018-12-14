---
title: DeploymentBaseOptions.Password Property  (Microsoft.Web.Deployment)
TOCTitle: Password Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentBaseOptions.Password
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentbaseoptions.password(v=VS.90)
ms:contentKeyID: 20208821
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentBaseOptions.Password
- Microsoft.Web.Deployment.DeploymentBaseOptions.get_Password
- Microsoft.Web.Deployment.DeploymentBaseOptions.set_Password
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentBaseOptions.get_Password
- Microsoft.Web.Deployment.DeploymentBaseOptions.Password
- Microsoft.Web.Deployment.DeploymentBaseOptions.set_Password
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Password Property

Gets or sets the password used to access the deployment location.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicPropertyPasswordAsString
'Usage
DiminstanceAsDeploymentBaseOptionsDimvalueAsStringvalue = instance.Password

instance.Password = value
```

``` csharp
publicstringPassword { get; set; }
```

``` c++
public:
propertyString^ Password {
    String^ get ();
    voidset (String^ value);
}
```

``` jscript
function getPassword () : Stringfunction setPassword (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string that contains the unencrypted password.  

## Examples

The following example implements several properties of the [DeploymentBaseOptions](deploymentbaseoptions-class-microsoft-web-deployment.md) class. This example instantiates the [DeploymentBaseOptions](deploymentbaseoptions-class-microsoft-web-deployment.md) for both the source and destination objects and modifies the property values to enable a remote sync operation.

    using System;
    using Microsoft.Web.Deployment;
    
    namespace MSDeploy.Web.Deployment
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Example to show how DeploymentBaseOptions can be used
                string _directory = Environment.ExpandEnvironmentVariables(
                    @"%systemdrive%\inetpub\wwwroot");
                DeploymentSyncOptions syncOptions = 
                    new DeploymentSyncOptions();
                DeploymentBaseOptions sourceBaseOptions = 
                    new DeploymentBaseOptions();
                sourceBaseOptions.ComputerName = "sourceMachineName";
                sourceBaseOptions.IncludeAcls = true; // false by default
                sourceBaseOptions.UserName = "username";
                sourceBaseOptions.Password = "password";
                DeploymentBaseOptions destinationBaseOptions = 
                    new DeploymentBaseOptions();
                destinationBaseOptions.ComputerName = 
                    "destinationMachineName";
                destinationBaseOptions.UserName = "username";
                destinationBaseOptions.Password = "password";
                DeploymentObject deploymentObject = 
                    DeploymentManager.CreateObject("contentPath", 
                    _directory, sourceBaseOptions);
                deploymentObject.SyncTo(
                    DeploymentWellKnownProvider.ContentPath, _directory,
                    destinationBaseOptions, syncOptions);
            }
        }
    }

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentBaseOptions Class](deploymentbaseoptions-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

