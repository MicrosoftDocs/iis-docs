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

4. When the server sends back the response, it adds the **Content-Encoding** response header with the selected compression scheme as the header value.

5. Finally, the user agent uses the scheme indicated in the **Content-Encoding** response header to decompress the response body and to render the original contents to the user.

#### Enabling Multiple Compression Schemes

One of the key ideas behind HTTP compression scheme negotiation is the possibility of supporting new compression schemes while still allow to maintain backward compatibility with old clients or servers.
While **Brotli** compression offers the benefit of higher compression ratio and has been supported by many browsers, it is still not as widely adopted as **Gzip** at the time of writing.
Therefore, one possible optimization is to enable both **Brotli** and **Gzip** compression, but prioritize **Brotli** if the client-side user agent also supports it.

##### IIS 10.0 Version 1803 or Above

Compression scheme prioritization is supported in IIS 10.0 version 1803 or above.
The priority of each compression scheme is determined by its order in the `<scheme>` collection of the `<httpCompression>`element:

- A compression scheme appearing on the top of the `<scheme>` collection is prioritized over the one appearing after, if their quality values specified in the **Accept-Encoding** request header value are the same.
- A compression scheme with higher quality value in the **Accept-Encoding** request header value is prioritized over the one with lower quality value regardless of their order in the `<scheme>` collection.

The installation of **IIS Compression** registers **iisbrotli.dll** and **iiszlib.dll** as the **br** and **gzip** compression scheme providers, respectively, and places **br** before **gzip** in the `<scheme>` collection:

[!code-xml[Main](using-iis-compression/samples/compression-scheme-prioritization-config.xml)]

Such configuration order allows the IIS server to prioritize **Brotli** over **Gzip** when most browsers that support **Brotli** use `Accept-Encoding: gzip, deflate, br` for compression scheme negotiation.

> [!NOTE]
> Typically the browsers that support **Brotli** compression only advertise **br** in the **Accept-Encoding** header value when **HTTPS** is used.

##### Before IIS 10.0 Version 1803

Although IIS prior to version 10.0 version 1803 allows enabling multiple compression schemes, but it prioritizes the compression scheme based on the scheme order appearing in the **Accept-Encoding** request header value:

- A compression scheme appearing first (from left to right) in the **Accept-Encoding** request header value is prioritized over the one appearing after, if they have the same quality values.
- A compression scheme with higher quality value is prioritized over the one with lower quality value regardless of their order in the **Accept-Encoding** request header value.

In consequence, IIS always prioritizes **gzip** over **br** for the typical scenario that the browser sets `Accept-Encoding: gzip, deflate, br` header in the request.

A possible workaround is installing the [URL Rewrite Module](https://docs.microsoft.com/en-us/iis/extensions/url-rewrite-module/using-the-url-rewrite-module) and configuring a rewrite rule to modify the **Accept-Encoding** header value.
The following configuration shows a sample rewrite rule that rewrites the **Accept-Encoding** header value to only include **br** scheme if it finds the string **br** in the header value with a non-zero quality value.

[!code-xml[Main](using-iis-compression/samples/compression-scheme-prioritization-workaround.xml)]

More details on how to configure rewrite rules can be found in
[Creating Rewrite Rules for the URL Rewrite Module](https://docs.microsoft.com/en-us/iis/extensions/url-rewrite-module/creating-rewrite-rules-for-the-url-rewrite-module).

## Testing Compression

After IIS Compression is installed

> [!NOTE]
> To test **IIS Compression** for static content compression:
> - Ensure the MIME type of the requested resource is enabled in the `<staticTypes>` collection in the `<httpCompression>` element.
> - Ensure the requested resource size is larger than `minFileSizeForComp` specified in `<httpCompression>` element.
> - Ensure the "frequently hit" threshold is reached for the request. frequency is reached , or ensure the `staticCompressionIgnoreHitFrequency` property specified in the `<httpCompression>` element is set as `true`.

> [!NOTE]
> To test **IIS Compression** for dynamic content compression:
> - Ensure the MIME type of the requested resource is enabled in the `<dynamicTypes>` collection in the `<httpCompression>` element.
