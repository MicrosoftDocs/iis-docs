---
title: ClipEventArgs Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ClipEventArgs Class
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.ClipEventArgs
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.clipeventargs(v=VS.95)
ms:contentKeyID: 46307937
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipEventArgs
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipEventArgs
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ClipEventArgs Class

Class used by media clips to pass event argument information that contains an associated clip context instance.

## Inheritance Hierarchy

 [System.Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.95\))  
  [System.EventArgs](https://msdn.microsoft.com/en-us/library/118wxtk3\(v=vs.95\))  
    Microsoft.Web.Media.SmoothStreaming.ClipEventArgs  
      [Microsoft.Web.Media.SmoothStreaming.ClipPlaybackEventArgs](clipplaybackeventargs-class-microsoft-web-media-smoothstreaming_1.md)  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Class ClipEventArgs _
    Inherits EventArgs
'Usage

Dim instance As ClipEventArgs
```

``` csharp
public class ClipEventArgs : EventArgs
```

``` c++
public ref class ClipEventArgs : public EventArgs
```

``` fsharp
type ClipEventArgs =  
    class
        inherit EventArgs
    end
```

``` jscript
public class ClipEventArgs extends EventArgs
```

The ClipEventArgs type exposes the following members.

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
<td><a href="clipeventargs-context-property-microsoft-web-media-smoothstreaming_1.md">Context</a></td>
<td>Gets or sets the <a href="clipeventargs-context-property-microsoft-web-media-smoothstreaming_1.md">Context</a> property.</td>
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
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.95)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
</tbody>
</table>


Top

## Remarks

For more information, see [Scheduling Media Clips](scheduling-media-clips.md).

## Examples

If the user clicks on the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) surface while an inserted clip is playing, the delegate method that handles the event can access the Microsoft.Web.Media.SmoothStreaming.ClipContext from the ClipEventArgs. The [ClipInformation](clipcontext-clipinformation-property-microsoft-web-media-smoothstreaming_1.md) property contains the [Microsoft.Web.Media.SmoothStreaming.ClipInformation.ClickThroughUrl](https://msdn.microsoft.com/en-us/library/ee532602\(v=vs.95\)) that was assigned when the [ClipInformation](clipinformation-class-microsoft-web-media-smoothstreaming_1.md) object was initialized.

The following delegate opens a new browser window for the [Microsoft.Web.Media.SmoothStreaming.ClipInformation.ClickThroughUrl](https://msdn.microsoft.com/en-us/library/ee532602\(v=vs.95\)).

    void SmoothPlayer_ClipClickThrough(object sender, ClipEventArgs e)
        {
            System.Windows.Browser.HtmlPage.Window.Navigate(e.Context.ClipInformation.ClickThroughUrl, "_newWindow");
        }

## Version Information

#### Silverlight

Supported in: 5  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

