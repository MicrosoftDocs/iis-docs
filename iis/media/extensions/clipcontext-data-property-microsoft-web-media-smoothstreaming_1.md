---
title: ClipContext.Data Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Data Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ClipContext.Data
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.clipcontext.data(v=VS.95)
ms:contentKeyID: 46307766
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipContext.Data
- Microsoft.Web.Media.SmoothStreaming.ClipContext.get_Data
- Microsoft.Web.Media.SmoothStreaming.ClipContext.set_Data
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipContext.Data
- Microsoft.Web.Media.SmoothStreaming.ClipContext.get_Data
- Microsoft.Web.Media.SmoothStreaming.ClipContext.set_Data
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ClipContext.Data Property

Gets or sets the Data property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Property Data As Object
    Get
    Private Set
'Usage

Dim instance As ClipContext
Dim value As Object

value = instance.Data
```

``` csharp
public Object Data { get; private set; }
```

``` c++
public:
property Object^ Data {
    Object^ get ();
    private: void set (Object^ value);
}
```

``` fsharp
member Data : Object with get, private set
```

``` jscript
function get Data () : Object
private function set Data (value : Object)
```

#### Property Value

Type: [System.Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.95\))  
A [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.95\)) that contains media data.

## Remarks

Any data passed by the player application.

## Version Information

#### Silverlight

Supported in: 5  

## See Also

#### Reference

[ClipContext Class](clipcontext-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

