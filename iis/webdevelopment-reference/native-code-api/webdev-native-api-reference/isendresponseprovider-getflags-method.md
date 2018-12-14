---
title: "ISendResponseProvider::GetFlags Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 3062e690-a714-515f-bdc8-7f7ec38716e9
caps.latest.revision: 13
author: "shirhatti"
manager: "wpickett"
---
# ISendResponseProvider::GetFlags Method
Retrieves the flags for the current HTTP response.  
  
## Syntax  
  
```cpp  
virtual DWORD GetFlags(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A `DWORD` that contains the response flags.  
  
## Remarks  
 You can use the `GetFlags` method to retrieve the response flags for the current response. These flags provide additional control over the HTTP behavior for [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)]. The following flags are defined in the Http.h header file.  
  
|Name|Value|Description|  
|----------|-----------|-----------------|  
|HTTP_SEND_RESPONSE_FLAG_DISCONNECT|0x00000001|Disconnects the network connection immediately after the response is sent.|  
|HTTP_SEND_RESPONSE_FLAG_MORE_DATA|0x00000002|Sends additional data in the response.|  
|HTTP_SEND_RESPONSE_FLAG_BUFFER_DATA|0x00000004|Buffers the response before it is sent.|  
|HTTP_SEND_RESPONSE_FLAG_ENABLE_NAGLING|0x00000008|Enables the Nagle algorithm to optimize TCP response packets.|  
  
## Example  
 The following code example demonstrates how to use the [SetFlags](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/isendresponseprovider-setflags-method.md) and `GetFlags` methods to create an HTTP module that sets the flags for the current response. The example then retrieves the modified flags and returns the response to a Web client.  
  
<!-- TODO: review snippet reference  [!CODE [ISendResponseProviderGetFlags#1](ISendResponseProviderGetFlags#1)]  -->  
  
 Your module must export the [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [ISendResponseProvider Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/isendresponseprovider-interface.md)   
 [ISendResponseProvider::SetFlags Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/isendresponseprovider-setflags-method.md)