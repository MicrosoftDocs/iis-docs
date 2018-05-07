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

An IIS compression scheme provider is a pluggable extension of IIS `StaticCompressionModule` and `DynamicCompressionModule` - essentially a dynamic link library (dll) that implements and exposes the [IIS HTTP Compression API](https://msdn.microsoft.com/en-us/library/dd692872.aspx). IIS `StaticCompressionModule` and `DynamicCompressionModule` load the registered compression scheme providers into worker process at runtime, and leverage them to perform compression for static files and dynamically-generated contents, respectively.

## Why use IIS Compression?

IIS ships a default compression scheme provider `gzip.dll` that supports both **Gzip** and **Deflate** compression, and it is registered as `gzip` scheme in `applicationHost.config`. The in-box `gzip.dll` is based on an "in-house" implementation of Gzip and Deflate encoding.

#### Better Compression Ratio with Brotli

Brotli is a relatively new addition to the HTTP compression. The Brotli specification, RFC7932, was developed in 2015-2016 by Google, with the Brotli compression library open-sourced on

#### Better Gzip Compression Provider

#### Open Source

**IIS Compression** is a supported open-source product, and the source code can be found in [IIS.Compression](https://github.com/Microsoft/IIS.Compression) Github repository. Making it open source provides better flexibility and agility for future enhancement, bug fixing, and customization. **IIS Compression** also serves a reference project of developing an IIS compression scheme provider to the community.

## Installing IIS compression



## HTTP Compression Content Encoding Negotiation

The negotiation of content-encoding between user agents and IIS servers complies with HTTP/1.1 standard (RFC 7231, 5.3.4. Accept-Encoding).

1. The negotiation starts with the user agent specifying the list of acceptable compression schemes in the `Accept-Encoding` request header.
2. The server examines the `Accept-Encoding` header in the request and selects a scheme it supports.
3. The server then applies the corresponding algorithm to compress the response body.
4. When the server sends back the response, it adds a `Content-Encoding` response header to indicate the chosen scheme.
5. Finally, the user agent uses the coding indicated in `Content-Encoding` header to decompress the response body and to render the original contents to the user.
