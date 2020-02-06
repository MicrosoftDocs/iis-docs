---
title: "IMapPathProvider::SetPhysicalPath Method"
ms.date: "10/07/2016"
ms.assetid: 0c3ecda8-d86b-f299-d3c5-cee8b9b761c2
---
# IMapPathProvider::SetPhysicalPath Method
Sets the physical path mapping for the current request.  
  
## Syntax  
  
```cpp  
virtual HRESULT SetPhysicalPath(  
   PCWSTR pszPhysicalPath,  
   DWORD cchPhysicalPath  
) = 0;  
```  
  
### Parameters  
 `pszPhysicalPath`  
 [IN] A pointer to a string that contains the physical path to set.  
  
 `cchPhysicalPath`  
 [IN] A `DWORD` that contains the length of the `pszPhysicalPath` string.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_PARAMETER|Indicates that an invalid value was passed in one of the parameters.|  
  
## Remarks  
 The `SetPhysicalPath` method modifies the mapped path for requests. For example, an HTTP module can use the `SetPhysicalPath` method to change the default content location for requests to a path that is different than the path that is configured in the ApplicationHost.config file.  
  
## Example  
 The following code example demonstrates how to use the `SetPhysicalPath` method to create an HTTP module that modifies the default physical path for the current request to C:\Temp.  
  
 [!code-cpp[IMapPathProviderSetPhysicalPath#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IMapPathProviderSetPhysicalPath/cpp/IMapPathProviderSetPhysicalPath.cpp#1)]  
  
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
 [IMapPathProvider Interface](../../web-development-reference/native-code-api-reference/imappathprovider-interface.md)