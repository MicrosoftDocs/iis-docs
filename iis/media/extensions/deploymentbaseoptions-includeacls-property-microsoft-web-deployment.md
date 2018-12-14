---
title: DeploymentBaseOptions.IncludeAcls Property  (Microsoft.Web.Deployment)
TOCTitle: IncludeAcls Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentBaseOptions.IncludeAcls
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentbaseoptions.includeacls(v=VS.90)
ms:contentKeyID: 20208742
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentBaseOptions.IncludeAcls
- Microsoft.Web.Deployment.DeploymentBaseOptions.get_IncludeAcls
- Microsoft.Web.Deployment.DeploymentBaseOptions.set_IncludeAcls
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentBaseOptions.get_IncludeAcls
- Microsoft.Web.Deployment.DeploymentBaseOptions.IncludeAcls
- Microsoft.Web.Deployment.DeploymentBaseOptions.set_IncludeAcls
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# IncludeAcls Property

Gets or sets a value that indicates whether security descriptors will be added to the deployment context.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicPropertyIncludeAclsAsBoolean
'Usage
DiminstanceAsDeploymentBaseOptionsDimvalueAsBooleanvalue = instance.IncludeAcls

instance.IncludeAcls = value
```

``` csharp
publicboolIncludeAcls { get; set; }
```

``` c++
public:
propertyboolIncludeAcls {
    boolget ();
    voidset (boolvalue);
}
```

``` jscript
function getIncludeAcls () : booleanfunction setIncludeAcls (value : boolean)
```

#### Property Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
true if security descriptors will be added to the deployment context, otherwise false.  

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

