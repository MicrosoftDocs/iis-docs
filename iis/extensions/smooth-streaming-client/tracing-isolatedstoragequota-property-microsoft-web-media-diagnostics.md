---
title: Tracing.IsolatedStorageQuota Property  (Microsoft.Web.Media.Diagnostics)
TOCTitle: IsolatedStorageQuota Property
ms:assetid: P:Microsoft.Web.Media.Diagnostics.Tracing.IsolatedStorageQuota
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.diagnostics.tracing.isolatedstoragequota(v=VS.90)
ms:contentKeyID: 23961230
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.Diagnostics.Tracing.IsolatedStorageQuota
- Microsoft.Web.Media.Diagnostics.Tracing.get_IsolatedStorageQuota
- Microsoft.Web.Media.Diagnostics.Tracing.set_IsolatedStorageQuota
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.Tracing.get_IsolatedStorageQuota
- Microsoft.Web.Media.Diagnostics.Tracing.IsolatedStorageQuota
- Microsoft.Web.Media.Diagnostics.Tracing.set_IsolatedStorageQuota
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# IsolatedStorageQuota Property

Gets or sets the IsolatedStorageQuota property.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

  Public Shared Property IsolatedStorageQuota As Long
'Usage

  Dim value As Long

value = Tracing.IsolatedStorageQuota
```

``` csharp
  public static long IsolatedStorageQuota { get; private set; }
```

``` c++
  public:
static property long long IsolatedStorageQuota {
    long long get ();
    private: void set (long long value);
}
```

``` jscript
  static function get IsolatedStorageQuota () : long
private static function set IsolatedStorageQuota (value : long)
```

#### Property Value

Type: [System. . :: . .Int64](https://msdn.microsoft.com/en-us/library/6yy583ek\(v=vs.90\))  
A long integer value that specifies the required isolated storage quota.  

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[Tracing Class](tracing-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

