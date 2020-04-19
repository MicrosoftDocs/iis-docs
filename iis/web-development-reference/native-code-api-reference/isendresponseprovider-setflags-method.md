---
title: "ISendResponseProvider::SetFlags Method"
ms.date: "10/07/2016"
ms.assetid: 854d8dd1-0c04-e658-3526-0baba7e36f96
---
# ISendResponseProvider::SetFlags Method
Configures the flags for the current HTTP response.  
  
## Syntax  
  
```cpp  
virtual VOID SetFlags(  
   DWORD dwFlags  
) = 0;  
```  
  
### Parameters  
 `dwFlags`  
 A `DWORD` that contains the response flags to set.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 You can use the `SetFlags` method to specify which response flags to use with the current response. These flags provide additional control over the HTTP behavior for [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)]. The following flags are defined in the Http.h header file.  
  
|Name|Value|Description|  
|----------|-----------|-----------------|  
|HTTP_SEND_RESPONSE_FLAG_DISCONNECT|0x00000001|Disconnects the network connection immediately after the response is sent.|  
|HTTP_SEND_RESPONSE_FLAG_MORE_DATA|0x00000002|Sends additional data in the response.|  
|HTTP_SEND_RESPONSE_FLAG_BUFFER_DATA|0x00000004|Buffers the response before it is sent.|  
|HTTP_SEND_RESPONSE_FLAG_ENABLE_NAGLING|0x00000008|Enables the Nagle algorithm to optimize TCP response packets.|  
  
## Example  
 The following code example demonstrates how to use the `SetFlags` and [GetFlags](../../web-development-reference/native-code-api-reference/isendresponseprovider-getflags-method.md) methods to create an HTTP module that sets the flags for the current response. The example then retrieves the modified flags and returns the response to a Web client.  
  
 [!code-cpp[ISendResponseProviderGetFlags#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/ISendResponseProviderGetFlags/cpp/ISendResponseProviderGetFlags.cpp#1)]  
  
 Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [ISendResponseProvider Interface](../../web-development-reference/native-code-api-reference/isendresponseprovider-interface.md)   
 [ISendResponseProvider::GetFlags Method](../../web-development-reference/native-code-api-reference/isendresponseprovider-getflags-method.md)