---
title: ManifestTrack.CustomAttributeNames Property
TOCTitle: CustomAttributeNames Property
ms:assetid: 8bbb3af0-0f18-47db-9687-7cd50f3e6012
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822775(v=VS.90)
ms:contentKeyID: 50079530
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# ManifestTrack.CustomAttributeNames Property

**Applies to:** Windows Store apps only

Gets the track level custom attributes names.

## Syntax

```csharp
public IVectorView<string> CustomAttributeNames { get; }
```

```cpp
public:
virtual property IVectorView<String^>^ CustomAttributeNames {
IVectorView<String^>^ get () sealed;
}
```

```jscript
final function get CustomAttributeNames () : IVectorView<String>
```

## Property Value

The track level custom attributes names.

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
