---
title: AdvancedLoggingPlugin Class (Microsoft.Web.Media.Diagnostics)
TOCTitle: AdvancedLoggingPlugin Class
ms:assetid: T:Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.advancedloggingplugin(v=VS.95)
ms:contentKeyID: 46307921
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# AdvancedLoggingPlugin Class

Posts advanced logs to a server that by default will upload a log every 30 seconds.

## Inheritance Hierarchy

 [System.Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.95\))  
  Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin  

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Class AdvancedLoggingPlugin _
    Implements IDisposable
'Usage

Dim instance As AdvancedLoggingPlugin
```

``` csharp
public class AdvancedLoggingPlugin : IDisposable
```

``` c++
public ref class AdvancedLoggingPlugin : IDisposable
```

``` fsharp
type AdvancedLoggingPlugin =  
    class
        interface IDisposable
    end
```

``` jscript
public class AdvancedLoggingPlugin implements IDisposable
```

The AdvancedLoggingPlugin type exposes the following members.

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
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="advancedloggingplugin-constructor-microsoft-web-media-diagnostics_1.md">AdvancedLoggingPlugin</a></td>
<td>Initializes a new instance of the AdvancedLoggingPlugin class.</td>
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
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="advancedloggingplugin-applicationlogurls-property-microsoft-web-media-diagnostics_1.md">ApplicationLogUrls</a></td>
<td>Gets or sets the ApplicationLogUrls.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="advancedloggingplugin-manifestlogurls-property-microsoft-web-media-diagnostics_1.md">ManifestLogUrls</a></td>
<td>Gets the ManifestLogUrls.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="advancedloggingplugin-smoothstreamingmediaelement-property-microsoft-web-media-diagnostics_1.md">SmoothStreamingMediaElement</a></td>
<td>Gets or sets the that this plug-in will service.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="advancedloggingplugin-timerinterval-property-microsoft-web-media-diagnostics_1.md">TimerInterval</a></td>
<td>Gets or sets the timer interval for periodic advanced logging posts.</td>
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
<td><a href="advancedloggingplugin-dispose-method-microsoft-web-media-diagnostics.md">Dispose</a></td>
<td>Disposes the advanced logging plugin.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bsc2ak47(v=vs.95)">Equals</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/4k87zsw7(v=vs.95)">Finalize</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.95)">GetHashCode</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/dfwy45w9(v=vs.95)">GetType</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/57ctke0a(v=vs.95)">MemberwiseClone</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Ee532579.slMobile(VS.95).gif" title="Supported by Windows Phone" alt="Supported by Windows Phone" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.95)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.95)">Object</a>.)</td>
</tr>
</tbody>
</table>


Top

## Remarks

For more information about advanced logging, see [Advanced Logging](advanced-logging.md).

## Examples

The following example shows initialization of the advanced logging plugin.

``` 
    void MainPage_Loaded(object sender, RoutedEventArgs e)
    {
        // Initialize IIS Advanced Logging.
        AdvancedLoggingPlugin log = new AdvancedLoggingPlugin();
        log.ApplicationLogUrls = new List<string> { "http://<serverName> /AdvancedLogs/Post.log" };
        log.TimerInterval = TimeSpan.FromSeconds(10);
        log.SmoothStreamingMediaElement = SmoothPlayer;
    }
```

## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

