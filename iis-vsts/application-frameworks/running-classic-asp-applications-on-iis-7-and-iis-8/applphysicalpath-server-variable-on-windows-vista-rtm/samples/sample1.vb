strCN = "DRIVER={Microsoft Access Driver (*.mdb)};" & _
        "DBQ=" & Request.ServerVariables("APPL_PHYSICAL_PATH") & _
        "App_Data\example.mdb"
Set objCN = Server.CreateObject("ADODB.Connection")
objCN.Open strCN