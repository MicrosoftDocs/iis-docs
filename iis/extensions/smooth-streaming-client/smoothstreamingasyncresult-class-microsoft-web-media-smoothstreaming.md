---
title: SmoothStreamingAsyncResult Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SmoothStreamingAsyncResult Class
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingasyncresult(v=VS.95)
ms:contentKeyID: 46307960
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# SmoothStreamingAsyncResult Class

Provides an implementation of the [IAsyncResult](https://msdn.microsoft.com/library/ft8a6455\(v=vs.95\)) interface for the [EndGetChunk(IAsyncResult)](trackinfo-endgetchunk-method-microsoft-web-media-smoothstreaming_1.md) method.

## Inheritance Hierarchy

 [System.Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\))  
  Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Class SmoothStreamingAsyncResult _
    Implements IAsyncResult
'Usage

Dim instance As SmoothStreamingAsyncResult
```

```csharp
public class SmoothStreamingAsyncResult : IAsyncResult
```

```cpp
public ref class SmoothStreamingAsyncResult : IAsyncResult
```

``` fsharp
type SmoothStreamingAsyncResult =  
    class
        interface IAsyncResult
    end
```

```jscript
public class SmoothStreamingAsyncResult implements IAsyncResult
```

The SmoothStreamingAsyncResult type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[SmoothStreamingAsyncResult](smoothstreamingasyncresult-constructor-microsoft-web-media-smoothstreaming.md)|Initializes a new instance of the SmoothStreamingAsyncResult class.|


## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[AsyncState](smoothstreamingasyncresult-asyncstate-property-microsoft-web-media-smoothstreaming.md)|Gets the state information passed by the application.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[AsyncWaitHandle](smoothstreamingasyncresult-asyncwaithandle-property-microsoft-web-media-smoothstreaming.md)|Gets the wait handle used by the application to wait.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[CompletedSynchronously](smoothstreamingasyncresult-completedsynchronously-property-microsoft-web-media-smoothstreaming.md)|Indicates whether the operation completed synchronously on the same thread.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[IsCompleted](smoothstreamingasyncresult-iscompleted-property-microsoft-web-media-smoothstreaming.md)|Gets a Boolean value that indicates whether the operation has completed.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[Result](smoothstreamingasyncresult-result-property-microsoft-web-media-smoothstreaming.md)|Returns the result of calling [EndGetChunk(IAsyncResult)](trackinfo-endgetchunk-method-microsoft-web-media-smoothstreaming_1.md).|


## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[Complete](smoothstreamingasyncresult-complete-method-microsoft-web-media-smoothstreaming.md)|Called when the operation has completed.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|


## Version Information

### Silverlight

Supported in: 5  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

