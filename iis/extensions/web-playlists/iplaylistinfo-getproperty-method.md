---
title: IPlaylistInfo::GetProperty Method
TOCTitle: IPlaylistInfo::GetProperty Method
ms:assetid: 9e7ad995-bc59-4cff-9047-c10c81d8e7ce
ms:mtpsurl: https://msdn.microsoft.com/library/Dd146283(v=VS.90)
ms:contentKeyID: 19132354
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistInfo::GetProperty Method

The **GetProperty** method gets the value of the requested property for this entry.

```cpp
HRESULT
GetProperty(
    [in]          PLAYLIST_PROPERTY_TYPE propertyName,
    [out, retval] VARIANT                *pVariantValue
);
```

## Arguments

|Argument|Description|
|--- |--- |
|*propertyName*|A requested property from the [PLAYLIST_PROPERTY_TYPE Enumeration](https://msdn.microsoft.com/library/dd146289) enumeration.|
|*pVariantValue*|The returned property value.|

## Return Value

If the method succeeds, it returns S\_OK. If it fails, it returns an HRESULT error code.

## Notes for Implementers

Implementers of the [IPlaylistInfo Interface](iplaylistinfo-interface.md) interface must implement this method. Implementers of this method should return a value that represents the results of the request in pVariantValue.

## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family
