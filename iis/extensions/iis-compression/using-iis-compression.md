---
title: "Using IIS Compression | Microsoft Docs"
author: bangbingsyb
description: "The article provides an overview on how to use IIS Compression"
ms.author: yashi
ms.date: 05/15/2018
ms.topic: article
ms.technology: iis
ms.prod: iis
msc.type: authoredcontent
---
Using IIS Compression
====================
by [Yanbing Shi](https://github.com/bangbingsyb)

> The article provides an overview on how to use IIS Compression.

## Compression Levels

HTTP compression is a trade-off of CPU for bandwidth. The compression levels of `iiszlib.dll`, `iisbrotli.dll`, and `gzip.dll` do not match with each other, and in contrast they have different ranges.

| Compression Scheme Provider | Compression Level: No Compression | Compression Level: Best Speed | Compression Level: Best Compression Ratio |
|---------|---------|---------|---------|
| gzip.dll | N/A | 0 | 10 |
| iiszlib.dll | 0 | 1 | 9 |
| iisbrotli.dll | N/A | 0 | 11 |

The lowest level of iiszlib.dll is 0, but level 0 is not the best speed  

## Compression Scheme Prioritization

## Verifying Compression

## Troubleshooting Compression

## HTTP Compression Content Encoding Negotiation

The negotiation of content-encoding between user agents and IIS servers complies with HTTP/1.1 standard (RFC 7231, 5.3.4. Accept-Encoding).

1. The negotiation starts with the user agent specifying the list of acceptable compression schemes in the `Accept-Encoding` request header.
2. The server examines the `Accept-Encoding` header in the request and selects a scheme it supports.
3. The server then applies the corresponding algorithm to compress the response body.
4. When the server sends back the response, it adds a `Content-Encoding` response header to indicate the chosen scheme.
5. Finally, the user agent uses the coding indicated in `Content-Encoding` header to decompress the response body and to render the original contents to the user.
