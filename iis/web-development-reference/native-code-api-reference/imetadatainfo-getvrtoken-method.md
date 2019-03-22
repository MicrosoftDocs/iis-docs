---
title: "IMetadataInfo::GetVrToken Method"
ms.date: "10/07/2016"
ms.assetid: 194a4a46-93f9-f826-8bf2-d4642b2765e9
---
# IMetadataInfo::GetVrToken Method
Retrieves an [IHttpTokenEntry](../../web-development-reference/native-code-api-reference/ihttptokenentry-interface.md) interface for the impersonation account that is configured for a virtual directory.  
  
## Syntax  
  
```cpp  
virtual IHttpTokenEntry* GetVrToken(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an `IHttpTokenEntry` interface.  
  
## Remarks  
 When creating a virtual directory in IIS that points to a network share, you can specify the impersonation user name and password that IIS will use to connect to the network share when IIS processes requests. You can then use the `GetVrToken` method to retrieve an `IHttpTokenEntry` interface for the impersonated user.  
  
## Example  
 The following code example demonstrates how to use the `GetVrToken` method to create an HTTP module that retrieves an `IHttpTokenEntry` interface for the impersonation account that is configured for a virtual directory. The module converts the user token to a string and returns the string to the Web client.  
  
<!-- TODO: review snippet reference  [!CODE [IMetadataInfoGetVrToken#1](IMetadataInfoGetVrToken#1)]  -->  
  
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
 [IMetadataInfo Interface](../../web-development-reference/native-code-api-reference/imetadatainfo-interface.md)