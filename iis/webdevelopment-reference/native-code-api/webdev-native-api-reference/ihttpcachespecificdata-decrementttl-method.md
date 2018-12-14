---
title: "IHttpCacheSpecificData::DecrementTTL Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 71fef368-1f35-a42d-35eb-8a053fd03bd9
caps.latest.revision: 25
author: "shirhatti"
manager: "wpickett"
---
# IHttpCacheSpecificData::DecrementTTL Method
Decrements the Time-to-Live (TTL) setting of the cached data.  
  
## Syntax  
  
```cpp  
virtual VOID DecrementTTL(  
   OUT BOOL* pfTTLExpired  
) = 0;  
```  
  
#### Parameters  
 `pfTTLExpired`  
 [OUT] `true` to indicate that the TTL count has reached 0; otherwise, `false`.  
  
## Thread Safety  
 Classes that implement the [IHttpCacheSpecificData](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-interface.md) interface are thread safe for the `DecrementTTL` and [ResetTTL](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-resetttl-method.md) methods.  
  
## Remarks  
 The `pfTTLExpired` parameter must not be NULL; otherwise, the `DecrementTTL` method will cause an access violation in some implementations.  
  
 The TTL setting specifies when cached data is no longer valid and, therefore, when that data should be reloaded. Most `IHttpCacheSpecificData` implementations set an initial internal count to a positive value and then allow that count to be reduced through successive calls to the `DecrementTTL` method. If the TTL value becomes 0, the data should be reloaded.  
  
 The behavior of `DecrementTTL` is implementation specific. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
-   Classes that implement the `IHttpCacheSpecificData` or [IHttpTokenEntry](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptokenentry-interface.md) interfaces initialize the internal count to 2 at construction and decrement that count by 1 on each call to `DecrementTTL`.  
  
-   Classes that implement the [IHttpFileInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpfileinfo-interface.md) interface are varied. Some classes implement the scheme defined above, while others perform empty operations on both the `ResetTTL` and `DecrementTTL` methods.  
  
## Notes for Implementers  
 The `DecrementTTL` and `ResetTTL` method implementations must be thread safe for an `IHttpCacheSpecificData` pointer.  
  
## Notes for Callers  
 Most callers may disregard the `DecrementTTL` method, because this method is meant to be used internally.  
  
## Example  
 The following code example demonstrates a class called `MySpecificData` that implements the `IHttpCacheSpecificData` methods.  
  
```  
class MySpecificData : public IHttpCacheSpecificData  
{  
public:  
    MySpecificData()  
    {  
        m_ttl = 2;  
    }  
  
    virtual ~MySpecificData()  
    {  
        m_ttl = 0;  
    }  
  
    virtual VOID ResetTTL(VOID)  
    {  
        m_ttl = 2;  
    }  
  
    virtual VOID DecrementTTL(BOOL* pfTTLExpired)  
    {  
        *pfTTLExpired = (InterlockedDecrement(&m_ttl) == 0);  
    }  
  
private:  
    LONG m_ttl;  
};  
```  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpCacheSpecificData Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-interface.md)