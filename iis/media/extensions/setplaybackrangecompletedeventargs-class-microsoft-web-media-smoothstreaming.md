---
title: SetPlaybackRangeCompletedEventArgs Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SetPlaybackRangeCompletedEventArgs Class
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.SetPlaybackRangeCompletedEventArgs
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.setplaybackrangecompletedeventargs(v=VS.95)
ms:contentKeyID: 46307947
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SetPlaybackRangeCompletedEventArgs
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SetPlaybackRangeCompletedEventArgs
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SetPlaybackRangeCompletedEventArgs Class

Represents event arguments for the completion of a SetPlaybackRangeAysnc operation.

## Inheritance Hierarchy

 [System.Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.95\))  
  [System.EventArgs](https://msdn.microsoft.com/en-us/library/118wxtk3\(v=vs.95\))  
    [System.ComponentModel.AsyncCompletedEventArgs](https://msdn.microsoft.com/en-us/library/2tde67e9\(v=vs.95\))  
      Microsoft.Web.Media.SmoothStreaming.SetPlaybackRangeCompletedEventArgs  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Class SetPlaybackRangeCompletedEventArgs _
    Inherits AsyncCompletedEventArgs
'Usage

Dim instance As SetPlaybackRangeCompletedEventArgs
```

``` csharp
public class SetPlaybackRangeCompletedEventArgs : AsyncCompletedEventArgs
```

``` c++
public ref class SetPlaybackRangeCompletedEventArgs : public AsyncCompletedEventArgs
```

``` fsharp
type SetPlaybackRangeCompletedEventArgs =  
    class
        inherit AsyncCompletedEventArgs
    end
```

``` jscript
public class SetPlaybackRangeCompletedEventArgs extends AsyncCompletedEventArgs
```

The SetPlaybackRangeCompletedEventArgs type exposes the following members.

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
<td><a href="setplaybackrangecompletedeventargs-constructor-exception-object-microsoft-web-media-smoothstreaming.md">SetPlaybackRangeCompletedEventArgs(Exception, Object)</a></td>
<td>Initializes a new instance of the SetPlaybackRangeCompletedEventArgs class for a failed completion of a SetPlaybackRangeAysnc operation.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="setplaybackrangecompletedeventargs-constructor-timespan-timespan-object-microsoft-web-media-smoothstreaming.md">SetPlaybackRangeCompletedEventArgs(TimeSpan, TimeSpan, Object)</a></td>
<td>Initializes a new instance of the SetPlaybackRangeCompletedEventArgs class for a successful completion of a SetPlaybackRangeAysnc operation.</td>
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
<td><a href="https://msdn.microsoft.com/en-us/library/hhb0kte8(v=vs.95)">Cancelled</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/2tde67e9(v=vs.95)">AsyncCompletedEventArgs</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/zye0z486(v=vs.95)">Error</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/2tde67e9(v=vs.95)">AsyncCompletedEventArgs</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="setplaybackrangecompletedeventargs-leftedge-property-microsoft-web-media-smoothstreaming.md">LeftEdge</a></td>
<td>Gets the left-most position for a seek operation.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="setplaybackrangecompletedeventargs-rightedge-property-microsoft-web-media-smoothstreaming.md">RightEdge</a></td>
<td>Gets the player application's expected right-most position or chunk timestamp.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/9b3wa0x3(v=vs.95)">UserState</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/2tde67e9(v=vs.95)">AsyncCompletedEventArgs</a>.)</td>
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
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/69w1sf5e(v=vs.95)">RaiseExceptionIfNecessary</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/2tde67e9(v=vs.95)">AsyncCompletedEventArgs</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.95)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
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

