---
title: Getting Started with IIS Smooth Streaming Management REST Services
TOCTitle: Getting Started with IIS Smooth Streaming Management REST Services
ms:assetid: e1d82b65-f608-40b3-bf3a-ee651029ee38
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Hh239769(v=VS.90)
ms:contentKeyID: 35957236
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Getting Started with IIS Smooth Streaming Management REST Services

The IIS Smooth Streaming Management REST Services Application Programming Interface (API) is a Representational State Transfer (REST) API that you can use to manage Live Smooth Streaming publishing points in IIS Media Services version 4.1 or later.

The Smooth Streaming Management REST Services API provides programmatic access to much of the functionality available through the Live Smooth Streaming Publishing Points icon in the Media Services area of IIS Manager. Using the Smooth Streaming Management REST Services API, you can create or delete publishing points; enumerate the publishing points on a Web site; query the setting, state, or statistics of a publishing point; or update the state of a publishing point.

XML elements that form the request body and response body of Smooth Streaming REST Services publishing point management are defined in the SmoothStreaming schema, [SmoothStreaming.xsd](http://go.microsoft.com/fwlink/?linkid=231871). For more information see the [SmoothStreaming Schema Reference](smoothstreaming-schema-reference.md).

## Using the IIS Smooth Streaming Management REST Services

The following table lists operations that can be performed using the IIS Smooth Streaming Management REST Services publishing point management.

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Operation</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p><a href="create-a-new-publishing-point.md">Create a New Publishing Point</a></p></td>
<td><p>Creates a new publishing point on the current Web site.</p></td>
</tr>
<tr class="even">
<td><p><a href="delete-a-publishing-point.md">Delete a Publishing Point</a></p></td>
<td><p>Deletes an existing publishing point.</p></td>
</tr>
<tr class="odd">
<td><p><a href="enumerate-web-site-publishing-points.md">Enumerate Web Site Publishing Points</a></p></td>
<td><p>Enumerates all publishing points on the current Web site.</p></td>
</tr>
<tr class="even">
<td><p><a href="enumerate-web-site-publishing-points-with-details.md">Enumerate Web Site Publishing Points with Details</a></p></td>
<td><p>Enumerates all publishing points on the current Web site, including publishing point details.</p></td>
</tr>
<tr class="odd">
<td><p><a href="query-publishing-point-settings.md">Query Publishing Point Settings</a></p></td>
<td><p>Retrieves settings for a specific publishing point.</p></td>
</tr>
<tr class="even">
<td><p><a href="query-publishing-point-state.md">Query Publishing Point State</a></p></td>
<td><p>Retrieves the state for a publishing point.</p></td>
</tr>
<tr class="odd">
<td><p><a href="query-publishing-point-statistics.md">Query Publishing Point Statistics</a></p></td>
<td><p>Retrieves statistics for a specific publishing point.</p></td>
</tr>
<tr class="even">
<td><p><a href="update-publishing-point-settings.md">Update Publishing Point Settings</a></p></td>
<td><p>Updates the settings for an existing publishing point.</p></td>
</tr>
<tr class="odd">
<td><p><a href="update-publishing-point-state.md">Update Publishing Point State</a></p></td>
<td><p>Updates the state of an existing publishing point.</p></td>
</tr>
</tbody>
</table>

