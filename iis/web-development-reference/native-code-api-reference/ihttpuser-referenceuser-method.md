---
title: "IHttpUser::ReferenceUser Method"
ms.date: "10/07/2016"
ms.assetid: dcb74db6-9cbb-08ad-7993-8b6bbdb760ae
---
# IHttpUser::ReferenceUser Method

Increments the user internal reference count.  
  
## Syntax  
  
```cpp  
virtual VOID ReferenceUser(  
   VOID  
) = 0;  
```  
  
### Parameters  

 This method takes no parameters.  
  
## Thread Safety  

 Classes that implement the [IHttpUser](../../web-development-reference/native-code-api-reference/ihttpuser-interface.md) interface are thread safe for the `ReferenceUser` and [DereferenceUser](../../web-development-reference/native-code-api-reference/ihttpuser-dereferenceuser-method.md) methods.  
  
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
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  

 [IHttpUser Interface](../../web-development-reference/native-code-api-reference/ihttpuser-interface.md)
