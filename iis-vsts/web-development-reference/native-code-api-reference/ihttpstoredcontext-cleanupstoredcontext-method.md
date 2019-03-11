---
title: "IHttpStoredContext::CleanupStoredContext Method"
ms.date: "10/07/2016"
ms.assetid: 49cb417f-3a67-488c-9218-a51b2d73d929
---
# IHttpStoredContext::CleanupStoredContext Method
Cleans up the stored context.  
  
## Syntax  
  
```cpp  
virtual VOID CleanupStoredContext(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Remarks  
 The behavior of this method depends on implementation. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
-   Some implementations perform an empty operation during the `CleanupStoredContext` method.  
  
-   Some implementations call `delete``this` on the current [IHttpStoredContext](../../web-development-reference\native-code-api-reference/ihttpstoredcontext-interface.md) pointer.  
  
-   Some implementations use internal reference counting and decrement an internal reference count during each call to `CleanupStoredContext`. These implementers call `delete``this` on the current `IHttpStoredContext` immediately if that reference count goes to 0.  
  
## Notes for Implementers  
 `IHttpStoredContext` implementers should create either `protected` or `private``virtual` destructors, because an `IHttpStoredContext` pointer should not be downcast to its most specific class for deletion. Rather, deletion of these implementers should be controlled by each pointer internally and handled during a call to `CleanupStoredContext`.  
  
## Notes for Callers  
 The `CleanupStoredContext` method should be called only once on an `IHttpStoredContext` pointer, because some implementations call `delete``this` when `CleanupStoredContext` is called. Calling `CleanupStoredContext` more than once on most `IHttpStoredContext` pointers will either throw an access violation exception or corrupt data in memory.  
  
## Example  
 The following code example demonstrates how to create an `IHttpStoredContext` class named `MyStoredContext` and to control deletion of a `MyStoredContext` pointer internally. `MyStoredContext` implements only a `private` destructor and calls that destructor when the `CleanupStoredContext` method is called.  
  
```  
// The MyStoredContext class implements the IHttpStoredContext  
// interface and demonstrates one possible solution for  
// implementing the CleanupStoredContext method.  
class MyStoredContext : public IHttpStoredContext  
{  
public:  
    // The MyStoredContext method is the public   
    // constructor for the MyStoredContext class.  
    MyStoredContext()  
    {  
  
    }  
  
    // The CleanupStoredContext method must be implemented  
    // by non-abstract classes that implement the   
    // IHttpStoredContext interface. This method   
    // calls delete this.  
    virtual void CleanupStoredContext(VOID)  
    {  
        delete this;  
    }  
  
private:  
    // The MyStoredContext method is the private virtual  
    // destructor for the MyStoredContext class.  
    virtual ~MyStoredContext()  
    {  
  
    }  
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
 [IHttpStoredContext Interface](../../web-development-reference\native-code-api-reference/ihttpstoredcontext-interface.md)