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
- "csharp"
- "jscript"
- "vb"
- "cpp"
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
---

# ClipPlaybackEventArgs Class

Class that contains event data for a media clip event.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  [System.EventArgs](https://msdn.microsoft.com/library/118wxtk3)  
    [Microsoft.Web.Media.SmoothStreaming.ClipEventArgs](clipeventargs-class-microsoft-web-media-smoothstreaming_1.md)  
      Microsoft.Web.Media.SmoothStreaming..::..ClipPlaybackEventArgs  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Class ClipPlaybackEventArgs _
    Inherits ClipEventArgs
'Usage

  Dim instance As ClipPlaybackEventArgs
```

```csharp
  public class ClipPlaybackEventArgs : ClipEventArgs
```

```cpp
  public ref class ClipPlaybackEventArgs : public ClipEventArgs
```

```jscript
  public class ClipPlaybackEventArgs extends ClipEventArgs
```

The ClipPlaybackEventArgs type exposes the following members.

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[Context](clipeventargs-context-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the [Context](clipeventargs-context-property-microsoft-web-media-smoothstreaming_1.md) property. (Inherited from [ClipEventArgs](clipeventargs-class-microsoft-web-media-smoothstreaming_1.md).)|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[Progress](clipplaybackeventargs-progress-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the [Progress](clipplaybackeventargs-progress-property-microsoft-web-media-smoothstreaming_1.md) property.|


## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|


## Version Information

### Silverlight

Supported in: 4  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

