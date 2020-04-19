---
title: "IHttpCacheSpecificData::ResetTTL Method"
ms.date: "10/07/2016"
ms.assetid: 6b8b7fce-32a3-c503-2c99-dc66de77d9ce
---
# IHttpCacheSpecificData::ResetTTL Method
Resets the Time-to-Live (TTL) setting of the cached data.  
  
## Syntax  
  
```cpp  
virtual VOID ResetTTL(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Thread Safety  
 Classes that implement the [IHttpCacheSpecificData](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-interface.md) interface are thread safe for the [DecrementTTL](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-decrementttl-method.md) and `ResetTTL` methods.  
  
## Remarks  
 The TTL is used to determine when cached data is no longer valid and, therefore, when that data should be reloaded. Most `IHttpCacheSpecificData` implementations set an initial internal count to a positive value, and then allow that count to be reduced through successive calls to the `DecrementTTL` method. If the TTL value becomes 0, the data should be reloaded.  
  
 The behavior of the `ResetTTL` method is implementation specific. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
-   Classes that implement the `IHttpCacheSpecificData` or [IHttpTokenEntry](../../web-development-reference/native-code-api-reference/ihttptokenentry-interface.md) interfaces initialize the internal count to 2 at construction, and decrement that count by 1 on each call to `DecrementTTL`.  
  
-   Classes that implement the [IHttpFileInfo](../../web-development-reference/native-code-api-reference/ihttpfileinfo-interface.md) interface are varied. Some classes implement the scheme defined above, while others perform empty operations on both `ResetTTL` and `DecrementTTL`.  
  
## Notes for Implementers  
 The `DecrementTTL` and `ResetTTL` method implementations must be thread safe for an `IHttpCacheSpecificData` pointer.  
  
## Notes for Callers  
 Most callers may disregard the `ResetTTL` method because this method is meant to be used internally.  
  
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
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpCacheSpecificData Interface](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-interface.md)