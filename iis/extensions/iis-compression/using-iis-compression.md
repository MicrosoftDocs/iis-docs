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

## Compression Level

HTTP compression is a trade-off of CPU for bandwidth.
For a given compression algorithm, achieving higher compression ratio typically comes with slower compression speed, and vice versa.
The balance between compression ratio and speed is controlled by the compression level.
The compression levels of **iiszlib.dll**, **iisbrotli.dll**, and **gzip.dll** do not match with each other in terms of range, compression ratio, and speed.
The comparison of the allowed compression levels of the three compression scheme providers is summarized in the below table.  

| Compression Scheme Provider | Compression Level: No Compression | Compression Level: Best Speed | Compression Level: Best Compression Ratio |
|---------|---------|---------|---------|
| gzip.dll | N/A | 0 | 10 |
| iiszlib.dll | 0 | 1 | 9 |
| iisbrotli.dll | N/A | 0 | 11 |

> [!NOTE]
> Level 0 of **iiszlib.dll** specifies no compression rather than best-speed compression.
> The default IIS **dynamicCompressionLevel** in [&lt;httpCompression&gt;](https://docs.microsoft.com/en-us/iis/configuration/system.webserver/httpcompression) is 0 as well. Therefore, **dynamicCompressionLevel** needs to be explicitly set above 0 to allow **iiszlib.dll** to compress dynamically generated contents.

## Compression Scheme Prioritization

#### HTTP Compression Content Encoding Negotiation

The negotiation of content-encoding between user agents and IIS servers complies with HTTP/1.1 standard (RFC 7231, 5.3.4. Accept-Encoding).

1. The negotiation starts with the user agent specifying the list of acceptable compression schemes in the `Accept-Encoding` request header.
2. The server examines the `Accept-Encoding` header in the request and selects a scheme it supports.
3. The server then applies the corresponding algorithm to compress the response body.
4. When the server sends back the response, it adds a `Content-Encoding` response header to indicate the chosen scheme.
5. Finally, the user agent uses the coding indicated in `Content-Encoding` header to decompress the response body and to render the original contents to the user.

## Testing Compression

## Troubleshooting Compression
