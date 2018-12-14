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
- c++
- jscript
---

# AdaptiveSourceFailedType Enumeration

**Applies to:** Windows Store apps only

Adaptive source failed type enumeration.

## Syntax

``` csharp
[VersionAttribute()]
public enum AdaptiveSourceFailedType
```

``` c++
[VersionAttribute()]
public enum class AdaptiveSourceFailedType
```

``` jscript
public enum AdaptiveSourceFailedType
```

## Enumeration Values

<table>
<colgroup>
<col style="width: 33%" />
<col style="width: 33%" />
<col style="width: 33%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Name</p></th>
<th><p>Value</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>Unknown</p></td>
<td><p>100</p></td>
<td><p>Generic error.</p></td>
</tr>
<tr class="even">
<td><p>ManifestParseFailed</p></td>
<td><p>200</p></td>
<td><p>Manifest parsing failed.</p></td>
</tr>
<tr class="odd">
<td><p>ManifestVersionUnsupported</p></td>
<td><p>201</p></td>
<td><p>The manifest version is unsupported.</p></td>
</tr>
<tr class="even">
<td><p>ManifestInvalid</p></td>
<td><p>202</p></td>
<td><p>The manifest is invalid.</p></td>
</tr>
<tr class="odd">
<td><p>ManifestHttpInvalidResult</p></td>
<td><p>203</p></td>
<td><p>The manifest HTTP result is invalid.</p></td>
</tr>
<tr class="even">
<td><p>HttpParseResponseFailed</p></td>
<td><p>300</p></td>
<td><p>The parsing failed.</p></td>
</tr>
<tr class="odd">
<td><p>HttpInvalidResult</p></td>
<td><p>301</p></td>
<td><p>The result is invalid.</p></td>
</tr>
<tr class="even">
<td><p>HttpTooManyRedirect</p></td>
<td><p>302</p></td>
<td><p>There are too many redirects.</p></td>
</tr>
<tr class="odd">
<td><p>HttpRedirectFailed</p></td>
<td><p>303</p></td>
<td><p>The redirect failed.</p></td>
</tr>
<tr class="even">
<td><p>HttpRedirectNotAllowed</p></td>
<td><p>304</p></td>
<td><p>The redirect is not allowed.</p></td>
</tr>
<tr class="odd">
<td><p>HttpCreateFailed</p></td>
<td><p>305</p></td>
<td><p>The create operation failed.</p></td>
</tr>
<tr class="even">
<td><p>HttpOpenFailed</p></td>
<td><p>306</p></td>
<td><p>The open operation failed.</p></td>
</tr>
<tr class="odd">
<td><p>HttpRecvFailed</p></td>
<td><p>307</p></td>
<td><p>The receive operation failed.</p></td>
</tr>
<tr class="even">
<td><p>HttpSendFailed</p></td>
<td><p>308</p></td>
<td><p>The send operation failed.</p></td>
</tr>
<tr class="odd">
<td><p>ChunkConnectHttpInvalidResult</p></td>
<td><p>400</p></td>
<td><p>The chunk result is invalid.</p></td>
</tr>
<tr class="even">
<td><p>ChunkNextHttpInvalidResult</p></td>
<td><p>401</p></td>
<td><p>The next chunk result is invalid.</p></td>
</tr>
<tr class="odd">
<td><p>ChunkHdrParseFailed</p></td>
<td><p>402</p></td>
<td><p>The chunk hdr parsing failed.</p></td>
</tr>
<tr class="even">
<td><p>ChunkInvalidData</p></td>
<td><p>403</p></td>
<td><p>The chunk contains invalid data.</p></td>
</tr>
</tbody>
</table>


## Requirements

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<tbody>
<tr class="odd">
<td><p><strong>Minimum supported client</strong></p></td>
<td><p>Windows 8</p></td>
</tr>
<tr class="even">
<td><p><strong>Minimum supported server</strong></p></td>
<td><p>Not Supported</p></td>
</tr>
<tr class="odd">
<td><p><strong>Metadata</strong></p></td>
<td><p>Microsoft.Media.AdaptiveStreaming.winmd</p></td>
</tr>
</tbody>
</table>

