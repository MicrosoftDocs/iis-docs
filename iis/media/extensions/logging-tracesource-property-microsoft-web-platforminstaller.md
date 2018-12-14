---
title: Logging.TraceSource Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: TraceSource Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Logging.TraceSource
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.logging.tracesource(v=VS.90)
ms:contentKeyID: 22049602
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Logging.TraceSource
- Microsoft.Web.PlatformInstaller.Logging.get_TraceSource
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Logging.get_TraceSource
- Microsoft.Web.PlatformInstaller.Logging.TraceSource
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TraceSource Property

Gets the tracing source of the current logging object.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicSharedReadOnlyPropertyTraceSourceAsTraceSourceGet
'Usage
DimvalueAsTraceSourcevalue = Logging.TraceSource
```

``` csharp
publicstaticTraceSourceTraceSource { get; }
```

``` c++
public:
staticpropertyTraceSource^ TraceSource {
    TraceSource^ get ();
}
```

``` jscript
staticfunction getTraceSource () : TraceSource
```

#### Property Value

Type: TraceSource  
A TraceSource instance.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Logging Class](logging-class-microsoft-web-platforminstaller.md)

[Logging Members](logging-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

