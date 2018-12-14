---
title: Delete a Publishing Point
TOCTitle: Delete a Publishing Point
ms:assetid: 00e26775-66b9-49f5-aad9-bf445205cdda
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Hh206005(v=VS.90)
ms:contentKeyID: 35990939
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Delete a Publishing Point

The Delete a Publishing Point operation deletes an existing publishing point. A delete call on a running publishing point causes it to be stopped and deleted.

## Publishing point state after successful operation

The publishing point no longer exists.

## Request

The Delete a Publishing Point request may be specified as follows:

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Method</p></th>
<th><p>URI</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>DELETE</p></td>
<td><p>http(s)://&lt;hostname&gt;/&lt;filepath&gt;/settings</p></td>
</tr>
</tbody>
</table>


### URI Parameters

URL template segments and parameters.

<table>
<colgroup>
<col style="width: 33%" />
<col style="width: 33%" />
<col style="width: 33%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Parameter</p></th>
<th><p>Description</p></th>
<th><p>Example</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>hostname</p></td>
<td><p>The host name.</p></td>
<td><p>Contoso.com</p></td>
</tr>
<tr class="even">
<td><p>filepath</p></td>
<td><p>The path of the publishing point file.</p></td>
<td><p>MyVideos/bunny.isml</p></td>
</tr>
</tbody>
</table>


### Request Body

None.

## Response

The response is an HTTP status code.

### Status Code

A successful operation returns status code 200 (OK). For information about error status codes, see [Service Management Status and Error Codes](service-management-status-and-error-codes.md).

### Response Body

None.

## Authorization

The authenticated user must have write access to the publishing point settings .isml file.

