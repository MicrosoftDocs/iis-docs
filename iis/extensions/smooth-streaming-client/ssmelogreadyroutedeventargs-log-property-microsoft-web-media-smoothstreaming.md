---
title: SSMELogReadyRoutedEventArgs.Log Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Log Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.Log
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.ssmelogreadyroutedeventargs.log(v=VS.90)
ms:contentKeyID: 31469234
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.get_Log
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.Log
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.set_Log
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.get_Log
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.Log
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.set_Log
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Log Property

Gets or sets an XML string in the Windows Media Log format that contains the fields listed in the LogFields section.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

  Public Property Log As String
'Usage

  Dim instance As SSMELogReadyRoutedEventArgs
Dim value As String

value = instance.Log
```

``` csharp
  public string Log { get; private set; }
```

``` c++
  public:
property String^ Log {
    String^ get ();
    private: void set (String^ value);
}
```

``` jscript
  function get Log () : String
private function set Log (value : String)
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string that contains XML data.  

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[SSMELogReadyRoutedEventArgs Class](ssmelogreadyroutedeventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

