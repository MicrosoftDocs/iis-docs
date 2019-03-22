---
title: SmoothStreamingErrorEventArgs Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SmoothStreamingErrorEventArgs Class
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingerroreventargs(v=VS.90)
ms:contentKeyID: 23960987
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingErrorEventArgs Class

Class to pass error event information about a Smooth Streaming operation.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  [System.EventArgs](https://msdn.microsoft.com/library/118wxtk3)  
    Microsoft.Web.Media.SmoothStreaming..::..SmoothStreamingErrorEventArgs  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Class SmoothStreamingErrorEventArgs _
    Inherits EventArgs
'Usage

  Dim instance As SmoothStreamingErrorEventArgs
```

```csharp
  public class SmoothStreamingErrorEventArgs : EventArgs
```

```cpp
  public ref class SmoothStreamingErrorEventArgs : public EventArgs
```

```jscript
  public class SmoothStreamingErrorEventArgs extends EventArgs
```

The SmoothStreamingErrorEventArgs type exposes the following members.

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[ErrorCode](smoothstreamingerroreventargs-errorcode-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the [ErrorCode](smoothstreamingerroreventargs-errorcode-property-microsoft-web-media-smoothstreaming_1.md) property.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[ErrorException](smoothstreamingerroreventargs-errorexception-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the [ErrorException](smoothstreamingerroreventargs-errorexception-property-microsoft-web-media-smoothstreaming_1.md) property.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[ErrorMessage](smoothstreamingerroreventargs-errormessage-property-microsoft-web-media-smoothstreaming_1.md)|Gets or sets the [ErrorMessage](smoothstreamingerroreventargs-errormessage-property-microsoft-web-media-smoothstreaming_1.md) property.|


## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")![Supported by Silverlight for Windows Phone](images/Ff728140.slMobile(en-us,VS.90).gif "Supported by Silverlight for Windows Phone")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|


## Remarks

For more information, see [Events (IIS Smooth Streaming)](events.md).

## Examples

The [SmoothStreamingErrorOccurred](smoothstreamingmediaelement-smoothstreamingerroroccurred-event-microsoft-web-media-smoothstreaming_1.md) event can be handled by assigning a delegate and by writing the code to process the exception.

Assign the delegate.

    SmoothPlayer.SmoothStreamingErrorOccurred += 
      new EventHandler<SmoothStreamingErrorEventArgs>(SmoothPlayer_SmoothStreamingErrorOccurred);

Define the handler.

    void SmoothPlayer_SmoothStreamingErrorOccurred(object sender, 
                                      SmoothStreamingErrorEventArgs e)
       {
            MessageBox.Show("Error: " + e.ErrorCode + "; " + e.ErrorMessage);
        }

This handler displays the error code and message to a text block. You can implement error-handling logic so that the application does not hang if an exception occurs.

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

