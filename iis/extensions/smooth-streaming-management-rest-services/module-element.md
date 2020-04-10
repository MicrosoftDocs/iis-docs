---
title: Module Element
TOCTitle: Module Element
ms:assetid: dd92d88f-b63e-479a-8810-3eb3af58ae28
ms:mtpsurl: https://msdn.microsoft.com/library/Hh547066(v=VS.90)
ms:contentKeyID: 37836907
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Module Element

Defines a module.

    <Module id="id" type="sink|source" name="name" />

## Attributes

|Attribute|Description|
|--- |--- |
|id|Required. Specifies an identifier for the module.|
|type|Required. The module type, either "sink" or "source".|
|name|Optional. Specifies a descriptive name for the module.|

## Child Elements

None.

## Parent Element

[Modules Element](modules-element.md)

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
