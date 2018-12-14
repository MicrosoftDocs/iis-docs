---
title: "Compress2 Function | Microsoft Docs"
ms.custom: ""
ms.date: "07/30/2018"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 9a3c22c0-2e3c-479f-bd4a-457ea4364c67
caps.latest.revision: 2
author: "shirhatti"
ms.author: "soshir"
---
# Compress2 Function
Compresses data given the compression context, input buffer, output buffer, compression level, and compression operation.

## Syntax

```cpp
HRESULT WINAPI Compress2(
   IN OUT PVOID context,
   IN CONST BYTE* input_buffer,
   IN LONG input_buffer_size,
   IN PBYTE output_buffer,
   IN LONG output_buffer_size,
   OUT PLONG input_used,
   OUT PLONG output_used,
   IN INT compression_level,
   IN INT operation
);
```

#### Parameters
 `context`
 [IN][OUT] Pointer to the new compression context.

 `input_buffer`
 [IN] Pointer to the input buffer.

 `input_buffer_size`
 [IN] The size of the input buffer.

 `output_buffer`
 [IN] Pointer to the output buffer.

 `output_buffer_size`
 [IN] Size of the output buffer.

 `input_used`
 [IN] Amount of input buffer used.

 `output_used`
 [OUT] Amount of output buffer used.

 `compression_level`
 [IN] Compression level.

 `operation`
 [IN] Compression operation. It can be one of the following values:

 |Identifier|Value|Description|
 |-----------|----|-----------|
 |IIS_COMPRESSION_OPERATION_PROCESS|0|Process input data. The encoder may choose to buffer the data and postpone flushing output.|
 |IIS_COMPRESSION_OPERATION_FLUSH|1|Flush all pending output data buffered in the encoder. Flush is performed when the available input data is depleted.|
 |IIS_COMPRESSION_OPERATION_FINISH|2|Finalize the stream. Finalization happens when the input stream reaches the end|

## Return Value
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.

|Value|Description|
|-----------|-----------------|
|S_OK|Indicates that the operation was successful.|
|S_FALSE|Indicates that all the available input data has been processed and all the output data has been produced.|

## Remarks
 When used with IIS, this method is called repeatedly until all the data required to fulfill the request is compressed.

## Requirements

|Type|Description|
|----------|-----------------|
|Client|-   |
|Server|-   |
|Product|-   |
|Header|Httpcompression.h|

## See Also
 [Web Server Core Functions](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-functions.md)
