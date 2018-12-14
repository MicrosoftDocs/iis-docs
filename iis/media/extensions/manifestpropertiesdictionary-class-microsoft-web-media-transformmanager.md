---
title: ManifestPropertiesDictionary Class (Microsoft.Web.Media.TransformManager)
TOCTitle: ManifestPropertiesDictionary Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.ManifestPropertiesDictionary
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.manifestpropertiesdictionary(v=VS.90)
ms:contentKeyID: 35520691
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ManifestPropertiesDictionary
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ManifestPropertiesDictionary
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ManifestPropertiesDictionary Class

Provides properties that can be used for task definitions and job templates. This type supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  [System.Collections.Generic. . :: . .Dictionary](https://msdn.microsoft.com/en-us/library/xfhwa508\(v=vs.90\))\< (Of \< ( \<'[String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\)), [ManifestProperty](manifestproperty-class-microsoft-web-media-transformmanager.md)\> ) \> ) \>  
    Microsoft.Web.Media.TransformManager..::..ManifestPropertiesDictionary  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<CollectionDataContractAttribute> _
PublicClassManifestPropertiesDictionary _
    InheritsDictionary(OfString, ManifestProperty)
'Usage
DiminstanceAsManifestPropertiesDictionary
```

``` csharp
[CollectionDataContractAttribute]
publicclassManifestPropertiesDictionary : Dictionary<string, ManifestProperty>
```

``` c++
[CollectionDataContractAttribute]
publicref classManifestPropertiesDictionary : publicDictionary<String^, ManifestProperty^>
```

``` fsharp
[<CollectionDataContractAttribute>]
typeManifestPropertiesDictionary =  
    classinheritDictionary<string, ManifestProperty>
    end
```

``` jscript
publicclass ManifestPropertiesDictionary extendsDictionary<String, ManifestProperty>
```

The ManifestPropertiesDictionary type exposes the following members.

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
<td><a href="manifestpropertiesdictionary-constructor-microsoft-web-media-transformmanager_1.md">ManifestPropertiesDictionary() () () ()</a></td>
<td>Initializes a new instance of the ManifestPropertiesDictionary class.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="manifestpropertiesdictionary-constructor-xelement-microsoft-web-media-transformmanager.md">ManifestPropertiesDictionary(XElement)</a></td>
<td>Initializes a new instance of the ManifestPropertiesDictionary class using the specified properties.</td>
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
<td><a href="https://msdn.microsoft.com/en-us/library/ms132092(v=vs.90)">Comparer</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/zhcy256f(v=vs.90)">Count</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/9tee9ht2(v=vs.90)">Item</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/yt2fy5zk(v=vs.90)">Keys</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="manifestpropertiesdictionary-namespace-property-microsoft-web-media-transformmanager.md">Namespace</a></td>
<td>Gets or sets the value from the namespace attribute of the XML element.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="manifestpropertiesdictionary-prefix-property-microsoft-web-media-transformmanager.md">Prefix</a></td>
<td>Gets or sets the value from the prefix attribute of the XML element.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/ekcfxy3x(v=vs.90)">Values</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
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
<td><a href="https://msdn.microsoft.com/en-us/library/k7z0zy8k(v=vs.90)">Add</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/b5txwy7s(v=vs.90)">Clear</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/kw5aaea4(v=vs.90)">ContainsKey</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/a63811ah(v=vs.90)">ContainsValue</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bsc2ak47(v=vs.90)">Equals</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/4k87zsw7(v=vs.90)">Finalize</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/9c6ftx8b(v=vs.90)">GetEnumerator</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.90)">GetHashCode</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td>GetObjectData</td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
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
<td>OnDeserialization</td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/kabs04ac(v=vs.90)">Remove</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bb347013(v=vs.90)">TryGetValue</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
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
<td><a href="manifestpropertiesdictionary-propertieselementname-field-microsoft-web-media-transformmanager.md">PropertiesElementName</a></td>
<td>Represents a constant that is used with task definitions and job templates. The value is &quot;properties&quot;.</td>
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
<td>ICollection&lt; (Of &lt; &lt;' (KeyValuePair&lt; (Of &lt; &lt;' (TKey, TValue&gt; ) &gt; &gt; )&gt; ) &gt; &gt; ). . :: . .Add</td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728198.privmethod(en-us,VS.90).gif" title="Private method" alt="Private method" /></td>
<td>IDictionary. . :: . .Add</td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728198.privmethod(en-us,VS.90).gif" title="Private method" alt="Private method" /></td>
<td>ICollection&lt; (Of &lt; &lt;' (KeyValuePair&lt; (Of &lt; &lt;' (TKey, TValue&gt; ) &gt; &gt; )&gt; ) &gt; &gt; ). . :: . .Contains</td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728198.privmethod(en-us,VS.90).gif" title="Private method" alt="Private method" /></td>
<td>IDictionary. . :: . .Contains</td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728198.privmethod(en-us,VS.90).gif" title="Private method" alt="Private method" /></td>
<td>ICollection&lt; (Of &lt; &lt;' (KeyValuePair&lt; (Of &lt; &lt;' (TKey, TValue&gt; ) &gt; &gt; )&gt; ) &gt; &gt; ). . :: . .CopyTo</td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728198.privmethod(en-us,VS.90).gif" title="Private method" alt="Private method" /></td>
<td>ICollection. . :: . .CopyTo</td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728198.privmethod(en-us,VS.90).gif" title="Private method" alt="Private method" /></td>
<td>IEnumerable&lt; (Of &lt; &lt;' (KeyValuePair&lt; (Of &lt; &lt;' (TKey, TValue&gt; ) &gt; &gt; )&gt; ) &gt; &gt; ). . :: . .GetEnumerator</td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728198.privmethod(en-us,VS.90).gif" title="Private method" alt="Private method" /></td>
<td>IEnumerable. . :: . .GetEnumerator</td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728198.privmethod(en-us,VS.90).gif" title="Private method" alt="Private method" /></td>
<td>IDictionary. . :: . .GetEnumerator</td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728140.privproperty(en-us,VS.90).gif" title="Private property" alt="Private property" /></td>
<td>IDictionary. . :: . .IsFixedSize</td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728140.privproperty(en-us,VS.90).gif" title="Private property" alt="Private property" /></td>
<td>ICollection&lt; (Of &lt; &lt;' (KeyValuePair&lt; (Of &lt; &lt;' (TKey, TValue&gt; ) &gt; &gt; )&gt; ) &gt; &gt; ). . :: . .IsReadOnly</td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728140.privproperty(en-us,VS.90).gif" title="Private property" alt="Private property" /></td>
<td>IDictionary. . :: . .IsReadOnly</td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728140.privproperty(en-us,VS.90).gif" title="Private property" alt="Private property" /></td>
<td>ICollection. . :: . .IsSynchronized</td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728140.privproperty(en-us,VS.90).gif" title="Private property" alt="Private property" /></td>
<td>IDictionary. . :: . .Item</td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728140.privproperty(en-us,VS.90).gif" title="Private property" alt="Private property" /></td>
<td>IDictionary&lt; (Of &lt; &lt;' (TKey, TValue&gt; ) &gt; &gt; ). . :: . .Keys</td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728140.privproperty(en-us,VS.90).gif" title="Private property" alt="Private property" /></td>
<td>IDictionary. . :: . .Keys</td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728198.privmethod(en-us,VS.90).gif" title="Private method" alt="Private method" /></td>
<td>ICollection&lt; (Of &lt; &lt;' (KeyValuePair&lt; (Of &lt; &lt;' (TKey, TValue&gt; ) &gt; &gt; )&gt; ) &gt; &gt; ). . :: . .Remove</td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728198.privmethod(en-us,VS.90).gif" title="Private method" alt="Private method" /></td>
<td>IDictionary. . :: . .Remove</td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728140.privproperty(en-us,VS.90).gif" title="Private property" alt="Private property" /></td>
<td>ICollection. . :: . .SyncRoot</td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728140.privproperty(en-us,VS.90).gif" title="Private property" alt="Private property" /></td>
<td>IDictionary&lt; (Of &lt; &lt;' (TKey, TValue&gt; ) &gt; &gt; ). . :: . .Values</td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728140.privproperty(en-us,VS.90).gif" title="Private property" alt="Private property" /></td>
<td>IDictionary. . :: . .Values</td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/xfhwa508(v=vs.90)">Dictionary</a>&lt; (Of &lt; ( &lt;'<a href="https://msdn.microsoft.com/en-us/library/s1wwdcbf(v=vs.90)">String</a>, <a href="manifestproperty-class-microsoft-web-media-transformmanager.md">ManifestProperty</a>&gt; ) &gt; ) &gt;.)</td>
</tr>
</tbody>
</table>


Top

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

