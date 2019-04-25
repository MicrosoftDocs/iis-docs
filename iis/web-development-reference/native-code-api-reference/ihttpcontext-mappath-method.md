---
title: "IHttpContext::MapPath Method"
ms.date: "10/07/2016"
ms.assetid: e4f19ece-2ef0-7e2f-b4b0-24f406979753
---
# IHttpContext::MapPath Method
Returns the physical path of a relative URL.  
  
## Syntax  
  
```cpp  
virtual HRESULT MapPath(  
   PCWSTR pszUrl,  
   __out_bcount(* pcbPhysicalPath) PWSTR pszPhysicalPath,  
   DWORD* pcbPhysicalPath  
) = 0;  
```  
  
### Parameters  
 `pszUrl`  
 [IN] A pointer to a string that contains the relative URL to map.  
  
 `pszPhysicalPath`  
 [OUT] A pointer to a string that receives the mapped path.  
  
 `pcbPhysicalPath`  
 [IN] A pointer to a `DWORD` that contains the size of the buffer pointed to by `pszPhysicalPath`.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INSUFFICIENT_BUFFER|Indicates that the buffer pointed to by `pszPhysicalPath` is not large enough to perform the operation.|  
|ERROR_NOT_ENOUGH_MEMORY|Indicates that there is insufficient memory to perform the operation.|  
  
## Remarks  
 The `MapPath` method returns the physical location of the relative URL that is contained in the `pszUrl` parameter.  
  
> [!NOTE]
>  If the buffer pointed to by the `pszPhysicalPath` parameter is not large enough to perform the operation, the `pcbPhysicalPath``DWORD` parameter will contain the required buffer size for the operation.  
  
## Example  
 The following code example demonstrates how to use the `MapPath` method to create an HTTP module that returns the physical path of the root folder for the Web site that uses this module.  
  
 [!code-cpp[IHttpContextMapPath#1](~/samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpContextMapPath/cpp/IHttpContextMapPath.cpp#1)]  
  
 Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpContext Interface](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md)