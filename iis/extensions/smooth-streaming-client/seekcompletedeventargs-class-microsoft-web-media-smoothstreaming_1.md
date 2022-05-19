---
title: SeekCompletedEventArgs Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SeekCompletedEventArgs Class
description: "The SeekCompletedEventArgs class is used to pass event argument information when a seek event completes."
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.seekcompletedeventargs(v=VS.95)
ms:contentKeyID: 46307946
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SeekCompletedEventArgs Class

Class used to pass event argument information when a seek event completes.

## Inheritance Hierarchy

 [System.Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\))  
  [System.EventArgs](https://msdn.microsoft.com/library/118wxtk3\(v=vs.95\))  
    Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Class SeekCompletedEventArgs _
    Inherits EventArgs
'Usage

Dim instance As SeekCompletedEventArgs
```

```csharp
public class SeekCompletedEventArgs : EventArgs
```

```cpp
public ref class SeekCompletedEventArgs : public EventArgs
```

``` fsharp
type SeekCompletedEventArgs =  
    class
        inherit EventArgs
    end
```

```jscript
public class SeekCompletedEventArgs extends EventArgs
```

The SeekCompletedEventArgs type exposes the following members.

## Properties

|Property Type|Name|Description|
|--- |--- |--- |
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[ActualSeekPosition](seekcompletedeventargs-actualseekposition-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the [ActualSeekPosition](seekcompletedeventargs-actualseekposition-property-microsoft-web-media-smoothstreaming_1.md) property.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[Success](seekcompletedeventargs-success-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the [Success](seekcompletedeventargs-success-property-microsoft-web-media-smoothstreaming_1.md) property to indicate that the seek operation is successful.|

## Methods

|Method Type|Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[Equals](https://msdn.microsoft.com/library/bsc2ak47(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[GetType](https://msdn.microsoft.com/library/dfwy45w9(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|

## Remarks

For more information, see the example in the topic [Events](events.md).

## Examples

The following code uses the SeekCompletedEventArgs parameter to find the position of the player after a seek operation.

``` 
    void SmoothPlayer_SeekCompleted(object sender, SeekCompletedEventArgs e)
    {
        OutputText.Text = "  Seek complete at: " + ((SmoothStreamingMediaElement)sender).Position;
    }
```

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
