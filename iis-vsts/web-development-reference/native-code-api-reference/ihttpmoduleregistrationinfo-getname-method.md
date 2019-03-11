---
title: "IHttpModuleRegistrationInfo::GetName Method"
ms.date: "10/07/2016"
ms.assetid: 7b712ccb-f82e-894f-18cf-4c123c78b38e
---
# IHttpModuleRegistrationInfo::GetName Method
Retrieves the module name.  
  
## Syntax  
  
```cpp  
virtual PCWSTR GetName(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to a string that contains the name of the module.  
  
## Remarks  
 You can use the `GetName` method to retrieve the configured name of the module as it appears in the [!INCLUDE[iismgr](../../wmi-provider/includes/iismgr-md.md)] and ApplicationHost.config file. For example, if you added a module to IIS, the settings in the ApplicationHost.config file might resemble the following excerpt:  
  
```  
<globalModules>  
    <add name="MyTestModule"  
        image="C:\Windows\system32\inetsrv\mytestmodule.dll" />  
</globalModules>  
```  
  
 If you then called the `GetName` method, it would return "MyTestModule" as the name of the module.  
  
## Example  
 The following code example demonstrates how to use the `GetName` method to retrieve the name of the module. The module returns the name to a Web client and then exits.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpModuleRegistrationInfoGetName#1](IHttpModuleRegistrationInfoGetName#1)]  -->  
  
 Your module must export the [RegisterModule](../../web-development-reference\native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpModuleRegistrationInfo Interface](../../web-development-reference\native-code-api-reference/ihttpmoduleregistrationinfo-interface.md)