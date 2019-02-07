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
 This method is intended for down casting a base class pointer to a derived class. For example, assuming you have an existing instance pointer to [IHttpRequest](../../web-development-reference\native-code-api-reference/ihttprequest-interface.md). your code would need to down cast to its derived class [IHttpRequest2](../../web-development-reference\native-code-api-reference/ihttprequest2-interface.md) in order to call one of its new methods.  
  
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
  
 Instead of using `GetExtendedInterface`, you could use the client [HttpGetExtendedInterface](../../web-development-reference\native-code-api-reference/httpgetextendedinterface-function.md) utility function to down cast the pointer.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpServer2 Interface](../../web-development-reference\native-code-api-reference/ihttpserver2-interface.md)