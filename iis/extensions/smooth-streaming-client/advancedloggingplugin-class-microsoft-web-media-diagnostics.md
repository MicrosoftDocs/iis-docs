---
title: AdvancedLoggingPlugin Class (Microsoft.Web.Media.Diagnostics)
TOCTitle: AdvancedLoggingPlugin Class
description: Posts advanced logs to a server that by default will upload a log every 30 seconds.
ms:assetid: T:Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.diagnostics.advancedloggingplugin(v=VS.90)
ms:contentKeyID: 31469158
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# AdvancedLoggingPlugin Class

Posts advanced logs to a server that by default will upload a log every 30 seconds.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  Microsoft.Web.Media.Diagnostics..::..AdvancedLoggingPlugin  

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Class AdvancedLoggingPlugin
'Usage

  Dim instance As AdvancedLoggingPlugin
```

```csharp
  public class AdvancedLoggingPlugin
```

```cpp
  public ref class AdvancedLoggingPlugin
```

```jscript
  public class AdvancedLoggingPlugin
```

The AdvancedLoggingPlugin type exposes the following members.

## Constructors

|Method Type|Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[AdvancedLoggingPlugin](advancedloggingplugin-constructor-microsoft-web-media-diagnostics_1.md)|Initializes a new instance of the AdvancedLoggingPlugin class.|

## Properties

|Property Type|Name|Description|
|--- |--- |--- |
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[ApplicationLogUrls](advancedloggingplugin-applicationlogurls-property-microsoft-web-media-diagnostics_1.md)|Gets or sets the ApplicationLogUrls.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[ManifestLogUrls](advancedloggingplugin-manifestlogurls-property-microsoft-web-media-diagnostics_1.md)|Gets the ManifestLogUrls.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[SmoothStreamingMediaElement](advancedloggingplugin-smoothstreamingmediaelement-property-microsoft-web-media-diagnostics_1.md)|Gets or sets the [SmoothStreamingMediaElement] that this plug-in will service.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[TimerInterval](advancedloggingplugin-timerinterval-property-microsoft-web-media-diagnostics_1.md)|Gets or sets the timer interval for periodic advanced logging posts.|

## Methods

|Method Typesw|Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|

## Remarks

For more information about advanced logging, see [Advanced Logging (IIS Smooth Streaming)](advanced-logging.md)

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

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)
