---
title: TraceLevel Enumeration (Microsoft.Web.Media.Diagnostics)
TOCTitle: TraceLevel Enumeration
ms:assetid: T:Microsoft.Web.Media.Diagnostics.TraceLevel
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.diagnostics.tracelevel(v=VS.95)
ms:contentKeyID: 46307925
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.Diagnostics.TraceLevel.Fatal
- Microsoft.Web.Media.Diagnostics.TraceLevel.Shutdown
- Microsoft.Web.Media.Diagnostics.TraceLevel.All
- Microsoft.Web.Media.Diagnostics.TraceLevel.FunctionExit
- Microsoft.Web.Media.Diagnostics.TraceLevel.Informational
- Microsoft.Web.Media.Diagnostics.TraceLevel
- Microsoft.Web.Media.Diagnostics.TraceLevel.None
- Microsoft.Web.Media.Diagnostics.TraceLevel.Verbose
- Microsoft.Web.Media.Diagnostics.TraceLevel.Error
- Microsoft.Web.Media.Diagnostics.TraceLevel.FunctionEntry
- Microsoft.Web.Media.Diagnostics.TraceLevel.Assertion
- Microsoft.Web.Media.Diagnostics.TraceLevel.Warning
dev_langs:
- csharp
- jscript
- vb
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.TraceLevel
- Microsoft.Web.Media.Diagnostics.TraceLevel.All
- Microsoft.Web.Media.Diagnostics.TraceLevel.Fatal
- Microsoft.Web.Media.Diagnostics.TraceLevel.Assertion
- Microsoft.Web.Media.Diagnostics.TraceLevel.Error
- Microsoft.Web.Media.Diagnostics.TraceLevel.FunctionEntry
- Microsoft.Web.Media.Diagnostics.TraceLevel.Shutdown
- Microsoft.Web.Media.Diagnostics.TraceLevel.Verbose
- Microsoft.Web.Media.Diagnostics.TraceLevel.Informational
- Microsoft.Web.Media.Diagnostics.TraceLevel.None
- Microsoft.Web.Media.Diagnostics.TraceLevel.FunctionExit
- Microsoft.Web.Media.Diagnostics.TraceLevel.Warning
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# TraceLevel Enumeration

Enumeration that specifies the severity of a trace event.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Enumeration TraceLevel
'Usage

Dim instance As TraceLevel
```

```csharp
public enum TraceLevel
```

```cpp
public enum class TraceLevel
```

``` fsharp
type TraceLevel
```

```jscript
public enum TraceLevel
```

## Members

||Member name|Description|
|--- |--- |--- |
|![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|None|0x0|
|![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|Assertion|0x1|
|![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|Error|0x2|
|![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|Fatal|0x4|
|![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|FunctionEntry|0x8|
|![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|FunctionExit|0x10|
|![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|Informational|0x20|
|![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|Shutdown|0x40|
|![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|Verbose|0x40|
|![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|Warning|0x80|
|![Supported by Windows Phone](images/Ff728255.slMobile(VS.95).gif "Supported by Windows Phone")|All|-1|

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)
