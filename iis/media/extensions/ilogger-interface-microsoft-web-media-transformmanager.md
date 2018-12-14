---
title: ILogger Interface (Microsoft.Web.Media.TransformManager)
TOCTitle: ILogger Interface
ms:assetid: T:Microsoft.Web.Media.TransformManager.ILogger
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.ilogger(v=VS.90)
ms:contentKeyID: 35520832
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ILogger
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Sdk.dll
api_name:
- Microsoft.Web.Media.TransformManager.ILogger
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ILogger Interface

Defines a logger that can be used by the task to write data to the job-instance log.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Sdk (in Microsoft.Web.Media.TransformManager.Sdk.dll)

## Syntax

``` vb
'Declaration
PublicInterfaceILogger
'Usage
DiminstanceAsILogger
```

``` csharp
publicinterfaceILogger
```

``` c++
publicinterface classILogger
```

``` fsharp
typeILogger =  interfaceend
```

``` jscript
publicinterface ILogger
```

The ILogger type exposes the following members.

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
<td><a href="ilogger-logfile-property-microsoft-web-media-transformmanager.md">LogFile</a></td>
<td>Gets the <a href="https://msdn.microsoft.com/en-us/library/3ssew6tk(v=vs.90)">StreamWriter</a> object for the logger.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="ilogger-loglevel-property-microsoft-web-media-transformmanager.md">LogLevel</a></td>
<td>Gets the level of errors that will be logged.</td>
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
<td><a href="ilogger-writeline-method-loglevel-string-microsoft-web-media-transformmanager.md">WriteLine(LogLevel, String)</a></td>
<td>Writes a line to the log.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="ilogger-writeline-method-loglevel-string-int32-microsoft-web-media-transformmanager.md">WriteLine(LogLevel, String, Int32)</a></td>
<td></td>
</tr>
</tbody>
</table>


Top

## See Also

#### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

