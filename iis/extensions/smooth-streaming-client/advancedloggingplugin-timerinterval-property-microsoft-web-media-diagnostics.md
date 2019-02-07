---
title: AdvancedLoggingPlugin.TimerInterval Property  (Microsoft.Web.Media.Diagnostics)
TOCTitle: TimerInterval Property
ms:assetid: P:Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.TimerInterval
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.advancedloggingplugin.timerinterval(v=VS.90)
ms:contentKeyID: 31469156
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.get_TimerInterval
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.set_TimerInterval
- Microsoft.Web.Media.Diagnostics.AdvancedLoggingPlugin.TimerInterval
dev_langs:
- CSharp
- JScript
- VB
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

# TimerInterval Property

Gets or sets the timer interval for periodic advanced logging posts.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

  Public Property TimerInterval As TimeSpan
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

``` jscript
  function get TimerInterval () : TimeSpan
function set TimerInterval (value : TimeSpan)
```

#### Property Value

Type: [System. . :: . .TimeSpan](https://msdn.microsoft.com/en-us/library/269ew577\(v=vs.90\))  
A [TimeSpan](https://msdn.microsoft.com/en-us/library/269ew577\(v=vs.90\)) object.  

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[AdvancedLoggingPlugin Class](advancedloggingplugin-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

