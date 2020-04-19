---
title: INativeConfigurationElement Interface [IIS 7]
TOCTitle: INativeConfigurationElement Interface
ms:assetid: 72fe53a1-4c78-4603-811a-b384833e0fd7
ms:mtpsurl: https://msdn.microsoft.com/library/Ee441231(v=VS.90)
ms:contentKeyID: 23160330
ms.date: 05/24/2010
mtps_version: v=VS.90
---

# INativeConfigurationElement Interface \[IIS 7\]

Provides an interface for a native configuration element.

    class INativeConfigurationElement : public IUnknown

## Methods

This interface contains no public methods.

## Remarks

The INativeConfigurationElement interface provides a means of accessing raw configuration elements. Your application code would create an instance this interface by calling QueryInterface on an IAppHostElement interface using the IID\_INativeConfigurationElement GUID.

Note: The INativeConfigurationElement interface contains several infrastructure methods that are not intended to be called directly from your application code.

This interface is only useful when your application is using the raw configuration interface INativeConfigurationElementCollection.

## Inheritance Hierarchy

**IUnknown**

   **INativeConfigurationElement**

## Requirements

| Type | Description |
| --- | --- |
| Client | IIS 7 |
| Server | IIS 7 |
| Product | IIS 7 |
| Header | Nativerd_pub.h |

## See Also

### Reference

[INativeConfigurationElementCollection Interface \[IIS 7\]](inativeconfigurationelementcollection-interface.md)
