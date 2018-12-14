---
title: ClipEventArgs.Context Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Context Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ClipEventArgs.Context
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.clipeventargs.context(v=VS.90)
ms:contentKeyID: 23961095
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipEventArgs.Context
- Microsoft.Web.Media.SmoothStreaming.ClipEventArgs.get_Context
- Microsoft.Web.Media.SmoothStreaming.ClipEventArgs.set_Context
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipEventArgs.Context
- Microsoft.Web.Media.SmoothStreaming.ClipEventArgs.get_Context
- Microsoft.Web.Media.SmoothStreaming.ClipEventArgs.set_Context
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Context Property

Gets or sets the Context property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicPropertyContextAsClipContext
'Usage
DiminstanceAsClipEventArgsDimvalueAsClipContextvalue = instance.Context
```

``` csharp
publicClipContextContext { get; privateset; }
```

``` c++
public:
propertyClipContext^ Context {
    ClipContext^ get ();
    private: voidset (ClipContext^ value);
}
```

``` jscript
function getContext () : ClipContextprivatefunction setContext (value : ClipContext)
```

#### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming. . :: . .ClipContext](clipcontext-class-microsoft-web-media-smoothstreaming_1.md)  
A [ClipContext](clipcontext-class-microsoft-web-media-smoothstreaming_1.md) object.  

## Remarks

For more information, see [Scheduling Media Clips (IIS Smooth Streaming)](scheduling-media-clips.md).

## Version Information

#### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[ClipEventArgs Class](clipeventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

