---
title: INativeConfigurationElementCollection::DeleteRawCollectionElement Method [IIS 7]
TOCTitle: INativeConfigurationElementCollection::DeleteRawCollectionElement Method
ms:assetid: 3c48bd7d-ebb1-46c6-8688-7b15c1d14d43
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Ee424816(v=VS.90)
ms:contentKeyID: 23044163
ms.date: 05/24/2010
mtps_version: v=VS.90
---

# INativeConfigurationElementCollection::DeleteRawCollectionElement Method \[IIS 7\]

Deletes a configuration element from a collection of native configuration elements.

    virtual HRESULT STDMETHODCALLTYPE DeleteRawCollectionElement(
       ULONG ulPosition,
       VOID ** ppElementException = NULL
    ) = 0;

## Parameters

  - ulPosition  
    \[IN\] A ULONG value that specifies the position for the element in the collection.

  - ppElementException  
    \[OUT\] A pointer to a pointer for an element exception.

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


