---
title: CacheResponse Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CacheResponse Class
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.CacheResponse
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.cacheresponse(v=VS.90)
ms:contentKeyID: 31469146
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CacheResponse Class

The object describing the response from the cache.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  Microsoft.Web.Media.SmoothStreaming..::..CacheResponse  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicClassCacheResponse
'Usage
DiminstanceAsCacheResponse
```

``` csharp
publicclassCacheResponse
```

``` c++
publicref classCacheResponse
```

``` jscript
publicclass CacheResponse
```

The CacheResponse type exposes the following members.

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
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ff728271.slMobile(en-us,VS.90).gif" title="Supported by Silverlight for Windows Phone" alt="Supported by Silverlight for Windows Phone" /></td>
<td><a href="cacheresponse-constructor-stream-microsoft-web-media-smoothstreaming_1.md">CacheResponse(Stream)</a></td>
<td>Initializes a new instance of the CacheResponse class from a <a href="https://msdn.microsoft.com/en-us/library/8f86tw9e(v=vs.90)">Stream</a> object.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ff728271.slMobile(en-us,VS.90).gif" title="Supported by Silverlight for Windows Phone" alt="Supported by Silverlight for Windows Phone" /></td>
<td><a href="cacheresponse-constructor-int64-string-webheadercollection-stream-httpstatuscode-string-datetime-microsoft-web-media-smoothstreaming_1.md">CacheResponse(Int64, String, WebHeaderCollection, Stream, HttpStatusCode, String, DateTime)</a></td>
<td>Initializes a new instance of the CacheResponse class from the parameters.</td>
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
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ff728271.slMobile(en-us,VS.90).gif" title="Supported by Silverlight for Windows Phone" alt="Supported by Silverlight for Windows Phone" /></td>
<td><a href="cacheresponse-contentlength-property-microsoft-web-media-smoothstreaming_1.md">ContentLength</a></td>
<td>The length in bytes.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ff728271.slMobile(en-us,VS.90).gif" title="Supported by Silverlight for Windows Phone" alt="Supported by Silverlight for Windows Phone" /></td>
<td><a href="cacheresponse-contenttype-property-microsoft-web-media-smoothstreaming_1.md">ContentType</a></td>
<td>A string object that identifies the content type</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ff728271.slMobile(en-us,VS.90).gif" title="Supported by Silverlight for Windows Phone" alt="Supported by Silverlight for Windows Phone" /></td>
<td><a href="cacheresponse-expirytime-property-microsoft-web-media-smoothstreaming_1.md">ExpiryTime</a></td>
<td>A <a href="https://msdn.microsoft.com/en-us/library/03ybds8y(v=vs.90)">DateTime</a> object that contains the time of response expiration.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ff728271.slMobile(en-us,VS.90).gif" title="Supported by Silverlight for Windows Phone" alt="Supported by Silverlight for Windows Phone" /></td>
<td><a href="cacheresponse-headers-property-microsoft-web-media-smoothstreaming_1.md">Headers</a></td>
<td>Metadata collection of response.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ff728271.slMobile(en-us,VS.90).gif" title="Supported by Silverlight for Windows Phone" alt="Supported by Silverlight for Windows Phone" /></td>
<td><a href="cacheresponse-response-property-microsoft-web-media-smoothstreaming_1.md">Response</a></td>
<td>A <a href="https://msdn.microsoft.com/en-us/library/8f86tw9e(v=vs.90)">Stream</a> object that contains the response.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ff728271.slMobile(en-us,VS.90).gif" title="Supported by Silverlight for Windows Phone" alt="Supported by Silverlight for Windows Phone" /></td>
<td><a href="cacheresponse-statuscode-property-microsoft-web-media-smoothstreaming_1.md">StatusCode</a></td>
<td>An HTTPStatusCode enumeration object.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ff728271.slMobile(en-us,VS.90).gif" title="Supported by Silverlight for Windows Phone" alt="Supported by Silverlight for Windows Phone" /></td>
<td><a href="cacheresponse-statusdescription-property-microsoft-web-media-smoothstreaming_1.md">StatusDescription</a></td>
<td>A string that contains the status description.</td>
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
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ff728271.slMobile(en-us,VS.90).gif" title="Supported by Silverlight for Windows Phone" alt="Supported by Silverlight for Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bsc2ak47(v=vs.90)">Equals</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ff728271.slMobile(en-us,VS.90).gif" title="Supported by Silverlight for Windows Phone" alt="Supported by Silverlight for Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/4k87zsw7(v=vs.90)">Finalize</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ff728271.slMobile(en-us,VS.90).gif" title="Supported by Silverlight for Windows Phone" alt="Supported by Silverlight for Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.90)">GetHashCode</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ff728271.slMobile(en-us,VS.90).gif" title="Supported by Silverlight for Windows Phone" alt="Supported by Silverlight for Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/dfwy45w9(v=vs.90)">GetType</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ff728271.slMobile(en-us,VS.90).gif" title="Supported by Silverlight for Windows Phone" alt="Supported by Silverlight for Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/57ctke0a(v=vs.90)">MemberwiseClone</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ff728271.slMobile(en-us,VS.90).gif" title="Supported by Silverlight for Windows Phone" alt="Supported by Silverlight for Windows Phone" /></td>
<td><a href="cacheresponse-readfrom-method-microsoft-web-media-smoothstreaming_1.md">ReadFrom</a></td>
<td>Reads the response from a <a href="https://msdn.microsoft.com/en-us/library/8f86tw9e(v=vs.90)">Stream</a> object. There is no default implementation for this method. Calling the method without implementing an override will result in a <a href="https://msdn.microsoft.com/en-us/library/8a7a4e64(v=vs.90)">NotSupportedException</a>.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ff728271.slMobile(en-us,VS.90).gif" title="Supported by Silverlight for Windows Phone" alt="Supported by Silverlight for Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ff728271.slMobile(en-us,VS.90).gif" title="Supported by Silverlight for Windows Phone" alt="Supported by Silverlight for Windows Phone" /></td>
<td><a href="cacheresponse-writeto-method-microsoft-web-media-smoothstreaming_1.md">WriteTo</a></td>
<td>Writes the response to a <a href="https://msdn.microsoft.com/en-us/library/8f86tw9e(v=vs.90)">Stream</a> object.</td>
</tr>
</tbody>
</table>


Top

## Remarks

The CacheResponse class supports offline playback scenarios. When the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) needs a chunk or manifest, it first checks with the registered cache plug-in. If the plug-in has it, the chunk is used. Otherwise, SSME downloads it by HTTP. After the download, [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) provides an option for the plug-in to persist the downloaded chunk.

A template example for implementation of the cache plug-in ships with Microsoft Expression Encoder 4.

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

