---
title: ClipPlaybackEventArgs Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ClipPlaybackEventArgs Class
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.ClipPlaybackEventArgs
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.clipplaybackeventargs(v=VS.90)
ms:contentKeyID: 23961058
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipPlaybackEventArgs
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipPlaybackEventArgs
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ClipPlaybackEventArgs Class

Class that contains event data for a media clip event.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  [System. . :: . .EventArgs](https://msdn.microsoft.com/en-us/library/118wxtk3\(v=vs.90\))  
    [Microsoft.Web.Media.SmoothStreaming. . :: . .ClipEventArgs](clipeventargs-class-microsoft-web-media-smoothstreaming_1.md)  
      Microsoft.Web.Media.SmoothStreaming..::..ClipPlaybackEventArgs  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

  Public Class ClipPlaybackEventArgs _
    Inherits ClipEventArgs
'Usage

  Dim instance As ClipPlaybackEventArgs
```

``` csharp
  public class ClipPlaybackEventArgs : ClipEventArgs
```

``` c++
  public ref class ClipPlaybackEventArgs : public ClipEventArgs
```

``` jscript
  public class ClipPlaybackEventArgs extends ClipEventArgs
```

The ClipPlaybackEventArgs type exposes the following members.

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[Context](clipeventargs-context-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the [Context](clipeventargs-context-property-microsoft-web-media-smoothstreaming_1.md) property. (Inherited from [ClipEventArgs](clipeventargs-class-microsoft-web-media-smoothstreaming_1.md).)|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[Progress](clipplaybackeventargs-progress-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the [Progress](clipplaybackeventargs-progress-property-microsoft-web-media-smoothstreaming_1.md) property.|


Top

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/en-us/library/bsc2ak47(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/en-us/library/4k87zsw7(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/en-us/library/dfwy45w9(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/en-us/library/57ctke0a(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|


Top

## Version Information

#### Silverlight

Supported in: 4  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

