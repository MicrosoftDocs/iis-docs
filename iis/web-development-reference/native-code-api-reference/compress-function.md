---
title: "Compress Function | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 254d5fc4-8abd-4410-84e3-d7f13ee6cd68
caps.latest.revision: 5
author: "shirhatti"
manager: "wpickett"
---
# Compress Function
Compresses data given the compression context, input buffer, output buffer, and compression level.  
  
## Syntax  
  
```cpp  
HRESULT WINAPI Compress(  
   IN OUT PVOID context,  
   IN CONST BYTE* input_buffer,  
   IN LONG input_buffer_size,  
   IN PBYTE output_buffer,  
   IN LONG output_buffer_size,  
   OUT PLONG input_used,  
   OUT PLONG output_used,  
   IN INT compression_level  
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
 [IN] Compression level (1…10).  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 When used with IIS, this method is called repeatedly until all the data required to fulfill the request is compressed.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpcompression.h|  
  
## See Also  
 [Web Server Core Functions](../../web-development-reference\native-code-api-reference/web-server-core-functions.md)