---
title: Modules Element
TOCTitle: Modules Element
ms:assetid: 8716d579-56d4-4cfc-9e2d-544cdfa314e8
ms:mtpsurl: https://msdn.microsoft.com/library/Hh547049(v=VS.90)
ms:contentKeyID: 37836890
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Modules Element

Lists the currently processing modules.

    <Modules>
      <Module />
    </Modules>

### Child Elements

[Module Element](module-element.md)

### Parent Element

[Settings Element](settings-element.md)

### Example

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
