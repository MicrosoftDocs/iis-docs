---
title: Tracing.IsolatedStorageQuota Property (Microsoft.Web.Media.Diagnostics)
TOCTitle: IsolatedStorageQuota Property
ms:assetid: P:Microsoft.Web.Media.Diagnostics.Tracing.IsolatedStorageQuota
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.diagnostics.tracing.isolatedstoragequota(v=VS.95)
ms:contentKeyID: 46307730
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.Diagnostics.Tracing.IsolatedStorageQuota
- Microsoft.Web.Media.Diagnostics.Tracing.get_IsolatedStorageQuota
- Microsoft.Web.Media.Diagnostics.Tracing.set_IsolatedStorageQuota
dev_langs:
- csharp
- jscript
- vb
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.Tracing.get_IsolatedStorageQuota
- Microsoft.Web.Media.Diagnostics.Tracing.IsolatedStorageQuota
- Microsoft.Web.Media.Diagnostics.Tracing.set_IsolatedStorageQuota
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Tracing.IsolatedStorageQuota Property

Gets or sets the IsolatedStorageQuota property.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Shared Property IsolatedStorageQuota As Long
    Get
    Private Set
'Usage

Dim value As Long

value = Tracing.IsolatedStorageQuota
```

```csharp
public static long IsolatedStorageQuota { get; private set; }
```

```cpp
public:
static property long long IsolatedStorageQuota {
    long long get ();
    private: void set (long long value);
}
```

``` fsharp
static member IsolatedStorageQuota : int64 with get, private set
```

```jscript
static function get IsolatedStorageQuota () : long
private static function set IsolatedStorageQuota (value : long)
```

### Property Value

Type: [System.Int64](https://msdn.microsoft.com/library/6yy583ek\(v=vs.95\))  
A long integer value that specifies the required isolated storage quota.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[Tracing Class](tracing-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

