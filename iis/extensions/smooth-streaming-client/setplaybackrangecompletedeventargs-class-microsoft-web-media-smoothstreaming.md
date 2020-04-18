---
title: SetPlaybackRangeCompletedEventArgs Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SetPlaybackRangeCompletedEventArgs Class
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.SetPlaybackRangeCompletedEventArgs
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.setplaybackrangecompletedeventargs(v=VS.95)
ms:contentKeyID: 46307947
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SetPlaybackRangeCompletedEventArgs
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SetPlaybackRangeCompletedEventArgs
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SetPlaybackRangeCompletedEventArgs Class

Represents event arguments for the completion of a SetPlaybackRangeAysnc operation.

## Inheritance Hierarchy

 [System.Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\))  
  [System.EventArgs](https://msdn.microsoft.com/library/118wxtk3\(v=vs.95\))  
    [System.ComponentModel.AsyncCompletedEventArgs](https://msdn.microsoft.com/library/2tde67e9\(v=vs.95\))  
      Microsoft.Web.Media.SmoothStreaming.SetPlaybackRangeCompletedEventArgs  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Class SetPlaybackRangeCompletedEventArgs _
    Inherits AsyncCompletedEventArgs
'Usage

Dim instance As SetPlaybackRangeCompletedEventArgs
```

```csharp
public class SetPlaybackRangeCompletedEventArgs : AsyncCompletedEventArgs
```

```cpp
public ref class SetPlaybackRangeCompletedEventArgs : public AsyncCompletedEventArgs
```

``` fsharp
type SetPlaybackRangeCompletedEventArgs =  
    class
        inherit AsyncCompletedEventArgs
    end
```

```jscript
public class SetPlaybackRangeCompletedEventArgs extends AsyncCompletedEventArgs
```

The SetPlaybackRangeCompletedEventArgs type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[SetPlaybackRangeCompletedEventArgs(Exception, Object)](setplaybackrangecompletedeventargs-constructor-exception-object-microsoft-web-media-smoothstreaming.md)|Initializes a new instance of the SetPlaybackRangeCompletedEventArgs class for a failed completion of a SetPlaybackRangeAysnc operation.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[SetPlaybackRangeCompletedEventArgs(TimeSpan, TimeSpan, Object)](setplaybackrangecompletedeventargs-constructor-timespan-timespan-object-microsoft-web-media-smoothstreaming.md)|Initializes a new instance of the SetPlaybackRangeCompletedEventArgs class for a successful completion of a SetPlaybackRangeAysnc operation.|

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[Cancelled](https://msdn.microsoft.com/library/hhb0kte8(v=vs.95))|(Inherited from [AsyncCompletedEventArgs](https://msdn.microsoft.com/library/2tde67e9(v=vs.95)).)|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[Error](https://msdn.microsoft.com/library/zye0z486(v=vs.95))|(Inherited from [AsyncCompletedEventArgs](https://msdn.microsoft.com/library/2tde67e9(v=vs.95)).)|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[LeftEdge](setplaybackrangecompletedeventargs-leftedge-property-microsoft-web-media-smoothstreaming.md)|Gets the left-most position for a seek operation.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[RightEdge](setplaybackrangecompletedeventargs-rightedge-property-microsoft-web-media-smoothstreaming.md)|Gets the player application's expected right-most position or chunk timestamp.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[UserState](https://msdn.microsoft.com/library/9b3wa0x3(v=vs.95))|(Inherited from [AsyncCompletedEventArgs](https://msdn.microsoft.com/library/2tde67e9(v=vs.95)).)|

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")|[RaiseExceptionIfNecessary](https://msdn.microsoft.com/library/69w1sf5e(v=vs.95))|(Inherited from [AsyncCompletedEventArgs](https://msdn.microsoft.com/library/2tde67e9(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|

## Version Information

### Silverlight

Supported in: 5  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
