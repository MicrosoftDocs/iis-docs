---
title: DeploymentWellKnownProvider Enumeration (Microsoft.Web.Deployment)
TOCTitle: DeploymentWellKnownProvider Enumeration
ms:assetid: T:Microsoft.Web.Deployment.DeploymentWellKnownProvider
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentwellknownprovider(v=VS.90)
ms:contentKeyID: 20209278
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.WebServer60
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.GacAssembly
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.ContentPath
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.Package
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.ArchiveDir
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.RootWebConfig32
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.DBMySql
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.MachineConfig32
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.AppHostSchema
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.WebServer
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.Auto
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.RegValue
- Microsoft.Web.Deployment.DeploymentWellKnownProvider
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.Unknown
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.AppHostConfig
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.MachineConfig64
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.RootWebConfig64
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.Manifest
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.MetaKey
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.RegKey
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.DBFullSql
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.DirPath
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.SetAcl
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.FilePath
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.AppPoolConfig
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.Cert
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.ComObject32
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.CreateApp
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.RunCommand
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.IisApp
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.ComObject64
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.RecycleApp
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentWellKnownProvider
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.AppHostConfig
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.AppHostSchema
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.AppPoolConfig
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.ArchiveDir
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.Auto
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.Cert
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.COMObject32
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.COMObject64
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.ContentPath
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.DBFullSql
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.DBMySql
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.DirPath
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.FilePath
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.GacAssembly
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.IISApp
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.MachineConfig32
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.MachineConfig64
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.Manifest
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.MetaKey
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.Package
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.RegKey
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.RegValue
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.RootWebConfig32
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.RootWebConfig64
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.SetAcl
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.Unknown
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.WebServer
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.WebServer60
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.CreateApp
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.RecycleApp
- Microsoft.Web.Deployment.DeploymentWellKnownProvider.RunCommand
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentWellKnownProvider Enumeration

Defines the list of known deployment provider factories.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicEnumerationDeploymentWellKnownProvider
'Usage
DiminstanceAsDeploymentWellKnownProvider
```

``` csharp
publicenumDeploymentWellKnownProvider
```

``` c++
publicenum classDeploymentWellKnownProvider
```

``` jscript
publicenum DeploymentWellKnownProvider
```

## Remarks

This list contains the default provider factories shipped with the Microsft.Web.Deployment assembly. Additional implementations created by third-parties are not listed in this enumeration.

## Examples

The following example uses the enumeration DeploymentWellKnownProvider to implement a sync operation with the method SyncTo. DeploymentWellKnownProvider is a safer method of using shipped providers compared to manually inputted strings, which is an offered overload of [CreateObject](deploymentmanager-createobject-method-microsoft-web-deployment.md).


> [!NOTE]
> <P>The switch statement helps to demonstrate the various elements in the enumeration</P>



using System;

using Microsoft.Web.Deployment;

namespace MSDeploy.Web.Deployment

{

class Program

{

public enum OSVersion

{

Windows2003,

Windows2008,

}

public enum SyncTypes

{

Content,

File,

Server

}

static void Main(string\[\] args)

{

string \_path = args\[0\];

OSVersion \_osVersion = OSVersion.Windows2003;

SyncTypes \_syncType = SyncTypes.Server;

DeploymentWellKnownProvider \_provider =

DeploymentWellKnownProvider.Unknown;

switch (\_syncType)

{

case SyncTypes.Content:

\_provider =

DeploymentWellKnownProvider.ContentPath;

break;

case SyncTypes.File:

\_provider = DeploymentWellKnownProvider.FilePath;

break;

case SyncTypes.Server:

if (\_osVersion == OSVersion.Windows2003)

{

\_provider = DeploymentWellKnownProvider.WebServer60;

}

else if (\_osVersion == OSVersion.Windows2008)

{

\_provider = DeploymentWellKnownProvider.AppHostConfig;

}

break;

default:

throw new NotImplementedException();

}

DeploymentSyncOptions syncOptions =

new DeploymentSyncOptions();

DeploymentBaseOptions sourceBaseOptions =

new DeploymentBaseOptions();

DeploymentBaseOptions destinationBaseOptions =

new DeploymentBaseOptions();

DeploymentObject deploymentObject =

DeploymentManager.CreateObject(

provider, path, sourceBaseOptions);

deploymentObject.SyncTo(

provider,\_path, destinationBaseOptions, syncOptions);

}

}

}

## See Also

#### Reference

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

