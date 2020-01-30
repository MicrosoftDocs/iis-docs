---
title: INativeConfigurationElementCollection::GetRawElementCount Method [IIS 7]
TOCTitle: INativeConfigurationElementCollection::GetRawElementCount Method
ms:assetid: f3d982ef-fecc-4101-8db2-6812590f9377
ms:mtpsurl: https://msdn.microsoft.com/library/Ee424825(v=VS.90)
ms:contentKeyID: 23044172
ms.date: 05/24/2010
mtps_version: v=VS.90
---

# INativeConfigurationElementCollection::GetRawElementCount Method \[IIS 7\]

Retrieves an element from a collection of native configuration elements based on the element's index in the collection.

    virtual HRESULT STDMETHODCALLTYPE GetRawElementByIndex(
       ULONG ulIndex,
       INativeConfigurationElement ** ppRawConfigElement
    ) = 0;

## Parameters

  - ulIndex  
    \[IN\] A ULONG value that specifies the index for the element in the collection.

  - ppRawConfigElement  
    \[OUT\] A pointer to a pointer for an INativeConfigurationElement interface for the configuration element.

## Return Value

An HRESULT. Possible values include, but are not limited to, those in the following table.

| Value | Description |
| --- | --- |
| S_OK | Indicates that the operation was successful. |
| NO_ERROR | Indicates that an error did not occur. |

## Requirements

| Type | Description |
| --- | --- |
| Client | IIS 7 |
| Server | IIS 7 |
| Product | IIS 7 |
| Header | Nativerd_pub.h |

