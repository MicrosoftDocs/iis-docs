---
title: AdvancedLoggingPlugin.TimerInterval Property  (Microsoft.Web.Media.Diagnostics)
TOCTitle: TimerInterval Property
ms:assetid: P:Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.TimerInterval
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.advancedloggingplugin.timerinterval(v=VS.95)
ms:contentKeyID: 46307724
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.get_TimerInterval
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.set_TimerInterval
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.TimerInterval
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.get_TimerInterval
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.set_TimerInterval
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.TimerInterval
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# AdvancedLoggingPlugin.TimerInterval Property

Gets or sets the timer interval for periodic advanced logging posts.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Property TimerInterval As TimeSpan
    Get
    Set
'Usage

Dim instance As AdvancedLoggingPlugin
Dim value As TimeSpan

value = instance.TimerInterval

instance.TimerInterval = value
```

``` csharp
public TimeSpan TimerInterval { get; set; }
```

``` c++
public:
property TimeSpan TimerInterval {
    TimeSpan get ();
    void set (TimeSpan value);
}
```

``` fsharp
member TimerInterval : TimeSpan with get, set
```

``` jscript
function get TimerInterval () : TimeSpan
function set TimerInterval (value : TimeSpan)
```

#### Property Value

Type: [System.TimeSpan](https://msdn.microsoft.com/en-us/library/269ew577\(v=vs.95\))  
A [TimeSpan](https://msdn.microsoft.com/en-us/library/269ew577\(v=vs.95\)) object.

## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[AdvancedLoggingPlugin Class](advancedloggingplugin-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

