---
title: "IScriptMapInfo::GetResponseBufferLimit Method"
ms.date: "10/07/2016"
ms.assetid: df408156-d43c-bc1d-db9c-d1dc0dadc4ac
---
# IScriptMapInfo::GetResponseBufferLimit Method

Retrieves the response buffer limit for the script processor.  
  
## Syntax  
  
```cpp  
virtual DWORD GetResponseBufferLimit(  
   VOID  
) const = 0;  
```  
  
### Parameters  

 This method takes no parameters.  
  
## Return Value  

 A `DWORD` that contains the size, in bytes, of the response buffer.  
  
## Remarks  

 The `GetResponseBufferLimit` method retrieves the `responseBufferLimit` attribute for a request handler that is located in the `<handlers>` section of the ApplicationHost.config file. This attribute contains the size, in bytes, of the response buffer for a request handler. If the `responseBufferLimit` attribute is not defined for a request handler, the default value from the Schema.xml file is used.  
  
> [!NOTE]
>  The default value for the `responseBufferLimit` attribute that is defined in Schema.xml is 4,194,304 bytes (4 MB.)  
  
## Example  

 The following code example demonstrates how to use the [IHttpContext::GetScriptMap](../../web-development-reference/native-code-api-reference/ihttpcontext-getscriptmap-method.md) method to create an HTTP module that retrieves a pointer to an [IScriptMapInfo](../../web-development-reference/native-code-api-reference/iscriptmapinfo-interface.md) interface. The example then uses the `GetResponseBufferLimit` method to retrieve the response buffer limit for the request handler that is processing the current request. The module returns the response buffer limit to a Web client and then exits.  
  
 [!code-cpp[IScriptMapInfoGetResponseBufferLimit#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IScriptMapInfoGetResponseBufferLimit/cpp/IScriptMapInfoGetResponseBufferLimit.cpp#1)]  
  
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

 [IScriptMapInfo Interface](../../web-development-reference/native-code-api-reference/iscriptmapinfo-interface.md)
