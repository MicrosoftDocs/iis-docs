---
title: AlternativeUris Property
TOCTitle: AlternativeUris Property
ms:assetid: 4b96af6c-fd67-4005-a87f-89919fc51eba
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822730(v=VS.90)
ms:contentKeyID: 50079485
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# AlternativeUris Property

**Applies to:** Windows Store apps only

Gets the alternate URI.

## Syntax

```csharp
public IVectorView<Uri> AlternateUris { get; }
```

```cpp
public:
virtual property IVectorView<Uri^>^ AlternateUris {
IVectorView<Uri^>^ get () sealed;
}
```

```jscript
final function get AlternateUris () : IVectorView<Uri>
```

## Property Value

The alternate URI.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

