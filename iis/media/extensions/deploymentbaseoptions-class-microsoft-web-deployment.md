---
title: DeploymentBaseOptions Class (Microsoft.Web.Deployment)
TOCTitle: DeploymentBaseOptions Class
ms:assetid: T:Microsoft.Web.Deployment.DeploymentBaseOptions
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentbaseoptions(v=VS.90)
ms:contentKeyID: 20209073
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentBaseOptions
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentBaseOptions
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentBaseOptions Class

Provides the base set of options for a deployment context.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  Microsoft.Web.Deployment..::..DeploymentBaseOptions  

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
<SerializableAttribute> _
PublicClassDeploymentBaseOptions _
    ImplementsISerializable
'Usage
DiminstanceAsDeploymentBaseOptions
```

``` csharp
[SerializableAttribute]
publicclassDeploymentBaseOptions : ISerializable
```

``` c++
[SerializableAttribute]
publicref classDeploymentBaseOptions : ISerializable
```

``` jscript
publicclass DeploymentBaseOptions implementsISerializable
```

The DeploymentBaseOptions type exposes the following members.

## Constructors

<table>
<thead>
<tr class="header">
<th> </th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentbaseoptions-constructor-microsoft-web-deployment_1.md">DeploymentBaseOptions() () () ()</a></td>
<td>Creates an instance of a DeploymentBaseOptions object.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="deploymentbaseoptions-constructor-serializationinfo-streamingcontext-microsoft-web-deployment.md">DeploymentBaseOptions(SerializationInfo, StreamingContext)</a></td>
<td></td>
</tr>
</tbody>
</table>


Top

## Properties

<table>
<thead>
<tr class="header">
<th> </th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentbaseoptions-authenticationtype-property-microsoft-web-deployment.md">AuthenticationType</a></td>
<td>Gets or sets a string that determines the type of authentication to use in the deployment operation.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentbaseoptions-computername-property-microsoft-web-deployment.md">ComputerName</a></td>
<td>Gets or sets the name of the computer.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentbaseoptions-defaultprovidersettings-property-microsoft-web-deployment.md">DefaultProviderSettings</a></td>
<td></td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentbaseoptions-encryptpassword-property-microsoft-web-deployment.md">EncryptPassword</a></td>
<td>Gets or sets the encrypted password.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentbaseoptions-includeacls-property-microsoft-web-deployment.md">IncludeAcls</a></td>
<td>Gets or sets a value that indicates whether security descriptors will be added to the deployment context.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentbaseoptions-linkextensions-property-microsoft-web-deployment.md">LinkExtensions</a></td>
<td>Get an enumerable collection of <a href="deploymentlinkextension-class-microsoft-web-deployment.md">DeploymentLinkExtension</a> objects.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentbaseoptions-password-property-microsoft-web-deployment.md">Password</a></td>
<td>Gets or sets the password used to access the deployment location.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentbaseoptions-prefetchpayload-property-microsoft-web-deployment.md">PrefetchPayload</a></td>
<td>Gets or sets a value that indicates whether a deployment request contains a prefetch payload.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentbaseoptions-retryattempts-property-microsoft-web-deployment.md">RetryAttempts</a></td>
<td>Gets or sets the number of times to attempt a deployment operation.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentbaseoptions-retryinterval-property-microsoft-web-deployment.md">RetryInterval</a></td>
<td>Gets or sets the interval, in milliseconds, to wait between retry attempts.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentbaseoptions-skipdirectives-property-microsoft-web-deployment.md">SkipDirectives</a></td>
<td>Gets a collection of <a href="deploymentskipdirective-class-microsoft-web-deployment.md">DeploymentSkipDirective</a> objects.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentbaseoptions-tempagent-property-microsoft-web-deployment.md">TempAgent</a></td>
<td></td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentbaseoptions-tracelevel-property-microsoft-web-deployment.md">TraceLevel</a></td>
<td>Gets or sets the trace level of the deployment base options.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentbaseoptions-username-property-microsoft-web-deployment.md">UserName</a></td>
<td>Gets or sets the username used to access the deployment location.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentbaseoptions-webserverconfiguration-property-microsoft-web-deployment.md">WebServerConfiguration</a></td>
<td></td>
</tr>
</tbody>
</table>


Top

## Methods

<table>
<thead>
<tr class="header">
<th> </th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentbaseoptions-adddefaultprovidersetting-method-microsoft-web-deployment.md">AddDefaultProviderSetting</a></td>
<td></td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bsc2ak47(v=vs.90)">Equals</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/4k87zsw7(v=vs.90)">Finalize</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.90)">GetHashCode</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentbaseoptions-getobjectdata-method-microsoft-web-deployment.md">GetObjectData</a></td>
<td>Deserializes an instance of the current class.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/dfwy45w9(v=vs.90)">GetType</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/57ctke0a(v=vs.90)">MemberwiseClone</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
</tbody>
</table>


Top

## Events

<table>
<thead>
<tr class="header">
<th> </th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Ff728249.pubevent(en-us,VS.90).gif" title="Public event" alt="Public event" /></td>
<td><a href="deploymentbaseoptions-trace-event-microsoft-web-deployment.md">Trace</a></td>
<td>An event to indicate when a deployment trace event has occurred.</td>
</tr>
</tbody>
</table>


Top

## Examples

The following example implements several properties of the DeploymentBaseOptions class. This example instantiates the DeploymentBaseOptions for both the source and destination objects and modifies the property values to enable a remote sync operation.

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

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

