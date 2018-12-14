---
title: "IHttpSite::GetModuleContextContainer Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 1fadc558-b8c0-d63a-631c-bf5b6ecb2859
caps.latest.revision: 21
author: "shirhatti"
manager: "wpickett"
---
# IHttpSite::GetModuleContextContainer Method
Returns the context container for a site.  
  
## Syntax  
  
```cpp  
virtual IHttpModuleContextContainer* GetModuleContextContainer(  
   VOID  
) = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an [IHttpModuleContextContainer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulecontextcontainer-interface.md).  
  
## Remarks  
 The `GetModuleContextContainer` method return value depends on implementation. By default, the current implementation creates an [IDispensedHttpModuleContextContainer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/idispensedhttpmodulecontextcontainer-interface.md) interface that is synchronized but not dispensed.  
  
## Notes for Implementers  
 [IHttpSite](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpsite-interface.md) implementers are responsible for memory management with this data; therefore, `IHttpSite` implementers should create an `IDispensedHttpModuleContextContainer` pointer at construction and hold a `private` reference to this `IDispensedHttpModuleContextContainer` pointer for the life of the `IHttpSite` pointer. When you call the `GetModuleContextContainer` method, you should upcast and return this same `IDispensedHttpModuleContextContainer` pointer. When you call the destructor of the class that implement the `IHttpSite` interface, this destructor should call the [IDispensedHttpModuleContextContainer::ReleaseContainer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/idispensedhttpmodulecontextcontainer-releasecontainer-method.md) method on this `private` reference and then set that reference to NULL.  
  
 `GetModuleContextContainer` should not return NULL. If the internal container is NULL, set this internal container to the value on the call to [IHttpServer::DispenseContainer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-dispensecontainer-method.md), and then return this same container.  
  
> [!NOTE]
>  Although implicit upcast operations are considered safe, consider using an explicit cast for program clarity. Also consider using the [dynamic_cast](http://go.microsoft.com/fwlink/?LinkId=57556) operator whenever possible.  
  
## Notes for Callers  
 `IHttpSite` implementers are responsible for memory management with this data; therefore, `IHttpSite` clients must not release, call `delete` on, or attempt to downcast and call `IDispensedHttpModuleContextContainer::ReleaseContainer` on the returned `IHttpModuleContextContainer` pointer when this data is no longer needed.  
  
## Example  
 The following code example demonstrates a custom class named `MyContainer` that implements the `IDispensedHttpModuleContextContainer` interface, and a custom class named `MyClass` that implements the `IHttpSite` interface. `MyClass` manages a `MyContainer` pointer during the lifetime of a `MyClass` pointer.  
  
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
// IHttpSite interface.  
class MyClass : public IHttpSite  
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
  
    // Implement additional IHttpSite  
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
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpSite Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpsite-interface.md)   
 [IHttpApplication::GetModuleContextContainer Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpapplication-getmodulecontextcontainer-method.md)   
 [IHttpConnection::GetModuleContextContainer Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpconnection-getmodulecontextcontainer-method.md)   
 [IHttpContext::GetModuleContextContainer Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getmodulecontextcontainer-method.md)   
 [IHttpFileInfo::GetModuleContextContainer Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpfileinfo-getmodulecontextcontainer-method.md)   
 [IHttpFileMonitor::GetModuleContextContainer Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpfilemonitor-getmodulecontextcontainer-method.md)   
 [IHttpUrlInfo::GetModuleContextContainer Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpurlinfo-getmodulecontextcontainer-method.md)   
 [IMetadataInfo::GetModuleContextContainer Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/imetadatainfo-getmodulecontextcontainer-method.md)