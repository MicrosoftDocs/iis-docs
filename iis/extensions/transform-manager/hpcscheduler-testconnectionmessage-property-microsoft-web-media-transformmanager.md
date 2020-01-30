---
title: HpcScheduler.TestConnectionMessage Property (Microsoft.Web.Media.TransformManager)
TOCTitle: TestConnectionMessage Property
ms:assetid: P:Microsoft.Web.Media.TransformManager.HpcScheduler.TestConnectionMessage
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.hpcscheduler.testconnectionmessage(v=VS.90)
ms:contentKeyID: 35520871
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.HpcScheduler.get_TestConnectionMessage
- Microsoft.Web.Media.TransformManager.HpcScheduler.TestConnectionMessage
- Microsoft.Web.Media.TransformManager.HpcScheduler.set_TestConnectionMessage
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.HpcScheduler.get_TestConnectionMessage
- Microsoft.Web.Media.TransformManager.HpcScheduler.set_TestConnectionMessage
- Microsoft.Web.Media.TransformManager.HpcScheduler.TestConnectionMessage
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# TestConnectionMessage Property

Gets the connection message.

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration

  Public Property TestConnectionMessage As String
    Get
    Private Set
'Usage

  Dim instance As HpcScheduler
Dim value As String

value = instance.TestConnectionMessage
```

```csharp
  public string TestConnectionMessage { get; private set; }
```

```cpp
  public:
property String^ TestConnectionMessage {
    String^ get ();
    private: void set (String^ value);
}
```

``` fsharp
  member TestConnectionMessage : string with get, private set
```

```jscript
  function get TestConnectionMessage () : String
private function set TestConnectionMessage (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
A connection message that contains exception details.  

## See Also

### Reference

[HpcScheduler Class](hpcscheduler-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

