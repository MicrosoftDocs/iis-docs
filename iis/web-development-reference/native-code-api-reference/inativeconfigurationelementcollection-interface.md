---
title: INativeConfigurationElementCollection Interface [IIS 7]
TOCTitle: INativeConfigurationElementCollection Interface
ms:assetid: 7cc5eef4-fbe8-407c-934f-8e77ec02cd83
ms:mtpsurl: https://msdn.microsoft.com/library/Ee441232(v=VS.90)
ms:contentKeyID: 23160331
ms.date: 05/24/2010
mtps_version: v=VS.90
---

# INativeConfigurationElementCollection Interface \[IIS 7\]

Provides an interface for a collection of native configuration elements.

```cpp
class INativeConfigurationElementCollection : public IUnknown
```

## Methods

The following table lists the methods that are exposed by the **INativeConfigurationElementCollection** interface.

| Name | Description |
|---|---|
|[INativeConfigurationElementCollection::AddRawCollectionElement Method [IIS 7]](../inativeconfigurationelementcollection-addrawcollectionelement-method) | Adds a configuration element to a collection of native configuration elements. |
|[INativeConfigurationElementCollection::DeleteRawCollectionElement Method [IIS 7]](../inativeconfigurationelementcollection-deleterawcollectionelement-method) | Deletes a configuration element from a collection of native configuration elements. |
|[INativeConfigurationElementCollection::GetRawElementCount Method [IIS 7]](../inativeconfigurationelementcollection-getrawelementcount-method) | Retrieves a configuration element from a collection of native configuration elements based on its index. |
|[INativeConfigurationElementCollection::GetRawElementByIndex Method [IIS 7]](../inativeconfigurationelementcollection-getrawelementbyindex-method) | Returns the number of elements within a collection of native configuration elements. |
|[INativeConfigurationElementCollection::NotUsed0 Method [IIS 7]](../inativeconfigurationelementcollection-notused0-method) | This is an infrastructure method that is not intended to be called directly. |
|[INativeConfigurationElementCollection::NotUsed1 Method [IIS 7]](../inativeconfigurationelementcollection-notused1-method) | This is an infrastructure method that is not intended to be called directly. |
|[INativeConfigurationElementCollection::NotUsed2 Method [IIS 7]](../inativeconfigurationelementcollection-notused2-method) | This is an infrastructure method that is not intended to be called directly. |
|[INativeConfigurationElementCollection::NotUsed3 Method [IIS 7]](../inativeconfigurationelementcollection-notused3-method) | This is an infrastructure method that is not intended to be called directly. |
|[INativeConfigurationElementCollection::NotUsed4 Method [IIS 7]](../inativeconfigurationelementcollection-notused4-method) | This is an infrastructure method that is not intended to be called directly. |
|[INativeConfigurationElementCollection::NotUsed5 Method [IIS 7]](../inativeconfigurationelementcollection-notused5-method) | This is an infrastructure method that is not intended to be called directly. |

## Remarks

The INativeConfigurationElementCollection interface provides a means of accessing raw configuration collections. Your application code would create an instance this interface by calling QueryInterface on an IAppHostElementCollection interface using the IID\_INativeConfigurationElementCollection GUID.

Note: The INativeConfigurationElementCollection interface contains several infrastructure methods that are not intended to be called directly from your application code.

## Inheritance Hierarchy

**IUnknown**

   **INativeConfigurationElementCollection**

## Requirements

| Type | Description |
|---|---|
| Client | IIS 7 |
| Server | IIS 7 |
| Product | IIS 7 |
| Header | Nativerd_pub.h |

## See Also

### Reference

[INativeConfigurationElement Interface \[IIS 7\]](inativeconfigurationelement-interface.md)
