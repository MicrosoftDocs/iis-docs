---
title: "IHttpConnection::GetModuleContextContainer Method"
ms.date: "10/07/2016"
ms.assetid: af3ebc74-5cbd-11bd-5674-50e9ab9267b2
---
# IHttpConnection::GetModuleContextContainer Method
Returns the module context container for the connection.  
  
## Syntax  
  
```cpp  
virtual IHttpModuleContextContainer* GetModuleContextContainer(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an [IHttpModuleContextContainer](../../web-development-reference\native-code-api-reference/ihttpmodulecontextcontainer-interface.md).  
  
## Remarks  
 The `GetModuleContextContainer` method return value depends on implementation. By default, the current implementation creates an [IDispensedHttpModuleContextContainer](../../web-development-reference\native-code-api-reference/idispensedhttpmodulecontextcontainer-interface.md) interface that is synchronized but not dispensed.  
  
## Notes for Implementers  
 [IHttpConnection](../../web-development-reference\native-code-api-reference/ihttpconnection-interface.md) implementers are responsible for memory management with this data; therefore, `IHttpConnection` implementers should create an `IDispensedHttpModuleContextContainer` pointer at construction and hold a `private` reference to this `IDispensedHttpModuleContextContainer` pointer for the life of the `IHttpConnection` pointer. When you call the `GetModuleContextContainer` method, you should upcast and return this same `IDispensedHttpModuleContextContainer` pointer. When you call the destructor of the class that implements the `IHttpConnection` interface, this destructor should call the [IDispensedHttpModuleContextContainer::ReleaseContainer](../../web-development-reference\native-code-api-reference/idispensedhttpmodulecontextcontainer-releasecontainer-method.md) method on this `private` reference and then set that reference to NULL.  
  
 `GetModuleContextContainer` should not return NULL. If the internal container is NULL, set this internal container to the value on the call to [IHttpServer::DispenseContainer](../../web-development-reference\native-code-api-reference/ihttpserver-dispensecontainer-method.md), and then return this same container.  
  
> [!NOTE]
>  Although implicit upcast operations are considered safe, consider using an explicit cast for program clarity. Also consider using the [dynamic_cast](http://go.microsoft.com/fwlink/?LinkId=57556) operator whenever possible.  
  
## Notes for Callers  
 `IHttpConnection` implementers are responsible for memory management with this data; therefore, `IHttpConnection` clients must not release, call `delete` on, or attempt to downcast and call `IDispensedHttpModuleContextContainer::ReleaseContainer` on the returned `IHttpModuleContextContainer` pointer when this data is no longer needed.  
  
## Example  
 The following code example demonstrates a custom class named `MyContainer` that implements the `IDispensedHttpModuleContextContainer` interface, and a custom class named `MyClass` that implements the `IHttpConnection` interface. `MyClass` manages a `MyContainer` pointer during the lifetime of a `MyClass` pointer.  
  
```  
// The MyContainer class implements the   
// IDispensedHttpModuleContextContainer interface.  
class MyContainer : public IDispensedHttpModuleContextContainer  
{  
public:  
    // The MyContainer method is the public  
    // constructor for the MyContainer class.  
    // Make this method protected if the   
    // MyContainer class is abstract.  
    // dispensed: true if the container should  
    // call delete this when the ReleaseContainer  
    // method is called.  
    MyContainer(bool dispensed = false)   
        : m_dispensed(dispensed)  
    {  
  
    }  
  
    // The ReleaseContainer method   
    // calls delete this if this container  
    // is dispensed.  
    virtual VOID ReleaseContainer(VOID)  
    {  
        if (m_dispensed)  
        {  
            delete this;  
        }  
    }  
  
    // Implement additional   
    // IDispensedHttpModuleContextContainer  
    // pure virtual methods if this class  
    // is not abstract.  
  
private:  
    // The MyContainer method is the private  
    // destructor for the MyContainer class.  
    // Make this method protected and virtual   
    // if the MyContainer class expects   
    // to be a class of derivation. This method   
    // should not be public because   
    // IDispensedHttpModuleContextContainer pointers  
    // should be disposed externally only by   
    // calling the ReleaseContainer method.  
    ~MyContainer()  
    {  
  
    }  
  
    // Specify a Boolean value for dispensing.  
    bool m_dispensed;  
};  
  
// The MyClass class implements the  
// IHttpConnection interface.  
class MyClass : public IHttpConnection  
{  
public:  
    // The MyClass method is the public  
    // constructor for the MyClass class.  
    MyClass()  
    {  
        m_container = new MyContainer;  
    }  
  
    // The MyClass method is the   
    // public virtual destructor   
    // for the MyClass class. This destructor  
    // calls ReleaseContainer on the internal  
    // IDispensedHttpModuleContextContainer  
    // pointer and sets that pointer to NULL.  
    virtual ~MyClass()  
    {  
        m_container->ReleaseContainer();  
        m_container = NULL;  
    }  
  
    // The GetModuleContextContainer method  
    // returns an IHttpModuleContextContainer  
    // pointer.  
    // return: an explicit upcast   
    // IDispensedHttpModuleContextContainer  
    // pointer for readability.  
    virtual IHttpModuleContextContainer*   
        GetModuleContextContainer(VOID)  
    {  
        return (IHttpModuleContextContainer*)m_container;  
    }  
  
    // Implement additional IHttpConnection  
    // pure virtual methods if this class  
    // is not abstract.  
  
private:  
    // Specify a private  
    // IDispensedHttpModuleContextContainer  
    // pointer.  
    IDispensedHttpModuleContextContainer* m_container;  
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
 [IHttpConnection Interface](../../web-development-reference\native-code-api-reference/ihttpconnection-interface.md)   
 [IHttpApplication::GetModuleContextContainer Method](../../web-development-reference\native-code-api-reference/ihttpapplication-getmodulecontextcontainer-method.md)   
 [IHttpContext::GetModuleContextContainer Method](../../web-development-reference\native-code-api-reference/ihttpcontext-getmodulecontextcontainer-method.md)   
 [IHttpFileInfo::GetModuleContextContainer Method](../../web-development-reference\native-code-api-reference/ihttpfileinfo-getmodulecontextcontainer-method.md)   
 [IHttpFileMonitor::GetModuleContextContainer Method](../../web-development-reference\native-code-api-reference/ihttpfilemonitor-getmodulecontextcontainer-method.md)   
 [IHttpSite::GetModuleContextContainer Method](../../web-development-reference\native-code-api-reference/ihttpsite-getmodulecontextcontainer-method.md)   
 [IHttpUrlInfo::GetModuleContextContainer Method](../../web-development-reference\native-code-api-reference/ihttpurlinfo-getmodulecontextcontainer-method.md)   
 [IMetadataInfo::GetModuleContextContainer Method](../../web-development-reference\native-code-api-reference/imetadatainfo-getmodulecontextcontainer-method.md)