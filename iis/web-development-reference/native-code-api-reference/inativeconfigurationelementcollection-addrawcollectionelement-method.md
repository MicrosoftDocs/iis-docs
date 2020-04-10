---
title: INativeConfigurationElementCollection::AddRawCollectionElement Method [IIS 7]
TOCTitle: INativeConfigurationElementCollection::AddRawCollectionElement Method
ms:assetid: 141e2988-fb89-4f1d-81cd-81cff6cd572a
ms:mtpsurl: https://msdn.microsoft.com/library/Ee424815(v=VS.90)
ms:contentKeyID: 23044162
ms.date: 05/24/2010
mtps_version: v=VS.90
---

# INativeConfigurationElementCollection::AddRawCollectionElement Method \[IIS 7\]

Adds a configuration element to a collection of native configuration elements.

    virtual HRESULT STDMETHODCALLTYPE AddRawCollectionElement(
       INativeConfigurationElement * pConfigElement,
       ULONG ulPosition,
       VOID ** ppElementException = NULL
    ) = 0;

## Parameters

  - pConfigElement  
    \[IN\] A pointer to an INativeConfigurationElement interface.

  - ulPosition  
    \[IN\] A ULONG value that specifies the index position for the element in the collection.

  - ppElementException  
    \[OUT\] A pointer to a pointer to void. (Note: This is an infrastructure parameter and it is not intended to be used. Your application code should pass null for this parameter.)

## Return Value

An HRESULT. Possible values include, but are not limited to, those in the following table.

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Value</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>S_OK</p></td>
<td><p>Indicates that the operation was successful.</p></td>
</tr>
<tr class="even">
<td><p>NO_ERROR</p></td>
<td><p>Indicates that an error did not occur.</p></td>
</tr>
</tbody>
</table>

## Requirements

| Type | Description |
| --- | --- |
| Client | IIS 7 |
| Server | IIS 7 |
| Product | IIS 7 |
| Header | Nativerd_pub.h |
