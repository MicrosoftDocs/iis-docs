---
title: SSMELogReadyRoutedEventArgs.OriginalSource Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: OriginalSource Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.OriginalSource
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.ssmelogreadyroutedeventargs.originalsource(v=VS.95)
ms:contentKeyID: 46307865
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.get_OriginalSource
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.OriginalSource
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.set_OriginalSource
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.get_OriginalSource
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.OriginalSource
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.set_OriginalSource
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SSMELogReadyRoutedEventArgs.OriginalSource Property

Gets or sets the object that raised the event.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Property OriginalSource As Object
    Get
    Private Set
'Usage

Dim instance As SSMELogReadyRoutedEventArgs
Dim value As Object

value = instance.OriginalSource
```

``` csharp
public Object OriginalSource { get; private set; }
```

``` c++
public:
property Object^ OriginalSource {
    Object^ get ();
    private: void set (Object^ value);
}
```

``` fsharp
member OriginalSource : Object with get, private set
```

``` jscript
function get OriginalSource () : Object
private function set OriginalSource (value : Object)
```

#### Property Value

Type: [System.Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.95\))  
An [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.95\)) that is the source of the event.

## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[SSMELogReadyRoutedEventArgs Class](ssmelogreadyroutedeventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

