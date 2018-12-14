---
title: SeekCompletedEventArgs.ActualSeekPosition Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ActualSeekPosition Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.ActualSeekPosition
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.seekcompletedeventargs.actualseekposition(v=VS.90)
ms:contentKeyID: 23961084
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.ActualSeekPosition
- Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.get_ActualSeekPosition
- Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.set_ActualSeekPosition
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.ActualSeekPosition
- Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.get_ActualSeekPosition
- Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.set_ActualSeekPosition
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ActualSeekPosition Property

Gets or sets the ActualSeekPosition property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicPropertyActualSeekPositionAsTimeSpan
'Usage
DiminstanceAsSeekCompletedEventArgsDimvalueAsTimeSpanvalue = instance.ActualSeekPosition

instance.ActualSeekPosition = value
```

``` csharp
publicTimeSpanActualSeekPosition { get; set; }
```

``` c++
public:
propertyTimeSpanActualSeekPosition {
    TimeSpanget ();
    voidset (TimeSpanvalue);
}
```

``` jscript
function getActualSeekPosition () : TimeSpanfunction setActualSeekPosition (value : TimeSpan)
```

#### Property Value

Type: [System. . :: . .TimeSpan](https://msdn.microsoft.com/en-us/library/269ew577\(v=vs.90\))  
A [TimeSpan](https://msdn.microsoft.com/en-us/library/269ew577\(v=vs.90\)) structure object.  

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[SeekCompletedEventArgs Class](seekcompletedeventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

