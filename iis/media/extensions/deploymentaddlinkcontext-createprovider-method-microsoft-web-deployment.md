---
title: DeploymentAddLinkContext.CreateProvider Method  (Microsoft.Web.Deployment)
TOCTitle: CreateProvider Method
ms:assetid: Overload:Microsoft.Web.Deployment.DeploymentAddLinkContext.CreateProvider
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentaddlinkcontext.createprovider(v=VS.90)
ms:contentKeyID: 20208915
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentAddLinkContext.CreateProvider
dev_langs:
- CSharp
- JScript
- VB
---

# CreateProvider Method

Creates a new deployment object and adds it to the underlying collection.

This member is overloaded. For complete information about this member, including syntax, usage, and examples, click a name in the overload list.

## Overload List

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
<td><a href="deploymentaddlinkcontext-createprovider-method-deploymentprovideroptions-microsoft-web-deployment.md">CreateProvider(DeploymentProviderOptions)</a></td>
<td>Creates a new deployment object and adds it to the underlying collection.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentaddlinkcontext-createprovider-method-string-string-microsoft-web-deployment.md">CreateProvider(String, String)</a></td>
<td>Creates a new deployment object by using the specified provider factory name and path. The new object is added to the underlying collection.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentaddlinkcontext-createprovider-method-deploymentprovideroptions-string-microsoft-web-deployment.md">CreateProvider(DeploymentProviderOptions, String)</a></td>
<td>Creates a new deployment object by using the specified provider options and link name. The new object is added to the underlying collection.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentaddlinkcontext-createprovider-method-string-string-string-microsoft-web-deployment.md">CreateProvider(String, String, String)</a></td>
<td>Creates a new deployment object by using the specified provider factory name, path, and link name. The new object is added to the underlying collection.</td>
</tr>
</tbody>
</table>


Top

## Remarks

This method creates a deployment object provider that is then used to create a deployment object. The overloads provided by this method enable the caller to control how the deployment object provider and deployment object are created. After the new deployment object is created, it is added to the deployment object collection of this class.

## See Also

#### Reference

[DeploymentAddLinkContext Class](deploymentaddlinkcontext-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

