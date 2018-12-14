---
title: DeploymentSyncOptions.WhatIf Property  (Microsoft.Web.Deployment)
TOCTitle: WhatIf Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentSyncOptions.WhatIf
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsyncoptions.whatif(v=VS.90)
ms:contentKeyID: 20209159
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSyncOptions.WhatIf
- Microsoft.Web.Deployment.DeploymentSyncOptions.get_WhatIf
- Microsoft.Web.Deployment.DeploymentSyncOptions.set_WhatIf
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncOptions.get_WhatIf
- Microsoft.Web.Deployment.DeploymentSyncOptions.set_WhatIf
- Microsoft.Web.Deployment.DeploymentSyncOptions.WhatIf
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# WhatIf Property

Gets or sets a value that determines whether operations should be performed.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicPropertyWhatIfAsBoolean
'Usage
DiminstanceAsDeploymentSyncOptionsDimvalueAsBooleanvalue = instance.WhatIf

instance.WhatIf = value
```

``` csharp
publicboolWhatIf { get; set; }
```

``` c++
public:
propertyboolWhatIf {
    boolget ();
    voidset (boolvalue);
}
```

``` jscript
function getWhatIf () : booleanfunction setWhatIf (value : boolean)
```

#### Property Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
true if the option should not be performed, otherwise false. The default value is false.  

## Remarks

If set to true, operations will not be executed but events will still be fired via the Action()()()() event specifying what would have happened. If set to false, the synchronization events actually fire.

## Examples

The following example implements the class [DeploymentSyncOptions](deploymentsyncoptions-class-microsoft-web-deployment.md)by calling the static method [GetAvailableRules](deploymentsyncoptions-getavailablerules-method-microsoft-web-deployment.md) to get currently available rules that will apply to the sync operation. A [DeploymentSyncOptions](deploymentsyncoptions-class-microsoft-web-deployment.md) instance then modifies properties: WhatIf and [UseChecksum](deploymentsyncoptions-usechecksum-property-microsoft-web-deployment.md).

**Note**   The WhatIf property allows for the possibility of performing a trial sync in order to determine the possibility of a sync operation and to provide a measurement of the changes that might occur in used in conjunction with an instance of [DeploymentChangeSummary](deploymentchangesummary-class-microsoft-web-deployment.md).

using System;

using Microsoft.Web.Deployment;

namespace MSDeploy.Web.Deployment

{

class Program

{

static void Main(string\[\] args)

{

// List currently available rules

foreach(DeploymentRule rule in

DeploymentSyncOptions.GetAvailableRules())

{

Console.WriteLine("Description: " + rule.Description);

Console.WriteLine("ExampleOrDetail: " + rule.ExampleOrDetail);

Console.WriteLine("FriendlyName: " + rule.FriendlyName);

Console.WriteLine("Name: " + rule.Name);

Console.WriteLine("Handler: " +

rule.RuleHandler.ToString());

Console.WriteLine();

}

DeploymentSyncOptions syncOptions = new DeploymentSyncOptions();

syncOptions.WhatIf = true; // report expected results of

// syncing without performing a sync operation

syncOptions.UseChecksum = true; // compare files through

// checksum to determine if they should be synced

DeploymentBaseOptions sourceBaseOptions =

new DeploymentBaseOptions();

DeploymentBaseOptions destinationBaseOptions =

new DeploymentBaseOptions();

DeploymentObject deploymentObject =

DeploymentManager.CreateObject(

DeploymentWellKnownProvider.AppHostConfig,

"Default Web Site", sourceBaseOptions);

DeploymentChangeSummary changes =

deploymentObject.SyncTo(

DeploymentWellKnownProvider.AppHostConfig,

"Default Web Site2", destinationBaseOptions,

syncOptions);

Console.WriteLine("Added: " +

changes.ObjectsAdded.ToString());

Console.WriteLine("Updated: " +

changes.ObjectsUpdated.ToString());

Console.WriteLine("Deleted: " +

changes.ObjectsDeleted.ToString());

Console.WriteLine("Errors: " +

changes.Errors.ToString());

}

}

}

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncOptions Class](deploymentsyncoptions-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

