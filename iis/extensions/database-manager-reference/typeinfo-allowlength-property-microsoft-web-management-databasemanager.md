---
title: TypeInfo.AllowLength Property (Microsoft.Web.Management.DatabaseManager)
TOCTitle: AllowLength Property
ms:assetid: P:Microsoft.Web.Management.DatabaseManager.TypeInfo.AllowLength
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.management.databasemanager.typeinfo.allowlength(v=VS.90)
ms:contentKeyID: 20476776
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.TypeInfo.AllowLength
- Microsoft.Web.Management.DatabaseManager.TypeInfo.get_AllowLength
- Microsoft.Web.Management.DatabaseManager.TypeInfo.set_AllowLength
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.TypeInfo.AllowLength
- Microsoft.Web.Management.DatabaseManager.TypeInfo.get_AllowLength
- Microsoft.Web.Management.DatabaseManager.TypeInfo.set_AllowLength
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# TypeInfo.AllowLength Property

Gets or sets a value that indicates whether the data type supports length.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

```vb
'Declaration
Public Property AllowLength As Boolean
'Usage
Dim instance As TypeInfo
Dim value As Boolean

value = instance.AllowLength

instance.AllowLength = value
```

```csharp
public bool AllowLength { get; set; }
```

```cpp
public:
property bool AllowLength {
    bool get ();
    void set (bool value);
}
```

```jscript
function get AllowLength () : boolean
function set AllowLength (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
true if the data type supports length; otherwise, false.  

## Examples

The following code sample illustrates an example GetServerTypes method that returns a list of database types for an OLEDB provider.

```vb

    Public Overrides Function GetServerTypes( _
            ByVal connectionString As String) _
            As System.Collections.Generic.ICollection( _
            Of Microsoft.Web.Management.DatabaseManager.TypeInfo)

        Dim types As List(Of TypeInfo) = New List(Of TypeInfo)
        Dim info As TypeInfo

        ' Add a Binary type.
        info = New TypeInfo
        info.AllowIdentity = False
        info.AllowLength = True
        info.AllowNulls = True
        info.IsBinary = True
        info.IsVariableLength = False
        info.Name = "Binary"
        types.Add(info)

        ' Add a Bit type.
        info = New TypeInfo
        info.AllowIdentity = False
        info.AllowLength = False
        info.AllowNulls = True
        info.IsBinary = False
        info.IsVariableLength = False
        info.Name = "Bit"
        types.Add(info)

        ' Add a Byte type.
        info = New TypeInfo
        info.AllowIdentity = False
        info.AllowLength = False
        info.AllowNulls = True
        info.IsBinary = False
        info.IsVariableLength = False
        info.Name = "Byte"
        types.Add(info)

        ' Add a Currency type.
        info = New TypeInfo
        info.AllowIdentity = False
        info.AllowLength = False
        info.AllowNulls = True
        info.HasPrecision = True
        info.MaximumPrecision = 28
        info.DefaultPrecision = 18
        info.IsBinary = False
        info.IsVariableLength = False
        info.Name = "Currency"
        types.Add(info)

        ' Add a DateTime type.
        info = New TypeInfo
        info.AllowIdentity = False
        info.AllowLength = False
        info.AllowNulls = True
        info.IsBinary = False
        info.IsVariableLength = False
        info.Name = "DateTime"
        types.Add(info)

        ' Add a Decimal type.
        info = New TypeInfo
        info.AllowIdentity = False
        info.AllowLength = False
        info.AllowNulls = True
        info.HasPrecision = True
        info.MaximumPrecision = 28
        info.DefaultPrecision = 18
        info.IsBinary = False
        info.IsVariableLength = False
        info.Name = "Decimal"
        types.Add(info)

        ' Add a Float type.
        info = New TypeInfo
        info.AllowIdentity = False
        info.AllowLength = False
        info.AllowNulls = True
        info.IsBinary = False
        info.IsVariableLength = False
        info.Name = "Float"
        types.Add(info)
        ' Add an Integer type.
        info = New TypeInfo
        info.AllowIdentity = False
        info.AllowLength = False
        info.AllowNulls = True
        info.IsBinary = False
        info.IsVariableLength = False
        info.Name = "Integer"
        types.Add(info)

        ' Add a Real type.
        info = New TypeInfo
        info.AllowIdentity = False
        info.AllowLength = False
        info.AllowNulls = True
        info.IsBinary = False
        info.IsVariableLength = False
        info.Name = "Real"
        types.Add(info)

        ' Add a SmallInt type.
        info = New TypeInfo
        info.AllowIdentity = False
        info.AllowLength = False
        info.AllowNulls = True
        info.IsBinary = False
        info.IsVariableLength = False
        info.Name = "SmallInt"
        types.Add(info)
        ' Add a Text type.
        info = New TypeInfo
        info.AllowIdentity = False
        info.AllowLength = True
        info.AllowNulls = True
        info.IsBinary = False
        info.IsVariableLength = True
        info.Name = "Text"
        types.Add(info)

        ' Add a UNIQUEIDENTIFIER type.
        info = New TypeInfo
        info.AllowIdentity = True
        info.AllowLength = False
        info.AllowNulls = False
        info.IsBinary = False
        info.IsVariableLength = False
        info.Name = "UniqueIdentifier"
        types.Add(info)

        Return types

    End Function

