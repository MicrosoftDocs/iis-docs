---
title: Module Element
TOCTitle: Module Element
ms:assetid: dd92d88f-b63e-479a-8810-3eb3af58ae28
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Hh547066(v=VS.90)
ms:contentKeyID: 37836907
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Module Element

Defines a module.

    <Module id="id" type="sink|source" name="name" />

## Attributes

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Attribute</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>id</p></td>
<td><p>Required. Specifies an identifier for the module.</p></td>
</tr>
<tr class="even">
<td><p>type</p></td>
<td><p>Required. The module type, either &quot;sink&quot; or &quot;source&quot;.</p></td>
</tr>
<tr class="odd">
<td><p>name</p></td>
<td><p>Optional. Specifies a descriptive name for the module.</p></td>
</tr>
</tbody>
</table>


## Child Elements

None.

## Parent Element

<table>
<colgroup>
<col style="width: 100%" />
</colgroup>
<tbody>
<tr class="odd">
<td><p><a href="modules-element.md">Modules Element</a></p></td>
</tr>
</tbody>
</table>


## Example

    <Modules>
      <Module id="hls" type="sink" name="HTTP Live Streaming">
         // Apple HLS module configuration. 
        <HLS>
          <SegmentLength>PT10S</SegmentLength>
          <MaxBitRate>3000000</MaxBitRate>
          <AllowCaching>false</AllowCaching>
          <BackwardCompatible>true</BackwardCompatible>
          <IncludeCodecs>false</IncludeCodecs>
          <Encryption enabled="true">
            <Key>8C339AD2F44E4B2B72C95888385221BE</Key>
          </Encryption>
        </HLS>
      </Module>
    </Modules>

