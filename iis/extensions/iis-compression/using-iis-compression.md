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

#### HTTP Compression Scheme Negotiation

The compression scheme negotiation between user agents and IIS servers complies with [Requests For Comment (RFC) specification 7231](https://www.ietf.org/rfc/rfc7231.txt):

1. The negotiation starts with the user agent specifying the list of acceptable compression schemes in the **Accept-Encoding** request header.

2. The server examines the **Accept-Encoding** header in the request and selects a scheme that the server supports.

3. The server then applies the corresponding algorithm to compress the response body.

4. When the server sends back the response, it adds the **Content-Encoding** response header with the selected compression scheme as the header field value.

5. Finally, the user agent uses the scheme indicated in the **Content-Encoding** response header to decompress the response body and to render the original contents to the user.

#### Enabling Multiple Compression Schemes

One of the key ideas behind HTTP compression scheme negotiation is the possibility of supporting new compression schemes while still allow to maintain backward compatibility with old clients or servers.
While **Brotli** compression offers the benefit of higher compression ratio and has been supported by many browsers, it is still not as widely adopted as **Gzip** at the time of writing.
Therefore, one possible optimization is to enable both **Brotli** and **Gzip** compression, but prioritize **Brotli** if the client-side user agent also supports it.

##### IIS 10.0 Version 1803 or Above

Compression scheme prioritization is supported in IIS 10.0 version 1803 or above.
The priority of each compression scheme is determined by its order in the `<scheme>` collection of the `<httpCompression>`element:

- A compression scheme appearing on the top of the `<scheme>` collection is prioritized over the one appearing after, if their quality values specified in the **Accept-Encoding** request header field value are the same.
- A compression scheme with higher quality value in the **Accept-Encoding** request header field value is prioritized over the one with lower quality value regardless of their order in the `<scheme>` collection.

The installation of **IIS Compression** registers **iisbrotli.dll** and **iiszlib.dll** as the **br** and **gzip** compression scheme providers, respectively, and places **br** before **gzip** in the `<scheme>` collection:

[!code-xml[Main](using-iis-compression/samples/compression-scheme-prioritization-config.xml)]

Such configuration order allows the IIS server to prioritize **Brotli** over **Gzip** when most browsers that support **Brotli** use `Accept-Encoding: gzip, deflate, br` for compression scheme negotiation.

> [!NOTE]
> Typically the browsers that support **Brotli** compression only advertise **br** in the **Accept-Encoding** header field value when HTTPS is used.

##### Before IIS 10.0 Version 1803

IIS before version 10.0 version 1803 allows users to add multiple compression schemes, but it prioritizes the compression scheme based on the scheme order in the **Accept-Encoding** request header field value:

- A compression scheme appearing first in the **Accept-Encoding** request header field value is prioritized over the one appearing after, if they have the same quality values.
- A compression scheme with higher quality value is prioritized over the one with lower quality value regardless of their order in the **Accept-Encoding** request header field value.

## Testing Compression

After IIS Compression is installed

> [!NOTE]
> To test **IIS Compression** with static content compression, ensure the requested file size is larger than

> [!NOTE]
> Level 0 of **iiszlib.dll** specifies no compression rather than best-speed compression.
> The default IIS **dynamicCompressionLevel** in [&lt;httpCompression&gt;](https://docs.microsoft.com/en-us/iis/configuration/system.webserver/httpcompression) is 0 as well. Therefore, **dynamicCompressionLevel** needs to be explicitly set above 0 to allow **iiszlib.dll** to compress dynamically generated contents.
