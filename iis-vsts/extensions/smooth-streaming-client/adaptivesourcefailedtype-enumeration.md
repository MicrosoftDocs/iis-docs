---
title: AdaptiveSourceFailedType Enumeration
TOCTitle: AdaptiveSourceFailedType Enumeration
ms:assetid: 190445d0-5d54-4739-9feb-5a289e29971a
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822688(v=VS.90)
ms:contentKeyID: 50079443
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# AdaptiveSourceFailedType Enumeration

**Applies to:** Windows Store apps only

Adaptive source failed type enumeration.

## Syntax

```csharp
[VersionAttribute()]
public enum AdaptiveSourceFailedType
```

```cpp
[VersionAttribute()]
public enum class AdaptiveSourceFailedType
```

```jscript
public enum AdaptiveSourceFailedType
```

## Enumeration Values

|Name|Value|Description|
|--- |--- |--- |
|Unknown|100|Generic error.|
|ManifestParseFailed|200|Manifest parsing failed.|
|ManifestVersionUnsupported|201|The manifest version is unsupported.|
|ManifestInvalid|202|The manifest is invalid.|
|ManifestHttpInvalidResult|203|The manifest HTTP result is invalid.|
|HttpParseResponseFailed|300|The parsing failed.|
|HttpInvalidResult|301|The result is invalid.|
|HttpTooManyRedirect|302|There are too many redirects.|
|HttpRedirectFailed|303|The redirect failed.|
|HttpRedirectNotAllowed|304|The redirect is not allowed.|
|HttpCreateFailed|305|The create operation failed.|
|HttpOpenFailed|306|The open operation failed.|
|HttpRecvFailed|307|The receive operation failed.|
|HttpSendFailed|308|The send operation failed.|
|ChunkConnectHttpInvalidResult|400|The chunk result is invalid.|
|ChunkNextHttpInvalidResult|401|The next chunk result is invalid.|
|ChunkHdrParseFailed|402|The chunk hdr parsing failed.|
|ChunkInvalidData|403|The chunk contains invalid data.|


## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

