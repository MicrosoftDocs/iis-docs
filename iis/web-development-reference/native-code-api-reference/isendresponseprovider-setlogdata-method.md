---
title: "ISendResponseProvider::SetLogData Method"
ms.date: "10/07/2016"
ms.assetid: 9862aeef-c8c2-789f-9981-648f4b35271b
---
# ISendResponseProvider::SetLogData Method
Configures logging information for the current response.  
  
## Syntax  
  
```cpp  
virtual HRESULT SetLogData(  
   IN VOID* pLogData  
) = 0;  
```  
  
### Parameters  
 `pLogData`  
 [IN] A pointer to `VOID`.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 You can use the `SetLogData` method to modify values that IIS will write to a log file. To use this method in an HTTP module, your module should first call the [ISendResponseProvider::GetReadyToLogData](../../web-development-reference/native-code-api-reference/isendresponseprovider-getreadytologdata-method.md) method to verify that IIS is ready to log information, and then call the [ISendResponseProvider::GetLogData](../../web-development-reference/native-code-api-reference/isendresponseprovider-getlogdata-method.md) method to retrieve a `VOID` pointer that you will cast to an [HTTP_LOG_FIELDS_DATA](https://go.microsoft.com/fwlink/?LinkId=59280) structure.  
  
> [!NOTE]
>  The `HTTP_LOG_FIELDS_DATA` structure is defined in the Http.h header file.  
  
 You can use the `HTTP_LOG_FIELDS_DATA` structure to modify any of the values that IIS is logging (for example, the server name or the client's user-agent string). When you have finished modifying the log values, you use `SetLogData` to submit your modified values to IIS.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that uses the `GetReadyToLogData` method to determine whether IIS is ready log information. The module completes the following steps:  
  
1.  Uses the `GetLogData` method to retrieve an `HTTP_LOG_FIELDS_DATA` structure.  
  
2.  Uses this structure to retrieve the server name from the log information.  
  
3.  Modifies the server port in the log entry.  
  
4.  Uses the `SetLogData` method to submit the modified log information to IIS.  
  
5.  Returns the server name to a Web client and then exits.  
  
 [!code-cpp[ISendResponseProviderGetLogData#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/ISendResponseProviderGetLogData/cpp/ISendResponseProviderGetLogData.cpp#1)]  
  
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
 [ISendResponseProvider::GetLogData Method](../../web-development-reference/native-code-api-reference/isendresponseprovider-getlogdata-method.md)
