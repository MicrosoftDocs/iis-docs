---
title: "IHttpApplication::GetModuleContextContainer Method"
ms.date: "10/07/2016"
ms.assetid: 6aab65ba-de19-0383-abbf-ce25c5fe7aa2
---
# IHttpApplication::GetModuleContextContainer Method
Returns the module context container for the application.  
  
## Syntax  
  
```cpp  
virtual IHttpModuleContextContainer* GetModuleContextContainer(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an [IHttpModuleContextContainer](../../web-development-reference/native-code-api-reference/ihttpmodulecontextcontainer-interface.md).  
  
## Remarks  
 The `GetModuleContextContainer` method return value is dependent on implementation. By default, the current implementation creates an [IDispensedHttpModuleContextContainer](../../web-development-reference/native-code-api-reference/idispensedhttpmodulecontextcontainer-interface.md) that is synchronized but not dispensed.  
  
## Notes for Implementers  
 [IHttpApplication](../../web-development-reference/native-code-api-reference/ihttpapplication-interface.md) implementers are responsible for memory management with this data; therefore, `IHttpApplication` implementers should create an `IDispensedHttpModuleContextContainer` pointer at construction and hold a `private` reference to this `IDispensedHttpModuleContextContainer` pointer for the life of the `IHttpApplication` pointer. When the `GetModuleContextContainer` method is called, you should upcast and return this same `IDispensedHttpModuleContextContainer` pointer. When the destructor of the class that implements the `IHttpApplication` interface is called, this destructor should call the [IDispensedHttpModuleContextContainer::ReleaseContainer](../../web-development-reference/native-code-api-reference/idispensedhttpmodulecontextcontainer-releasecontainer-method.md) method on this `private` reference and then set that reference to NULL.  
  
 `GetModuleContextContainer` should not return NULL. If the internal container is NULL, set this internal container to the value on the call to [IHttpServer::DispenseContainer](../../web-development-reference/native-code-api-reference/ihttpserver-dispensecontainer-method.md), and then return this same container.  
  
> [!NOTE]
>  Although implicit upcast operations are considered safe, consider using an explicit cast for program clarity. Whenever possible, also consider using the [dynamic_cast](https://go.microsoft.com/fwlink/?LinkId=57556) operator.  
  
## Notes for Callers  
 `IHttpApplication` implementers are responsible for memory management with this data; therefore, `IHttpApplication` clients must not release, call `delete` on, or attempt to downcast and call `IDispensedHttpModuleContextContainer::ReleaseContainer` on the returned `IHttpModuleContextContainer` pointer when this data is no longer needed.  
  
## Example  
 The following code example demonstrates a custom class named `MyContainer` that implements the `IDispensedHttpModuleContextContainer` interface, and a custom class named `MyClass` that implements the `IHttpApplication` interface. `MyClass` manages a `MyContainer` pointer during the lifetime of a `MyClass` pointer.  
  
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
// IHttpApplication interface.  
class MyClass : public IHttpApplication  
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
  
    // Implement additional IHttpApplication  
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
 [IHttpApplication Interface](../../web-development-reference/native-code-api-reference/ihttpapplication-interface.md)   
 [IHttpConnection::GetModuleContextContainer Method](../../web-development-reference/native-code-api-reference/ihttpconnection-getmodulecontextcontainer-method.md)   
 [IHttpContext::GetModuleContextContainer Method](../../web-development-reference/native-code-api-reference/ihttpcontext-getmodulecontextcontainer-method.md)   
 [IHttpFileInfo::GetModuleContextContainer Method](../../web-development-reference/native-code-api-reference/ihttpfileinfo-getmodulecontextcontainer-method.md)   
 [IHttpFileMonitor::GetModuleContextContainer Method](../../web-development-reference/native-code-api-reference/ihttpfilemonitor-getmodulecontextcontainer-method.md)   
 [IHttpSite::GetModuleContextContainer Method](../../web-development-reference/native-code-api-reference/ihttpsite-getmodulecontextcontainer-method.md)   
 [IHttpUrlInfo::GetModuleContextContainer Method](../../web-development-reference/native-code-api-reference/ihttpurlinfo-getmodulecontextcontainer-method.md)   
 [IMetadataInfo::GetModuleContextContainer Method](../../web-development-reference/native-code-api-reference/imetadatainfo-getmodulecontextcontainer-method.md)