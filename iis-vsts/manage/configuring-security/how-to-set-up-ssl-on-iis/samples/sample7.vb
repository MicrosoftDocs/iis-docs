'''''''''''''''''''''''''''''''''''''''''''''
' CREATE SSL BINDING
'''''''''''''''''''''''''''''''''''''''''''''

oIIS.Get("SSLBinding").Create _ 
   "*", 443, "4dc67e0ca1d9ac7dd4efb3daaeb15d708c9184f8", "MY"