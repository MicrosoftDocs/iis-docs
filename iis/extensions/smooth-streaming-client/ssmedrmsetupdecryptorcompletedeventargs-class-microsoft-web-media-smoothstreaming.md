---
title: SSMEDrmSetupDecryptorCompletedEventArgs Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SSMEDrmSetupDecryptorCompletedEventArgs Class
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.SSMEDrmSetupDecryptorCompletedEventArgs
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.ssmedrmsetupdecryptorcompletedeventargs(v=VS.95)
ms:contentKeyID: 46307952
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SSMEDrmSetupDecryptorCompletedEventArgs
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SSMEDrmSetupDecryptorCompletedEventArgs
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SSMEDrmSetupDecryptorCompletedEventArgs Class

Represents event arguments for a [DrmSetupDecryptorCompleted](smoothstreamingmediaelement-drmsetupdecryptorcompleted-event-microsoft-web-media-smoothstreaming.md) event.

## Inheritance Hierarchy

 [System.Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\))  
  [System.EventArgs](https://msdn.microsoft.com/library/118wxtk3\(v=vs.95\))  
    [System.ComponentModel.AsyncCompletedEventArgs](https://msdn.microsoft.com/library/2tde67e9\(v=vs.95\))  
      Microsoft.Web.Media.SmoothStreaming.SSMEDrmSetupDecryptorCompletedEventArgs  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Class SSMEDrmSetupDecryptorCompletedEventArgs _
    Inherits AsyncCompletedEventArgs
'Usage

Dim instance As SSMEDrmSetupDecryptorCompletedEventArgs
```

```csharp
public class SSMEDrmSetupDecryptorCompletedEventArgs : AsyncCompletedEventArgs
```

```cpp
public ref class SSMEDrmSetupDecryptorCompletedEventArgs : public AsyncCompletedEventArgs
```

``` fsharp
type SSMEDrmSetupDecryptorCompletedEventArgs =  
    class
        inherit AsyncCompletedEventArgs
    end
```

```jscript
public class SSMEDrmSetupDecryptorCompletedEventArgs extends AsyncCompletedEventArgs
```

The SSMEDrmSetupDecryptorCompletedEventArgs type exposes the following members.

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[Cancelled](https://msdn.microsoft.com/library/hhb0kte8(v=vs.95))|(Inherited from [AsyncCompletedEventArgs](https://msdn.microsoft.com/library/2tde67e9(v=vs.95)).)|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[ChunkInfo](ssmedrmsetupdecryptorcompletedeventargs-chunkinfo-property-microsoft-web-media-smoothstreaming.md)|Gets the chunk information associated with the decryptor.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[Error](https://msdn.microsoft.com/library/zye0z486(v=vs.95))|(Inherited from [AsyncCompletedEventArgs](https://msdn.microsoft.com/library/2tde67e9(v=vs.95)).)|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[KeyId](ssmedrmsetupdecryptorcompletedeventargs-keyid-property-microsoft-web-media-smoothstreaming.md)|Gets the KeyID of the decryptor being set up.|
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
