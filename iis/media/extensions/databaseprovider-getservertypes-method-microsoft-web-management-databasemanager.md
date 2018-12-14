---
title: DatabaseProvider.GetServerTypes Method  (Microsoft.Web.Management.DatabaseManager)
TOCTitle: GetServerTypes Method
ms:assetid: M:Microsoft.Web.Management.DatabaseManager.DatabaseProvider.GetServerTypes(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.databasemanager.databaseprovider.getservertypes(v=VS.90)
ms:contentKeyID: 22049487
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.DatabaseManager.DatabaseProvider.GetServerTypes
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.DatabaseManager.dll
api_name:
- Microsoft.Web.Management.DatabaseManager.DatabaseProvider.GetServerTypes
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DatabaseProvider.GetServerTypes Method

Returns the list of supported server types for a database provider.

**Namespace:**  [Microsoft.Web.Management.DatabaseManager](microsoft-web-management-databasemanager-namespace.md)  
**Assembly:**  Microsoft.Web.Management.DatabaseManager (in Microsoft.Web.Management.DatabaseManager.dll)

## Syntax

``` vb
'Declaration
Public MustOverride Function GetServerTypes ( _
    connectionString As String _
) As ICollection(Of TypeInfo)
'Usage
Dim instance As DatabaseProvider
Dim connectionString As String
Dim returnValue As ICollection(Of TypeInfo)

returnValue = instance.GetServerTypes(connectionString)
```

``` csharp
public abstract ICollection<TypeInfo> GetServerTypes(
    string connectionString
)
```

``` c++
public:
virtual ICollection<TypeInfo^>^ GetServerTypes(
    String^ connectionString
) abstract
```

``` jscript
public abstract function GetServerTypes(
    connectionString : String
) : ICollection<TypeInfo>
```

#### Parameters

  - connectionString  
    Type: [System.String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The connection string for the database connection.  

#### Return Value

Type: [System.Collections.Generic.ICollection](https://msdn.microsoft.com/en-us/library/92t2ye13\(v=vs.90\))\<[TypeInfo](typeinfo-class-microsoft-web-management-databasemanager.md)\>  
A read-only ICollection object that contains a collection of [TypeInfo](typeinfo-class-microsoft-web-management-databasemanager.md) objects.  

## Remarks

Your provider must implement the GetServerTypes method in order to return the database types for your provider.


> [!NOTE]
> <P>The types for a provider vary greatly between database servers; you must consult the documentation for your database server in order to construct the list of server types for your provider.</P>



## Examples

The following code sample illustrates an example GetServerTypes method that returns a list of database types for an OLEDB provider.

``` vb

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

``` csharp

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

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DatabaseProvider Class](databaseprovider-class-microsoft-web-management-databasemanager.md)

[Microsoft.Web.Management.DatabaseManager Namespace](microsoft-web-management-databasemanager-namespace.md)

