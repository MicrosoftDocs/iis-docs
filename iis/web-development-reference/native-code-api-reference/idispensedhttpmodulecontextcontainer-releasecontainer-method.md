---
title: "IDispensedHttpModuleContextContainer::ReleaseContainer Method"
ms.date: "10/07/2016"
ms.assetid: cb956ec2-9da1-8259-c487-872aae697d55
---
# IDispensedHttpModuleContextContainer::ReleaseContainer Method

Deletes the context container if it is dispensed.  
  
## Syntax  
  
```cpp  
virtual VOID ReleaseContainer(  
   VOID  
) = 0;  
```  
  
### Parameters  

 This method takes no parameters.  
  
## Thread Safety  

 The `ReleaseContainer` method is not thread safe for implementers that are dispensed.  
  
## Remarks  

 The behavior of this method depends on the implementation. You should use the following information as a guideline, but it might not be correct in all scenarios:  
  
- Most implementers declare a private `Boolean` value named `dispensed`; the default value is `false` and the default behavior is that `dispensed` is never set to `true`. However, if the implementation has set `dispensed` to `true`, when `ReleaseContainer` is called, the [IDispensedHttpModuleContextContainer](../../web-development-reference/native-code-api-reference/idispensedhttpmodulecontextcontainer-interface.md) pointer calls `delete` on itself. Otherwise, `ReleaseContainer` is an empty operation.  
  
- If `delete` is called, `IDispensedHttpModuleContextContainer` enumerates its internal array of [IHttpStoredContext](../../web-development-reference/native-code-api-reference/ihttpstoredcontext-interface.md) pointers and calls the [IHttpStoredContext::CleanupStoredContext](../../web-development-reference/native-code-api-reference/ihttpstoredcontext-cleanupstoredcontext-method.md) method on any pointers that were added previously by using the [IHttpModuleContextContainer::SetModuleContext](../../web-development-reference/native-code-api-reference/ihttpmodulecontextcontainer-setmodulecontext-method.md) method. The context container then disposes of the array memory on the heap and sets that array to NULL.  
  
## Example  

 The following example shows a custom class named `MyContainer` that implements the `IDispensedHttpModuleContextContainer` interface. It also shows a custom class named `MyClass` that implements a method named `GetModuleContextContainer`. `MyClass` manages a `MyContainer` pointer during the lifetime of a `MyClass` pointer.  
  
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
  
// Create the MyClass class.  
class MyClass  
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
    // return: a static upcast   
    // IDispensedHttpModuleContextContainer.  
    virtual IHttpModuleContextContainer*   
        GetModuleContextContainer(VOID)  
    {  
        return static_cast<IHttpModuleContextContainer*>  
            (m_container);  
    }  
  
    // Implement additional IHttpUrlInfo  
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

 [IDispensedHttpModuleContextContainer Interface](../../web-development-reference/native-code-api-reference/idispensedhttpmodulecontextcontainer-interface.md)   
 [IHttpApplication::GetModuleContextContainer Method](../../web-development-reference/native-code-api-reference/ihttpapplication-getmodulecontextcontainer-method.md)   
 [IHttpConnection::GetModuleContextContainer Method](../../web-development-reference/native-code-api-reference/ihttpconnection-getmodulecontextcontainer-method.md)   
 [IHttpContext::GetModuleContextContainer Method](../../web-development-reference/native-code-api-reference/ihttpcontext-getmodulecontextcontainer-method.md)   
 [IHttpFileInfo::GetModuleContextContainer Method](../../web-development-reference/native-code-api-reference/ihttpfileinfo-getmodulecontextcontainer-method.md)   
 [IHttpModuleContextContainer Interface](../../web-development-reference/native-code-api-reference/ihttpmodulecontextcontainer-interface.md)   
 [IHttpSite::GetModuleContextContainer Method](../../web-development-reference/native-code-api-reference/ihttpsite-getmodulecontextcontainer-method.md)   
 [IHttpUrlInfo::GetModuleContextContainer Method](../../web-development-reference/native-code-api-reference/ihttpurlinfo-getmodulecontextcontainer-method.md)   
 [IMetadataInfo::GetModuleContextContainer Method](../../web-development-reference/native-code-api-reference/imetadatainfo-getmodulecontextcontainer-method.md)
