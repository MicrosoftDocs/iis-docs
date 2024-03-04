---
title: CHttpModule::CHttpModule Method 2.0
TOCTitle: CHttpModule::CHttpModule Method 2.0
description: CHttpModule CHttpModule Method initializes a new instance of the CHttpModule class.
ms:assetid: 8b95c504-0a60-4676-8708-1765f91d7f6d
ms:mtpsurl: https://msdn.microsoft.com/library/ms692938(v=VS.90)
ms:contentKeyID: 6826325
ms.date: 03/09/2018
mtps_version: v=VS.90
dev_langs:
- cpp
---

# CHttpModule::CHttpModule Method 2.0

Initializes a new instance of the [CHttpModule](chttpmodule-class.md) class.

## Syntax

```cpp
CHttpModule (  
);  
```

### Parameters

This method takes no parameters.

## Remarks

The constructor for the `CHttpModule` class is `protected` to prevent the direct creation of a `CHttpModule` class. You must create a class that is derived from `CHttpModule`, because `CHttpModule` defines pure `virtual` methods that derived classes must implement.

## Example

The following code example demonstrates how to create a request-level HTTP module that registers for the [RQ\_BEGIN\_REQUEST](request-processing-constants.md) event notification. When a request enters the integrated request-processing pipeline, IIS will call the example module's [OnBeginRequest](chttpmodule-onbeginrequest-method.md) method. This method will write an entry in the application log of the Windows Event Viewer that contains "Hello World\!" in the event data. When processing is complete, the module will exit.

```cpp
#define _WINSOCKAPI_
#include <windows.h>
#include <sal.h>
#include <httpserv.h>

// Create the module class.
class MyHttpModule : public CHttpModule
{
public:

    // Process an RQ_BEGIN_REQUEST event.
    REQUEST_NOTIFICATION_STATUS
    OnBeginRequest(
        IN IHttpContext * pHttpContext,
        IN IHttpEventProvider * pProvider
    )
    {
        UNREFERENCED_PARAMETER( pHttpContext );
        UNREFERENCED_PARAMETER( pProvider );
        WriteEventViewerLog("Hello World!");
        return RQ_NOTIFICATION_CONTINUE;
    }

    // 
    MyHttpModule()
    {
        // Open a handle to the Event Viewer.
        m_hEventLog = RegisterEventSource( NULL,"IISADMIN" );
    }

    ~MyHttpModule()
    {
        // Test whether the handle for the Event Viewer is open.
        if (NULL != m_hEventLog)
        {
            // Close the handle to the Event Viewer.
            DeregisterEventSource( m_hEventLog );
            m_hEventLog = NULL;
        }
    }

private:

    // Create a handle for the event viewer.
    HANDLE m_hEventLog;

    // Define a method that writes to the Event Viewer.
    BOOL WriteEventViewerLog(LPCSTR szNotification)
    {
        // Test whether the handle for the Event Viewer is open.
        if (NULL != m_hEventLog)
        {
            // Write any strings to the Event Viewer and return.
            return ReportEvent(
                m_hEventLog,
                EVENTLOG_INFORMATION_TYPE,
                0, 0, NULL, 1, 0, &szNotification, NULL );
        }
        return FALSE;
    }
};

// Create the module's class factory.
class MyHttpModuleFactory : public IHttpModuleFactory
{
public:
    HRESULT
    GetHttpModule(
        OUT CHttpModule ** ppModule, 
        IN IModuleAllocator * pAllocator
    )
    {
        UNREFERENCED_PARAMETER( pAllocator );

        // Create a new instance.
        MyHttpModule * pModule = new MyHttpModule;

        // Test for an error.
        if (!pModule)
        {
            // Return an error if the factory cannot create the instance.
            return HRESULT_FROM_WIN32( ERROR_NOT_ENOUGH_MEMORY );
        }
        else
        {
            // Return a pointer to the module.
            *ppModule = pModule;
            pModule = NULL;
            // Return a success status.
            return S_OK;
        }            
    }

    void Terminate()
    {
        // Remove the class from memory.
        delete this;
    }
};

// Create the module's exported registration function.
HRESULT
__stdcall
RegisterModule(
    DWORD dwServerVersion,
    IHttpModuleRegistrationInfo * pModuleInfo,
    IHttpServer * pGlobalInfo
)
{
    UNREFERENCED_PARAMETER( dwServerVersion );
    UNREFERENCED_PARAMETER( pGlobalInfo );

    // Set the request notifications and exit.
    return pModuleInfo->SetRequestNotifications(
        // Specify the class factory.
        new MyHttpModuleFactory,
        // Specify the event notifications.
        RQ_BEGIN_REQUEST,
        // Specify no post-event notifications.
        0
    );
}
```

Your module must export the [RegisterModule](pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](https://msdn.microsoft.com/library/ms689320).

You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.

## Requirements

| Type | Description |
| --- | --- |
| Client | - IIS 7.0 on Windows Vista

- IIS 7.5 on Windows 7

- IIS 8.0 on Windows 8

- IIS 10.0 on Windows 10 |
| Server | - IIS 7.0 on Windows Server 2008

- IIS 7.5 on Windows Server 2008 R2

- IIS 8.0 on Windows Server 2012

- IIS 8.5 on Windows Server 2012 R2

- IIS 10.0 on Windows Server 2016 Technical Preview |
| Product | - IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0

- IIS Express 7.5, IIS Express 8.0, IIS Express 10.0 |
| Header | Httpserv.h |

## See Also

[CHttpModule Class](chttpmodule-class.md)  
[REQUEST\_NOTIFICATION\_STATUS Enumeration](request-notification-status-enumeration.md)
