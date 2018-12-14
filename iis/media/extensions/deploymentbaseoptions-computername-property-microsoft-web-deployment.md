---
title: DeploymentBaseOptions.ComputerName Property  (Microsoft.Web.Deployment)
TOCTitle: ComputerName Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentBaseOptions.ComputerName
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentbaseoptions.computername(v=VS.90)
ms:contentKeyID: 20208704
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentBaseOptions.ComputerName
- Microsoft.Web.Deployment.DeploymentBaseOptions.get_ComputerName
- Microsoft.Web.Deployment.DeploymentBaseOptions.set_ComputerName
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentBaseOptions.ComputerName
- Microsoft.Web.Deployment.DeploymentBaseOptions.get_ComputerName
- Microsoft.Web.Deployment.DeploymentBaseOptions.set_ComputerName
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ComputerName Property

Gets or sets the name of the computer.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicPropertyComputerNameAsString
'Usage
DiminstanceAsDeploymentBaseOptionsDimvalueAsStringvalue = instance.ComputerName

instance.ComputerName = value
```

``` csharp
publicstringComputerName { get; set; }
```

``` c++
public:
propertyString^ ComputerName {
    String^ get ();
    voidset (String^ value);
}
```

``` jscript
function getComputerName () : Stringfunction setComputerName (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string that contains the name of the computer.  

## Remarks

This value may be the name specified in a UNC path ("\\\\fabrikam\\"), a URL ("[http://www.microsoft.com](http://www.microsoft.com/)"), a simple string ("fabrikam") or null Nothing nullptr unit a null reference (Nothing in Visual Basic) (Nothing in Visual Basic).

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

