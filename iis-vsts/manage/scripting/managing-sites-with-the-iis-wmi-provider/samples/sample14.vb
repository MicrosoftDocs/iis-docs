Set oIIS = GetObject("winmgmts:root\WebAdministration")
                        
Set oSite = oIIS.Get("Site.Name='NewSite'")
                        
WScript.Echo oSite.Name & " is " & GetStateDescription(oSite.GetState)
            
oSite.Stop
        
WScript.Echo oSite.Name & " is " & GetStateDescription(oSite.GetState)
 
' -------helper functions-----------
                        
Function GetStateDescription(statusCode)                        
            
   Select Case statusCode
                                   
      Case 1                       
 GetStateDescription = "Started"
                                  
      Case 2
                                  
 GetStateDescription = "Starting"
                        
      Case 3
                        
 GetStateDescription = "Stopped"
                        
      Case 4
                        
 GetStateDescription = "Stopping"
                        
      Case 5
                        
 GetStateDescription = "Unknown"
                                                                    
      Case Else
                                                
GetStateDescription = "Error: Bad Status"