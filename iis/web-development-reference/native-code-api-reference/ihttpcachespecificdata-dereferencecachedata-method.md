---
title: "IHttpCacheSpecificData::DereferenceCacheData Method"
ms.date: "10/07/2016"
ms.assetid: 5717cb11-2b6a-bac5-4f92-4d9d83340192
---
# IHttpCacheSpecificData::DereferenceCacheData Method
Decrements the internal reference count for the cached data.  
  
## Syntax  
  
```cpp  
virtual VOID DereferenceCacheData(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Thread Safety  
 Classes that implement the [IHttpCacheSpecificData](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-interface.md) interface are thread safe for the `DereferenceCacheData` and [ReferenceCacheData](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-referencecachedata-method.md) methods.  
  
## Remarks  
 Classes that implement the `IHttpCacheSpecificData` interface use reference counting that is thread safe for memory management. When an `IHttpCacheSpecificData` pointer is constructed, the internal reference count (a `private` member variable) is set to 1. When the `ReferenceCacheData` method is called, this reference count is incremented by 1. When the `DereferenceCacheData` method is called, this same reference count is decremented by 1. Only when the reference count goes to 0 is the `IHttpCacheSpecificData` pointer removed from the heap. This scheme guarantees that the `IHttpCacheSpecificData` pointer will not be deleted until the last client of that pointer calls `DereferenceCacheData`.  
  
## Notes for Implementers  
 The `ReferenceCacheData` and `DereferenceCacheData` method implementations should be thread safe for an `IHttpCacheSpecificData` interface. Implementers should provide `protected` or `private` destructors that are called internally only when the reference count goes to 0.  
  
## Notes for Callers  
 Clients should never attempt to cast an `IHttpCacheSpecificData` interface to a more specific class and then call `delete` directly. Clients should instead call the `ReferenceCacheData` method exactly once when a pointer to an `IHttpCacheSpecificData` interface is retrieved, and then call the `DereferenceCacheData` method when the `IHttpCacheSpecificData` pointer will no longer be accessed. You should call the `ReferenceCacheData` and `DereferenceCacheData` methods as early and as late as possible, respectively, to guarantee that an `IHttpCacheSpecificData` pointer will be valid on the heap when it is accessed and deleted when it is no longer needed.  
  
## Example  
 The following code example demonstrates a class called `MySpecificData` that implements the `IHttpCacheSpecificData` methods.  
  
```  
// Create a class that implements the IHttpCacheSpecificData interface.  
class MySpecificData : public IHttpCacheSpecificData  
{  
public:  
    // Create a public constructor.  
    // Set the internal reference count to 1.  
    MySpecificData ()  
    {  
        m_cRefs = 1;  
    }  
  
    // Increment the internal reference count.  
    virtual VOID ReferenceCacheData(VOID)  
    {  
        InterlockedIncrement(&m_cRefs);  
    }  
  
    // Decrement the internal reference count.  
    virtual VOID DereferenceCacheData(VOID)  
    {  
        // Decrement the reference count and delete this  
        // if the count is 0.  
        if (0 == InterlockedDecrement(&m_cRefs))  
        {  
            delete this;  
        }  
    }  
  
    // To do: implement custom MySpecificData implementation.  
  
private:  
    // Create a private destructor called from DereferenceCacheData.  
    virtual ~MySpecificData ()  
    {  
  
    }  
  
    // Create a private reference count member.  
    LONG m_cRefs;  
}  
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
 [IHttpFileInfo Interface](../../web-development-reference/native-code-api-reference/ihttpfileinfo-interface.md)   
 [IHttpTokenEntry Interface](../../web-development-reference/native-code-api-reference/ihttptokenentry-interface.md)
