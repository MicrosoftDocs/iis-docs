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

    class INativeConfigurationElementCollection : public IUnknown

## Methods

The following table lists the methods that are exposed by the **INativeConfigurationElementCollection** interface.

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Name</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p><a href="inativeconfigurationelementcollection-addrawcollectionelement-method.md">INativeConfigurationElementCollection::AddRawCollectionElement Method [IIS 7]</a></p></td>
<td><p>Adds a configuration element to a collection of native configuration elements.</p></td>
</tr>
<tr class="even">
<td><p><a href="inativeconfigurationelementcollection-deleterawcollectionelement-method.md">INativeConfigurationElementCollection::DeleteRawCollectionElement Method [IIS 7]</a></p></td>
<td><p>Deletes a configuration element from a collection of native configuration elements.</p></td>
</tr>
<tr class="odd">
<td><p><a href="inativeconfigurationelementcollection-getrawelementcount-method.md">INativeConfigurationElementCollection::GetRawElementCount Method [IIS 7]</a></p></td>
<td><p>Retrieves a configuration element from a collection of native configuration elements based on its index.</p></td>
</tr>
<tr class="even">
<td><p><a href="inativeconfigurationelementcollection-getrawelementbyindex-method.md">INativeConfigurationElementCollection::GetRawElementByIndex Method [IIS 7]</a></p></td>
<td><p>Returns the number of elements within a collection of native configuration elements.</p></td>
</tr>
<tr class="odd">
<td><p><a href="inativeconfigurationelementcollection-notused0-method.md">INativeConfigurationElementCollection::NotUsed0 Method [IIS 7]</a></p></td>
<td><p>This is an infrastructure method that is not intended to be called directly.</p></td>
</tr>
<tr class="even">
<td><p><a href="inativeconfigurationelementcollection-notused1-method.md">INativeConfigurationElementCollection::NotUsed1 Method [IIS 7]</a></p></td>
<td><p>This is an infrastructure method that is not intended to be called directly.</p></td>
</tr>
<tr class="odd">
<td><p><a href="inativeconfigurationelementcollection-notused2-method.md">INativeConfigurationElementCollection::NotUsed2 Method [IIS 7]</a></p></td>
<td><p>This is an infrastructure method that is not intended to be called directly.</p></td>
</tr>
<tr class="even">
<td><p><a href="inativeconfigurationelementcollection-notused3-method.md">INativeConfigurationElementCollection::NotUsed3 Method [IIS 7]</a></p></td>
<td><p>This is an infrastructure method that is not intended to be called directly.</p></td>
</tr>
<tr class="odd">
<td><p><a href="inativeconfigurationelementcollection-notused4-method.md">INativeConfigurationElementCollection::NotUsed4 Method [IIS 7]</a></p></td>
<td><p>This is an infrastructure method that is not intended to be called directly.</p></td>
</tr>
<tr class="even">
<td><p><a href="inativeconfigurationelementcollection-notused5-method.md">INativeConfigurationElementCollection::NotUsed5 Method [IIS 7]</a></p></td>
<td><p>This is an infrastructure method that is not intended to be called directly.</p></td>
</tr>
</tbody>
</table>

## Remarks

The INativeConfigurationElementCollection interface provides a means of accessing raw configuration collections. Your application code would create an instance this interface by calling QueryInterface on an IAppHostElementCollection interface using the IID\_INativeConfigurationElementCollection GUID.

Note: The INativeConfigurationElementCollection interface contains several infrastructure methods that are not intended to be called directly from your application code.

## Inheritance Hierarchy

**IUnknown**

   **INativeConfigurationElementCollection**

## Requirements

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Type</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>Client</p></td>
<td><p>IIS 7</p></td>
</tr>
<tr class="even">
<td><p>Server</p></td>
<td><p>IIS 7</p></td>
</tr>
<tr class="odd">
<td><p>Product</p></td>
<td><p>IIS 7</p></td>
</tr>
<tr class="even">
<td><p>Header</p></td>
<td><p>Nativerd_pub.h</p></td>
</tr>
</tbody>
</table>

## See Also

### Reference

[INativeConfigurationElement Interface \[IIS 7\]](inativeconfigurationelement-interface.md)
