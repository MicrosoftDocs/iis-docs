---
title: StoredProcedureParameter.Value Property (Microsoft.Web.Management.DatabaseManager)
TOCTitle: Value Property
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.StoredProcedureParameter.Value
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.storedprocedureparameter.value(v=VS.90)
ms:contentKeyID: 20476805
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.StoredProcedureParameter.Value
- Microsoft.Web.Management.DatabaseManager.StoredProcedureParameter.get_Value
- Microsoft.Web.Management.DatabaseManager.StoredProcedureParameter.set_Value
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.StoredProcedureParameter.get_Value
- Microsoft.Web.Management.DatabaseManager.StoredProcedureParameter.set_Value
- Microsoft.Web.Management.DatabaseManager.StoredProcedureParameter.Value
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# StoredProcedureParameter.Value Property

Gets or sets the value of the parameter for a stored procedure.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Property Value As String
'Usage
Dim instance As StoredProcedureParameter
Dim value As String

value = instance.Value

instance.Value = value
```

```csharp
public string Value { get; set; }
```

```cpp
public:
property String^ Value {
    String^ get ();
    void set (String^ value);
}
```

```jscript
function get Value () : String
function set Value (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
The value of the parameter for a stored procedure.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[StoredProcedureParameter Class](storedprocedureparameter-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

