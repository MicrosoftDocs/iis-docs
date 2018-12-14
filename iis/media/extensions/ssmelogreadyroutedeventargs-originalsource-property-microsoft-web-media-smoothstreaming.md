---
title: SSMELogReadyRoutedEventArgs.OriginalSource Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: OriginalSource Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.OriginalSource
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.ssmelogreadyroutedeventargs.originalsource(v=VS.90)
ms:contentKeyID: 31469256
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.get_OriginalSource
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.OriginalSource
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.set_OriginalSource
dev_langs:
- CSharp
- JScript
- VB
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

# OriginalSource Property

Gets or sets the object that raised the event.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicPropertyOriginalSourceAsObject
'Usage
DiminstanceAsSSMELogReadyRoutedEventArgsDimvalueAsObjectvalue = instance.OriginalSource
```

``` csharp
publicObjectOriginalSource { get; privateset; }
```

``` c++
public:
propertyObject^ OriginalSource {
    Object^ get ();
    private: voidset (Object^ value);
}
```

``` jscript
function getOriginalSource () : Objectprivatefunction setOriginalSource (value : Object)
```

#### Property Value

Type: [System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
An [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\)) that is the source of the event.  

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

