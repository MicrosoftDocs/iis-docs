strCN = "DRIVER={Microsoft Access Driver (*.mdb)};" & _
        "DBQ=C:\Inetpub\wwwroot\App_Data\example.mdb"
Set objCN = Server.CreateObject("ADODB.Connection")
objCN.Open strCN ' <-- Note: ASP Error Occurs Here
strSQL = "SELECT * FROM TableName"