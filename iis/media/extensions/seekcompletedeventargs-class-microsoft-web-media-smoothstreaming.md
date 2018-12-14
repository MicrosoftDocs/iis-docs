---
title: SeekCompletedEventArgs Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SeekCompletedEventArgs Class
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.seekcompletedeventargs(v=VS.90)
ms:contentKeyID: 23961249
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SeekCompletedEventArgs Class

Class used to pass event argument information when a seek event completes.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  [System. . :: . .EventArgs](https://msdn.microsoft.com/en-us/library/118wxtk3\(v=vs.90\))  
    Microsoft.Web.Media.SmoothStreaming..::..SeekCompletedEventArgs  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicClassSeekCompletedEventArgs _
    InheritsEventArgs
'Usage
DiminstanceAsSeekCompletedEventArgs
```

``` csharp
publicclassSeekCompletedEventArgs : EventArgs
```

``` c++
publicref classSeekCompletedEventArgs : publicEventArgs
```

``` jscript
publicclass SeekCompletedEventArgs extendsEventArgs
```

The SeekCompletedEventArgs type exposes the following members.

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
<td><a href="seekcompletedeventargs-actualseekposition-property-microsoft-web-media-smoothstreaming_1.md">ActualSeekPosition</a></td>
<td>Gets or sets the <a href="seekcompletedeventargs-actualseekposition-property-microsoft-web-media-smoothstreaming_1.md">ActualSeekPosition</a> property.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ff728271.slMobile(en-us,VS.90).gif" title="Supported by Silverlight for Windows Phone" alt="Supported by Silverlight for Windows Phone" /></td>
<td><a href="seekcompletedeventargs-success-property-microsoft-web-media-smoothstreaming_1.md">Success</a></td>
<td>Gets or sets the <a href="seekcompletedeventargs-success-property-microsoft-web-media-smoothstreaming_1.md">Success</a> property to indicate that the seek operation is successful.</td>
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
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
</tbody>
</table>


Top

## Remarks

For more information, see the example in the topic [Events (IIS Smooth Streaming)](events.md).

## Examples

The following code uses the SeekCompletedEventArgs parameter to find the position of the player after a seek operation.

``` 
    void SmoothPlayer_SeekCompleted(object sender, SeekCompletedEventArgs e)
    {
        OutputText.Text = "  Seek complete at: " + ((SmoothStreamingMediaElement)sender).Position;
    }
```

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

