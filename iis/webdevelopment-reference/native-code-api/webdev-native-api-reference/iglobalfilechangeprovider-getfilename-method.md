---
title: "IGlobalFileChangeProvider::GetFileName Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: b4aed437-7a05-404c-8069-84a816df1479
caps.latest.revision: 19
author: "shirhatti"
manager: "wpickett"
---
# IGlobalFileChangeProvider::GetFileName Method
Retrieves the full path to a file that has been changed.  
  
## Syntax  
  
```cpp  
virtual PCWSTR GetFileName(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to a string that contains the file path.  
  
## Remarks  
 When a file within the scope of a Web site is changed, [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] generates a [GL_FILE_CHANGE](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) notification and creates an [IGlobalFileChangeProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobalfilechangeprovider-interface.md) interface that is passed to a module's [CGlobalModule::OnGlobalFileChange](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobalfilechange-method.md) method. When writing a module, you can use the [IGlobalFileChangeProvider::GetFileName](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobalfilechangeprovider-getfilename-method.md) method to retrieve the full path to the file that was modified.  
  
## Example  
 The following code example demonstrates how to create a global-level HTTP module that uses the `GetFileName` method to retrieve the path to a file that has been modified. The module then writes the path of the file to a log entry in the Event Viewer.  
  
<!-- TODO: review snippet reference  [!CODE [IGlobalFileChangeProviderGetFileName#1](IGlobalFileChangeProviderGetFileName#1)]  -->  
  
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
 [IGlobalFileChangeProvider Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobalfilechangeprovider-interface.md)