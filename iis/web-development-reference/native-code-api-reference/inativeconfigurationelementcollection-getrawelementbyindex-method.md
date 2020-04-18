---
title: INativeConfigurationElementCollection::GetRawElementByIndex Method [IIS 7]
TOCTitle: INativeConfigurationElementCollection::GetRawElementByIndex Method
ms:assetid: a7f37c40-39bf-4b02-8eff-f085a0575f56
ms:mtpsurl: https://msdn.microsoft.com/library/Ee424821(v=VS.90)
ms:contentKeyID: 23044168
ms.date: 05/24/2010
mtps_version: v=VS.90
---

# INativeConfigurationElementCollection::GetRawElementByIndex Method \[IIS 7\]

Returns the number of elements within a collection of native configuration elements.

    virtual HRESULT STDMETHODCALLTYPE GetRawElementCount(
       ULONG * pcRawElementCount
    ) = 0;

## Parameters

  - pcRawElementCount  
    \[OUT\] A pointer to a pointer for a ULONG value that will contain the number of elements in the collection.

## Return Value

An HRESULT. Possible values include, but are not limited to, those in the following table.

| Value | Description |
| --- | --- |
| S_OK | Indicates that the operation was successful. |
| NO_ERROR | Indicates that an error did not occur. |

## Remarks

The GetRawElementCount method returns the number of configuration elements in a collection, which includes defined elements as well as cleared elements.

## Requirements

| Type | Description |
| --- | --- |
| Client | IIS 7 |
| Server | IIS 7 |
| Product | IIS 7 |
| Header | Nativerd_pub.h |
