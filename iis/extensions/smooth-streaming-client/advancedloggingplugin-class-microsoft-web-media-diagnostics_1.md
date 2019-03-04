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
- csharp
- jscript
- vb
- FSharp
- cpp
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

 [System.Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\))  
  Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin  

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Class AdvancedLoggingPlugin _
    Implements IDisposable
'Usage

Dim instance As AdvancedLoggingPlugin
```

```csharp
public class AdvancedLoggingPlugin : IDisposable
```

```cpp
public ref class AdvancedLoggingPlugin : IDisposable
```

``` fsharp
type AdvancedLoggingPlugin =  
    class
        interface IDisposable
    end
```

```jscript
public class AdvancedLoggingPlugin implements IDisposable
```

The AdvancedLoggingPlugin type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[AdvancedLoggingPlugin](advancedloggingplugin-constructor-microsoft-web-media-diagnostics_1.md)|Initializes a new instance of the AdvancedLoggingPlugin class.|


## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[ApplicationLogUrls](advancedloggingplugin-applicationlogurls-property-microsoft-web-media-diagnostics_1.md)|Gets or sets the ApplicationLogUrls.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[ManifestLogUrls](advancedloggingplugin-manifestlogurls-property-microsoft-web-media-diagnostics_1.md)|Gets the ManifestLogUrls.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[SmoothStreamingMediaElement](advancedloggingplugin-smoothstreamingmediaelement-property-microsoft-web-media-diagnostics_1.md)|Gets or sets the that this plug-in will service.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[TimerInterval](advancedloggingplugin-timerinterval-property-microsoft-web-media-diagnostics_1.md)|Gets or sets the timer interval for periodic advanced logging posts.|


## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[Dispose](advancedloggingplugin-dispose-method-microsoft-web-media-diagnostics.md)|Disposes the advanced logging plugin.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[Equals](https://msdn.microsoft.com/library/bsc2ak47(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[GetType](https://msdn.microsoft.com/library/dfwy45w9(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|


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

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

