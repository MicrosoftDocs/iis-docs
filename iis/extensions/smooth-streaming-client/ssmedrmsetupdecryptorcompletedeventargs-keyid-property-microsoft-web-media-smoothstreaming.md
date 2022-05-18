---
title: SSMEDrmSetupDecryptorCompletedEventArgs.KeyId Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: KeyId Property
description: Gets the KeyID of the decryptor being set up.
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SSMEDrmSetupDecryptorCompletedEventArgs.KeyId
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.ssmedrmsetupdecryptorcompletedeventargs.keyid(v=VS.95)
ms:contentKeyID: 46307860
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SSMEDrmSetupDecryptorCompletedEventArgs.KeyId
- Microsoft.Web.Media.SmoothStreaming.SSMEDrmSetupDecryptorCompletedEventArgs.get_KeyId
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SSMEDrmSetupDecryptorCompletedEventArgs.get_KeyId
- Microsoft.Web.Media.SmoothStreaming.SSMEDrmSetupDecryptorCompletedEventArgs.KeyId
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SSMEDrmSetupDecryptorCompletedEventArgs.KeyId Property

Gets the KeyID of the decryptor being set up.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public ReadOnly Property KeyId As Guid
    Get
'Usage

Dim instance As SSMEDrmSetupDecryptorCompletedEventArgs
Dim value As Guid

value = instance.KeyId
```

```csharp
public Guid KeyId { get; }
```

```cpp
public:
property Guid KeyId {
    Guid get ();
}
```

``` fsharp
member KeyId : Guid
```

```jscript
function get KeyId () : Guid
```

### Property Value

Type: [System.Guid](https://msdn.microsoft.com/library/cey1zx63\(v=vs.95\))  
The KeyID GUID.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[SSMEDrmSetupDecryptorCompletedEventArgs Class](ssmedrmsetupdecryptorcompletedeventargs-class-microsoft-web-media-smoothstreaming.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
