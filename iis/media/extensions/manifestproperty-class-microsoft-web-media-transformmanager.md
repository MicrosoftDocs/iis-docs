---
title: ManifestProperty Class (Microsoft.Web.Media.TransformManager)
TOCTitle: ManifestProperty Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.ManifestProperty
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.manifestproperty(v=VS.90)
ms:contentKeyID: 31477621
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ManifestProperty
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ManifestProperty
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ManifestProperty Class

Defines the manifest properties that contain task-specific metadata for task definitions, in job templates, and in tasks.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  Microsoft.Web.Media.TransformManager..::..ManifestProperty  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

``` vb
'Declaration
<DataContractAttribute> _
PublicClassManifestProperty _
    ImplementsIManifestProperty
'Usage
DiminstanceAsManifestProperty
```

``` csharp
[DataContractAttribute]
publicclassManifestProperty : IManifestProperty
```

``` c++
[DataContractAttribute]
publicref classManifestProperty : IManifestProperty
```

``` fsharp
[<DataContractAttribute>]
typeManifestProperty =  
    classinterfaceIManifestPropertyend
```

``` jscript
publicclass ManifestProperty implementsIManifestProperty
```

The ManifestProperty type exposes the following members.

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
<td><a href="manifestproperty-constructor-microsoft-web-media-transformmanager_1.md">ManifestProperty() () () ()</a></td>
<td>Initializes a new instance of the ManifestProperty class.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="manifestproperty-constructor-string-xelement-microsoft-web-media-transformmanager.md">ManifestProperty(String, XElement)</a></td>
<td>Initializes a new instance of the ManifestProperty class using the specified namespace and XML metadata element.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="manifestproperty-constructor-xname-string-microsoft-web-media-transformmanager.md">ManifestProperty(XName, String)</a></td>
<td>Initializes a new instance of the ManifestProperty class using the specified name and value.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="manifestproperty-constructor-xname-xelement-microsoft-web-media-transformmanager.md">ManifestProperty(XName, XElement)</a></td>
<td>Initializes a new instance of the ManifestProperty class using the specified name and value.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="manifestproperty-constructor-xname-string-boolean-microsoft-web-media-transformmanager.md">ManifestProperty(XName, String, Boolean)</a></td>
<td>Initializes a new instance of the ManifestProperty class using the specified name and value, and whether the property is required.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="manifestproperty-constructor-string-string-string-boolean-microsoft-web-media-transformmanager.md">ManifestProperty(String, String, String, Boolean)</a></td>
<td>Initializes a new instance of the ManifestProperty class using the specified namespace, name, and value, and whether the property is required.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="manifestproperty-constructor-xname-string-boolean-cultureinfo-microsoft-web-media-transformmanager.md">ManifestProperty(XName, String, Boolean, CultureInfo)</a></td>
<td>Initializes a new instance of the ManifestProperty class using the specified name, value, culture, and whether the property is required.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="manifestproperty-constructor-string-string-string-boolean-cultureinfo-microsoft-web-media-transformmanager.md">ManifestProperty(String, String, String, Boolean, CultureInfo)</a></td>
<td>Initializes a new instance of the ManifestProperty class using the specified namespace, name, value, and culture, and whether the property is required.</td>
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
<td><a href="manifestproperty-cultureinfo-property-microsoft-web-media-transformmanager.md">CultureInfo</a></td>
<td>Gets or sets the culture information for the manifest property.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="manifestproperty-cultureinfomoniker-property-microsoft-web-media-transformmanager.md">CultureInfoMoniker</a></td>
<td>Gets or sets a value that represents the culture language.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="manifestproperty-helptext-property-microsoft-web-media-transformmanager.md">HelpText</a></td>
<td>Gets or sets the help text that is associated with the manifest property.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="manifestproperty-localname-property-microsoft-web-media-transformmanager.md">LocalName</a></td>
<td>Gets or sets the LocalName element of the manifest property.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="manifestproperty-name-property-microsoft-web-media-transformmanager.md">Name</a></td>
<td>Gets or sets the Name element of the manifest property.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="manifestproperty-required-property-microsoft-web-media-transformmanager.md">Required</a></td>
<td>Get or sets a value that specifies whether the manifest property is required.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="manifestproperty-value-property-microsoft-web-media-transformmanager.md">Value</a></td>
<td>Gets or sets the manifest property value.</td>
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
<td><a href="manifestproperty-createpropertyelement-method-microsoft-web-media-transformmanager.md">CreatePropertyElement</a></td>
<td>Creates a manifest property element.</td>
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
<td><a href="https://msdn.microsoft.com/en-us/library/dfwy45w9(v=vs.90)">GetType</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/57ctke0a(v=vs.90)">MemberwiseClone</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
</tbody>
</table>


Top

## Fields

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
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="manifestproperty-propertyelementname-field-microsoft-web-media-transformmanager.md">PropertyElementName</a></td>
<td>The string &quot;property&quot;.</td>
</tr>
</tbody>
</table>


Top

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

