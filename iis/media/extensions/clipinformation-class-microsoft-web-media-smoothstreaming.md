---
title: ClipInformation Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ClipInformation Class
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.ClipInformation
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.clipinformation(v=VS.90)
ms:contentKeyID: 23961135
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ClipInformation Class

Metadata class for scheduling and viewing a segment of audio or video media data.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  Microsoft.Web.Media.SmoothStreaming..::..ClipInformation  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicClassClipInformation
'Usage
DiminstanceAsClipInformation
```

``` csharp
publicclassClipInformation
```

``` c++
publicref classClipInformation
```

``` jscript
publicclass ClipInformation
```

The ClipInformation type exposes the following members.

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
<td><a href="clipinformation-constructor-boolean-uri-microsoft-web-media-smoothstreaming_1.md">ClipInformation(Boolean, Uri)</a></td>
<td>Initializes a new instance of the ClipInformation class.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="clipinformation-constructor-boolean-uri-uri-microsoft-web-media-smoothstreaming_1.md">ClipInformation(Boolean, Uri, Uri)</a></td>
<td>Initializes a new instance of the ClipInformation class.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="clipinformation-constructor-boolean-uri-duration-microsoft-web-media-smoothstreaming_1.md">ClipInformation(Boolean, Uri, Duration)</a></td>
<td>Initializes a new instance of the ClipInformation class.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="clipinformation-constructor-boolean-uri-uri-duration-microsoft-web-media-smoothstreaming_1.md">ClipInformation(Boolean, Uri, Uri, Duration)</a></td>
<td>Initializes a new instance of the ClipInformation class.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="clipinformation-constructor-boolean-uri-uri-duration-ismoothstreamingcache-microsoft-web-media-smoothstreaming_1.md">ClipInformation(Boolean, Uri, Uri, Duration, ISmoothStreamingCache)</a></td>
<td>Initializes a new instance of the ClipInformation class.</td>
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
<td><a href="clipinformation-clickthroughuri-property-microsoft-web-media-smoothstreaming_1.md">ClickThroughUri</a></td>
<td>Gets or sets a <a href="https://msdn.microsoft.com/en-us/library/txt7706a(v=vs.90)">Uri</a> object that contains the Uri to additional information.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="clipinformation-clipuri-property-microsoft-web-media-smoothstreaming_1.md">ClipUri</a></td>
<td>Gets or sets a <a href="https://msdn.microsoft.com/en-us/library/txt7706a(v=vs.90)">Uri</a> object that contains the clip source.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="clipinformation-duration-property-microsoft-web-media-smoothstreaming_1.md">Duration</a></td>
<td>Gets or sets the running time of the media clip.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="clipinformation-issmoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md">IsSmoothStreamingSource</a></td>
<td>Gets or sets a Boolean value that indicates whether the media clip is in Smooth Streaming format.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="clipinformation-smoothstreamingcache-property-microsoft-web-media-smoothstreaming_1.md">SmoothStreamingCache</a></td>
<td>Gets or sets the Smooth Streaming cache.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="clipinformation-usesmoothstreamingcache-property-microsoft-web-media-smoothstreaming_1.md">UseSmoothStreamingCache</a></td>
<td>Gets or sets a Boolean value that indicates whether to use the Smooth Streaming cache.</td>
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
<td><a href="https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.90)">GetHashCode</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
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
<td><a href="clipinformation-setsource-method-microsoft-web-media-smoothstreaming_1.md">SetSource</a></td>
<td>Sets the source for the clip. Enables setting the clip information on the clip MediaElement for extensibility purposes.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
</tbody>
</table>


Top

## Examples

You can initialize a ClipInformation object that specifies the media clip to play by its [ClipUri](clipinformation-clipuri-property-microsoft-web-media-smoothstreaming_1.md) and [Duration](clipinformation-duration-property-microsoft-web-media-smoothstreaming_1.md). You can also supply the [ClickThroughUri](clipinformation-clickthroughuri-property-microsoft-web-media-smoothstreaming_1.md) to provide follow-up information to the user when he clicks on the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) surface while it is playing the clip.

``` 
    private void InsertClipCheckbox_Checked(object sender, RoutedEventArgs e)
    {
        clips.Add(new ClipInformation(true,
            new Uri("http://<serverName>/advertisement-clip.ism/Manifest"),
            new Uri("http://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.aspx"),
            new TimeSpan(1789250001)));
    }
```

For more information, see [Scheduling Media Clips (IIS Smooth Streaming)](scheduling-media-clips.md).

## Version Information

#### Silverlight

Supported in: 4  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

