---
title: "IHttpRequest2::GetChannelBindingToken Method"
ms.date: "10/07/2016"
ms.assetid: 307775f3-dc62-49a7-8237-6a48966ee980
---
# IHttpRequest2::GetChannelBindingToken Method

Gets the channel binding token (CBT) being used for request validation.  
  
## Syntax  
  
```cpp  
virtual HRESULT GetChannelBindingToken(  
   _Outptr_result_bytebuffer_to_(*pTokenSize, *pTokenSize)  
   PBYTE *             ppToken,  
   _Out_ DWORD *       pTokenSize  
) = 0;  
```  
  
### Parameters  

 `ppToken`  
 [OUT] Pointer to the channel binding token.  
  
 `pTokenSize`  
 [OUT] Size in bytes of the channel binding token.  
  
## Return Value  

 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  

 [IHttpRequest2 Interface](../../web-development-reference/native-code-api-reference/ihttprequest2-interface.md)
