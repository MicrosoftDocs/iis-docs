---
title: "IHttpResponse::WriteEntityChunkByReference Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 8cc3aefe-5f9e-9ae3-2e8a-b033aff39687
caps.latest.revision: 28
author: "shirhatti"
manager: "wpickett"
---
# IHttpResponse::WriteEntityChunkByReference Method
Inserts or appends an [HTTP_DATA_CHUNK](http://go.microsoft.com/fwlink/?LinkId=56011) structure into the response body.  
  
## Syntax  
  
```cpp  
HRESULT WriteEntityChunkByReference(  
   IN HTTP_DATA_CHUNK* pDataChunk,  
   IN LONG lInsertPosition = -1  
)  
```  
  
#### Parameters  
 `pDataChunk`  
 [IN] A pointer to an `HTTP_DATA_CHUNK` structure.  
  
 `lInsertPosition`  
 [IN] A `LONG` value that specifies whether to insert or append the chunk.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_PARAMETER|Indicates that the parameter is not valid (for example, the `HTTP_DATA_CHUNK` pointer is set to NULL).|  
|ERROR_NOT_ENOUGH_MEMORY|Indicates that there is insufficient memory to perform the operation.|  
|ERROR_ARITHMETIC_OVERFLOW|Indicates that more than 65535 chunks have been added to the response.|  
  
## Remarks  
 The `WriteEntityChunkByReference` method inserts or appends an `HTTP_DATA_CHUNK` structure into the response buffer depending on the value of the `lInsertPosition` parameter.  
  
-   If `lInsertPosition` is 0, the data will be inserted before the existing response data.  
  
-   If `lInsertPosition` is -1, the data will be appended after the last chunk of existing response data.  
  
 The `WriteEntityChunkByReference` method inserts a reference to the original data chunk, instead of a copy, into the response buffer. Therefore, the memory allocated for `pDataChunk->FromMemory.pBuffer` must persist for the duration of your response processing. Using local or stack memory results in undefined behavior.  
  
 A maximum of 65535 (64 KB minus 1) chunks can be written to a request.  
  
## Example  
 The following example demonstrates how to use the `WriteEntityChunkByReference` method to insert data into the response. It also demonstrates how to use the `lInsertPosition` parameter to insert or append data chunks.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpResponseWriteEntityChunkByReference#1](IHttpResponseWriteEntityChunkByReference#1)]  -->  
<!-- TODO: review snippet reference [!CODE [IHttpResponseWriteEntityChunkByReference#2](IHttpResponseWriteEntityChunkByReference#2)]  -->  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpResponse Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-interface.md)   
 [IHttpResponse::WriteEntityChunks Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-writeentitychunks-method.md)