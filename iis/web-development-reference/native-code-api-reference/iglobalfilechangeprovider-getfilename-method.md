---
title: "IGlobalFileChangeProvider::GetFileName Method"
ms.date: "10/07/2016"
ms.assetid: b4aed437-7a05-404c-8069-84a816df1479
---
# IGlobalFileChangeProvider::GetFileName Method
Retrieves the full path to a file that has been changed.  
  
## Syntax  
  
```cpp  
virtual PCWSTR GetFileName(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to a string that contains the file path.  
  
## Remarks  
 When a file within the scope of a Web site is changed, [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a [GL_FILE_CHANGE](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notification and creates an [IGlobalFileChangeProvider](../../web-development-reference/native-code-api-reference/iglobalfilechangeprovider-interface.md) interface that is passed to a module's [CGlobalModule::OnGlobalFileChange](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalfilechange-method.md) method. When writing a module, you can use the [IGlobalFileChangeProvider::GetFileName](../../web-development-reference/native-code-api-reference/iglobalfilechangeprovider-getfilename-method.md) method to retrieve the full path to the file that was modified.  
  
## Example  
 The following code example demonstrates how to create a global-level HTTP module that uses the `GetFileName` method to retrieve the path to a file that has been modified. The module then writes the path of the file to a log entry in the Event Viewer.  
  
 [!code-cpp[IGlobalFileChangeProviderGetFileName#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IGlobalFileChangeProviderGetFileName/cpp/IGlobalFileChangeProviderGetFileName.cpp#1)]  
  
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
 [IGlobalFileChangeProvider Interface](../../web-development-reference/native-code-api-reference/iglobalfilechangeprovider-interface.md)