---
title: RewriteTemplateFeature Class (Microsoft.Web.Management.Iis.Rewrite)
TOCTitle: RewriteTemplateFeature Class
ms:assetid: T:Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.iis.rewrite.rewritetemplatefeature(v=VS.90)
ms:contentKeyID: 20476369
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.Rewrite.Client.dll
api_name:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# RewriteTemplateFeature Class

Represents the base class used by all rewrite templates.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  Microsoft.Web.Management.Iis.Rewrite..::..RewriteTemplateFeature  

**Namespace:**  [Microsoft.Web.Management.Iis.Rewrite](microsoft-web-management-iis-rewrite-namespace.md)  
**Assembly:**  Microsoft.Web.Management.Rewrite.Client (in Microsoft.Web.Management.Rewrite.Client.dll)

## Syntax

``` vb
'Declaration
PublicMustInheritClassRewriteTemplateFeature _
    ImplementsIServiceProvider
'Usage
DiminstanceAsRewriteTemplateFeature
```

``` csharp
publicabstractclassRewriteTemplateFeature : IServiceProvider
```

``` c++
publicref classRewriteTemplateFeatureabstract : IServiceProvider
```

``` jscript
publicabstractclass RewriteTemplateFeature implementsIServiceProvider
```

The RewriteTemplateFeature type exposes the following members.

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
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="rewritetemplatefeature-constructor-module-string-string-microsoft-web-management-iis-rewrite.md">RewriteTemplateFeature(Module, String, String)</a></td>
<td>Creates an instance of a RewriteTemplateFeature object with the given module, title, and description.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="rewritetemplatefeature-constructor-module-string-string-rewritetemplatecategory-microsoft-web-management-iis-rewrite.md">RewriteTemplateFeature(Module, String, String, RewriteTemplateCategory)</a></td>
<td>Creates an instance of a RewriteTemplateFeature object with the given module, title, description, small image and rewrite template category.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="rewritetemplatefeature-constructor-module-string-string-object-object-microsoft-web-management-iis-rewrite.md">RewriteTemplateFeature(Module, String, String, Object, Object)</a></td>
<td>Creates an instance of a RewriteTemplateFeature object with the given module, title, description, small image and large image.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="rewritetemplatefeature-constructor-module-string-string-object-object-rewritetemplatecategory-microsoft-web-management-iis-rewrite.md">RewriteTemplateFeature(Module, String, String, Object, Object, RewriteTemplateCategory)</a></td>
<td>Creates an instance of a RewriteTemplateFeature object with the given module, title, description, small image, large image, and rewrite template category.</td>
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
<td><a href="rewritetemplatefeature-category-property-microsoft-web-management-iis-rewrite.md">Category</a></td>
<td>Gets the <a href="rewritetemplatecategory-class-microsoft-web-management-iis-rewrite.md">RewriteTemplateCategory</a> of the RewriteTemplateFeature object.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="rewritetemplatefeature-connection-property-microsoft-web-management-iis-rewrite.md">Connection</a></td>
<td>Gets the Connection service that represents the current management unit.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="rewritetemplatefeature-description-property-microsoft-web-management-iis-rewrite.md">Description</a></td>
<td>Gets a string that contains description information about the current module.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="rewritetemplatefeature-isenabled-property-microsoft-web-management-iis-rewrite.md">IsEnabled</a></td>
<td>Gets a Boolean value that indicates whether the RewriteTemplateFeature is enabled.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="rewritetemplatefeature-largeimage-property-microsoft-web-management-iis-rewrite.md">LargeImage</a></td>
<td>Gets the large icon displayed on the client-side user interface for this feature.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="rewritetemplatefeature-module-property-microsoft-web-management-iis-rewrite.md">Module</a></td>
<td>Gets the client-side user interface module that this feature uses.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="rewritetemplatefeature-serviceprovider-property-microsoft-web-management-iis-rewrite.md">ServiceProvider</a></td>
<td>Gets the service provider.for the current feature.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="rewritetemplatefeature-smallimage-property-microsoft-web-management-iis-rewrite.md">SmallImage</a></td>
<td>Gets the small icon displayed on the client-side user interface for this feature.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="rewritetemplatefeature-title-property-microsoft-web-management-iis-rewrite.md">Title</a></td>
<td>Gets the title displayed on the client-side user interface for this feature.</td>
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
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="rewritetemplatefeature-displayerrormessage-method-microsoft-web-management-iis-rewrite.md">DisplayErrorMessage</a></td>
<td>Displays information about an exception on the user interface for the current feature.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="rewritetemplatefeature-equals-method-microsoft-web-management-iis-rewrite.md">Equals</a></td>
<td>Determines whether this instance and another specified object have the same value. (Overrides <a href="https://msdn.microsoft.com/en-us/library/bsc2ak47(v=vs.90)">Object. . :: . .Equals(Object)</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/4k87zsw7(v=vs.90)">Finalize</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="rewritetemplatefeature-gethashcode-method-microsoft-web-management-iis-rewrite.md">GetHashCode</a></td>
<td>Gets the hash value for the current object. (Overrides <a href="https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.90)">Object. . :: . .GetHashCode() () () ()</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="rewritetemplatefeature-getservice-method-microsoft-web-management-iis-rewrite.md">GetService</a></td>
<td>Gets the service object of the specified type.</td>
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
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="rewritetemplatefeature-navigate-method-type-microsoft-web-management-iis-rewrite.md">Navigate(Type)</a></td>
<td>Directs the client to navigate to the specified page type.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="rewritetemplatefeature-navigate-method-type-object-microsoft-web-management-iis-rewrite.md">Navigate(Type, Object)</a></td>
<td>Directs the client to navigate to the specified page type.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="rewritetemplatefeature-run-method-microsoft-web-management-iis-rewrite.md">Run</a></td>
<td>Runs the current feature.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="rewritetemplatefeature-showdialog-method-microsoft-web-management-iis-rewrite.md">ShowDialog</a></td>
<td>Shows the specified <a href="https://msdn.microsoft.com/en-us/library/ms634496(v=vs.90)">DialogForm</a> on the client.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="rewritetemplatefeature-showmessage-method-string-string-microsoft-web-management-iis-rewrite.md">ShowMessage(String, String)</a></td>
<td>Shows a message box with the features specified by the parameters.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="rewritetemplatefeature-showmessage-method-string-string-messageboxbuttons-messageboxicon-microsoft-web-management-iis-rewrite.md">ShowMessage(String, String, MessageBoxButtons, MessageBoxIcon)</a></td>
<td>Shows a message box with the features specified by the parameters.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="rewritetemplatefeature-showmessage-method-string-string-messageboxbuttons-messageboxicon-messageboxdefaultbutton-microsoft-web-management-iis-rewrite.md">ShowMessage(String, String, MessageBoxButtons, MessageBoxIcon, MessageBoxDefaultButton)</a></td>
<td>Shows a message box with the features specified by the parameters.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
</tbody>
</table>


Top

## Explicit Interface Implementations

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
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728198.privmethod(en-us,VS.90).gif" title="Private method" alt="Private method" /></td>
<td><a href="rewritetemplatefeature-iserviceprovider-getservice-method-microsoft-web-management-iis-rewrite.md">IServiceProvider. . :: . .GetService</a></td>
<td></td>
</tr>
</tbody>
</table>


Top

## Remarks

This class is marked as abstract (MustInherit in Visual Basic). Rewrite templates must inherit from this base class. The Run method is the only method that must be overridden by subclasses.

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Management.Iis.Rewrite Namespace](microsoft-web-management-iis-rewrite-namespace.md)

