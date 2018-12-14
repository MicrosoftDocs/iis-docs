---
title: "IHttpUser::ReferenceUser Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: dcb74db6-9cbb-08ad-7993-8b6bbdb760ae
caps.latest.revision: 32
author: "shirhatti"
manager: "wpickett"
---
# IHttpUser::ReferenceUser Method
Increments the user internal reference count.  
  
## Syntax  
  
```cpp  
virtual VOID ReferenceUser(  
   VOID  
) = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Thread Safety  
 Classes that implement the [IHttpUser](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpuser-interface.md) interface are thread safe for the `ReferenceUser` and [DereferenceUser](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpuser-dereferenceuser-method.md) methods.  
  
## Remarks  
 Classes that implement the `IHttpUser` interface use reference counting that is thread safe for memory management. When an `IHttpUser` pointer is constructed, the internal reference count (a `private` member variable) is set to 1. When the `ReferenceUser` method is called, this reference count is incremented by 1. When the `DereferenceUser` method is called, this same reference count is decremented by 1. The `IHttpUser` interface is removed from the heap only when the reference count goes to 0. This scheme guarantees that the `IHttpUser` pointer will not be deleted until the last client of that pointer calls the `DereferenceUser` method.  
  
## Notes for Implementers  
 The `ReferenceUser` and `DereferenceUser` method implementations should be thread safe for an `IHttpUser` pointer. Implementers should provide only `private` or `protected` destructors that are called only when the reference count goes to 0.  
  
## Notes for Callers  
 Clients should never attempt to cast an `IHttpUser` interface to a more specific class and then call `delete` directly; clients should instead call the `ReferenceUser` method exactly once when a pointer to an `IHttpUser` interface is retrieved, and then call the `DereferenceUser` method when the `IHttpUser` interface will no longer be accessed. You should call the `ReferenceUser` and `DereferenceUser` methods as early and as late as possible, respectively, to guarantee that an `IHttpUser` pointer will be valid on the heap when it is accessed and deleted when it is no longer needed.  
  
## Example  
 The following code example demonstrates a class called `MyHttpUser` that implements the `IHttpUser` interface.  
  
```  
// Create a class that implements the IHttpUser interface.  
class MyHttpUser : public IHttpUser  
{  
public:  
    // Create a public constructor.  
    // Set the internal reference count to 1.  
    MyHttpUser()  
    {  
        m_cRefs = 1;  
    }  
  
    // Increment the internal reference count.  
    virtual VOID ReferenceUser(VOID)  
    {  
        InterlockedIncrement(&m_cRefs);  
    }  
  
    // Decrement the internal reference count.  
    virtual VOID DereferenceUser(VOID)  
    {  
        // Decrement the reference count and call delete this  
        // if the count is 0.  
        if (0 == InterlockedDecrement(&m_cRefs))  
        {  
            delete this;  
        }  
    }  
  
private:  
    // Create a private destructor called from DereferenceUser.  
    virtual ~MyHttpUser()  
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
 [IHttpUser Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpuser-interface.md)