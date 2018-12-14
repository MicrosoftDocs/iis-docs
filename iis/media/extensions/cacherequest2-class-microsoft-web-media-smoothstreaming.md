---
title: CacheRequest2 Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CacheRequest2 Class
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.CacheRequest2
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.cacherequest2(v=VS.95)
ms:contentKeyID: 46307926
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.CacheRequest2
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheRequest2
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CacheRequest2 Class

Provides an extension of the [CacheRequest](cacherequest-class-microsoft-web-media-smoothstreaming_1.md) class that enables creation of a CacheRequest object based on a specified stream or a specified [HttpWebRequest](https://msdn.microsoft.com/en-us/library/8y7x3zz2\(v=vs.95\)) object and list of selectable tracks.

## Inheritance Hierarchy

 [System.Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.95\))  
  [Microsoft.Web.Media.SmoothStreaming.CacheRequest](cacherequest-class-microsoft-web-media-smoothstreaming_1.md)  
    Microsoft.Web.Media.SmoothStreaming.CacheRequest2  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Class CacheRequest2 _
    Inherits CacheRequest
'Usage

Dim instance As CacheRequest2
```

``` csharp
public class CacheRequest2 : CacheRequest
```

``` c++
public ref class CacheRequest2 : public CacheRequest
```

``` fsharp
type CacheRequest2 =  
    class
        inherit CacheRequest
    end
```

``` jscript
public class CacheRequest2 extends CacheRequest
```

The CacheRequest2 type exposes the following members.

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
<td><a href="cacherequest2-constructor-stream-microsoft-web-media-smoothstreaming.md">CacheRequest2(Stream)</a></td>
<td>Initializes a new instance of the CacheRequest2 class based on the specified stream.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="cacherequest2-constructor-httpwebrequest-ilist-trackinfo-microsoft-web-media-smoothstreaming.md">CacheRequest2(HttpWebRequest, IList&lt;TrackInfo&gt;)</a></td>
<td>Initializes a new instance of the CacheRequest2 class based on the specified web request and list of selectable tracks.</td>
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
<td><a href="cacherequest-canonicaluri-property-microsoft-web-media-smoothstreaming_1.md">CanonicalUri</a></td>
<td>The Uri of the request. (Inherited from <a href="cacherequest-class-microsoft-web-media-smoothstreaming_1.md">CacheRequest</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="cacherequest2-selectabletracks-property-microsoft-web-media-smoothstreaming.md">SelectableTracks</a></td>
<td>Gets a list of suggested tracks for the cache plug-in to choose for downloading.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="cacherequest2-webrequest-property-microsoft-web-media-smoothstreaming.md">WebRequest</a></td>
<td>Gets or sets a web request that the media element downloader uses for downloading.</td>
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
<td><a href="https://msdn.microsoft.com/en-us/library/bsc2ak47(v=vs.95)">Equals</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/4k87zsw7(v=vs.95)">Finalize</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.95)">GetHashCode</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/dfwy45w9(v=vs.95)">GetType</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/57ctke0a(v=vs.95)">MemberwiseClone</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="cacherequest-readfrom-method-microsoft-web-media-smoothstreaming_1.md">ReadFrom</a></td>
<td>Reads the request from a <a href="https://msdn.microsoft.com/en-us/library/8f86tw9e(v=vs.95)">Stream</a> object. There is no default implementation for this method. Calling the method without implementing an override will result in a <a href="https://msdn.microsoft.com/en-us/library/8a7a4e64(v=vs.95)">NotSupportedException</a>. (Inherited from <a href="cacherequest-class-microsoft-web-media-smoothstreaming_1.md">CacheRequest</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.95)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="cacherequest-writeto-method-microsoft-web-media-smoothstreaming_1.md">WriteTo</a></td>
<td>Writes the request to a <a href="https://msdn.microsoft.com/en-us/library/8f86tw9e(v=vs.95)">Stream</a> object. (Inherited from <a href="cacherequest-class-microsoft-web-media-smoothstreaming_1.md">CacheRequest</a>.)</td>
</tr>
</tbody>
</table>


Top

## Version Information

#### Silverlight

Supported in: 5  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

