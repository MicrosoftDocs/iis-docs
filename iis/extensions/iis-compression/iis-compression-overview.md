---
title: "IIS Compression Overview | Microsoft Docs"
author: bangbingsyb
description: "The article provides an overview of IIS Compression"
ms.author: yashi
ms.date: 04/20/2018
ms.topic: article
ms.technology: iis
ms.prod: iis
msc.type: authoredcontent
---
IIS Compression Overview
====================
by [Yanbing Shi](https://github.com/bangbingsyb)

> The article provides an overview of IIS Compression.

## What is IIS Compression?

**IIS Compression** is a bundle of two IIS compression scheme providers `iisbrotli.dll` and `iiszlib.dll` that support IIS to compress HTTP response contents. `iisbrotli.dll` supports **Brotli** compression, while `iiszlib.dll` supports both **Gzip** and **Deflate** compression.

#### What is a compression scheme provider?

An IIS compression scheme provider is a pluggable extension of IIS `StaticCompressionModule` and `DynamicCompressionModule` and provides algorithm for one or multiple HTTP compression schemes. IIS `StaticCompressionModule` and `DynamicCompressionModule` load the registered compression scheme providers into worker process at runtime, and leverage them to perform compression on static files and dynamically-generated contents, respectively.

## Why use IIS Compression?

IIS ships a default compression scheme provider `gzip.dll` that supports both **Gzip** and **Deflate** compression, and it is registered as the `gzip` scheme in `applicationHost.config` by default. The in-box `gzip.dll` is based on an internal implementation of Gzip and Deflate encoding, and it works properly.
Then why introduce new compression scheme providers?

#### Higher Compression Ratio with Brotli compression

Brotli compression, developed in 2013-2016, is a relatively new addition to the HTTP compression.
The encoding algorithm and format of Brotli are specified in [Requests For Comment (RFC) specification 7932](https://www.ietf.org/rfc/rfc7932.txt), and response data streams compressed with Brotli have the content encoding type "br".
Brotli is capable of offering higher compression ratio than **Gzip** and **Deflate**, with the cost of lower compression speed.
In addition, the Brotli decompression on the client (browser) side is in general faster as well.
Therefore, enabling Brotli compression using iisbrotli.dll can potentially bring performance benefit for servicing static files in general, or for servicing dynamic contents across slow network.

#### Better Gzip Compression Scheme Provider

While `iiszlib.dll` included in **IIS Compression** offers same **Gzip** and **Deflate** compression functionalities as the default provider `gzip.dll`, the zlib-based `iiszlib.dll` is more up-to-date with slightly better performance and better dynamic compression support.

#### Open Source

**IIS Compression** is a supported open-source product, and the source code can be found in [IIS.Compression](https://github.com/Microsoft/IIS.Compression) Github repository.
It uses the open-source [brotli](https://github.com/google/brotli) and [zlib](https://zlib.net/) libraries as the core encoders, and bridges them with IIS compression modules through implementing the [IIS HTTP Compression API](https://msdn.microsoft.com/en-us/library/dd692872.aspx).
Making it open-source provides transparency to the users and allows flexible and agile future enhancement, bug fixing, and customization.
The open-source project also serves a general reference for developing an IIS compression scheme provider to the community.

## Installing IIS Compression

## Using IIS Compression

#### Enable Compression Modules

The compression scheme providers, `iiszlib.dll` and `iisbrotli.dll`, offered by IIS Compression are not IIS modules, instead they are extensions of IIS `StaticCompressionModule` and `DynamicCompressionModule`.
At runtime, `StaticCompressionModule` and `DynamicCompressionModule` load the compression scheme providers and pass the response content data to them for compression.

Therefore, either or both of the two compression modules need to be installed on the IIS server as a prerequisite - see [HTTP Compression](https://docs.microsoft.com/en-us/iis/configuration/system.webserver/httpcompression) on how to install the features.
Once the modules are installed, ensure static and/or dynamic compression are enabled for a desired URL namespace - see [URL Compression](https://docs.microsoft.com/en-us/iis/configuration/system.webserver/urlcompression) on how to enable the corresponding type of compression.

#### Compression Levels

HTTP compression is a trade-off of CPU for bandwidth. The compression levels of `iiszlib.dll`, `iisbrotli.dll`, and `gzip.dll` do not match with each other, and in contrast they have different ranges.

| Compression Scheme Provider | Compression Level: No Compression | Compression Level: Best Speed | Compression Level: Best Compression Ratio |
|---------|---------|---------|---------|
| gzip.dll | N/A | 0 | 10 |
| iiszlib.dll | 0 | 1 | 9 |
| iisbrotli.dll | N/A | 0 | 11 |

The lowest level of iiszlib.dll is 0, but level 0 is not the best speed  

#### Compression Scheme Prioritization

#### Verifying Compression

#### Troubleshooting Compression

## HTTP Compression Content Encoding Negotiation

The negotiation of content-encoding between user agents and IIS servers complies with HTTP/1.1 standard (RFC 7231, 5.3.4. Accept-Encoding).

1. The negotiation starts with the user agent specifying the list of acceptable compression schemes in the `Accept-Encoding` request header.
2. The server examines the `Accept-Encoding` header in the request and selects a scheme it supports.
3. The server then applies the corresponding algorithm to compress the response body.
4. When the server sends back the response, it adds a `Content-Encoding` response header to indicate the chosen scheme.
5. Finally, the user agent uses the coding indicated in `Content-Encoding` header to decompress the response body and to render the original contents to the user.
