Set oIIS = GetObject("winmgmts:root\WebAdministration")        
Set oSection = oIIS.Get("ImageCopyright.Path='MACHINE/WEBROOT/APPHOST/Default Web Site',Location=''")
oSection.Enabled = true
oSection.Message = "Copyright (C) IIS7 Team - Date: " & date
oSection.Color = "White"
oSection.Put_