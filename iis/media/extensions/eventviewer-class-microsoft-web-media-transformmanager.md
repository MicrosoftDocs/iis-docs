---
title: EventViewer Class (Microsoft.Web.Media.TransformManager)
TOCTitle: EventViewer Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.EventViewer
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.eventviewer(v=VS.90)
ms:contentKeyID: 35520868
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.EventViewer
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.EventViewer
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# EventViewer Class

Provides event details that are written to an event viewer for an IIS Transform Manager job. The default event viewer is the Windows Event Viewer. This type supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  Microsoft.Web.Media.TransformManager..::..EventViewer  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
PublicNotInheritableClassEventViewer
'Usage
DiminstanceAsEventViewer
```

``` csharp
publicsealedclassEventViewer
```

``` c++
publicref classEventViewersealed
```

``` fsharp
[<SealedAttribute>]
typeEventViewer =  classend
```

``` jscript
publicfinalclass EventViewer
```

The EventViewer type exposes the following members.

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
<td><a href="eventviewer-eventiderror-field-microsoft-web-media-transformmanager.md">EventIdError</a></td>
<td>Represents a constant that is used when error information is written to the event viewer. This member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="eventviewer-eventidinformation-field-microsoft-web-media-transformmanager.md">EventIdInformation</a></td>
<td>Represents a constant that is used when information is written to the event viewer. This member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="eventviewer-eventidsuccess-field-microsoft-web-media-transformmanager.md">EventIdSuccess</a></td>
<td>Represents a constant that is used when success information is written to the event viewer. This member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="eventviewer-eventidwarning-field-microsoft-web-media-transformmanager.md">EventIdWarning</a></td>
<td>Represents a constant that is used when warning information is written to the event viewer. This member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="eventviewer-eventsource-field-microsoft-web-media-transformmanager.md">EventSource</a></td>
<td>Represents a constant that is used when event source information is written to the event viewer. This member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.</td>
</tr>
</tbody>
</table>


Top

## Remarks

The event viewer requires an event message to have a very specific format. Otherwise, the IIS Transform Manager provides a message that the product is not installed correctly.

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

