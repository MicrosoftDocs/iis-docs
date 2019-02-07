---
title: IPlaylistEntryInfo::GetProperty Method
TOCTitle: IPlaylistEntryInfo::GetProperty Method
ms:assetid: a36f33d1-e59d-457e-bb5f-5b1fda770d45
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Dd146284(v=VS.90)
ms:contentKeyID: 19132355
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IPlaylistEntryInfo::GetProperty Method

The **GetProperty** method gets the value of the requested property for this entry.

    HRESULT
    GetProperty(
        [in]            PLAYLIST_ENTRY_PROPERTY_TYPE   propertyName,
        [out, retval]   VARIANT *pVariantValue
    );

## Arguments

|||
|--- |--- |
|*propertyName*|A [PLAYLIST_ENTRY_PROPERTY_TYPE Enumeration](https://msdn.microsoft.com/en-us/library/dd146267(v=vs.90)) enumeration describing the location type of the entry.|
|*pVariantValue*|The returned property value. Implementers should return a value that represents the results of the request in propertyName.|


## Return Value

If the method succeeds, it returns S\_OK. If it fails, it returns an HRESULT error code.

## Notes for Implementers

Implementers of the [IPlaylistEntryInfo Interface](iplaylistentryinfo-interface.md) interface must implement this method.

## Requirements

**Header:** playlistprovider.h

**Library:** playlistprovider.dll

**Platform:** Windows Server 2008 family

