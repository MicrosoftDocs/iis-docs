---
title: SmoothStreamingMediaElement.DrmSetupDecryptorCompleted Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: DrmSetupDecryptorCompleted Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.DrmSetupDecryptorCompleted
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.drmsetupdecryptorcompleted(v=VS.95)
ms:contentKeyID: 46307495
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.DrmSetupDecryptorCompleted
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_DrmSetupDecryptorCompleted
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.DrmSetupDecryptorCompleted
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_DrmSetupDecryptorCompleted
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElement.DrmSetupDecryptorCompleted Event

Occurs when the digital rights management (DRM) decryptor setup has completed.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Event DrmSetupDecryptorCompleted As EventHandler(Of SSMEDrmSetupDecryptorCompletedEventArgs)
'Usage

Dim instance As SmoothStreamingMediaElement
Dim handler As EventHandler(Of SSMEDrmSetupDecryptorCompletedEventArgs)

AddHandler instance.DrmSetupDecryptorCompleted, handler
```

```csharp
public event EventHandler<SSMEDrmSetupDecryptorCompletedEventArgs> DrmSetupDecryptorCompleted
```

```cpp
public:
 event EventHandler<SSMEDrmSetupDecryptorCompletedEventArgs^>^ DrmSetupDecryptorCompleted {
    void add (EventHandler<SSMEDrmSetupDecryptorCompletedEventArgs^>^ value);
    void remove (EventHandler<SSMEDrmSetupDecryptorCompletedEventArgs^>^ value);
}
```

``` fsharp
member DrmSetupDecryptorCompleted : <EventHandler<SSMEDrmSetupDecryptorCompletedEventArgs>,
    SSMEDrmSetupDecryptorCompletedEventArgs>
```

```jscript
JScript supports the use of events, but not the declaration of new ones.
```

## Remarks

For more information, see [Events](events.md).

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
