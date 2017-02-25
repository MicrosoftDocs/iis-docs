strAP = Request.ServerVariables("APPL_PHYSICAL_PATH")
If Right(strAP,1)<>"\" Then strAP = strAP & "\"
strCN = "DRIVER={Microsoft Access Driver (*.mdb)};" & _
        "DBQ=" & strAP & "App_Data\example.mdb"
Set objCN = Server.CreateObject("ADODB.Connection")
objCN.Open strCN