```

```csharp

        public override ICollection<TypeInfo> GetServerTypes(
            string connectionString )
        {
            List<TypeInfo> types = new List<TypeInfo>();
            TypeInfo info;

            // Add a Binary type.
            info = new TypeInfo();
            info.AllowIdentity = false;
            info.AllowLength = true;
            info.AllowNulls = true;
            info.IsBinary = true;
            info.IsVariableLength = false;
            info.Name = "Binary";
            types.Add(info);

            // Add a Bit type.
            info = new TypeInfo();
            info.AllowIdentity = false;
            info.AllowLength = false;
            info.AllowNulls = true;
            info.IsBinary = false;
            info.IsVariableLength = false;
            info.Name = "Bit";
            types.Add(info);

            // Add a Byte type.
            info = new TypeInfo();
            info.AllowIdentity = false;
            info.AllowLength = false;
            info.AllowNulls = true;
            info.IsBinary = false;
            info.IsVariableLength = false;
            info.Name = "Byte";
            types.Add(info);

            // Add a Currency type.
            info = new TypeInfo();
            info.AllowIdentity = false;
            info.AllowLength = false;
            info.AllowNulls = true;
            info.HasPrecision = true;
            info.MaximumPrecision = 28;
            info.DefaultPrecision = 18;
            info.IsBinary = false;
            info.IsVariableLength = false;
            info.Name = "Currency";
            types.Add(info);

            // Add a DateTime type.
            info = new TypeInfo();
            info.AllowIdentity = false;
            info.AllowLength = false;
            info.AllowNulls = true;
            info.IsBinary = false;
            info.IsVariableLength = false;
            info.Name = "DateTime";
            types.Add(info);

            // Add a Decimal type.
            info = new TypeInfo();
            info.AllowIdentity = false;
            info.AllowLength = false;
            info.AllowNulls = true;
            info.HasPrecision = true;
            info.MaximumPrecision = 28;
            info.DefaultPrecision = 18;
            info.IsBinary = false;
            info.IsVariableLength = false;
            info.Name = "Decimal";
            types.Add(info);

            // Add a Float type.
            info = new TypeInfo();
            info.AllowIdentity = false;
            info.AllowLength = false;
            info.AllowNulls = true;
            info.IsBinary = false;
            info.IsVariableLength = false;
            info.Name = "Float";
            types.Add(info);

            // Add an Integer type.
            info = new TypeInfo();
            info.AllowIdentity = false;
            info.AllowLength = false;
            info.AllowNulls = true;
            info.IsBinary = false;
            info.IsVariableLength = false;
            info.Name = "Integer";
            types.Add(info);

            // Add a Real type.
            info = new TypeInfo();
            info.AllowIdentity = false;
            info.AllowLength = false;
            info.AllowNulls = true;
            info.IsBinary = false;
            info.IsVariableLength = false;
            info.Name = "Real";
            types.Add(info);

            // Add a SmallInt type.
            info = new TypeInfo();
            info.AllowIdentity = false;
            info.AllowLength = false;
            info.AllowNulls = true;
            info.IsBinary = false;
            info.IsVariableLength = false;
            info.Name = "SmallInt";
            types.Add(info);

            // Add a Text type.
            info = new TypeInfo();
            info.AllowIdentity = false;
            info.AllowLength = true;
            info.AllowNulls = true;
            info.IsBinary = false;
            info.IsVariableLength = true;
            info.Name = "Text";
            types.Add(info);

            // Add a UNIQUEIDENTIFIER type.
            info = new TypeInfo();
            info.AllowIdentity = true;
            info.AllowLength = false;
            info.AllowNulls = false;
            info.IsBinary = false;
            info.IsVariableLength = false;
            info.Name = "UniqueIdentifier";
            types.Add(info);

            return types;
        }

```

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[TypeInfo Class](typeinfo-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

