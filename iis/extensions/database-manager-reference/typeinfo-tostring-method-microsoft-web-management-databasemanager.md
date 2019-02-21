---
title: TypeInfo.ToString Method  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: ToString Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.TypeInfo.ToString
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.typeinfo.tostring(v=VS.90)
ms:contentKeyID: 20476620
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.TypeInfo.ToString
dev_langs:
- "csharp"
- "jscript"
- "vb"
- "cpp"
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.TypeInfo.ToString
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# TypeInfo.ToString Method

Returns the name of the data type.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Overrides Function ToString As String
'Usage
Dim instance As TypeInfo
Dim returnValue As String

returnValue = instance.ToString()
```

```csharp
public override string ToString()
```

```cpp
public:
virtual String^ ToString() override
```

```jscript
public override function ToString() : String
```

### Return Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
A string that contains the name of the data type.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[TypeInfo Class](typeinfo-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

