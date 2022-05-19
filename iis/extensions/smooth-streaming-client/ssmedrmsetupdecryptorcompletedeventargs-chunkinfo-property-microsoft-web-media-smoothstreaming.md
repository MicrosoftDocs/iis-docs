---
title: SSMEDrmSetupDecryptorCompletedEventArgs.ChunkInfo Property (Microsoft.Web.Media.SmoothStreaming)
description: This article describes the syntax for the Microsoft.Web.Media.SmoothStreaming.ChunkInfo property is an object representing the chunk information.
TOCTitle: ChunkInfo Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SSMEDrmSetupDecryptorCompletedEventArgs.ChunkInfo
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.ssmedrmsetupdecryptorcompletedeventargs.chunkinfo(v=VS.95)
ms:contentKeyID: 46307859
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SSMEDrmSetupDecryptorCompletedEventArgs.get_ChunkInfo
- Microsoft.Web.Media.SmoothStreaming.SSMEDrmSetupDecryptorCompletedEventArgs.set_ChunkInfo
- Microsoft.Web.Media.SmoothStreaming.SSMEDrmSetupDecryptorCompletedEventArgs.ChunkInfo
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SSMEDrmSetupDecryptorCompletedEventArgs.ChunkInfo
- Microsoft.Web.Media.SmoothStreaming.SSMEDrmSetupDecryptorCompletedEventArgs.get_ChunkInfo
- Microsoft.Web.Media.SmoothStreaming.SSMEDrmSetupDecryptorCompletedEventArgs.set_ChunkInfo
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SSMEDrmSetupDecryptorCompletedEventArgs.ChunkInfo Property

Gets the chunk information associated with the decryptor.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property ChunkInfo As ChunkInfo
    Get
    Private Set
'Usage

Dim instance As SSMEDrmSetupDecryptorCompletedEventArgs
Dim value As ChunkInfo

value = instance.ChunkInfo
```

```csharp
public ChunkInfo ChunkInfo { get; private set; }
```

```cpp
public:
property ChunkInfo^ ChunkInfo {
    ChunkInfo^ get ();
    private: void set (ChunkInfo^ value);
}
```

``` fsharp
member ChunkInfo : ChunkInfo with get, private set
```

```jscript
function get ChunkInfo () : ChunkInfo
private function set ChunkInfo (value : ChunkInfo)
```

### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.ChunkInfo](chunkinfo-class-microsoft-web-media-smoothstreaming_1.md)  
An object representing the chunk information.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[SSMEDrmSetupDecryptorCompletedEventArgs Class](ssmedrmsetupdecryptorcompletedeventargs-class-microsoft-web-media-smoothstreaming.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
