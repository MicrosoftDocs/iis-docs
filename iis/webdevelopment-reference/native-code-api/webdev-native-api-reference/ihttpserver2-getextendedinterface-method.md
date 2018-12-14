---
title: "IHttpServer2::GetExtendedInterface Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 36084663-a38a-4941-bfe4-f6782594efd9
caps.latest.revision: 3
author: "shirhatti"
manager: "wpickett"
---
# IHttpServer2::GetExtendedInterface Method
Retrieves the correct down-casted pointer based on version GUID (globally unique identifier) values.  
  
## Syntax  
  
```cpp  
virtual HRESULT GetExtendedInterface(  
   _In_ const GUID &       Version1,  
   _In_ PVOID              pInput,  
   _In_ const GUID &       Version2,  
   _Outptr_ PVOID *        ppOutput  
) = 0;  
```  
  
#### Parameters  
 `Version1`  
 [IN] GUID of the legacy instance.  
  
 `pInput`  
 [IN] Points to the legacy instance.  
  
 `Version2`  
 [IN] GUID of the interface to down cast to.  
  
 `ppOutput`  
 [OUT] Points to the down-casted instance.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 This method is intended for down casting a base class pointer to a derived class. For example, assuming you have an existing instance pointer to [IHttpRequest](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttprequest-interface.md). your code would need to down cast to its derived class [IHttpRequest2](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttprequest2-interface.md) in order to call one of its new methods.  
  
```  
HRESULT SomeFunction(   
    IHttpServer2* pHttpServer,  
    IHttpRequest pHttpRequest   
)  
{  
    IHttpRequest2 pHttpRequest2 = NULL;  
    // Grab a new interface!  
    pHttpServer-> GetExtendedInterface(__uuidof(pHttpRequest), pHttpRequest, __uuidof(pHttpRequest2), &pHttpRequest2 );  
    …  
}  
```  
  
 Instead of using `GetExtendedInterface`, you could use the client [HttpGetExtendedInterface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/httpgetextendedinterface-function.md) utility function to down cast the pointer.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpServer2 Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver2-interface.md)