---
title: "IHttpCacheSpecificData::ReferenceCacheData Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: e200bb07-9b60-ec28-fe4d-c2c24643c3de
caps.latest.revision: 23
author: "shirhatti"
manager: "wpickett"
---
# IHttpCacheSpecificData::ReferenceCacheData Method
Increments the internal reference count for the cached data.  
  
## Syntax  
  
```cpp  
virtual VOID ReferenceCacheData(  
   VOID  
) = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Thread Safety  
 Classes that implement the [IHttpCacheSpecificData](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-interface.md) interface are thread safe for the [DereferenceCacheData](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-dereferencecachedata-method.md) and `ReferenceCacheData` methods.  
  
## Remarks  
 Classes that implement the `IHttpCacheSpecificData` interface use reference counting that is thread safe for memory management. When an `IHttpCacheSpecificData` pointer is constructed, the internal reference count (a `private` member variable) is set to 1. When the `ReferenceCacheData` method is called, this reference count is incremented by 1. When the `DereferenceCacheData` method is called, this same reference count is decremented by 1. Only when the reference count goes to 0 is the `IHttpCacheSpecificData` pointer removed from the heap. This scheme guarantees that the `IHttpCacheSpecificData` pointer will not be deleted until the last client of that pointer calls `DereferenceCacheData`.  
  
## Notes for Implementers  
 The `ReferenceCacheData` and `DereferenceCacheData` method implementations should be thread safe for an `IHttpCacheSpecificData` interface. Implementers should provide `protected` or `private` destructors that are called internally only when the reference count goes to 0.  
  
## Notes for Callers  
 Clients should never attempt to cast an `IHttpCacheSpecificData` pointer to a more specific class and then call `delete` directly. Clients should instead call the `ReferenceCacheData` method exactly once when a pointer to an `IHttpCacheSpecificData` interface is retrieved, and then call the `DereferenceCacheData` method when the `IHttpCacheSpecificData` pointer will no longer be accessed. You should call the `ReferenceCacheData` and `DereferenceCacheData` methods as early and as late as possible, respectively, to guarantee that an `IHttpCacheSpecificData` pointer will be valid on the heap when it is accessed and deleted when it is no longer needed.  
  
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
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpCacheSpecificData Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-interface.md)